# Csharp

//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        string name;
        public static void Main(string[] args)
        {
            
         Program test=new Program("yusif");  
         Program test1 = new Program(test);
            test1.show();
        }
        public Program()
        {
         Console.WriteLine("test constructor")   ;
        }
        public Program(string name)
        {
        this.name=name;
        Console.WriteLine("test1"); 
        }
        public Program(Program ob):this(ob.name)
        {
        Console.WriteLine("test2");
        }
        public void show()
        {
            Console.WriteLine(name);
        }
    }
}
