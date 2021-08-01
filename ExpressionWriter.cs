using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class ExpressionWriter
    {
        public static void ShowResult(Expression expression)
        {
            Console.WriteLine($"{expression.FirstNumber} {expression.MathOperation} {expression.SecondNumber} = {Calculation.Calculate(expression)}");
        }
    }
}
