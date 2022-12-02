using System;
using System.Collections.Generic;
using System.Text;

namespace Practy
{
    class Base
    {
        private string Text;

        public Base()
        {
            Text = "Intialised with no value";
        }

        public Base(string Text)
        {
            this.Text = $"Initialised with value {Text}";
        }


        public double Divide(double a,double b)
        {
            double res;
            if (b == 0)
                throw new DivideByZeroException("Divide by zero is not permissible");

            return a/b;
        }
    }
}
