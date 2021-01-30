using System;
using HW4.Exercise1;
using HW4.Exercise2;
using HW4.Exercise3_var1;
using HW4.Exercise3_var2;



namespace HW4
{
    class Program
    { 

        static void Main()
        {
            Example1 example1 = new Example1();
            example1.ShowExample();

            Example2 example2 = new Example2();
            example2.ShowExample();

            Example3 example3 = new Example3();
            example3.ShowExample();

            Example4 example4 = new Example4();
            example4.ShowExample();

            Example5 example5 = new Example5();
            example5.ShowExample();

            Console.ReadKey();
        }
    }
}
