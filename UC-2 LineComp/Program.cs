using System;

namespace UC_2_LineComp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int x1, y1, x2, y2;
                double lengthofLine;
                double lengthofLine1, lengthofLine2;
                x1 = 2;
                y1 = 3;
                x2 = 4;
                y2 = 5;
            Console
                lengthofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                Console.WriteLine("Length of line =" + lengthofLine);
                Console.WriteLine("Hello World!");
        }
    }
}
