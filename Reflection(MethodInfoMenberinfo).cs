using System;
using System.Reflection;
//get information about menber methods
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
            Console.WriteLine("\n\n\nget information about nonpublic methods\n\n");
            // get information abot nonpublic methods
            MethodInfo[] minfo = typeof(Program).GetMethods( BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(MethodInfo mi1 in minfo)
            {
                Console.WriteLine(@"Method name:{0}                 Return type:{1}", mi1.Name, mi1.ReturnType.Name);
                ParameterInfo[] prpInfo = mi1.GetParameters();
                foreach (ParameterInfo prp in prpInfo)
                {
                    Console.WriteLine(@"param type:{0}               tparam name:{1}", prp.ParameterType.Name, prp.Name);
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
        protected string prifun(string t="",double db=0.0)
        {
            return "test string from protected function";
        }
        string profun(string t = "", double db = 0.0)
        {
            return "test string from private function";
        }
    }
}
