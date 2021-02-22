using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.AssemblyEx
{
    class AssemblyTestClass
    {
        private readonly int Field1;
        public AssemblyTestClass()
        {   
            this.Field1 = new Random().Next(10,100);
        }

        public int GetField1()
        {
            return Field1;
        }
    }
}
