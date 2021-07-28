using System;

namespace Calculator
{
    public class Runner
    {
        static void Main(string[] args)
        {
            Expression Expression = new Expression();

            InputOutput.InputFigure(Expression);
            InputOutput.InputMathOperation(Expression);
            Calculation.Calculate(Expression);
            InputOutput.ShowResult(Expression);          
        }
    }
}
