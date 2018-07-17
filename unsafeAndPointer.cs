# Csharp
using System;


namespace pointer
{

    unsafe class Program
    {
         int* code,cd;
        public Program( int* code,int x)
        {
           this.code = code;
            Console.WriteLine("x=" + x);
            cd = &x;
        }
         ~Program()
        {
            this.code = null;
        }
        public void show()
        {
            Console.WriteLine("value of code : {0}\nadress of code : {1}\nvalue of cd : {2}\nadress of cd : {3}\n", *code,(int)code,*cd,(int)cd);
        }
        static  void Main(string[] args)
        {

     
            int* ptr;
            int a = 54;
            ptr = &a;
            Program ob = new Program( &a,44);
            Console.WriteLine("value of ptr : {0}\nadress of ptr : {1}\n", *ptr, (int)ptr);
            ob.show();
            Console.ReadKey();
        }
    }
}
