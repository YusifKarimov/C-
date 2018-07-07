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
       protected int id;
       
        public static void Main(string[] args)
        {
            //Your code goes here
            childe ch =new childe("yusif",1234);
            ch.show();
        }
        public Program (int id)
        {
            this.id=id;
        }
    }
    public class childe : Program
    {
         string name;
        public childe(string name,int id):base(id)
        {
            this.name=name;
        }
        public void show()
        {
            Console.WriteLine("name={0},id={1}",name ,id)   ;
        }
    }
}
