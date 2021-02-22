using HW9.Attributes;
using HW9.Serialization;
using System;
using System.Threading.Tasks;
using HW9.AssemblyEx;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfoExamlpe.Execute();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            AttributesExample.ExecuteHW9();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            AttributesExample.ExecuteHW10();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            SerializedExample.SerializedToJson();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            SerializedExample.DeSerializedFromJson();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
            AssemblyExample.Execute();
            Console.ReadKey();
        }
    }
}
