# Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
        byte age;

        public static void Main(string[] args)
        {
            Program test = new Program();
            test.page = 180;
            Console.WriteLine(test.page);
            Console.ReadKey();
        }
        public Program()
        {
            this.age = 0;
        }
        public byte page
        {
            get
            {
                return age;
            }
            set
            {
               age = value > 0 && value < 150 ? value : (byte)1;
            }

        }

    }
}
