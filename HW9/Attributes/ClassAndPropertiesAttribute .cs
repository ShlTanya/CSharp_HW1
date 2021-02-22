using System;


namespace HW9.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    class ClassAndPropertiesAttribute : Attribute
    {
        public string Author { get; }

        public string Version { get; set; }

        public ClassAndPropertiesAttribute(string author)
        {
            Author = author;
        }

    }
}
