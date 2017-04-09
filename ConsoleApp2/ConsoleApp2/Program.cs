using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
            {
                int[] arr;
                arr = new int[6];

            Class_Main.Input(ref arr,6);
         


            for (int i = 0; i < 6; i++)
            {
               
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }


        }
        }
}
