using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Array
{
    class ExampleArray
    {
        private int[] ExArray;

        private bool InputArray()
        {
            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                ExArray = new int[Length];

                //вводим элементы массива
                Console.WriteLine("Введите целочисленные элементы массива:");
                for (int i = 0; i < Length; i++)
                {
                    if (!int.TryParse(Console.ReadLine(), out ExArray[i]))
                    {
                        Console.WriteLine("Ошибка: введено не целочисленное значение. Повторите ввод этого элемента:");
                        i--;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("Введено неверное значение размерности массива.");
                return false;
            }
        }

        public void ShowExample()
        {
            Console.WriteLine("****** Пример работы с одномерным массивом ******");
            Console.WriteLine("Введите размерность массива:");
            if (!InputArray())
                return;

            //выведем значения массива одной строкой
            Console.WriteLine("\n");
            Console.Write("Введенный массив: ");
            foreach (int i in ExArray)
                Console.Write("\t" + Convert.ToString(i));

            //выведем массив в обратном порядке одной строкой
            Console.WriteLine("\n");
            Console.Write("В обратном порядке: ");
            int y = ExArray.Length - 1;
            while (y >= 0)
            {
                Console.Write("\t" + Convert.ToString(ExArray[y]));
                y--;
            }
        }
    }
}
