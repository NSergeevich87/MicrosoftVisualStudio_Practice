using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson
{
    enum Color
    {
        Red, 
        Green, 
        Blue, 
        Magenta, 
        Orange, 
        Yellow
    }
    class Point
    {
        public int x; 
        public int y;
        public Color color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p = new Point();
            p.x = 4;
            p.y = 2;

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 6;

            Console.WriteLine($"X: {p.x} | Y: {p.y}");*/

            Point p = new Point();

            p.x = 4;
            p.y = 2;

            p.color = Color.Magenta;

            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");
        }
    }
}