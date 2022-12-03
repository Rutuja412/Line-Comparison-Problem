using System;

namespace UC_3LineComp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, p1, p2, q1, q2;
            double lengthofLine;
            double lengthofLine1, lengthofLine2;
            Console.WriteLine("Enter values of x1,y1 and x2,y2 on Line 1: ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter values of p1,q1 and p2,q2 on Line2:");
            p1 = double.Parse(Console.ReadLine());
            p2 = double.Parse(Console.ReadLine());
            q1 = double.Parse(Console.ReadLine());
            q2 = double.Parse(Console.ReadLine());

            lengthofLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line 1 =" + lengthofLine1);

            lengthofLine2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            Console.WriteLine("Length of Line 2:" + lengthofLine2);

            if (lengthofLine1 == lengthofLine2)
            {
                Console.WriteLine("Two Lines are equal");
            }
            else if(lengthofLine1>lengthofLine2)
            {
                Console.WriteLine("First length is greater");
            }
            else
            {
                Console.WriteLine("Two Lines are not equal");
            }
        }
    }
}
