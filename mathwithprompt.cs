using System;

namespace mathwithprompt
{
    class program
    {
        static void Main(string[] args)
        {
            double pi = 3.142;
            Console.Write("Input your radius : ");
            double radius = double.Parse(Console.ReadLine());
            double area = pi*radius*radius;
            Console.WriteLine("The area of a circle with radius"+radius+"is"+area);
            Console.WriteLine("Hit any key to escape...");
            Cosole.ReadKey();
        }
    }
}
