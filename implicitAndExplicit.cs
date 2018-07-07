# Csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExolicit
{
   
    class Program
    {
        int a;
        double b;
        string name;
        bool ch;
        byte[] arr;
        float ft;
        static void Main(string[] args)
        {
            Program ob = new Program(34,23.55,"world",true,(float)77.8);
            
            Console.WriteLine("cvb:{0}\ndbl:{1}\nstr:{2}\nch:{3},\n{4}",34+ob,34.543+ob,"hello "+ob, ob ? "is true" : "is false",(float)ob);
            ob.Show();
            Console.ReadKey();
        }
        public Program(int a=0,double b=0.0,string name="",bool ch=false,float ft=(float)0.0)

        {
            this.a = a;
            this.b = b;
            this.name = name;
            this.ch = ch;
            this.ft = ft;
        }
        public void Show()
        {
            Console.WriteLine("a={0}, b={1}, name={2}, ch={3}, ft={4}",a,b,name,ch,ft);
                
        }
        public static implicit operator  int(Program ob)
        {
            return ob.a;
        }
        public static implicit operator string(Program ob)
        {
            return ob.name;
        }
        public static implicit operator double(Program ob)
        {
            return ob.b;
        }
        public static implicit operator bool(Program ob)
        {
            return ob.ch;
        }
        public static explicit operator float(Program ob)
        {
            return ob.ft;
        }
    }
}
