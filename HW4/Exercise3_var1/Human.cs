using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var1
{
    class Human
    {
        public Human()
        {
            Cat.WakeUpEvent += HumanWakeUpEvent;
        }

        void HumanWakeUpEvent()
        {
            Console.Write("\tHuman feed cat");
        }
    }
}
