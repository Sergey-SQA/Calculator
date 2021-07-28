using System;

namespace Calculator
{
    public static class InputOutput
    {
        public static void ShowResult(Expression expression)
        {
            Console.WriteLine($"{expression.Array[0]} {expression.MathOperation} {expression.Array[1]} = {expression.Result}");
        }

        public static void ShowExpressionNumbers(Expression expression)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Число №{i + 1} = {expression.Array[i]}");
            }
        }

        public static void InputFigure(Expression expression)
        {
            int x;

            for (int i = 0; i < 2; i++)
            {
                do
                {
                    Console.WriteLine($"Введите простое целое число №{i + 1} от 1 до 1000.");
                    int.TryParse(Console.ReadLine(), out x);
                    expression.Array[i] = x;
                } while (!ValidateInputNumberType(x) || !ValidateInputNumberRange(x));               
            }            
            ShowExpressionNumbers(expression);
        }

        public static void InputMathOperation(Expression expression)
        {
            Console.WriteLine("Введите символ математической операции.\n+: сложение\n-: вычитание\n*: умножение\n/: деление");
            expression.MathOperation = Console.ReadLine();
        }

        public static bool ValidateInputNumberType(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Ошибка. Неверный тип данных. Введите число.");
                return false;
            }
            return true;
        }
        public static bool ValidateInputNumberRange(int number)
        {
            if (number < 1 | number > 1000)
            {
                Console.WriteLine("Ошибка. Неверный диапазон данных. Введите число от 1 до 1000.");
                return false;
            }
            return true;
        }
       
    }
}

