using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.CollectionGeneric
{
    class ExampleLinkedList
    {
        private LinkedList<string> ExLList = new LinkedList<string>();

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");

            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            { 
                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции LinkedList:");
                ExLList.AddFirst(Console.ReadLine());
                for (int i = 1; i < Length - 1; i++)
                    ExLList.AddAfter(ExLList.Last, Console.ReadLine());
                ExLList.AddLast(Console.ReadLine());
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
            LinkedListNode<string> currNode = ExLList.First;
            while (currNode != null)
            {
                Console.Write(currNode.Value + "\t");
                currNode = currNode.Next;
            }
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией LinkedList ******");

            if (!InputCollection())
                return;

            Console.WriteLine("\n");
            Console.WriteLine("Введенная коллекция:");
            ShowCollectiion();

            //удалим элемент
            Console.WriteLine("\n");
            Console.WriteLine($"Введите индекс удаляемого элемента(от 0 до {ExLList.Count - 1}):");
            if (int.TryParse(Console.ReadLine(), out int Index) && Index >= 0 && Index < ExLList.Count)
            {
                LinkedListNode<string> currNode = ExLList.First;
                for(int i = 0; i < Index; i++)
                    currNode = currNode.Next;
                ExLList.Remove(currNode);

                Console.WriteLine($"Элемент с индексом {Index} успешно удален");

                //выведем элементы коллекции ключ - значение 
                Console.WriteLine("\n");
                Console.WriteLine("Введенная коллекция после удаления:");
                ShowCollectiion();
            }
            else
                Console.WriteLine("Введено неверное значение индекса.");

            Console.WriteLine("\n***************************************************");
        }
    }
}
