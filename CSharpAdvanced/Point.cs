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

        // Equals Override
        public override bool Equals(object? obj)
        {
            if (obj is Point p)
            {
                return this == p;
            }
            return false;
        }

        // Equals Override
        public override string ToString()
        {
            return $"XCoord = {this.XCoord}, YCoord = {this.YCoord}";
        }

        // GetHashCode Override
        public override int GetHashCode()
        {
            // Manual calculation for custom hash code
            //var hashCode = 17;
            //hashCode = hashCode * 23 + XCoord.GetHashCode();
            //hashCode = hashCode * 23 + YCoord.GetHashCode();
            //return hashCode;

            // Or built-in method for automatic hash code generation
            return HashCode.Combine(this.XCoord, this.YCoord);
        }
    }
}
