using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    internal class ArrayExample
    {
        public void RightRotataeArray(int []arr)
        {
            int n = 3;
            for (int i=0;i<n;i++)
            {
                int first = arr[0];
                int j;
                for (j=0;j<arr.Length-1;j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[j] = first; 
            }


            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
