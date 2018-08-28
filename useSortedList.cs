using System;
using System.Collections;

namespace useSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList SrList = new SortedList();

            SrList.Add("name", "Yusif");
            SrList["sname"] = "Karimov";
            SrList["age"] = 23;
            SrList.Add("speciality","Komputer Sicintis");

            Console.WriteLine("capacity:{0}",SrList.Capacity);
            IList keys = SrList.GetKeyList();
            foreach(string k in keys)
            {
             
                show <string> (k, SrList[k].ToString());
            }
            SortedList MixList = new SortedList();
            MixList.Add(4, 24);
            MixList[3] = "male";
            MixList.Add(0, "Leon");

            MixList[1] = "Bekker";
            MixList.Add(2, "Unknow");

            //MixList.Add(true,34); //it is error , because first element type is integer
           // MixList.Add(1.2, "test"); // it is error

            Console.WriteLine("\n\ncount:{1}\tcapacity:{0}", MixList.Capacity,MixList.Count);
            ICollection kk = MixList.Keys;
            foreach(var k in kk )
            {

                show<object>(k,MixList[k]);
            }
            Console.ReadKey();
        }
        public static void  show<T>(T k,T v)
        {
            Console.WriteLine($"key:{k}\tvalue:{v}");
        }
    }
}
