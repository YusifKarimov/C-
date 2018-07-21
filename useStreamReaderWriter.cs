# Csharp
using System;
using System.IO;

namespace useStreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader strReader;
            StreamWriter strWriter;
            try
            {
                strReader = new StreamReader("K:\\Programing\\Test files\\test.txt");
                strWriter= new StreamWriter ("K:\\Programing\\Test files\\test10.txt");
                do
                {
                    try
                    {
                        strWriter.WriteLine(strReader.ReadLine());

                    }
                    catch (IOException exc)
                    {
                        Console.WriteLine(exc.Message);
                        return;
                    }
                } while (!strReader.EndOfStream);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            strReader.Close();
            strWriter.Close();
            Console.ReadKey();
        }
    }
}
