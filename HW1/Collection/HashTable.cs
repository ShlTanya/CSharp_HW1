using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.Collection
{
    class ExampleHashTable
    {
        private Hashtable ExHashtable = new Hashtable();

        private bool InputCollection()
        {
            Console.WriteLine("Введите количество элементов коллекции:");
            if (int.TryParse(Console.ReadLine(), out int Length) && Length > 0)
            {
                //вводим элементы коллекции
                Console.WriteLine("Введите элементы коллекции HashTable:");
                for (int i = 0; i < Length; i++)
                {
                    Console.WriteLine("элемент " + Convert.ToString(i) + " ключ:");
                    var Key = Console.ReadLine();
                    Console.WriteLine("элемент " + Convert.ToString(i) + " значение:");
                    var Value = Console.ReadLine();
                    try
                    {
                        ExHashtable.Add(Key, Value);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка: введено неверное значение ключа. Повторите ввод.");
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
            foreach (DictionaryEntry o in ExHashtable)
                Console.WriteLine(o.Key.ToString() + "\t" + o.Value.ToString() + "\t" + o.GetHashCode().ToString());
        }

        private void ShowCollection(string Info)
        {
            Console.WriteLine(Info);
            foreach (DictionaryEntry o in ExHashtable)
                Console.WriteLine(o.Key.ToString() + "\t" + o.Value.ToString() + "\t" + o.GetHashCode().ToString());
        }

        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с коллекцией Hashtable ******");

            if (!InputCollection())
                return;

            //выведем элементы коллекции ключ - значение - hash
            Console.WriteLine("\n");
             ShowCollection("Введенная коллекция:");

            //удалим элемент по ключу
            Console.WriteLine("\n");
            Console.WriteLine("Введите ключ удаляемого элемента:");
            var KeyForDelete = Console.ReadLine();
            if(ExHashtable.ContainsKey(KeyForDelete))
            {
                ExHashtable.Remove(KeyForDelete);
                Console.WriteLine($"Элемент с ключем {KeyForDelete} успешно удален");

                //выведем элементы коллекции ключ - значение - hash
                Console.WriteLine("\n");
                Console.WriteLine("Введенная коллекция после удаления:");
                ShowCollection();
            }
            else
                Console.WriteLine($"Элемент c ключем {KeyForDelete} не найден.");

            Console.WriteLine("\n***************************************************");
        }
    }
}
