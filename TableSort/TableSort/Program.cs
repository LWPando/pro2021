using System;

namespace TableSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int[] number = { 6, 24, 80, 4, 19, 84, 1, 10, 13, 7 }; //******BUBBLE SORT******
            //bool zastavica = true;
            //int temp;
            //int numLength = number.Length;

            ////sorting an array  
            //for (int i = 1; (i <= (numLength - 1)) && zastavica; i++)
            //{
            //    zastavica = false;
            //    for (int j = 0; j < (numLength - 1); j++)
            //    {
            //        if (number[j + 1] < number[j])
            //        {
            //            temp = number[j];
            //            number[j] = number[j + 1];
            //            number[j + 1] = temp;
            //            zastavica = true;
            //        }
            //    }
            //}

            ////Sorted array  
            //foreach (int num in number)
            //{
            //    Console.Write("\t {0}", num);
            //}
            //Console.Read();

            //  int[] a = { 6, 24, 80, 4, 19, 84, 1, 10, 13, 7 }; //******** SELECTION SORT******
            //Console.WriteLine("Neurejena");
            //Izpis(a);
            //Izbiranje(a);
            //Console.WriteLine("Urejena");
            //Izpis(a);
            //Console.ReadLine();
            int[] arr = new int[10] { 6, 24, 80, 4, 19, 84, 1, 10, 13, 7 }; //******* INSERTION SORT*******
            int n = 10, i, j, val, flag;
            Console.WriteLine("Urejanje z vstavljanjem");
            Console.Write("Neurejena tabela: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nUrejena tabela: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        //  static void Izbiranje(int[] a) //***** SELECTION SORT*******
        //{
        //    for(int k = 0; k < a.Length; k++)
        //    {
        //        int min = a[k];
        //        int minIndeks = k;
        //        for(int j = k; j < a.Length; j++)
        //        {
        //            if(a[j] < min)
        //            {
        //                min = a[j];
        //                minIndeks = j;
        //            }
        //        }
        //        int temp = a[k];
        //        a[k] = a[minIndeks];
        //        a[minIndeks] = temp;
        //        Izpis(a);
        //    }
        //}
        //static void Izpis(int[] a)
        //{
        //    for(int k =0; k<a.Length; k++)
        //    {
        //        Console.Write(a[k] + "\t");
        //    }
        //    Console.WriteLine();
        //}
    }
}
