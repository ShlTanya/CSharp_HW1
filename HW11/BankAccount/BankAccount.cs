using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW11.BankAccount
{
    class BankAccount
    {
        private int _balance;
        static readonly object locker = new object();

        public BankAccount()
        {
            _balance = 0;
        }

        public void Credit(int sum)
        {
            lock (locker)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.Write($"Thread Id: {threadId} \tBalanceBefore: {_balance} \t+Summ: {sum} ");
                _balance += sum;
                Console.WriteLine($"\tBalanceAfter: {_balance}");
                Thread.Sleep(100);
            }
        }

        public void Debit(int sum)
        {
            lock (locker)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.Write($"Thread Id: {threadId} \tBalanceBefore: {_balance} \t-Summ: {sum} ");
                if (sum > _balance)
                {
                    Console.WriteLine($"\t!!! The action was canceled because the debit({sum}) is greater than the balance({_balance})");
                }
                else
                {
                    _balance -= sum;
                    Console.WriteLine($"\tBalanceAfter: {_balance}");
                }
                Thread.Sleep(50);
            }
        }

        public int CurrentBalance()
        {
            return _balance;
        }

    }
}
