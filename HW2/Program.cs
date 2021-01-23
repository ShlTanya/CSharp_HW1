using System;
using System.Collections;
using System.Collections.Generic;
using HW2.UserCollection;
using HW2.Generics;

namespace HW2
{
    class Program
    {

        static void ShowExampleMyGClass()
        {
            Console.WriteLine("*********** Задание 2 (вариант 1) ***************");
            GenericsList<int> gList = new GenericsList<int>() {1,2,4,5,6};
            GenericsUserClass<int, GenericsList<int>> gUserClass = new GenericsUserClass<int, GenericsList<int>>(gList);

            GenericsList<int> gNewList = new GenericsList<int>();
            gUserClass.Element = 7;
            gNewList = gUserClass.AddElement();

            Console.WriteLine("Элементы старой коллекции:");
            foreach (object o in gList)
                Console.WriteLine(o);

            Console.WriteLine("Элементы новой коллекции:");
            foreach (object o in gNewList)
                Console.WriteLine(o);
        }

        static void ShowExampleMyGClassR()
        {
            Console.WriteLine("*********** Задание 2 (вариант 2) ***************");
            GenericsList<int> gList = new GenericsList<int>() { 1, 2, 4, 5, 6 };
            GenericsUserClassR<int, GenericsList<int>> gUserClass = new GenericsUserClassR<int, GenericsList<int>>(gList);

            GenericsList<int> gNewList = new GenericsList<int>();
            gUserClass.Element = 7;
            gNewList = gUserClass.AddElement();

            Console.WriteLine("Элементы старой коллекции:");
            foreach (object o in gList)
                Console.WriteLine(o);

            Console.WriteLine("Элементы новой коллекции:");
            foreach (object o in gNewList)
                Console.WriteLine(o);
        }

        static void ShowExampleMyList()
        {
            Console.WriteLine("*********** Задание 1 ***************");
            GenericsList<int> gList = new GenericsList<int>();

            ArrayList arrayToFill = new ArrayList() { 1, 2, "asdad", 3, 4, 5, "asdas", 6, 7 };

            Console.WriteLine("Добавление элементов в коллекцию MyList:");
            for(int i = 0; i < arrayToFill.Count; i++)
            {
                try
                {
                    gList.Add(arrayToFill[i]);
                    Console.WriteLine($"Добавлен элемент {arrayToFill[i]}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка при добавлении элемента {arrayToFill[i]}: " + e.Message);
                }

            }
            Console.WriteLine("\nЭлементы коллекции GList:");
            foreach (object o in gList)
                Console.WriteLine(o);

            bool Rem = true;

            while (Rem)
            {
                //удалим заданный (по индексу) элемент  
                Console.WriteLine("Введите индекс удаляемого элемента:");
                if ((int.TryParse(Console.ReadLine(), out int Index)) && (Index > -1) && (Index < gList.Count))
                {
                    try
                    {
                        gList.Remove(Index);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    Console.WriteLine("\nЭлементы GList:");
                    foreach (object o in gList)
                        Console.WriteLine(o);
                }
                else
                    Console.WriteLine("Введено неверное значение индекса.");

                Console.WriteLine("Хотите еще раз удалить элемент (да/нет)?");
                if (!(Console.ReadLine().ToLower() == "да"))
                    Rem = false;
            }
        }

        static void Main(string[] args)
        {
            ShowExampleMyList();

            ShowExampleMyGClass();

            ShowExampleMyGClassR();

            Console.ReadKey();
        }


    }
}
