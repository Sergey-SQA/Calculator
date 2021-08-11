using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Division : IOperation
    {
        public float Calculate(int a, int b)
        {
            return (float) a / b;
        }
    }
}
