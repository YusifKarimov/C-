using System;
using System.Reflection;

namespace CreateInstanceUseReflection
{
    
    class Program
    {

        static void Main(string[] args)
        {

            myClass ob = new myClass("Yusif","Karimov",23,true);
            //myClass.resetOb(ref ob);
            //ob.show();
            
            Type tipMyclass = typeof(myClass);
            //myClass ob = new myClass("Yusif", "Karimov", 22, true);
            //myClass ob = new myClass();
            //Console.WriteLine(typeof(myClass));
            ConstructorInfo[] ctors = tipMyclass.GetConstructors();
            MethodInfo[] meths = tipMyclass.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
           // MethodInfo[] meths = tipMyclass.GetMethods(BindingFlags.Instance | BindingFlags.Public |  BindingFlags.DeclaredOnly);
            
            foreach (ConstructorInfo ctor in ctors)
            {
                ParameterInfo[] pinfo = ctor.GetParameters();
                /*foreach(ParameterInfo pi in pinfo)
                {
                    Console.WriteLine(pi.ParameterType);
                }
                */
                // myClass paramerli konstruktor ucun check up
                if (pinfo.Length == 1 && pinfo[0].ParameterType == typeof(myClass))
                {
                    myClass testob = new myClass();
                    //call retOb method
                    MethodInfo mi1 = tipMyclass.GetMethod("retOb");
                    object test1 = (object)mi1.Invoke(testob, new object[] { "Ramil","ALiyev",(byte)22,true });
                    object refobj = ctor.Invoke(new object[] { test1 });
                    foreach (MethodInfo mi in meths)
                    {
                        ParameterInfo[] mpinfo = mi.GetParameters();
                        //    Console.WriteLine("name:{1},parm-count:{0}",mpinfo.Length,mi.Name);
                        if (mpinfo.Length == 0 && mi.ReturnType == typeof(void) && mi.Name.Equals("show"))
                        {

                            mi.Invoke(refobj, null);
                            // Console.WriteLine(mi.ReturnType);
                        }
                    }

                    Console.WriteLine("ctor1");
                }
                //4 paramertli konstruktor ucun check up
                else if (pinfo.Length == 4 && pinfo[0].ParameterType == typeof(string) && pinfo[1].ParameterType == typeof(string) && pinfo[2].ParameterType == typeof(byte) && pinfo[3].ParameterType == typeof(bool))
                {
                    object refobj = ctor.Invoke(new object[] { "Yusif","Karimov",(byte)22,true});
                    foreach(MethodInfo mi in meths)
                    {
                        ParameterInfo[] mpinfo = mi.GetParameters();
                        //    Console.WriteLine("name:{1},parm-count:{0}",mpinfo.Length,mi.Name);
                        if (mpinfo.Length == 0 && mi.ReturnType == typeof(void) && mi.Name.Equals("show"))
                        {
                            
                            mi.Invoke(refobj, null);
                          // Console.WriteLine(mi.ReturnType);
                        }
                     }
                    Console.WriteLine("ctor 2");
                }
                //non parametr konstruktor ucun check up
                else if (pinfo.Length == 0)
                {
                    object refobj = ctor.Invoke(null);
                    foreach (MethodInfo mi in meths)
                    {
                        ParameterInfo[] mpinfo = mi.GetParameters();
                        //    Console.WriteLine("name:{1},parm-count:{0}",mpinfo.Length,mi.Name);
                        if (mpinfo.Length == 0 && mi.ReturnType == typeof(void) && mi.Name.Equals("show"))
                        {

                            mi.Invoke(refobj, null);
                            // Console.WriteLine(mi.ReturnType);
                        }
                    }
                    Console.WriteLine("ctor");
                }
                else //uygun konstruktor olmadiqda
                    Console.WriteLine("uygun ctor yox");
                
                Console.WriteLine();
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

      
    }

    class myClass
    {
        string name, sname;
        byte age;
        bool status;
        public myClass()
        {
            name = sname=null;
            age = 0;
            status = false;
        }
        public myClass(myClass ob)
        {
            this.name = ob.name;
            this.sname = ob.sname;
            this.age = ob.age;
            this.status = ob.status;
        }
        public myClass(string name, string sname, byte age, bool status)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.status = status;
        }
       
        public void show()
        {
            if (status)
                Console.WriteLine($"name={name}\nsname={sname}\nage={age}");
            else
                Console.WriteLine("this user is private for you");
        }
         public static void resetOb(ref myClass ob)
        {
            ob = new myClass();
        }
        public static myClass retOb(string name=null,string sname=null,byte age=0,bool status=false)
        {
            return new myClass(name,sname,age,status);
        }
    }
}
