using System;
using System.Threading;

namespace Calculator
{
    class CalcuHome
    {
        private int FirstInt;
        private int SecondInt;
        private int OperationCalculate;
        private int OperationRestart;

        public int GetFirstInt()
        {
            return FirstInt;
        }

        public int GetSecondInt()
        {
            return SecondInt;
        }

        public int GetOperation()
        {
            return OperationCalculate;
        }

        public int GetOperationRestart()
        {
            return OperationRestart;
        }


        public void InputFirstFigure()
        {
            Begin:
            Console.WriteLine("Введите простое целое число №1 от 1 до 1000");
            bool trueInt = int.TryParse(Console.ReadLine(), out FirstInt);
            while (!trueInt)
            {
                Console.WriteLine("Ошибка ввода. Вы ввели не число");
                Console.WriteLine("Введите простое целое число №1 от 1 до 1000");
                trueInt = int.TryParse(Console.ReadLine(), out FirstInt);               
            }
            while (FirstInt > 1000 ^ FirstInt < 1)
            {
                Console.WriteLine("Ошибка ввода. Неверный диапазон значений");
                Console.WriteLine("Введите простое целое число №1 от 1 до 1000");
                trueInt = int.TryParse(Console.ReadLine(), out FirstInt);
                if (trueInt == false)
                {
                    Console.WriteLine("Ошибка ввода. Вы ввели не число");
                    goto Begin;
                }
            }
            Console.WriteLine($"Успешно. Вы ввели число {FirstInt}"); 
        }

        public void InputSecondFigure()
        {   
            Begin:
            Console.WriteLine("Введите простое целое число №2 от 1 до 1000");
            bool trueInt = int.TryParse(Console.ReadLine(), out SecondInt);
            while (!trueInt)
            {
                Console.WriteLine("Ошибка ввода. Вы ввели не число");
                Console.WriteLine("Введите простое целое число №2 от 1 до 1000");
                trueInt = int.TryParse(Console.ReadLine(), out SecondInt);
            }
            while (SecondInt > 1000 ^ SecondInt < 1)
            {
                Console.WriteLine("Ошибка ввода. Неверный диапазон значений");
                Console.WriteLine("Введите простое целое число №2 от 1 до 1000");
                trueInt = int.TryParse(Console.ReadLine(), out SecondInt);
                if (trueInt == false)
                {
                    Console.WriteLine("Ошибка ввода. Вы ввели не число");
                    goto Begin;
                }
            }
            Console.WriteLine($"Успешно. Вы ввели число {SecondInt}");
        }

        public void InputOperation()
        {
            Console.WriteLine("Введите номер операции:\n1 - сложение;\n2 - вычитание;\n3 - умножение;\n4 - деление");
            bool trueInt = int.TryParse(Console.ReadLine(), out OperationCalculate);
            while (!trueInt)
            {
                Console.WriteLine("Ошибка ввода. Вы ввели не число");
                Console.WriteLine("Введите номер операции:\n1 - сложение;\n2 - вычитание;\n3 - умножение;\n4 - деление");
                trueInt = int.TryParse(Console.ReadLine(), out OperationCalculate);
            }
            while (OperationCalculate > 4 ^ OperationCalculate < 1)
            {
                Console.WriteLine("Ошибка ввода. Неверный диапазон значений");
                Console.WriteLine("Введите номер операции:\n1 - сложение;\n2 - вычитание;\n3 - умножение;\n4 - деление");
                trueInt = int.TryParse(Console.ReadLine(), out OperationCalculate);
            }
            switch (OperationCalculate)
            {
                case 1: Console.WriteLine($"{OperationCalculate} - Выбрано сложение");
                    break;
                case 2: Console.WriteLine($"{OperationCalculate} - Выбрано вычитание");
                    break;
                case 3: Console.WriteLine($"{OperationCalculate} - Выбрано умножение");
                    break;
                case 4: Console.WriteLine($"{OperationCalculate} - Выбрано деление");
                    break;
            }
        }

        public void NewCalcuRun()
        {
            Console.WriteLine("Произвести новый расчёт?\n1 - да\n2 - нет");
            bool trueInt = int.TryParse(Console.ReadLine(), out OperationRestart);
            while (!trueInt)
            {
                Console.WriteLine("Ошибка ввода. Вы ввели не число");
                Console.WriteLine("Произвести новый расчёт?\n1 - да\n2 - нет");
                trueInt = int.TryParse(Console.ReadLine(), out OperationRestart);
            }
            while (OperationRestart > 2 ^ OperationRestart < 1)
            {
                Console.WriteLine("Ошибка ввода. Неверный диапазон значений");
                Console.WriteLine("Произвести новый расчёт?\n1 - да\n2 - нет");
                trueInt = int.TryParse(Console.ReadLine(), out OperationRestart);
            }
            switch (OperationRestart)
            {
                case 1:
                    Console.WriteLine($"{OperationRestart} - Выбран новый расчет. Ожидайте перезапуска программы.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine($"{OperationRestart} - Выбран выходи из программы.");
                    break;
            }
        }
    }
}
