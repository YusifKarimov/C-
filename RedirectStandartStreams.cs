# Csharp
using System;
using System.IO;

namespace RedirectStandartStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter strWriter;
            string[] student = { "Ramil Aliyev", "Yusif Karimov", "Nahid Jamalli" };
            try
            {
                strWriter = new StreamWriter("K:\\Programing\\Test files\\test10.txt",true);

            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            
            Console.SetOut(strWriter);
            foreach(string std in student)
            Console.WriteLine(std);
            
            strWriter.Close();
            
            
         
        }
    }
}
