using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC27
{
    public class MargeSorts
    {
        public static int[] MargeSorting(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                for (int i = mid; i < n; i++)
                {
                    right[i - mid] = arr[i];
                }
                MargeSorting(left);
                MargeSorting(right);
                Marge(left, right, arr);

            }
            return arr;
        }
        public static int[] Marge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }

            return arr;
        }

    }
}