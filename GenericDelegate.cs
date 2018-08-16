using System;


namespace GenericDelegate
{
    delegate T myDelType<T>(T tt);
    class Program
    {
        public static string Strfun(string name)
        {

            return $"your name is {name}";
        }
        public static int Intfun(int x)
        {
            return x * 4;
        }
        public static float Flfun(float x)
        {
            return 3 * x;
        }
        static void Main(string[] args)
        {
            myDelType<string> strdelg = Strfun;
            myDelType<int> intdelg = Intfun;
            myDelType<float> fldelg = Flfun;
            Console.WriteLine($"string type delegae: {strdelg("Leon")}\nint type delegate: {intdelg(22)}\nfloat type delegate: {fldelg((345.6F))}");
            Console.ReadKey();
        }
    }
}
