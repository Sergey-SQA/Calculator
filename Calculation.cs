using System;

namespace Calculator
{
    public static class Calculation
    {
        public static float Calculate(Expression expression)
        {
            switch (expression.MathOperation)
            {
                case "+":
                    return expression.FirstNumber + expression.SecondNumber;
                case "-":
                    return expression.FirstNumber - expression.SecondNumber;
                case "*":
                    return expression.FirstNumber * expression.SecondNumber;
                case "/":
                    return (float) expression.FirstNumber / expression.SecondNumber;
                default:
                    throw new InvalidMathOperatorException("Неверный математический оператор");
            }
        }
    }
}
