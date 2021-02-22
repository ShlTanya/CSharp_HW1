using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW10_1;
using HW10_3;
using HW10_4;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            AttributesExample.Execute();
            Console.ReadKey();

            AssemblyExample.Execute();
            Console.ReadKey();

            SerializedExample.SerializedToJson();
            Console.ReadKey();

            SerializedExample.DeSerializedFromJson();
            Console.ReadKey();

        }

    }
}
