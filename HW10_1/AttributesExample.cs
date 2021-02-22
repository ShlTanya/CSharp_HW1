using System;
using System.Reflection;

namespace HW10_1
{
    public class AttributesExample
    {
        public static void Execute()
        {
            Console.WriteLine($"===========Attributes example(HW10 задание 1,2)============");
            Type type = Type.GetType("HW10_1.ExampleClass", false, true);

            foreach (MemberInfo mi in type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"{mi.MemberType} {mi.Name}");
            }
        }
    }
}
