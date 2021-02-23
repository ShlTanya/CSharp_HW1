using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW10_3
{
    public class SerializedExample<T> where T: class 
    {
        public static void SerializedToJson(T ob)
        {
             using (FileStream stream = new FileStream(@"D:\ExampleClass.txt", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<T>(stream, ob, 
                    new JsonSerializerOptions { IncludeFields = true });
            }

            Console.WriteLine("Object was serialized to Json");
        }

        public static async Task<T> DeSerializedFromJson()
        {
            T obNew;

            using (FileStream stream = new FileStream(@"D:\ExampleClass.txt", FileMode.OpenOrCreate))
            {
                obNew = await JsonSerializer.DeserializeAsync<T>(stream,
                   new JsonSerializerOptions { IncludeFields = true });
            }
            Console.WriteLine("Object was deserialized from Json");
            return obNew;
        }
    }
}
