using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW10_1;
using HW10_3;
using HW10_4;

namespace HW10
{
    class Program
    {
        static public void Main(string[] args)
        {
            AttributesExample.Execute();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();

            AssemblyExample.Execute();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();

            ShowSerialization();

        }

        static async void ShowSerialization()
        {
            Console.WriteLine($"===========Attributes example(HW10 SerializedToJson)============");

            Console.WriteLine("Create new object exampleClass");
            ExampleClass exampleClass = new ExampleClass { ClassName = "MyClass" };
            exampleClass.MyClassExec();
            exampleClass.UpdateExecDate(new DateTime(2021, 02, 01));
            exampleClass.MyClassExec();

            SerializedExample<ExampleClass>.SerializedToJson(exampleClass);
            Console.WriteLine("Press key to continue");
            Console.ReadKey();

            Console.WriteLine($"===========Attributes example(HW10 DeSerializedFromJson)============");
            ExampleClass exampleClassNew = await SerializedExample<ExampleClass>.DeSerializedFromJson();
            exampleClassNew.MyClassExec();
            Console.ReadKey();
        }

    }
}
