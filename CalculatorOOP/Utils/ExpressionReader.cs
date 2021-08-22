using System;

namespace Calculator
{
    public static class ExpressionReader
    {
        private const int NotANumber = 0;

        private static int InputFigureCounter = 1;
        public static int InputFigure()
        {
            int parsseNumber;

            do
            {
                Console.WriteLine($"Введите простое целое число №{InputFigureCounter} от 1 до 1000.");
                int.TryParse(Console.ReadLine(), out parsseNumber);
            } while (!IsNumberType(parsseNumber) || !IsWithinRange(parsseNumber));

            InputFigureCounter++;
            return parsseNumber;
        }

        public static bool IsRestart()
        {
            Console.WriteLine("Нажмите + чтобы перезапустить программу. Нажмите любую клавишу, чтобы выйти.");
            InputFigureCounter = 1;
            return Console.ReadLine().Equals("+");
        }

        public static string InputMathOperation()
        {
            string str;

            do
            {
                Console.WriteLine("Введите символ математической операции.\n+: сложение\n-: вычитание\n*: умножение\n/: деление");
                str = Console.ReadLine();
            } while (!IsValidMathOperator(str));

            return str;
        }

        private static bool IsValidMathOperator(string mathOperator)
        {

            if (mathOperator.Equals("+") || mathOperator.Equals("-") ||
                mathOperator.Equals("*") || mathOperator.Equals("/"))
                return true;

            Console.WriteLine("Ошибка. Введите валидный символ оператора.");
            return false;
        }

        private static bool IsNumberType(int number)
        {
            if (number == NotANumber)
            {
                Console.WriteLine("Ошибка. Неверный тип данных. Введите число.");
                return false;
            }
            return true;
        }

        private static bool IsWithinRange(int number)
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

