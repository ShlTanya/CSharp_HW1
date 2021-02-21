using System;


namespace HW9.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class MethodAttribute : Attribute
    {
        public string Name { get; }

        public bool CanExecute { get; set; }
        
        public MethodAttribute(string name)
        {
            Name = name;
        }

    }
}
