using System;

namespace LinearSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] a = new int[10];
            Int32 Largest, PosLargest, Temp;

            Console.WriteLine("====================Enter 10 values====================");

            for( int x=0; x<10; x++)
            {
                a[x] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("====================Sorted List=======================");

            for (int k=0; k<10; k++)
            {
                Largest = a[k];
                PosLargest = k;

                for (int i=k+1; i<10; i++)
                {
                    if (a[i] > Largest)
                    {
                        Largest = a[i];
                        PosLargest = i;
                    }
                }

                Temp = a[k];
                a[k] = a[PosLargest];
                a[PosLargest] = Temp;
            }

            for (int i=0; i<10; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
    }
}
