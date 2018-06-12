using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            Console.WriteLine("Enter the Number elements to sort");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                values.Add(Convert.ToInt32(Console.ReadLine()));
                N--;
            }
            //quickSort(values, 0, (values.Count - 1));
            //mergeSort(values, 0, values.Count);
            //heapSort();
            //insertionSort(values, 0, values.Count);
            //selectionSort(values, 0, values.Count);
            //bubbleSort(values, 0, values.Count);
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public static void heapSort(List<int> elements, int p, int q)
        {

        }

        public static void mergeSort(List<int> elements, int p, int q)
        {
            if (q - p <= 1)
            {
                return;
            }
            int left_start = p;
            int left_end = (p + q) / 2;
            int right_start = left_end;
            int right_end = q;
            mergeSort(elements,left_start,left_end);
            mergeSort(elements,right_start,right_end);

            merge(elements, left_start, left_end, right_start, right_end);
        }

        public static void merge(List<int> elements, int left_start, int left_end, int right_start, int right_end)
        {
            int left_length = left_end - left_start;
            int right_length = right_end - right_start;

            int[] left_half = new int[left_length];
            int[] right_half = new int[right_length];

            int r = 0, l = 0, i = 0;

            for (i = left_start; i < left_end; i++)
            {
                left_half[l] = elements[i];
                l++;
            }

            for (i = right_start; i < right_end; i++)
            {
                right_half[r] = elements[i];
                r++;
            }

            for (i = left_start, l = 0, r = 0; l < left_length && r < right_length; i++)
            {
                if (left_half[l] > right_half[r])
                {
                    elements[i] = right_half[r];
                    r++;
                }
                else
                {
                    elements[i] = left_half[l];
                    l++;
                }
            }

            int st1, st2;
            for(st1 = l; st1 < left_length; st1++)
            {
                elements[i] = left_half[st1];
                i++;
            }
            for (st2 = r; st2 < right_length; st2++)
            {
                elements[i] = right_half[st2];
                i++;
            }
        }

        public static void selectionSort(List<int> elements, int p, int q)
        {
            int min = 0;
            for (int i = 0; i < q - 1; i++)
            {
                min = i;
                for (int j = i+1; j < q; j++)
                {
                    if (elements[j] < elements[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    swap(elements, i, min);
                }
            }
        }

        public static void bubbleSort(List<int> elements, int p, int q)
        {
            for (int i = 0; i < q -1 ; i++)
            {
                for (int j = i+1; j < q; j++)
                {
                    if (elements[i] > elements[j])
                    {
                        swap(elements, i, j);
                    }
                }
            }
        }

        public static void insertionSort(List<int> elements, int p, int q)
        {
            int key = 0;
            int j = 0;
            for (int i = 1; i < q; i++)
            {
                key = elements[i];
                j = i - 1;
                while (j >= 0 && elements[j] > key)
                {
                    elements[j+1] = elements[j];
                    j--;
                }
                elements[j + 1] = key;
            }
        }

        public static void quickSort(List<int> elements, int p, int q)
        {
            if (p < q)
            {
                int r = partition(elements, p, q);
                quickSort(elements, p, r);
                quickSort(elements, r + 1, q);
            }
        }

        public static int partition(List<int> elements, int p, int q)
        {
            int pivot = elements[p];
            while (true)
            {
                while (elements[p] < pivot)
                    p++;
                while (elements[q] > pivot)
                    q--;
                if (p < q)
                {
                    swap(elements, p, q);
                }
                else
                {
                    return q;
                }
            }
        }

        private static void swap(List<int> ar, int a, int b)
        {
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }
    }
}