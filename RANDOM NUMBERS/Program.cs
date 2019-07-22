using System;
using static System.Console;
namespace RANDOM_NUMBERS
{
    class Program
    {
        static void Main()
        {
            int N, MAX=0, MIN=0, F,P=0;
            float T = 0;
            Write("\n Jumlah Bilangan = ");
            N = int.Parse(ReadLine());
            int[] A = new int[N];
            Random R = new Random();
            WriteLine(" Bilangan Random : ");

            for (int X = 0; X < N; X++)
            {
                A[X] = R.Next(100, 1000);
                T += A[X];
                if (X==0) { MAX = A[0]; MIN = A[0]; }
                if (A[X] > MAX) MAX = A[X];
                if (A[X] < MIN) MIN = A[X];
                Write(" {0} ", A[X]);
            }
            WriteLine("\n Terbesar  = "+ MAX);
            WriteLine(" Terkecil = " + MIN);
            WriteLine("\n Total = " + T);
            Write(" Rata-Rata = {0:0.00}", T / N);

            Write("\n Cari Data = "); F = int.Parse(ReadLine());
            for (int X = 0; X < N; X++) if (F == A[X]) P = X + 1;
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Yellow;
            if (P > 0)
                WriteLine("\n {0} ada di posisi ke {1}", F, P);
            else
                WriteLine("\n {0} tidak ada...", F);
            ReadKey();
        }
    }
}
