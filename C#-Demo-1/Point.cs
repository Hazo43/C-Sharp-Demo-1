using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Demo_1
{
    public class Point
    {
        // Video 7
        public Point( int x , int y)
        { 
            X = x;
            Y = y;

        }

        public int X {  get; set; }
        public int Y {  get; set; }

       // video 8
        public override string ToString()
        {
            return $"X={X}, Y={Y}";
        }

        public override bool Equals(object? obj)
        {
            Point point = (Point)obj;

            return this.X==point.X && this.Y==point.Y ;
        }
    }
}
