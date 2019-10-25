using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1

            int Tf = 120;
            Console.WriteLine("Температура по Фаренгейту: " + Tf);
            float Tc = ((float)Tf - 32) * 5 / 9;
            Console.WriteLine("Температура по Цельсию: " + Tc);

       // Task 2
     
            int x1 = 1;
            int y1 = 1;
            int x2 = 2;
            int y2 = 5;
            int x3 = 5;
            int y3 = 3;
            double a = (double)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = (double)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = (double)Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
           
            double p = a + b + c;
            Console.WriteLine("Периметр Р = " + (float)p);
            double p1 = p / 2;
            double S = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
            Console.WriteLine("Площадь S = " + S);

            // Task 3

            int number = 999;
            Console.WriteLine("Число: " + number);
            string[] string1 = { " ", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] string2 = { " ", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восеьдесят", "девяносто" };
            string[] string3 = { " ", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восеь", "девять" };
            Console.WriteLine("Число словами: ");
            int f1 = number / 100;
            Console.Write(string1[f1] + " ");
            int f2 = (number / 10) % 10;
            Console.Write(string2[f2] + " ");
            int f3 = number%10;
            Console.WriteLine(string3[f3] + " ");

            // Task 4
            Console.WriteLine("Введите А:");
            var A = Console.ReadLine();
            int a1 = Convert.ToInt32(A);
            Console.WriteLine("Введите B:");
            var B = Console.ReadLine();
            int b1 = Convert.ToInt32(B);
            Console.WriteLine("Введите С:");
            var C = Console.ReadLine();
            int c1 = Convert.ToInt32(C);
            int s = a1 * b1;
            if (c1 <= a1 && c1 <= b1)
            { int k = 0;
                while ( a1 >= c1)
                {
                    a1 -= c1;
                    k++;
                }
                int l = 0;
                while (b1 >= c1)
                {
                    b1 -= c1;
                    l++;
                }
                int m = k * l;
                Console.WriteLine("Количество квадратов = " + m);
                Console.WriteLine("Незанятая площадь = " + (s - m * Math.Pow(c1,2)));
            } else
            {
                Console.WriteLine("В прямоугольнике нельзя разместить ни одного квадрата со стороной С");
            }
            // Task 5
            float vklad = 1000;
            float P = 15.5f;
            int K = 0;
            while (vklad <= 1100)
            {
                vklad = vklad + vklad * (P / 100);
                K++;
            }
            Console.WriteLine("Размер вклада равен: " + vklad);
            Console.WriteLine("Количество месяцев = " + K);



        }
    }
}
