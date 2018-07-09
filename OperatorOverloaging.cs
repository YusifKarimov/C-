# Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    class Program
    {
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        double  a;
        public Program(double a =0)
        {
            this.a = a;
        }
        public void Show()
        {
            Console.WriteLine("cavab: {0}",a);
        }
        static void Main(string[] args)
        {
            Program ob1 = new Program(222);
            Program ob2 = new Program(333);
            
            (ob1+ob2).Show();
            (ob1 + 4).Show();
            (2 * ob1).Show();
            (++ob1).Show();
            Console.WriteLine(ob1 ? "it is true " : "it is false");
            Console.ReadKey();
        }

        public static Program operator +(Program ob1,Program ob2)
        {
            return new Program(ob1.a + ob2.a); 
        }
        public static Program operator -(Program ob1, Program ob2)
        {
            return new Program(ob1.a - ob2.a);
        }
        public static Program operator +(Program ob, double sum)
        {
            return new Program(ob.a + sum);
        }
        public static Program operator +( double sum, Program ob)
        {
            return new Program( sum + ob.a);
        }
        public static Program operator -(Program ob, double minus)
        {
            return new Program(ob.a - minus);
        }
        public static Program operator -( double minus, Program ob)
        {
            return new Program( minus - ob.a);
        }
        public static Program operator *(Program ob1, Program ob2)
        {
            return new Program(ob1.a * ob2.a);
        }
        public static Program operator /(Program ob1, Program ob2)
        {
            return new Program(ob1.a / ob2.a);
        }
        public static Program operator *(Program ob, double mul)
        {
            return new Program(ob.a * mul);
        }
        public static Program operator *( double mul, Program ob)
        {
            return new Program( mul * ob.a);
        }
        public static Program operator /(Program ob, double div)
        {
            return new Program(ob.a / div);
        }
        public static Program operator /( double div, Program ob)
        {
            return new Program(div/ob.a );
        }
        public static Program operator ++(Program ob)
        {
            return new Program(ob.a++);
        }
        public static Program operator --(Program ob)
        {
            return new Program(ob.a--);
        }
        //compare object
        
        public static bool operator ==(Program ob1,Program ob2)
        {
            return ob1.a == ob2.a ? true : false;
        }
        public static bool operator !=(Program ob1, Program ob2)
        {
            return ob1.a != ob2.a ? true : false;
        }
        
        public static bool operator >(Program ob1, Program ob2)
        {
            return ob1.a > ob2.a ? true : false;
        }
        public static bool operator <(Program ob1, Program ob2)
        {
            return ob1.a < ob2.a ? true : false;
        }
        public static bool operator >=(Program ob1, Program ob2)
        {
            return ob1.a >= ob2.a ? true : false;
        }
        public static bool operator <=(Program ob1, Program ob2)
        {
            return ob1.a <= ob2.a ? true : false;
        }
        public static bool operator true (Program ob)
        {
            return ob.a>0 ? true : false;
        }
        public static bool operator false(Program ob)
        {
            return ob.a <= 0 ? true : false;
        }
        //logical operators
        public static bool operator | (Program ob1,Program ob2)
        {
            return ob1.a != 0 | ob2.a !=0 ? true : false;
        }
        public static bool operator &(Program ob1, Program ob2)
        {
            return ob1.a != 0 & ob2.a != 0 ? true : false;
        }
        public static bool operator !(Program ob)
        {
            return ob.a !=0 ? true : false;
        }
    }
}
