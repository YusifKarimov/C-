# Csharp
//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
interface Itest
{
 void fun1();   
}
    public abstract class Program
    {
        public abstract void fun();
        public static void Main(string[] args)
        {
            //Your code goes here
            Program test;
            test= new sinif();
            test.fun();
            Itest t=new sinif();
            t.fun1();
            sinif tt=new sinif();
            tt.fun2();
            t=new vsinif();
            //t.fun() ; // bu xeta verecek cunki interface icinde bu funksiya yoxdur
            t.fun1();
            test= new sinif();
            test.fun();
            //test.fun1(); //xeta abstarct class daxilinde bu funksiya movcud deyl
            
        }
    }
   public class sinif : Program,Itest
    {
     public  void fun1()
     {
      Console.WriteLine("interfacedeki metoddan torenen")   ;
     }
        public override void fun()
        {
         Console.WriteLine("varis sinif");   
     
        }
        public void fun2()
        {
         Console.WriteLine("test fun")   ;
        }
    }
    public class vsinif:sinif{
     public override  void fun()
     {
      Console.WriteLine("vsinif classi")   ;
     
     }
        public  void fun1()
        {
             Console.WriteLine("vsinif classi(fun1)")   ;
        }
      
    }
}
