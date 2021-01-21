using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.CollectionGeneric
{
    class ExampleQueueGeneric
    {
        private Queue<string> ExQueue;

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");

            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                ExQueue = new Queue<string>(Length);

                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции Queue:");
                for (int i = 0; i < Length; i++)
                    ExQueue.Enqueue(Console.ReadLine());
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
            foreach (object o in ExQueue)
                Console.Write(o + "\t");
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией Queue (Generics) ******");

            if (!InputCollection())
                return;

            Console.WriteLine("Введенная коллекция:");
            ShowCollectiion();

            //выведим элементы коллекции
            Console.WriteLine("\n");
            Console.WriteLine("Просмотр коллекции с удалением:");
            while (ExQueue.Count > 0)
            {
                Console.WriteLine("Dequeue -> {0}", ExQueue.Dequeue());
                Console.Write("коллекция:");
                ShowCollectiion();
                Console.WriteLine("\n");
            }
            Console.WriteLine("Количество элементов в коллекции: " + ExQueue.Count);

            Console.WriteLine("\n***************************************************");
        }
    }
}
