using System;

namespace UC_1_Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {int x1,y1, x2, y2;
            double lengthofLine;
            x1 = 2;
            y1=3;
            x2 = 4;
            y2 = 5;
            lengthofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line ="+lengthofLine);
        }
    }
}
