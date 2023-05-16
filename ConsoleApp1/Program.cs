using RLE_app_4LR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RLEPacker packer = new RLEPacker();
            MemoryStream stream = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
            MemoryStream stream3 = new MemoryStream();
           
            for(int i = 0; i < 2000000; i++)
            {
                byte b = (byte)i;
                stream.WriteByte(b);
                
            }
            stream.Seek(0, SeekOrigin.Begin);
            packer.StreamPack(stream, stream2);

            stream2.Seek(0, SeekOrigin.Begin);
            packer.StreamUnPack(stream2, stream3);


            stream.Seek(0, SeekOrigin.Begin);
            stream3.Seek(0, SeekOrigin.Begin);
            bool flag = true;
            for (int i = 0; i < stream.Length; i++)
            {
                if (stream.ReadByte() != stream3.ReadByte())
                {
                    flag = false; break;

                }
            }
            Console.WriteLine(flag);
            Console.ReadKey();

        }
    }
}
