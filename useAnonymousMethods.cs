# Csharp
using System;

delegate int mydlgt(int t);

    public class Program
    {
         mydlgt fun()
        {
            int sum = 0;
            mydlgt dl = delegate (int ok)
            {
                for (int i = 1; i <= ok; i++)
                    sum += i;
                return sum;
            };
            return dl;
        }
        static void Main(string[] args)
        {
        //simple example anonymous method
        mydlgt mydelsv = delegate (int x)
       {

           return x*4;
       };
        Console.WriteLine("4*{0}={1}",5,mydelsv(5));

        //example for captured outher variable
        mydlgt mydlv = (new Program()).fun();
         
        Console.WriteLine($"sum of number(4)  :{mydlv(4)}\nsum of number(5) : {mydlv(5)}");
        (new Program()).fun();
        Console.WriteLine($"sum of number(4)  :{mydlv(4)}\nsum of number(5) : {mydlv(5)}");
        Console.ReadKey();
        }
    }

