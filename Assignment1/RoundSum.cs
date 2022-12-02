using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class RoundSum
    {
        public int[] calculateColSum(int[,] arr, int row,int col)
        {
            int[] arr_sum = new int[col];
            Array.Clear(arr_sum, 0, arr_sum.Length);
            for(int i = 0; i < row; i++)
            {
                for(int j=0; j< col; j++)
                {
                    arr_sum[j] += arr[i, j];
                }
            }

            return arr_sum;
        }

        public long findRoundSum(int[,] arr, int[] arr_sum, int row, int col)
        {
            long finalSum = 0;
            Console.Write("STEP 2 - ");
            for(int i=0; i<col; i++)
            {
                int n = (arr_sum[i] - 1) % col ;
                finalSum += arr[i%row,n];
                Console.Write($"{arr[i % row, n]} ");
            }
            return finalSum;
        }


        //public static void Main(string[] args)
        //{ 
        //    int row;
        //    int col;
        //    Console.Write("Enter No of Rows : ");
            
        //    row = Int32.Parse(Console.ReadLine());
        //    Console.Write("Enter No of Columns : ");
        //    col = Int32.Parse(Console.ReadLine());
        //    int[,] arr = new int[row, col];
            
        //    for(int i=0; i<row; i++)
        //    {
        //        Console.WriteLine($"Enter the Array {i + 1} Elemets : ");
        //        for (int j = 0; j< col; j++)
        //        {
        //            arr[i, j] = Int32.Parse(Console.ReadLine());
        //        }
        //    }

        //    RoundSum ob = new RoundSum();

        //    int[] arr_sum = ob.calculateColSum(arr, row, col);

        //    Console.Write("STEP 1 - ");
        //    Console.WriteLine("[{0}]", string.Join(", ", arr_sum));
        //    long finalSum = ob.findRoundSum(arr, arr_sum, row, col);
        //    Console.WriteLine($"\nSTEP 3 - {finalSum}");
        //}
    }
}
