using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW1.Array;
using HW1.Collection;
using HW1.CollectionGeneric;
using HW1.ExampleInterfaces;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleArrayList exampleArrayList = new ExampleArrayList();
            exampleArrayList.ShowExample();

            ExampleHashTable exampleHashTable = new ExampleHashTable();
            exampleHashTable.ShowExample();

            ExampleStack exampleStack = new ExampleStack();
            exampleStack.ShowExample();

            ExampleQueue exampleQueue = new ExampleQueue();
            exampleQueue.ShowExample();

            ExampleList exampleList = new ExampleList();
            exampleList.ShowExample();

            ExampleDictionary exampleDictionary = new ExampleDictionary();
            exampleDictionary.ShowExample();

            ExampleStackGeneric exampleStackGeneric = new ExampleStackGeneric();
            exampleStackGeneric.ShowExample();

            ExampleQueueGeneric exampleQueueGeneric = new ExampleQueueGeneric();
            exampleQueueGeneric.ShowExample();

            ExampleLinkedList exampleLinkedList = new ExampleLinkedList();
            exampleLinkedList.ShowExample();

            ExInterfaces exInterfaces = new ExInterfaces();
            exInterfaces.ShowExample();

            Console.ReadKey();
        }
    }
}
