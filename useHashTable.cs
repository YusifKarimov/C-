using System;
using System.Collections.Generic;
using System.Collections;

namespace useHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHT = new Hashtable();

            myHT["name"] = "Yusif";
            myHT["speciality"] = "Computer Scients";
            myHT["sname"] = "Karimov";
            myHT["age"] = 23;
            //myHT.Add("name", "Yusif");
            Hashtable myHT1 = new Hashtable(myHT);

            Console.WriteLine($"count:{myHT1.Count}");
            // ICollection key1 = myHT1.Keys;
            myHT1["name"] = "Ramil";
            Console.WriteLine(myHT1["name"]);
            Console.WriteLine($"count:{myHT.Count}");
            ICollection keys = myHT.Keys;
            foreach(var k in keys)
            {
                Console.WriteLine($"{k}=>{myHT[k]}");
            }
            Console.ReadKey();
        }
    }
}
