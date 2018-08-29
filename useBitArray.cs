using System;
using System.Collections;

namespace useBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byar = { 37 };
            BitArray btar = new BitArray(byar);
            BitArray Bint = new BitArray(new int[] { 334456562 });
            Console.WriteLine("bit array for byte type");
            for (int i = btar.Count-1; i >=0; i--)
            {
                Console.Write(btar[i] ? 1 : 0);
            }
            Console.WriteLine("\n\nbit array for int type");
            for (int i = Bint.Count - 1; i >= 0; i--)
            {
                Console.Write(Bint[i] ? 1 : 0);
                if (i % 8 == 0) Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
