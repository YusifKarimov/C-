using System;


namespace CompareGenericTypeElement
{
    class Program
    {
        static void Main(string[] args)
        {

            GenClass<string> strob = new GenClass<string>();
            string[] Name =  {"Ramil", "Leon","Yusif"};
            strob.CompareComparable("Leon", Name);
            //for myclasss
            MyClass myStrOb = new MyClass(10);
            myStrOb.setStrArr();
            myStrOb.CheckResult(myStrOb.CompareTo("skjahasdasd"));
            Console.ReadKey();
        }
    }
     class GenClass<T> where T:IComparable,IComparable<T>,IEquatable<T>
        {
     public   void CompareComparable(T a,T[] arr)
        {
            foreach(T t in arr)
            {
                if(a.CompareTo(t)==0)
                {
                    Console.WriteLine("ok:");
                    break;
               }
              
            }
           
        }
        }
    class MyClass: IComparable<String>,IEquatable<String>
        {
        public string[] StrArr;
        int strcount;
        public MyClass(int count)
        {
            StrArr = new string[count];
            strcount = count;
        }
        public void setStrArr()
        {
            Random rd = new Random();
            string Symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < strcount; i++)
            {
                Char[] ChrArr = new char[rd.Next(5, 20)];
                for (int j = 0; j < ChrArr.Length; j++)
                ChrArr[j] = (char)Symbols[rd.Next(0, Symbols.Length-1)];
                StrArr[i] = new string(ChrArr);
            }
        }
        public void getStrArr()
        {
            foreach (string str in StrArr)
                Console.WriteLine(str);
            
        }
        public bool Equals(String ob)
        {
            foreach (string str in StrArr)
            {
                if (str.Length == ob.Length)
                 return true;  
            }
            return false;
        }
        public static  bool IsNullOrEmpty(String value)
        {

            return String.IsNullOrEmpty(value.Trim());
        }
        public int CompareTo(String ob)
        {

            if (MyClass.IsNullOrEmpty(ob)) return 99;
            else
            foreach (string str in StrArr)
            {
                if (str.Length == ob.Length)
                    return 0;
            }
            return 88;
        }
        public void CheckResult(int ret)
        {
            switch (ret)
            {
                case 0:  Console.WriteLine("String is Equal"); break;
                case 1:  Console.WriteLine("the Firs is bigger"); break;
                case -1:  Console.WriteLine("the Second is bigger"); break;
                case 99: Console.WriteLine("the String is empty or null");  break;
                default:  Console.WriteLine("Undefined Error"); break;
            }

        }
    }
}
