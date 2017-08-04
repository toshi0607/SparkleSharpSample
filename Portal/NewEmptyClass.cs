using System;
namespace SparkleSharpSample
{
    public class NewEmptyClass
    {
        EmptyClass klass = new EmptyClass();
        public NewEmptyClass()
        {
        }

        public string GetString()
        {
            return klass.GetString();
        }
    }
}
