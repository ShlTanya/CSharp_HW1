using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Collection
{
    class ExampleStack
    {
        private Stack ExStack;

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");

            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                ExStack = new Stack(Length);

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

        private void ShowCollection()
        {
            foreach (object o in ExStack)
                Console.Write(o + "\t");
        }

        private void ShowCollection(string Info)
        {
            Console.WriteLine("\n" + Info);
            foreach (object o in ExStack)
                Console.Write(o + "\t");
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией Stack ******");

            if (!InputCollection())
                return;

            ShowCollection("Введенная коллекция:");

            //выведим элементы коллекции
            Console.WriteLine("Просмотр коллекции с удалением:");
            while (ExStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", ExStack.Pop());
                Console.Write("коллекция:");
                ShowCollection();
                Console.Write("\n");
            }

            Console.WriteLine("Количество элементов в коллекции: " + ExStack.Count);

            Console.WriteLine("\n***************************************************");
        }
    }
}
