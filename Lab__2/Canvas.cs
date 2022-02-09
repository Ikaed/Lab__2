using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Canvas
    {
      //tA BORT??
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}