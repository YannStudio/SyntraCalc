using SyntraCalc.Models;
using System;
using System.Collections.Generic;

namespace SyntraCalc.Services
{
    public class GeometricShapesService : IGeometricShapesService
    {
        // Constant variables

        string Circle = "Circle";
        string Square = "Square";
        string Triangle = "Triangle";

        // Method to get all possible shapes
        public IList<GeometricShape> GetAllPossibleShapes()
        {
            List<GeometricShape> shapes = new List<GeometricShape>();

            shapes.Add(new GeometricShape(Square, "In geometry, a square is a regular quadrilateral, which means that it has four equal sides and four equal angles (90-degree angles, or (100-gradian angles or right angles).[1] It can also be defined as a rectangle in which two adjacent sides have equal length."));
            shapes.Add(new GeometricShape(Triangle, "A right triangle (American English) or right-angled triangle (British English) is a triangle in which one angle is a right angle (that is, a 90-degree angle). The relation between the sides and angles of a right triangle is the basis for trigonometry."));
            shapes.Add(new GeometricShape(Circle, "A circle is a shape consisting of all points in a plane that are a given distance from a given point, the centre; equivalently it is the curve traced out by a point that moves in a plane so that its distance from a given point is constant. The distance between any point of the circle and the centre is called the radius."));

            return shapes;
        }

        // Methode to calculate shape circumference
        public double CalculateCircumference(GeometricShape shape)
        {
            double result = 0;
            if (shape.ShapeName == Circle)
            {
                result = Math.Round(2 * shape.Radius * Math.PI, 2);
                return result;
            }
            if (shape.ShapeName == Square)
            {
                result = 4 * shape.Length;
                return result;
            }
            if (shape.ShapeName == Triangle)
            {
                if (shape.Length != 0 && shape.Width != 0)
                {
                    result = Math.Round(shape.Length + shape.Width + shape.Height, 2);
                    return result;
                }                
            }


            return result;

        }

        // Method to calculate shape surface
        public double CalculateSurface(GeometricShape shape)
        {
            double result = 0;
            if (shape.ShapeName == Circle)
            {
                result = Math.Round(Math.PI * Math.Pow(shape.Radius, 2), 2);
                return result;
            }
            if (shape.ShapeName == Square)
            {
                result = Math.Pow(shape.Length, 2);
                return result;
            }
            if (shape.ShapeName == Triangle)
            {
                if (shape.Length != 0 && shape.Width != 0)
                {
                    result = Math.Round((shape.Length * shape.Width)/2, 2);
                    return result;
                }
                
            }

            return result;

        }

        // Method to  calculate 3th side of triangle

        public double CalculateSideTriangle(GeometricShape shape)
        {
            double result = 0;

            if (shape.ShapeName == Triangle)
            {
                if (shape.Length != 0 && shape.Width != 0 )
                {
                    result = Math.Round(Math.Sqrt((Math.Pow(shape.Length, 2) + Math.Pow(shape.Width, 2))), 2);
                }                
            }

            return result;
        }
        



    }
}
