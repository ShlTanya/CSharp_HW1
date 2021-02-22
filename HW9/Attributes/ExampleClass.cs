using System;
using System.Text.Json.Serialization;

namespace HW9.Attributes
{
    [ClassAndPropertiesAttribute("ShlTanya", Version ="1.01")]
    class ExampleClass
    {
        [ClassAndPropertiesAttribute("TananaMich", Version = "1.00")]
        [ClassAndPropertiesAttribute("ShlTanya", Version = "1.01")]
        public string ClassName { get; set; }

        [JsonPropertyName("ExecuteDate")]
        public DateTime execDate;

        public ExampleClass()
        {
            SetExecDate();
        }

        private void SetExecDate()
        {
            this.execDate = DateTime.Now;
        }

        [MethodAttribute("MyClassExec", CanExecute = true)]
        public void MyClassExec()
        {
            Console.WriteLine($"MyClass {ClassName} execute at {execDate}");
        }

        [MethodAttribute("UpdateExecDate", CanExecute = true)]
        public void UpdateExecDate(DateTime execDate)
        {
            this.execDate = execDate;
            Console.WriteLine($"Execute date was update to {execDate}");
        }
    }
}
