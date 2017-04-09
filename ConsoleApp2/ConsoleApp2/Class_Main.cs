using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   static class Class_Main
    {
        static public void Input(ref int[] arr, int l)
        {
            for (int i = 0; i < l; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
        }
    }
}
