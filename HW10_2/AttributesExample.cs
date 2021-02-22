using System;
using System.Reflection;
using HW10_1;

namespace HW10_2
{
    public class AttributesExample
    {
        public static void Execute(Object ob)
        {
            Console.WriteLine($"===========Attributes example(HW10 задание 2)============");
            ExampleClass exampleClass = new ExampleClass();
            string className = exampleClass.ToString();
            Type type = Type.GetType(className, false, true);

            foreach (MemberInfo mi in type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"{mi.MemberType} {mi.Name}");
            }
        }
    }
}
