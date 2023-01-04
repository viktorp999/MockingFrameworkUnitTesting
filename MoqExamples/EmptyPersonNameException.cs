using System;

namespace MoqExamples
{
    public class EmptyPersonNameException : Exception
    {
        public string Error()
        {
            return "Empty name is not allowed";
        }
    }
}
