using System;
namespace Math
{
    class program
    {
        static void Main(string[args])
        {
            double pi = 3.142;
            double radius = 3.5;
            double area = pi*radius*radius;

            Console.WriteLine("the area of a circle with radius :"+radius+"is"+area);
            Console.WriteLine("press any key to escape...");
            Console.ReadKey();
        }
    }
}

