using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;

namespace Lesson
{
    // Модификаторы доступа public и private, для членов класса

   /* enum Color
    {
        Red, 
        Green, 
        Blue, 
        Magenta, 
        Orange, 
        Yellow
    }*/
    class Point
    {
        int z = 3;
        public int x = 1; 
        private int y = 44;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }

        public void PrintZ()
        {
            Console.WriteLine($"Z: {z}");
        }

        public void PrintPoint()
        { 
            PrintX();
            PrintY();
            PrintZ();
        }
        //public Color color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            point.PrintZ();

            var typeInfo = typeof(Point).
                GetFields(BindingFlags.Instance | 
                BindingFlags.NonPublic | 
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }

            /*p.x = 4;
            p.y = 2;

            p.color = Color.Magenta;

            Console.WriteLine($"X: {p.x} | Y: {p.y} | Color: {p.color}");*/
        }
    }
}