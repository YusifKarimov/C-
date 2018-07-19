# Csharp
using System;
using System.IO;
namespace CompyAnyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            FileStream fin, fout;
            try
            {
                fin = new FileStream("K:\\Programing\\Test files\\nbcq.png", FileMode.Open);
                fout = new FileStream("K:\\Programing\\Test files\\nbcq3.png", FileMode.Create);
                while(i!=-1)
                {
                    try
                    {
                        i = fin.ReadByte();
                        fout.WriteByte((byte)i);
                       
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine($"Message:{exc.Message}\nStackTRace:{exc.StackTrace}\nMethod:{exc.TargetSite}");
                    }
                    
                }
             
                    Console.WriteLine("File copied");
             

                fin.Close();
                fout.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine($"Message:{exc.Message}\nStackTRace:{exc.StackTrace}\nMethod:{exc.TargetSite}");
            }
            
            Console.ReadKey();
        }
    }
}
