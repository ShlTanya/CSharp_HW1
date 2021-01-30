using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var1
{
    class Dog
    {
        public Dog()
        {
            Cat.WakeUpEvent += DogWakeUpEvent;
        }

        void DogWakeUpEvent()
        {
            Console.Write("\tDog wof wof");
        }
    }
}
