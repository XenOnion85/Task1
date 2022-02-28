using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class z1
    {
        public int Viraj (int a, int b, int z, int x)
        {
            int c;
            c = ((b+z)*(a-b))/x;
            return c;
        }
        public int Login (string A)
        {
            int B;
            if (A == "Админ")
            {
                Console.WriteLine("Введите пароль:");
                B = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Я вас не знаю");
                B = 0;
            }
            return B;
        }
        public double Adin(double x, double a)
        {
            double Y;
            double А = Math.Pow(x, 5);
            double Б = (x * Math.Atan(a + x) - Math.Sqrt(Math.Abs(x - a)));
            double В = Math.Log10(Math.Pow(Math.Abs(x) + 1, 2));
            Y =  А*Б + В;
            return Y;
        }
        public double Bdin (double a, double x, double b)
        {
            double F;
            F = Math.Sqrt(a * x * x + b * x) * Math.Exp(-a * x) + Math.Log10(Math.Abs(x) + 1);
            return F;
        }
        public int Den (int K, int N)
        {
            int D;
            D = ((K + N - 2) % 7) + 1;
            return D;
        }
    }
}
