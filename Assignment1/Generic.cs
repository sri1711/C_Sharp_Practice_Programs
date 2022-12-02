using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Generic
    {
        /*static void Main(string[] args)
        {
            Data<string, int> ob = new Data<string, int>("Hello", 21);
            Console.WriteLine(ob.Compare(ob.data1, ob.data2));
        }*/
    }
    class Data<T, U>
    {
        public T data1;
        public U data2;
        public Data(T d1, U d2)
        {
            data1 = d1;
            data2 = d2;
        }

        public Boolean Compare(T d1, U d2)
        {
            if (d1!.GetType() == d2!.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
