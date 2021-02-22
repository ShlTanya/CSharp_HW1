using System;
using System.Reflection;


namespace HW9.AssemblyEx
{
    static class AssemblyExample
    {
        public static void Execute()
        {
            Assembly asm = Assembly.LoadFrom("HW9.exe");

            Console.WriteLine("Types in assembly:");
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine(">  " + t);

            Console.WriteLine("Select class and method:");
            Type type = asm.GetType("HW9.AssemblyEx.AssemblyTestClass");
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
