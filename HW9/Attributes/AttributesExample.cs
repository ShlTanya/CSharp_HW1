using System;
using System.Reflection;

namespace HW9.Attributes
{
    class AttributesExample
    {
        public static void Execute()
        {
            Console.WriteLine($"===========Attributes example============");
            Type type = Type.GetType("HW9.Attributes.ExampleClass", false, true);

            foreach (MethodInfo mi in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.Write($"{mi.ReturnType.Name} {mi.Name} (attributes: ");
                foreach (CustomAttributeData a in mi.CustomAttributes)
                Console.WriteLine($"{a.AttributeType.Name},  {a.NamedArguments[0].MemberName} - {a.NamedArguments[0].TypedValue})");
            }
                Console.ReadKey();
        }
    }
}
