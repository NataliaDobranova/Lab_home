using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            float[] A = new float[5];
            Console.WriteLine("Введите 5 элементов массива:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write((i + 1) + ":");
                A[i] = float.Parse(Console.ReadLine());

            }
            float max = A.Max();
            float min = A.Min();
            float sum = 0;
            float sum_even = 0;
            float pr = 1;
            foreach (float el in A)
            {
                Console.Write(el + "  ");
                sum += el;
                pr *= el;
                if (el % 2 == 0) sum_even += el;
            }
            Console.WriteLine();

            float[,] B = new float[3, 4];
            float s_odd = 0;
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = (float)Convert.ToDouble(random.Next(-100, 100) / 10.0);
                    Console.Write(B[i, j] + " ");
                    if (B[i, j] > max) max = B[i, j];
                    if (B[i, j] < min) min = B[i, j];
                    sum += B[i, j];
                    pr *= B[i, j];
                    if (j % 2 != 0) s_odd += B[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Sum evel elements A[] = " + sum_even);
            Console.WriteLine("Product = " + pr);
            Console.WriteLine("Sum in odd column = " + s_odd);

            // Task 2
            int M = 5;
            int N = 7;
            int[] One = new int[M];
            int[] Two = new int[N];
            int K;
            for (int i = 0; i < One.Length; i++)
            {
                One[i] = random.Next(0, 10);
                Console.Write(One[i] + "  ");
            }
            Console.WriteLine();

            for (int i = 0; i < Two.Length; i++)
            {
                Two[i] = random.Next(0, 10);
                Console.Write(Two[i] + "  ");
            }
            Console.WriteLine();

            if (M < N) K = N;
            else K = M;
            int[] Three = new int[K];
            int index = 0;
            int k = 0;
            while (k < Two.Length)
            {
                for (int j = 0; j < One.Length; j++)
                {
                    int p = 0;
                    if (One[j] == Two[k])
                    {
                        for (int l = 0; l < K; l++)
                        {
                            if (One[j] == Three[l]) p++;
                        }

                        if (p == 0)
                        {
                            Three[index] = One[j];
                            Console.Write(Three[index] + "  ");
                            index++;
                        }



                    }

                }
                k++;
            }
            Console.WriteLine();


            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            bool palindrom = true;
            int c = str.Length;
            for (int i = (c - 1) / 2; i >= 0; i--)
            {
                if (str[i] != str[c - 1 - i])
                {
                    palindrom = false;
                    break;
                }
            }

            if (palindrom)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else Console.WriteLine("Строка не является палиндромом.");


            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            char[] text1 = text.ToCharArray();
            int h = 0;
            int count = 1;
            while (text1[h] != '.')
            {
                if (text1[h] == ' ') count++;
                h++;
            }
            Console.WriteLine("Число слов в строке равно " + count);


            int[,] L = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    L[i, j] = random.Next(-100, 100);
                    Console.Write(L[i, j] + " ");
                }
                Console.WriteLine();
            }
            int iMin = 0;
            int jMin = 0;
            int iMax = 0;
            int jMax = 0;
            int Min = L[0, 0];
            int Max = L[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (L[i, j] < Min)
                    {
                        Min = L[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    if (L[i, j] > Max)
                    {
                        Max = L[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
                int i1 = 0;
                int j1 = 0;
                int i2 = 0;
                int j2 = 0;

                if (iMin == iMax)
                {
                    i1 = i2 = iMin;
                    if (jMin < jMax)
                    {
                        j1 = jMin;
                        j2 = jMax;
                    }
                    else
                    {
                        j2 = jMin;
                        j1 = jMax;
                    }
                }
                else
                {
                    if (iMin < iMax)
                    {
                        i1 = iMin;
                        j1 = jMin;
                        i2 = iMax;
                        j2 = jMax;

                    }
                    else
                    {
                        i2 = iMin;
                        j2 = jMin;
                        i1 = iMax;
                        j1 = jMax;
                    }

                }

                int summa = 0;
                if (i1 == i2)
                {
                    for (int p = j1; p <= j2; p++)
                    summa += L[i1, p];
                }
                else
                {

                    for (int p = j1; p < 5; p++)
                    {
                        summa += L[i1, p];
                    }
                    for (int p = 0; p <= j2; p++)
                    {
                        summa += L[i2, p];
                    }
                    for (int p = i1+1; p < i2; p++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            summa += L[p, j];
                        }
                    }
                }

            Console.WriteLine(" Max = " + Max);
            Console.WriteLine(" Min = " + Min);
            Console.WriteLine(" Сумма между минимальным и максимальным элементами равна " + summa);
        }



    }
}
