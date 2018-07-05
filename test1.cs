# Csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            //Console.WriteLine("cem:{0}" ) ;
           
            Console.WriteLine("\n\n"+maxE(arry(6)));
            fun();
            fun("Yusif");
            string nm="Test";
            fun(ref nm);
        }
        public static int maxE(int[] arr)
        {
            if(arr.Length==0)  
            {
                Console.WriteLine("array is empty");
                return 0;
            }
            int i, tmp=arr[0];
            for(i=1;i<arr.Length;i++)
            tmp = arr[i]>tmp ? arr[i] : tmp;
            return tmp;
        }
        public static int[] arry(uint size)
        {
            int[] mass= new int[size];
            Random rmd =new Random();
            for(byte i=0;i<size;i++)
            {
                mass[i]=rmd.Next(0,1000);
                Console.Write("{0}\t",mass[i]);
            }
               
            
            return mass;
        }
        public static void fun()
        {
         Console.WriteLine("salam")   ;
        }
        
        public static void fun(string n)
        {
         Console.WriteLine(n)   ;
        }
        
        public static void fun(ref string n)
        {
         Console.WriteLine(n)   ;
        }
    }
}
