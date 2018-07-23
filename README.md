# Csharp
using System;
using System.IO;

namespace useBinarryStream
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryWriter biWriter;
            BinaryReader biReader;
            
            string name = "Yusif";
            byte age = 22;
            bool male = true;
            float salary = 355.4F;
            try
            {
                biWriter =new BinaryWriter (new FileStream("K:\\Programing\\Test files\\testBinarry",FileMode.Create)) ;
            }
            catch(IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            try
            {
                biWriter.Write(name);
                biWriter.Write(age);
                biWriter.Write(male);
                biWriter.Write(salary);
             
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            biWriter.Close();
            

            try
            {
                biReader = new BinaryReader (new FileStream("K:\\Programing\\Test files\\testBinarry", FileMode.Open));
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            string name1;
            float salary1;
            bool male1;
            byte age1;
            try
            {
                 name1 = biReader.ReadString();
                 salary1 = biReader.ReadSingle();
                 male1 = biReader.ReadBoolean();
                age1 = biReader.ReadByte();
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            biReader.Close();
            Console.WriteLine($"name:{name1}\nage:{age1}\nsalary:{salary1}\nmale:{male1}");
            Console.ReadKey();
        }
        
    }
}
