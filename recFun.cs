using System;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(funRec(4));
         }
    
    public static long funRec(uint x)
    {
        return x<2 ? 1 : funRec(x-1)*x;
    }
        
    }
}
