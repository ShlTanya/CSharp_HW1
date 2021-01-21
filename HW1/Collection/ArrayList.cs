using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Collection
{
    class ExampleArrayList
    {
        private ArrayList ExArrayList = new ArrayList();

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");
            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции ArrayList (различного типа):");
                for (int i = 0; i < Length; i++)
                    ExArrayList.Add(Console.ReadLine());
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
            foreach (object o in ExArrayList)
                Console.Write("\t" + o.ToString());
        }

        private void ShowCollection(string Info)
        {
            Console.Write(Info);
            for (int i = 0; i < ExArrayList.Count; i++)
                Console.Write("\t" + ExArrayList[i].ToString());
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией ArrayList ******");

            if (!InputCollection())
                return;

            //выведем элементы коллекции одной строкой
            Console.WriteLine("\n");
            ShowCollection("Введенная коллекция: ");


            //выведем элементы коллекции в обратном порядке одной строкой
            Console.WriteLine("\n");
            Console.Write("В обратном порядке: ");
            ExArrayList.Reverse();
            ShowCollection();
 
            //удалим заданный (по индексу) элемент инверсированной коллекции
            Console.WriteLine("\n");
            Console.WriteLine($"Введите индекс удаляемого элемента(от 0 до {ExArrayList.Count - 1}):");
            if ((int.TryParse(Console.ReadLine(), out int Index)) && (Index >= 0) && (Index < ExArrayList.Count))
            {
                ExArrayList.RemoveRange(Index, 1);
                ShowCollection("Коллекция после удаления:");
            }
            else
                Console.WriteLine("Введено неверное значение индекса.");

            Console.WriteLine("\n***************************************************");
        }
    }
}
