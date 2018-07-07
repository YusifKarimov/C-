# Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Program
    {
        private string[] Names;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Program obIndexer = new Program(7);
            obIndexer[1] = "Yusif";
            obIndexer[0] = "Asif";
            obIndexer[2] = "Vasif";
            obIndexer[6] = "Ramil";
            
            obIndexer[4] = "Sənan";
            obIndexer[5] = "İlham";
            for(byte i=0;i< 7;i++)
            {
                Console.WriteLine("resualt:{0}",obIndexer[i]);
            }
            
            Console.ReadKey();
        }
        public Program(int size=1)
        {
            Names = new string[size];
            for (byte i= 0;i< size;i++)
            {
                Names[i] = "test "+i;
            }
        }
        //indexer
        private string this [int id]
        {
            get
            {
                return Names[id];
            }
            set
            {
                Names[id] = value;
            }
        }
    }
}
