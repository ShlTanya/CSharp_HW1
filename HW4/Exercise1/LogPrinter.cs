using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise1
{
    class LogPrinter
    {
        public delegate string DateTimeFormater(DateTime date);
        DateTimeFormater _dateTimeFormater;

        public LogPrinter(DateTimeFormater dateTimeFormater)
        {
            _dateTimeFormater = dateTimeFormater;
        }

        public void Print(DateTime date, string message)
        {
            Console.WriteLine($"Дата: {_dateTimeFormater(date)} \t{message}");
        }
    }



}
