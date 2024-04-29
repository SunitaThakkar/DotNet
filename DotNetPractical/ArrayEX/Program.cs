using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEX
{
    public class myarray
    {
        static void mymethod(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public  void ParamArray(params int[] num)
        {
            int total = 0;
            foreach (int number in num)
            {
                total += number;
            }
            Console.WriteLine(total);
        }
    
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 10, 12, 13, 14 };

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            mymethod(arr1);
            mymethod(arr2);
            myarray m = new myarray();
            m.ParamArray(10,20,30);

            for(int i = 0; i<3; i++)
            {
                for (int j =0; j<3; j++)
                {
                    Console.WriteLine(arr[i, j] + " ");
                }
            }
            Console.Read();

                
        }
     }
        
    
}
