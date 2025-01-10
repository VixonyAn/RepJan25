using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public class GeometryDraw : IGeometryDraw
    {
        public void DrawCircle(int x, int y, int r)
        { // x,y coordinates for center point, r for radius
            throw new NotImplementedException();
        }

        public void DrawRectangle(int x, int y, int x1, int y1)
        { // x,y coordinates for start point, x1,y1 coordinates for end point, draw lines that intersect
            throw new NotImplementedException();
        }

        public int CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
