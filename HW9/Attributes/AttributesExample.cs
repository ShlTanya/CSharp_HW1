using System;
using System.IO;
using System.Reflection;

namespace HW9.Attributes
{
    class AttributesExample
    {
        public static void ExecuteHW9()
        {
            Console.WriteLine($"===========Attributes example(HW9)============");
            Type type = Type.GetType("HW9.Attributes.ExampleClass", false, true);

            foreach (MethodInfo mi in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.Write($"{mi.ReturnType.Name} {mi.Name} ");
                foreach (CustomAttributeData a in mi.CustomAttributes)
                {
                    Console.Write($"(attributes: {a.AttributeType.Name}");
                    foreach (CustomAttributeNamedArgument na in a.NamedArguments)
                        Console.Write($" {na.MemberName} - {na.TypedValue}");

                    Console.WriteLine(")");
                }
            }
        }

        public static void ExecuteHW10()
        {
            Console.WriteLine($"===========Attributes example(HW10 задание 2)============");
            Type type = Type.GetType("HW9.Attributes.ExampleClass", false, true);

            foreach (MemberInfo mi in type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"{mi.MemberType} {mi.Name}");
            }
        }
    }
}
