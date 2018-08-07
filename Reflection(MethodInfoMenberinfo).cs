using System;
using System.Reflection;

namespace useReflection2
{
     class Program
    {
        
      public  static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Type tip = typeof(Console);
            f(tip.Assembly.FullName);
            f(tip.BaseType.FullName);
            f(tip.Namespace);
            MethodInfo[] mInfo = typeof(Program).GetMethods();
            foreach(MethodInfo mi in mInfo )
            {
                Console.WriteLine(@"Method name:{0}                 Return type:{1}", mi.Name, mi.ReturnType.Name);
                ParameterInfo[] prpInfo = mi.GetParameters();
                foreach (ParameterInfo prp in prpInfo )
                {
                    Console.WriteLine(@"param type:{0}               tparam name:{1}", prp.ParameterType.Name,prp.Name);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
        
      public    static void f(object x,bool fl=false)
        {
            Console.WriteLine(x);
        }
       public int ff(float s=34)
        {
            return 0;
        }
    }
}
