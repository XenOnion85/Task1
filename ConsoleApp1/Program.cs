using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            #region 1
            //int c;
            //z1 number = new z1();
            //Console.WriteLine("Введите 4 переменных a,b,z,x: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int z = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            //c = number.Viraj(a,b,z,x);
            //Console.WriteLine("Значение выражения: {0}", c);
            #endregion
            #region 2
            //int B;
            //z1 par = new z1();
            //Console.WriteLine("Введите свой логин:");
            //string A = Console.ReadLine();
            //B = par.Login(A);
            #endregion
            #region 3
            //double Y;
            //z1 ad = new z1();
            //Console.WriteLine("Введите 2 переменные x,a:");
            //double xa = Convert.ToDouble(Console.ReadLine());
            //double aa = Convert.ToDouble(Console.ReadLine());
            //Y = ad.Adin(xa, aa);
            //Console.WriteLine("Значение выражения: {0}", Y);
            //double Z;
            //Z = ad.Bdin(0.5, 9.5, 1.5);
            //Console.WriteLine("Значение выражения с х=9,5 : {0}", Z);
            //Z = ad.Bdin(0.5, 1.5, 1.5);
            //Console.WriteLine("Значение выражения с х=1,5 : {0}", Z);
            #endregion
            #region 4
            int D;
            z1 den = new z1();
            Console.WriteLine("Введите день этого года: ");
            int K = Convert.ToInt32(Console.ReadLine());
            int N = 6;
            D = den.Den(K, N);
            Console.WriteLine("Введенный день недели: {0}", D)
            #endregion
        }
    }
}
