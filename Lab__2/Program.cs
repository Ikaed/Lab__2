using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> shapeHit = new List<double>();
            List<double> shapeMiss = new List<double>();
            List<double> pointScore = new List<double>();

            Circle circle = new Circle();
            Square square = new Square();
            
            int x = 51, y = 1;

            var botX = 10;
            var botY = 3;
            var topX = 20;
            var topY = 25;
                var L = 4;
           
            var x1 = botX - (L / 2);
            var y1 = botY - (L / 2);
            var x2 = topX + (L / 2);
            var y2 = topY + (L / 2);
 

            int length = 50;
                int circleX = 0, circleY = 1;
                int rad = ((int)(length / (2 * Math.PI))); ;

                if (circle.HitCircle(circleX, circleY, rad, x, y))
                    Console.WriteLine("Inuti cirkel");
              
                else
                    Console.WriteLine("Utanför cirkel");

            // bottom-left and top-right
            // corners of rectangle
            //int x1 = 0, y1 = 0,
            //    x2 = 10, y2 = 8;

            // given point
            int SquareX = 1, SquareY = 5;

            // function call
            if (square.HitSquare(x1, y1, x2, y2, SquareX, SquareY))
            {
                Console.Write("Inuti fyrkant");
            }
            else {
                Console.Write("Utanför fyrkant");
                
            }
            //tA BORT???
        var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Square());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}

