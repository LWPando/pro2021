using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] arr = { 6.5, 24.5, 80.5, 4, 19, 84, 1, 10, 13, 7 };  //DOUBLE SORT
            //int n = 10, i;
            //Console.WriteLine("Quick Sort");
            //Console.Write("Zacetna tabela: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //quickSort(arr, 0, 9);
            //Console.Write("\nSorted Array is: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            string[] arr = { "Jabka", "Banana", "Ribez", "Grozdje" };  //STRING SORT
            quicksort(arr, 0, arr.Length - 1);
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.ReadKey();
        }

        static int partition(string[] arr, int start, int end)  //STRING SORT
        {
            int pivot = end;
            int i = start, j = end;
            string temp;
            while (i < j)
            {
                while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
                    i++;
                while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
                    j--;

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            return j;
        }

        static void quicksort(string[] arr, int start, int end) //STRING SORT
        {
            if (start < end)
            {
                int pivotIndex = partition(arr, start, end);
                quicksort(arr, start, pivotIndex - 1);
                quicksort(arr, pivotIndex + 1, end);
            }
        }

        //static public int Partition(double[] arr, int left, int right) //DOUBLE SORT
        //{
        //    double pivot;
        //    pivot = arr[left];
        //    while (true)
        //    {
        //        while (arr[left] < pivot)
        //        {
        //            left++;
        //        }
        //        while (arr[right] > pivot)
        //        {
        //            right--;
        //        }
        //        if (left < right)
        //        {
        //            double temp = arr[right];
        //            arr[right] = arr[left];
        //            arr[left] = temp;
        //        }
        //        else
        //        {
        //            return right;
        //        }
        //    }
        //}
        //static public void quickSort(double[] arr, int left, int right) //DOUBLE SORT
        //{
        //    int pivot;
        //    if (left < right)
        //    {
        //        pivot = Partition(arr, left, right);
        //        if (pivot > 1)
        //        {
        //            quickSort(arr, left, pivot - 1);
        //        }
        //        if (pivot + 1 < right)
        //        {
        //            quickSort(arr, pivot + 1, right);
        //        }
        //    }
        //}
    }
}
