using System;

namespace Calculator
{
    public class Expression

    {
    public int FirstNumber { get; }
    public int SecondNumber { get; }
    public string MathOperation { get; }

        public Expression(int firstNumber, int secondNumber, string mathOperation)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
            this.MathOperation = mathOperation;
        }
    }
}
