using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.CollectionGeneric
{
    class ExampleStackGeneric
    {
        private Stack<string> ExStack = new Stack<string>();

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");

            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            { 
                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции Stack:");
                for (int i = 0; i < Length; i++)
                    ExStack.Push(Console.ReadLine());
                return true;
            }
            else
            {
                Console.WriteLine("Введено неверное значение количества элементов.");
                return false;
            }
        }

        private void ShowCollectiion()
        {
            foreach (object o in ExStack)
                Console.Write(o + "\t");
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией Stack (Generics) ******");

            if (!InputCollection())
                return;

            Console.WriteLine("Введенная коллекция:");
            ShowCollectiion();

            //выведим элементы коллекции
            Console.WriteLine("\n");
            Console.WriteLine("Просмотр коллекции с удалением:");
            while (ExStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", ExStack.Pop());
                Console.Write("коллекция:");
                ShowCollectiion();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Количество элементов в коллекции: " + ExStack.Count);

            Console.WriteLine("\n***************************************************");
        }
    }
}
