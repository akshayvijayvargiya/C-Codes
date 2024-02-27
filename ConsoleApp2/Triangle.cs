using System;
namespace ConsoleApp2
{
	public class Triangle
	{
		public Triangle()
		{
		}

        public static double calculateArea(int a, int b, int c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}

