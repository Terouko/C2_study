using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p_int = Convert.ToInt32(Console.ReadLine());
            p_int = 4*p_int*p_int + 3*p_int - 5;
            Console.WriteLine(p_int);
            var u = Convert.ToInt32(Music.Classik);
            for (int p = 0; p < 8; ++p)
            {
                Console.WriteLine(u);
                ++u;
            }
            Point A = new Point(5, 4, 3);
            Point B = new Point(5, 6, 3);
            line AB = new line(A, B);
            Console.WriteLine(AB.range());
    }
    }

    enum Music
    {
        Classik,
        Pop,
        Rock,
        Rap,
        House
    };

    struct Point
    {
        int x, y, z;

        public Point(int xx, int yy, int zz)
        {
            x = xx;
            y = yy;
            z = zz;
        }

        public static double operator -(Point A, Point B)
        {

            return Math.Pow(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2) + Math.Pow((B.z - A.z), 2), 0.5);
        }
    }

    struct line
    {
        Point a, b;

        public line(Point aa, Point bb)
        {
            a = aa;
            b = bb;
        }

        public double range()
        {
            return a - b;
        }
    }
}
