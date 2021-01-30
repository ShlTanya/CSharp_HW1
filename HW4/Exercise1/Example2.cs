using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise1
{
    class Example2
    {

        public void ShowExample()
        {
            Console.WriteLine("\nЗадание 1. Пример 2: ");
            LogPrinter logPrinter = new LogPrinter(x => x.ToString("G"));
            logPrinter.Print(DateTime.Now, "Событие1");
            logPrinter.Print(DateTime.Now, "Событие2");

            logPrinter = new LogPrinter(ShortDateTimeFormater.Format);
            logPrinter.Print(DateTime.Now, "Событие3");
            logPrinter.Print(DateTime.Now, "Событие4");

            logPrinter = new LogPrinter(LongDateTimeFormater.Format);
            logPrinter.Print(DateTime.Now, "Событие5");
            logPrinter.Print(DateTime.Now, "Событие6");

        }

    }

    class ShortDateTimeFormater
    {
        public static string Format(DateTime date)
        {
            return date.ToString("d");
        }
    }

    class LongDateTimeFormater
    {
        public static string Format(DateTime date)
        {
            return date.ToString("D");
        }
    }
}
