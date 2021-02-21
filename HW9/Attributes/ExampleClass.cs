using System;

namespace HW9.Attributes
{
    class ExampleClass
    {
        [MethodAttribute("MyClassExec", CanExecute = true)]
        public void MyClassExec()
        {
            Console.WriteLine("MyClassExec");
        }

        [MethodAttribute("MyClassNonExec", CanExecute = false)]
        private void MyClassNonExec()
        {
            Console.WriteLine("MyClassNonExec");
        }
    }
}
