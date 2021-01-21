using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.ExampleInterfaces
{
    interface IBankAccount
    {
        string AccNo{ get;}
    }

    interface ISum
    {
        string Value { get; }
    }

    class BpsBankAccount: IBankAccount
    {
        public string AccNo { get;}

        public BpsBankAccount(string accNo)
        {
            this.AccNo = "BPSB" + accNo;
        }
    }

    class BelBankAccount : IBankAccount
    {
        public string AccNo { get; }

        public BelBankAccount(string accNo)
        {
            this.AccNo = "BEL" + accNo;
        }
    }

    class BynSum: ISum
    {
        public string Value { get;}

        public BynSum(double value)
        {
            Value = Convert.ToString(value) + " BYN";
        }
    }

    class UsdSum : ISum
    {
        public string Value { get;}

        public UsdSum(double value)
        {
            Value = "$" + Convert.ToString(value);
        }
    }

    class ExInterfaces
    {
        public void ShowExample()
        {
            Console.WriteLine("\n****** Пример работы с интерфейсами ******");

            Dictionary<IBankAccount, ISum> dictAcc = new Dictionary<IBankAccount, ISum>();
            dictAcc.Add(new BpsBankAccount("1"), new BynSum(10));
            dictAcc.Add(new BelBankAccount("2"), new BynSum(20));
            dictAcc.Add(new BpsBankAccount("3"), new UsdSum(30));
            dictAcc.Add(new BelBankAccount("4"), new UsdSum(40));

            foreach (var el in dictAcc)
                Console.WriteLine(el.Key.AccNo + "\t" + el.Value.Value);

            Console.WriteLine("\n***************************************************");
        }
    }
}
