using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            //bug for demo purposes
            return a * b;
        }

        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            if (value > 100)
            {
                //bug for demo
                throw new ArgumentOutOfRangeException("by");
            }

            return value / by;
        }
    }
}
