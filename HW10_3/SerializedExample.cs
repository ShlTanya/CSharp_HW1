using System;
using System.IO;
using System.Text.Json;
using HW10_1;

namespace HW10_3
{
    public class SerializedExample
    {
        public static void SerializedToJson()
        {
            Console.WriteLine($"===========Attributes example(HW10 SerializedToJson)============");

            Console.WriteLine("Create new object exampleClass");
            ExampleClass exampleClass = new ExampleClass { ClassName = "MyClass" };
            exampleClass.MyClassExec();
            exampleClass.UpdateExecDate(new DateTime(2021, 02, 01));
            exampleClass.MyClassExec();

            using (FileStream stream = new FileStream(@"D:\ExampleClass.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<ExampleClass>(stream, exampleClass, 
                    new JsonSerializerOptions { IncludeFields = true });
            }

            Console.WriteLine("Object was serialized to Json");
        }

        public static async void DeSerializedFromJson()
        {
            Console.WriteLine($"===========Attributes example(HW10 DeSerializedFromJson)============");
 
            ExampleClass exampleClass;

            using (FileStream stream = new FileStream(@"D:\ExampleClass.txt", FileMode.OpenOrCreate))
            {
                exampleClass = await JsonSerializer.DeserializeAsync<ExampleClass>(stream,
                   new JsonSerializerOptions { IncludeFields = true });
            }
            exampleClass.MyClassExec();
            Console.WriteLine("Object was deserialized from Json");
        }
    }
}
