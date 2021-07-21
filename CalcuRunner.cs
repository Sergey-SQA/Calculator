using System;

namespace Calculator
{
    class CalcuRunner
    {
        static void Main(string[] args)
        {          
            CalcuHome HomePage = new CalcuHome();
            CalcuCount CalcuCount = new CalcuCount(HomePage);
            do
            {
                HomePage.InputFirstFigure();
                HomePage.InputSecondFigure();
                HomePage.InputOperation();
                CalcuCount.Calculate();
                CalcuCount.ShowResult();
                HomePage.NewCalcuRun();
            } while (HomePage.GetOperationRestart() == 1);        
        }
    }
}
