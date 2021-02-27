using HW11.BankAccount;
using HW11.Exercise2;
using System;
using System.Threading;

namespace HW11
{
    class Program
    {
        private static Mutex _mutex;

        static void Main(string[] args)
        {
            _mutex = new Mutex(false, "HW11", out bool isNew);

            if (!isNew)
            {
                Console.WriteLine($"Programm is started. Press key to exit");
                Console.ReadKey();
                return;
            }

            ExampleBankAccount.ShowExmple();
            ExampleExercise2.ShowExample();


        }
    }
}
