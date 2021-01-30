using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var1
{
    class Example4
    {
        public void ShowExample()
        {
            Console.WriteLine("\nЗадание 3. Пример 1:");
            Dog dog = new Dog();
            Mouse mouse = new Mouse();
            Human human = new Human();
            Cat cat1 = new Cat("Мурка");
            cat1.CatWakeUp();
            Cat cat2 = new Cat("Васька");
            cat2.CatWakeUp();


        }
    }
}
