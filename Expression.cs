using System;

namespace Calculator
{
    public class Expression

    {
        public int[] Array { get; }
        public string MathOperation { get; set; }

        public float Result { get; set; }

        public Expression()
        {
            Array = new int[2];
        }
    }
}
