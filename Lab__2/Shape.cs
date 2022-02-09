using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Lab2
{
   
    public class Circle : Shape
    {
    
        public override void Draw()
        {
            var length = 30;
            double areaC = Math.Pow(length, 2) / (4 * Math.PI);
       
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            var length = 30;
            double areaSQ = (length / 4) * (length / 4);
           
        }
    }
 

    public class Shape
    {
        //
        //public int Width { get; set; }
        //public int Height { get; set; }
        //public Position Position { get; set; }
        public bool HitCircle(int circleX, int circleY, int rad, int x, int y)
        {
          
            if ((x - circleX) * (x - circleX) +
                (y - circleY) * (y - circleY) <= rad * rad)
          
                return true;
            
            else
                return false;
        }

        public bool HitSquare(int x1, int y1, int x2,
            int y2, int SquareX, int SquareY)
        {
            if (SquareX > x1 && SquareX < x2 &&
                SquareY > y1 && SquareY < y2)
                return true;
        else
        return false;
    }



            public virtual void Draw()
            {

            }
        }
}