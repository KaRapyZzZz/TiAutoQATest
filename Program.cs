using System;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA = ParseInit("xA");
            double yA = ParseInit("yA");
            double xB = ParseInit("xB");
            double yB = ParseInit("yB");
            double xC = ParseInit("xC");
            double yC = ParseInit("yC");

            double AB = CalculateSideLenght(xA, xB, yA, yB);
            double BC = CalculateSideLenght(xB, xC, yB, yC);
            double CA = CalculateSideLenght(xC, xA, yC, yA);

            Console.WriteLine("\nLength of AB: " + AB);
            Console.WriteLine("Length of BC: " + BC);
            Console.WriteLine("Length of CA: " + CA);

            double perimeter = AB + BC + CA;
            Console.WriteLine("\nIs it equilateral triangle?: " + IsEquilateral(AB, BC, CA));
            Console.WriteLine("Is it isosceles triangle?: " + IsIsosceles(AB, BC, CA));
            Console.WriteLine("Is it right triangle?:" + IsRight(AB, BC, CA));
            Console.WriteLine("\nPerimeter: " + perimeter);

            Console.WriteLine("\nEven numbers from 0 to value of triangle perimeter");
            for (int i = 0; i < perimeter; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static bool IsRight(double AB, double BC, double CA)
        {
            if (CalculatePifagor(AB, BC, CA) || CalculatePifagor(AB, CA, BC) || CalculatePifagor(CA, BC, AB))
            {
                return true;
            }
            return false;
        }

        static bool CalculatePifagor(double a, double b, double c)
        {
            if (Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) <= 0.001)
            {
                return true;
            }
            return false;
        }

        static bool IsIsosceles(double AB, double BC, double CA)
        {
            if (AB == BC || BC == CA || CA == AB)
            {
                return true;
            }
            return false;
        }

        static double CalculateSideLenght(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(y2 - y1, 2));
        }

        static bool IsEquilateral(double AB, double BC, double CA)
        {
            if (AB == BC && BC == CA && AB == CA)
            {
                return true;
            }
            return false;
        }

        static double ParseInit(string varPoint)
        {
            Console.WriteLine("Enter the " + varPoint);
            while (true)
            {
                string _value = Console.ReadLine();
                if (Double.TryParse(_value, out double value))
                {
                    return value;
                }
            }
        }
    }
}
