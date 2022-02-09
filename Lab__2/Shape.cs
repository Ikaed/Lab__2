using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
//https://www.w3schools.com/cs/cs_polymorphism.php
namespace Lab2
{
   
    public class Circle : Shape  // Derived class (child) 
    {
        public bool HitCircle(int circleX, int circleY, int rad, int x, int y)
        {

            if ((x - circleX) * (x - circleX) +
                (y - circleY) * (y - circleY) <= rad * rad)

                return true;

            else
                return false;
        }
        public override void Draw()
        {
        ////    var length = 30;
        ////    double areaC = Math.Pow(length, 2) / (4 * Math.PI);
        ////    Console.WriteLine("test1");
        }
    }

    public class Square : Shape  // Derived class (child) 
    {
        public bool HitSquare(int x1, int y1, int x2,
            int y2, int SquareX, int SquareY)
        {
            if (SquareX > x1 && SquareX < x2 &&
                SquareY > y1 && SquareY < y2)
                return true;
            else
                return false;
        }
        //public override void Draw()
        //{
        //    var length = 30;
        //    double areaSQ = (length / 4) * (length / 4);
        //    Console.WriteLine("test2");
        //}
    }
 

    public class Shape // Base class (parent) 
    {
        //
        //public int Width { get; set; }
        //public int Height { get; set; }
        //public Position Position { get; set; }
        //public bool HitCircle(int circleX, int circleY, int rad, int x, int y)
        //{

        //    if ((x - circleX) * (x - circleX) +
        //        (y - circleY) * (y - circleY) <= rad * rad)

        //        return true;

        //    else
        //        return false;
        //}

        //    public bool HitSquare(int x1, int y1, int x2,
        //        int y2, int SquareX, int SquareY)
        //    {
        //        if (SquareX > x1 && SquareX < x2 &&
        //            SquareY > y1 && SquareY < y2)
        //            return true;
        //    else
        //    return false;
        //}


        //C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class,
        //and by using the override keyword for each derived class methods:
        public virtual void Draw()
            {

            }
        }
}