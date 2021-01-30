using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise2
{
    public delegate T Operation<T, R>(R value);

    class Example3
    {

        public void ShowExample()
        {
            Operation<string, int> operation = (int x) => Convert.ToString(x);

            Console.WriteLine("\nЗадание 2. Пример 1: ");
            Console.WriteLine(operation(5));
            int y = 10;
            Operation<string, int> operation1 = (int x) => Convert.ToString(x+y);
            Console.WriteLine(operation1(5));


        }

    }


}
