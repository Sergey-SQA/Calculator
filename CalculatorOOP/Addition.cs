using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Addition: IOperation
    {
        public float Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
