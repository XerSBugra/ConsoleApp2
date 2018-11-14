using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[,] sloy1 = new double[2,9];
            double[] sloy2_ves = new double[9];
            double[] y1 = new double[9];
            double x1,b2;
            b2= rand.NextDouble() * (1 - (-1)) + (-1);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 9; j++)
                    sloy1[i, j] = rand.NextDouble() * (1 - (-1)) + (-1);
            for (int i = 0; i < 9; i++)
                sloy2_ves[i] = rand.NextDouble() * (1 - (-1)) + (-1);
            for (int z = 0; z < 5; z++)
            {
            Console.Write("Введите Х: ");
            x1 = Convert.ToDouble(Console.ReadLine());
                for (int j = 0; j < 9; j++)
                    y1[j] = 1 / (1 + Math.Pow(Math.E, -(x1 * sloy1[0, j] + sloy1[1, j])));
                double s = 0;
                for (int i = 0; i < 9; i++)
                    s += y1[i] * sloy2_ves[i];
                s = s + b2;
                if (s <= 0)
                    Console.WriteLine("S= {0}, S<=0 => y=0", s);
                else
                    Console.WriteLine("S= {0}, S>0 => y=1", s);
            }
            Console.WriteLine("Умножили веса на 10");
            for (int i = 0; i < 9; i++)
            {
                sloy1[0, i] *= 10;
                sloy2_ves[i]*= 10;
            }
            for (int z = 0; z < 5; z++)
            {
                Console.Write("Введите Х: ");
                x1 = Convert.ToDouble(Console.ReadLine());
                for (int j = 0; j < 9; j++)
                    y1[j] = 1 / (1 + Math.Pow(Math.E, -x1 * sloy1[0, j] + sloy1[1, j]));
                double s = 0;
                for (int i = 0; i < 9; i++)
                    s += y1[i] * sloy2_ves[i];
                s = s + b2;
                if (s <= 0)
                    Console.WriteLine("S= {0}, S<=0 => y=0", s);
                else
                    Console.WriteLine("S= {0}, S>0 => y=1", s);
            }
            Console.ReadKey();
        }
    }
}
