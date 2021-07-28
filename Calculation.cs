using System;

namespace Calculator
{
    public static class Calculation
    {
        public static void Calculate(Expression expression)
        {
            switch (expression.MathOperation)
            {
                case "+":
                    expression.Result = expression.Array[0] + expression.Array[1];
                    break;
                case "-":
                    expression.Result = expression.Array[0] - expression.Array[1];
                    break;
                case "*":
                    expression.Result = expression.Array[0] * expression.Array[1];
                    break;
                case "/":
                    expression.Result = (float) expression.Array[0] / expression.Array[1];
                    break;
            }
        }
    }
}
