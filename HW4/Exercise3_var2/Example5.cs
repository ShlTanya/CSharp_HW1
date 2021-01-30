using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var2
{
    class Example5
    {
        public void ShowExample()
        {
            Console.WriteLine("\nЗадание 3. Пример 2:");
            Dog dog = new Dog();
            Mouse mouse = new Mouse();
            Human human = new Human();
            Cat cat1 = new Cat("Мурка");
            cat1.WakeUpEvent += dog.DogWakeUpEvent;
            cat1.WakeUpEvent += mouse.MouseWakeUpEvent;
            cat1.WakeUpEvent += human.HumanWakeUpEvent;
            cat1.CatWakeUp();
            Cat cat2 = new Cat("Васька");
            cat2.WakeUpEvent += mouse.MouseWakeUpEvent;
            cat2.WakeUpEvent += human.HumanWakeUpEvent;
            cat2.CatWakeUp();
        }
    }
}
