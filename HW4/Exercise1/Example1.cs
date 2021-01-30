using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise1
{
    class Example1
    {

        delegate CurrentDateTime ShowDateTime();

        public void ShowExample()
        {
            Console.WriteLine("Задание 1. Пример 1:");
            
            ShowDateTime showDateTimeLong = () => new CurrentDateTime("D");
            showDateTimeLong().ShowFormatedDateTime();

            ShowDateTime showDateTimeShort = () => new CurrentDateTime("d");
            showDateTimeShort().ShowFormatedDateTime();

         }

    }
}
