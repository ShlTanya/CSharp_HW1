using System;
using System.Reflection;


namespace HW10_4
{
    public static class AssemblyExample
    {
        public static void Execute()
        {
            Console.WriteLine($"===========Assembly example(HW10.4)============");
            Assembly asm = Assembly.LoadFrom("HW10_4.dll");

            Console.WriteLine("Types in assembly:");
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine(">  " + t);

            Console.WriteLine("Select class and method:");
            Type type = asm.GetType("HW10_4.AssemblyTestClass");
            Console.WriteLine(type.FullName);

            MethodInfo mInfo = type.GetMethod("GetField1");
            Console.WriteLine(mInfo.Name);

            Console.WriteLine("Create new object by selected class:");
            var myTestClass = System.Activator.CreateInstance(type);
            Console.WriteLine($"New object {myTestClass} was created");
            Console.WriteLine(mInfo.Name);
            Console.WriteLine(mInfo.Invoke(myTestClass, null));
        }

    }
}
