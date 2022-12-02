using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    interface G1
    {

        void mymethod();
    }

    interface G2
    {

        void mymethod();
    }
    class Geeks : G1, G2
    {
        void G1.mymethod()
        {
            Console.WriteLine("1st interface");
        }

        void G2.mymethod()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }

    public class GFG
    {
        static public void Main()
        {
            G1 obj = new Geeks();
            obj.mymethod();
            G2 ob = new Geeks();
            ob.mymethod();
        }
    }
}
