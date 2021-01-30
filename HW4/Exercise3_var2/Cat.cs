using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise3_var2
{
    class Cat
    {
        string _nickName;
        public Cat(string nickName) 
        {
            _nickName = nickName;
        }

        public delegate void WakeUpDelegate();
        public event WakeUpDelegate WakeUpEvent;

        public void CatWakeUp()
        {
            Console.Write($"\nCat {_nickName} wakeup - ");
            WakeUpEvent?.Invoke();
        }

    }
}
