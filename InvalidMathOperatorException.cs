using System;

namespace Calculator
{
    public class InvalidMathOperatorException : ApplicationException 
    {
        public InvalidMathOperatorException(string message) : base(message)
        {
        }
    }
}
