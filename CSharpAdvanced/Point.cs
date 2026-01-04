using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    internal class Point
    {
        public double XCoord { get; }
        public double YCoord { get; }
        public Point(double xCoord, double yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
        }

        // Arithmetic Operators
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.XCoord + p2.XCoord, p1.YCoord + p2.YCoord);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.XCoord - p2.XCoord, p1.YCoord - p2.YCoord);
        }

        // Comparison Operators
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.XCoord == p2.XCoord && p1.YCoord == p2.YCoord;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            //return p1.XCoord != p2.XCoord || p1.YCoord != p2.YCoord;
            return !(p1 == p2);
        }

        // Conversion Operators
        // Implicit conversion from (double, double) to Point
        public static implicit operator Point((double xCoord, double yCoord) coords)
        {
            return new Point(coords.xCoord, coords.yCoord);
        }
        // Implicit conversion from Point to (double, double)
        public static implicit operator (double, double)(Point p)
        {
            return (p.XCoord, p.YCoord);
        }
        // Explicit conversion is similar. Replace 'implicit' with 'explicit' in the above methods.

        // ToString Override
        public override string ToString()
        {
            return $"XCoord = {this.XCoord}, YCoord = {this.YCoord}";
        }

        // Equals Override
        public override bool Equals(object? obj)
        {
            if (obj is Point p)     // same as: if (obj != null && obj.GetType() == typeof(Point))
            {
                //return this.XCoord == p.XCoord && this.YCoord == p.YCoord;
                return this == p;   // Reuse the == operator since it's already overloaded
            }
            return false;
        }

        // GetHashCode Override
        public override int GetHashCode()
        {
            if (this is null)
            {
                throw new NullReferenceException("Object is null");
            }

            // Manual calculation for custom hash code
            //var hashCode = 17;
            //hashCode = hashCode * 23 + XCoord.GetHashCode();
            //hashCode = hashCode * 23 + YCoord.GetHashCode();
            //return hashCode;

            // Or use built-in method for automatic hash code generation
            return HashCode.Combine(this.XCoord, this.YCoord);
        }
    }
}
