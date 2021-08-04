namespace Calculator
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            do
            {
                Expression expression = new Expression(ExpressionReader.InputFigure(), ExpressionReader.InputFigure(), ExpressionReader.InputMathOperation());
                ExpressionWriter.ShowResult(expression);
            } while (ExpressionReader.IsRestart());
        }
    }
}
