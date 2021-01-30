using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var1
{
    class Mouse
    {
        public Mouse()
        {
            Cat.WakeUpEvent += MouseWakeUpEvent;
        }

        void MouseWakeUpEvent()
        {
            Console.Write("\tMouse run");
        }
    }
}
