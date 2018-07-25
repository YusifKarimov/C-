# Csharp
using System;


namespace useDelegate
{
     class c1  //x
    {

    }
     class c2 : c1  //y:x
    {

    }
    delegate c1 DelVal(c2 ob);
    delegate void myDelegateType(string str);
    class Program
    {
        public static c1 f11(c1 ob)
        {
            Console.WriteLine("ret-type:c1 arg-list:c1");
            return new c1();
        }

        public static c2 f12(c2 ob)
        {
            Console.WriteLine("ret-type:c2 arg-list:c2");
            return new c2();
        }

        static void Main(string[] args)
        {
            //myDelegateType mydlg = new myDelegateType(f1);
            //mydlg("salam");
            c1 o1 = new c1();
            c2 o2 = new c2();
            DelVal dl;
            dl = f11;
            //controvarinace
            c1 o11 =dl(o2) ;
            dl = f11;

            //covarinace
            //c2 o12 = (c2) dl(o2);

            //multicasting
            myDelegateType mydlg = f1;
            mydlg += f2;
            mydlg += f3;
            mydlg += f4;
            mydlg += f5;
            mydlg -= f3;
            mydlg += Sinif.f1;
            mydlg("Hi all");
            
            Console.ReadKey();
        }
        

        static void f1(string a)
        {
            Console.WriteLine("f1():"+a);
        }
        static void f2(string a)
        {
            Console.WriteLine("f2():" + a);
        }
        static void f3(string a)
        {
            Console.WriteLine("f3():" + a);
        }
        static void f4(string a)
        {
            Console.WriteLine("f4():" + a);
        }
        static void f5(string a)
        {
            Console.WriteLine("f5():" + a);
        }
    }
    class Sinif
    {

       public  static void f1(string a)
        {
            Console.WriteLine("sinif f1():"+a);

        }
    }

  
}
