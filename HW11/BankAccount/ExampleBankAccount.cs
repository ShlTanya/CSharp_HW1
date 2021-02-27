using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW11.BankAccount
{
    class ExampleBankAccount
    {
        private readonly static BankAccount bankAccount = new BankAccount();

        public static void ShowExmple()
        {
            Console.WriteLine("*********** Exersice 1 ******************");

            int threadcount = 5;
            Thread[] threads = new Thread[threadcount];

            for (int i = 0; i < threadcount; ++i)
                (threads[i] = new Thread(WorkWithBankAccout)).Start();

            for (int i = 0; i < threadcount; ++i)
                threads[i].Join();

            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }

        private static void WorkWithBankAccout()
        {
            bankAccount.Credit(100);
            bankAccount.Debit(5);
            bankAccount.Debit(150);
            bankAccount.Credit(20);
        }
    }
}
