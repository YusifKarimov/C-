# Csharp
using System;
using System.Text;
using System.IO;
namespace useStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string str;
            FileStream fout;
            try
            {
                fout = new FileStream("K:\\Programing\\Test files\\test3.txt", FileMode.Create);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            using (StreamWriter strfout = new StreamWriter(fout, Encoding.UTF8))
            {
                //fayla yazilmani dayandirmaq ucun 
                Console.WriteLine("file yazma islerin dayandirmaq ucun\"exit\" yazib enter click edin");
                try
                {

                    try
                    {
                        do
                        {
                            str = Console.ReadLine();
                            if (str == "exit") return;
                            strfout.Write(str + "\n");
                            //Console.WriteLine("fayla yazildi");
                        }
                        while (str != "quit");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        return;
                    }



                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return;
                }
                Console.ReadKey();
            }
        }
    }
}
