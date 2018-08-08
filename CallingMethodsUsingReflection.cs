using System;
using System.Reflection;

namespace CallingMethodsUsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            Type tip = typeof(Program);
            string menm = "funn";
            string name = "Leon";
            MethodInfo minfo = tip.GetMethod(menm);
            object[] arrOb = new object[2] ;
            arrOb[0] = name;
            arrOb[1] = 55;
           
            ParameterInfo[] pinfo = minfo.GetParameters();
            if (pinfo[0].ParameterType == typeof(string) && pinfo[1].ParameterType == typeof(int))
                minfo.Invoke(ob, arrOb);

            MethodInfo minfo1 = tip.GetMethod("fun1");
            ParameterInfo[] pinfi = minfo1.GetParameters();
            //foreach (ParameterInfo ppp in pinfi)
              //  Console.WriteLine(ppp.ParameterType);
            //Console.ReadKey();
            
            if (pinfi[0].ParameterType == typeof(int) && pinfi[1].ParameterType == typeof(double) && pinfi[2].ParameterType == typeof(string) && pinfi[3].ParameterType == typeof(bool))
          // minfo.Invoke(ob, arrOb);
            minfo1.Invoke(ob, new object[] { 344, 56.87, "test result", true });

            MethodInfo[] meInfo = tip.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);
            foreach (MethodInfo mi in meInfo)
            {
                ParameterInfo[] prinfo = mi.GetParameters();
                Console.WriteLine(prinfo.Length);
                if (prinfo.Length==2 &&  prinfo[0].ParameterType == typeof(string) && prinfo[1].ParameterType == typeof(string))
                {
                    mi.Invoke(ob, new object[] { "salam", "sagol" });
                }
                if (prinfo.Length==2 && prinfo[0].ParameterType == typeof(string) && prinfo[1].ParameterType == typeof(int))
                    mi.Invoke(ob, arrOb);
                  if (prinfo.Length == 4 && prinfo[0].ParameterType == typeof(int) && prinfo[1].ParameterType == typeof(double) && prinfo[2].ParameterType == typeof(string) && prinfo[3].ParameterType == typeof(bool))
                mi.Invoke(null,new object[] { 344, 56.87, "test result",true});
                  //call sattin non parametr function
                if (prinfo.Length==0 && mi.Name=="tt")
                mi.Invoke(null, null);
              }
            
            Console.ReadKey();
        }
        
        public void fun(string str, string x)

        {
            Console.WriteLine(" {0},{1}  calling with reflection", str,x);
        }
        
        public void funn(string bl,int x)
        {

         Console.WriteLine("{0} fun call reflection\nx={1}",bl,x);
        }
        static public void fun1(int a, double b, string c, bool bl)
        {
            if (bl)
                Console.WriteLine($"a={a}, d={b}, c={c}");
            else
                Console.WriteLine("return empty");

        }
        static void tt()
        {
            Console.WriteLine("static private function(non parametrs)");
        }
        
    }
}
