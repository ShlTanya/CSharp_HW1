using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.CollectionGeneric
{
    class ExampleList
    {
        private List<int> ExList;

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");
            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                ExList = new List<int>(Length);

                int ImputVal;
                //вводим элементы коллекции
                Console.WriteLine("Введите целочисленные элементы коллекции List:");
                for (int i = 0; i < Length; i++)
                    if (!int.TryParse(Console.ReadLine(), out ImputVal))
                    {
                        Console.WriteLine("Ошибка: введено не целочисленное значение. Повторите ввод этого элемента:");
                        i--;
                    }
                    else
                        ExList.Add(ImputVal);
                
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
            //foreach (object o in ExList)
            //    Console.Write("\t" + o.ToString());

            for (int i = 0; i < ExList.Count; i++)
                Console.Write("\t" + ExList[i].ToString());
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией List ******");

            if (!InputCollection())
                return;

            //выведем элементы коллекции одной строкой
            Console.WriteLine("\n");
            Console.Write("Введенная коллекция: ");
            ShowCollectiion();


            //выведем элементы коллекции в обратном порядке одной строкой
            Console.WriteLine("\n");
            Console.Write("В обратном порядке: ");
            ExList.Reverse();
            ShowCollectiion();

            //удалим заданный (по индексу) элемент инверсированной коллекции
            Console.WriteLine("\n");
            Console.WriteLine("Введите индекс удаляемого элемента");
            if ((int.TryParse(Console.ReadLine(), out int Index)) && (Index > 0) && (Index < ExList.Count - 1))
            {
                ExList.RemoveRange(Index, 1);
                Console.WriteLine("\n");
                Console.Write("Коллекция после удаления:");
                ShowCollectiion();
            }
            else
                Console.WriteLine("Введено неверное значение индекса.");

            Console.WriteLine("\n***************************************************");
        }
    }
}
