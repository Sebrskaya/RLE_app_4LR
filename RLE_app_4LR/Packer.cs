using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLE_app_4LR
{
    class Packer
    {
        public delegate void Notify(int Progress);
        public event Notify notifiera;
        RLEPacker rlePacker = new RLEPacker();
        public static string SourceFileName {set; get;}
        public static string DestFileName { set; get;}
        public void Pack()
        {

            //if (!File.Exists(SourceFileName))
            //    throw new FileNotFoundException();

            Stream Source = new FileStream(SourceFileName, FileMode.Open);
            Stream Dest = new FileStream(DestFileName, FileMode.Create);
            rlePacker.notifier += ((i) => notifiera?.Invoke(i));//в момент срабатываня первого ноти(внутренний) вызываем срабатываем нотиа (местного)
                                                                //по цепочке передаем значение прогресса(i)
            rlePacker.StreamPack(Source, Dest);
        }
        
        public void UnPack()
        {
            //if (!File.Exists(SourceFileName))
            //    throw new FileNotFoundException();

            Stream Source = new FileStream(SourceFileName, FileMode.Open);
            Stream Dest = new FileStream(DestFileName, FileMode.Create);
            rlePacker.notifier += ((i) => notifiera?.Invoke(i));
            rlePacker.StreamUnPack(Source, Dest);
        }
        public void Stop()
        {
            rlePacker.Stop();
        }

    }
}
