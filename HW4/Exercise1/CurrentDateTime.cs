using System;
using System.Collections.Generic;
using System.Text;

namespace HW4.Exercise1
{
    class CurrentDateTime
    {
        DateTime _now = DateTime.Now;

        public delegate void ShowFormatedMessage();
        public ShowFormatedMessage ShowFormatedDateTime;

        public CurrentDateTime(string format) 
        {
            switch (format)
            {
                case "D":
                    ShowFormatedDateTime = ShowFormatD;
                    break;
                case "d":
                    ShowFormatedDateTime = ShowFormatd;
                    break;
                default:
                    Console.WriteLine("Неизвестный формат даты");
                    break;
            }
        }

        void ShowFormatD()
        {
            Console.WriteLine($"Полный формат даты - {_now.ToString("D")}");
        }

        void ShowFormatd()
        {
            Console.WriteLine($"Краткий формат даты - {_now.ToString("d")}");
        }
    }
}
