using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ArraySum
    {
        private void CalculateSum(int[] arr,int size, out long evenSum, out long oddSum)
        {
            evenSum = 0;
            oddSum = 0;
            for(int i=0; i<size; i++)
            {
                if (i % 2 == 0)
                    evenSum += arr[i];
                else
                    oddSum += arr[i];
            }

        }

        public void swap(ref long evensum, ref long oddsum)
        {
            long tempSum = evensum;
            evensum = oddsum;
            oddsum = tempSum;
        }
        
       /* public static void Main(string[] args)
        {
            long evenSum;
            long oddSum;
            int size;


            size = Int32.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for(int i=0; i<size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            ArraySum ob1 = new ArraySum();
            ob1.CalculateSum(arr, size, out  evenSum, out  oddSum);
            Console.WriteLine("Before Swapping : \n");
            Console.WriteLine($"EVEN SUM : {evenSum} || ODD SUM : {oddSum}\n");
            ob1.swap(ref evenSum, ref oddSum);
            Console.WriteLine("After Swapping : \n");
            Console.WriteLine($"EVEN SUM : {evenSum} || ODD SUM : {oddSum}");
        }*/
    }
}
