using System;
using System.Collections.Generic;
using System.Text;

namespace Practy
{
    class Class1 : Base
    {


        public double CalculateDivision(double a, double b)
        {

            try
            {
                double res = Divide(a, b);
                Console.WriteLine(res);
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
            return 0.0;
        }
        //public static void Main()
        //{
        //    Console.WriteLine("-----------------Welcome to Division AAA-----------------");
        //    Console.Write("Enter The value of a : "); double a = Double.Parse(Console.ReadLine());
        //    Console.Write("Enter the value of b : "); double b = Double.Parse(Console.ReadLine());

        //    Class1 obj = new Class1();

        //    try { obj.CalculateDivision(a, b); } catch(DivideByZeroException e) {
        //        Console.WriteLine("In  Class 1 Method");
        //        Console.WriteLine(e.Message);
        //    }

        //}


    }
}
