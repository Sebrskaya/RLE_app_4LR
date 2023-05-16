using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RLE_app_4LR
{
    internal class RLEPacker
    {
        public delegate void Notify(int Progress);
        public event Notify notifier;

        public void StreamPack(Stream sourse, Stream dest)
        {
           
            StopFlag = true;
            Progress = 0;
            notifier?.Invoke(Progress);
            
            List<byte> Data = new List<byte>();//Создаем списокк - хранилище байтов

            while (sourse.Position < sourse.Length)//записываем байты из потока в список
            {
                if (StopFlag == false) { break; }
                byte sign = (byte)sourse.ReadByte();
                Data.Add(sign);
            }
            //sourse.Close();//высвобаждаем ресурсы из потока
            byte Duplicate = 0; //Дублирующиеся
            byte Unique = 0; //Уникальные
            List<byte> PackData = new List<byte>();//будущее хранилище для запакованных данных
            List<byte> bufferOfDifferentByte = new List<byte>();//буфер для уникальных элементов
            for (int i = 0; i < Data.Count - 1; i++)//по циклу прогоняем список элементов списка с байтами
            {
                if (StopFlag == false) { break; }
               // Thread.Sleep(1000);
                if (Data[i] == Data[i + 1]) // Повторяющиеся элементы 
                {
                    if (Unique > 0)  //Количество уникальных больше 0
                    {
                        PackData.Add(0);
                        PackData.Add(Unique); //Записываем количество уникальных элементов
                        PackData.AddRange(bufferOfDifferentByte);  //Записываем уникальне элементы
                        bufferOfDifferentByte.Clear();
                        Unique = 0;
                    }
                    if (Duplicate == 255)  //Ограничение по количеству байт
                    {
                        PackData.Add(Duplicate);
                        PackData.Add(Data[i]);
                        Duplicate = 0;
                    }
                    Duplicate++;
                }
                else
                {
                    if (Duplicate > 0)  //Количество повторяющихся больше 0
                    {
                        Duplicate++;
                        PackData.Add(Duplicate);
                        PackData.Add(Data[i]);
                        Duplicate = 0;
                    }
                    else
                    {
                        if (Unique == 255) //Ограничение по количеству байт
                        {
                            PackData.Add(0);
                            PackData.Add(Unique);
                            PackData.AddRange(bufferOfDifferentByte);
                            bufferOfDifferentByte.Clear();
                            Unique = 0;
                        }
                        bufferOfDifferentByte.Add(Data[i]); //Запись в любом случае
                        Unique++;
                    }
                }
                if (i == Data.Count - 2)
                {
                    if (Duplicate > 0)
                    {
                        Duplicate++;
                        PackData.Add(Duplicate);
                        PackData.Add(Data[i]);
                        Duplicate = 0;
                    }
                    if (Unique > 0)
                    {
                        bufferOfDifferentByte.Add(Data[i + 1]);
                        PackData.Add(0);
                        Unique++;
                        PackData.Add(Unique);
                        PackData.AddRange(bufferOfDifferentByte);
                        bufferOfDifferentByte.Clear();
                        Unique = 0;
                    }
                }
                //Будет вызываться событие прогресбара
                double pos = i;
                double length = Data.Count;
                Progress = (int)(pos / length * 100);
                notifier?.Invoke(Progress);
            }
            if (StopFlag == true)
            {
                notifier?.Invoke(100); //Для окончательного выполнения прогресбара
                byte[] temp = new byte[PackData.Count];
                PackData.CopyTo(temp);
                
                dest.Write(temp, 0, temp.Length);
                
            }
        }

        public void StreamUnPack(Stream sourse, Stream dest)
        {
            StopFlag = true;
            Progress = 0;
            notifier?.Invoke(Progress);
            List<byte> Data = new List<byte>();//Будущее хранилище закодированной последовательности байтов

            while (sourse.Position < sourse.Length)//записываем байты из потока в список
            {
                if (StopFlag == false) { break; }
                byte sign = (byte)sourse.ReadByte();
                Data.Add(sign);
            }
            

            List<byte> UnPackData = new List<byte>();

            for (int i = 0; i < Data.Count - 1; i++)
            {
                if (StopFlag == false) { break; }
                //Thread.Sleep(2000);
                if (Data[i] == 0)
                {
                    i++;
                    byte sequenceLength = Data[i];
                    for (int j = 0; j < sequenceLength; j++)
                    {
                        i++;
                        UnPackData.Add(Data[i]);
                    }
                }
                else
                {
                    byte sequenceLength = Data[i];
                    i++;
                    for (int j = 0; j < sequenceLength; j++)
                        UnPackData.Add(Data[i]);
                }
                double pos = i;
                double length = Data.Count;
                Progress = (int)(pos / length * 100);

                notifier?.Invoke(Progress);
            }
            if (StopFlag == true)
            {
                notifier?.Invoke(100);
                byte[] temp2 = new byte[UnPackData.Count];
                UnPackData.CopyTo(temp2);
                dest.Write(temp2, 0, temp2.Length);
                
            }

        }
        public static int Progress { get; private set; }

        public static bool StopFlag
        {
            get; set;
        }
        public void Stop()
        {
            StopFlag = false;
        }
    }
}
