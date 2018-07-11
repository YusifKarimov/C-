# Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumarable
{
    public struct Student
    {
        public string name;
        public string sName;
        public byte age;
    }
    class Program
    {
        Student[] st;
        byte size;
        public Program(byte size=1 )
        {
            this.size = size;
             st = new Student[size];
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Program index = new Program(5);
           index[1] = "Yusif,Kərimov,22";
            Console.WriteLine(index[1]);
            Console.ReadKey();
        }
        
        string this[byte id ]
        {
            get
            {
                return $"name:{st[id].name}\nsurname:{st[id].sName}\nage:{st[id].age}" ;
            }
            set
            {
                if (id < size && id > 0)
                {
                    string[] info = value.Split(',');
                   /* foreach (string i in info)
                        Console.WriteLine(i);*/
                    
                    st[id].name = info[0];
                    st[id].sName = info[1];
                    st[id].age = Convert.ToByte(info[2]);
                    
                }
                else Console.WriteLine("id uygun deyl");
            }
        }
    }
}
