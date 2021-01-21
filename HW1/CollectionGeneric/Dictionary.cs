using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.CollectionGeneric
{
    class ExampleDictionary
    {
        private Dictionary<int, string> ExDictionary = new Dictionary<int, string>();

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");
            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции Dictionary:");
                for (int i = 0; i < Length; i++)
                {
                    try
                    {
                        Console.WriteLine("элемент " + Convert.ToString(i) + " ключ (целое число):");
                        int Key = int.Parse(Console.ReadLine());
                        Console.WriteLine("элемент " + Convert.ToString(i) + " значение (строка):");
                        string Value = Console.ReadLine();
                        ExDictionary.Add(Key, Value);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка: введено неверное значение элемента. Повторите ввод.");
                        i--;
                    }
                }
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
            foreach (var el in ExDictionary)
                Console.WriteLine(el.Key.ToString() + "\t" + el.Value + "\t" + el.GetHashCode().ToString());
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией Dictionary ******");

            if (!InputCollection())
                return;

            //выведем элементы коллекции ключ - значение - hash
            Console.WriteLine("\n");
            Console.WriteLine("Введенная коллекция:");
            ShowCollection();

            //удалим элемент по ключу
            Console.WriteLine("\n");
            Console.WriteLine("Введите ключ удаляемого элемента:");
            if (int.TryParse(Console.ReadLine(), out int KeyForDelete))
            {
                if (ExDictionary.ContainsKey(KeyForDelete))
                {
                    ExDictionary.Remove(KeyForDelete);
                    Console.WriteLine($"Элемент с ключем {KeyForDelete} успешно удален.");

                    //выведем элементы коллекции ключ - значение - hash
                    Console.WriteLine("\n");
                    Console.WriteLine("Введенная коллекция после удаления:");
                    ShowCollection();
                }
                else
                    Console.WriteLine("Элемент c ключем " + KeyForDelete + " не найден.");
            }
            else
                Console.WriteLine("Введено неверное значение ключа.");

            Console.WriteLine("\n***************************************************");
        }
    }
}
