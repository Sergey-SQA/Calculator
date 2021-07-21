using System;
using System.Threading;

namespace Calculator
{
    class CalcuCount
    { 
        private float Result;

        CalcuHome HomePage;

        public CalcuCount(CalcuHome homeObject)
        {
            this.HomePage = homeObject;
        }


        public void Calculate()
        {
            Console.WriteLine("Подождите, идёт расчет...");
            
            Thread.Sleep(1000);

            switch (HomePage.GetOperation())
            {
                case 1: 
                    Result = HomePage.GetFirstInt() + HomePage.GetSecondInt();
                    break;
                case 2: 
                    Result = HomePage.GetFirstInt() - HomePage.GetSecondInt();
                    break;
                case 3:
                    Result = HomePage.GetFirstInt() * HomePage.GetSecondInt();
                    break;
                case 4:
                    Result = (float) HomePage.GetFirstInt() / HomePage.GetSecondInt();
                    break;
            }
        }

        public void ShowResult()
        {
            Console.WriteLine($"Результат расчета: {Result}");
        }

    }
}
