using System;

namespace Assignment1
{
    class Program
    {
        int even_sum;
        int odd_sum;
        public void Calculate_Sum(out int[] arr, int size)
        {

            arr = new int[20];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++){
                if(i%2 == 0)
                {
                    this.even_sum += arr[i];
                }
                else
                {
                    this.odd_sum += arr[i];
                }
            }
        }

        public void Swap(int even_sum,int odd_sum)
        {
            int temp = even_sum;
            this.even_sum = odd_sum;
            this.odd_sum = temp;


        }


/*        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            int[] arr;
            int size = Int32.Parse(Console.ReadLine());
            
            p.Calculate_Sum(out arr,size);
            Console.WriteLine($"Even sum : {p.even_sum}, Odd sum : {p.odd_sum}");
            p.Swap(p.even_sum, p.odd_sum);
            Console.WriteLine("After Swapped");
            Console.WriteLine($"Even sum : {p.even_sum}, Odd sum : {p.odd_sum}");
        }*/
    }
}
