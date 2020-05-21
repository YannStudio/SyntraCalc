using SyntraCalc.Models;
using System;
using System.Collections.Generic;

namespace SyntraCalc.Services
{
    public class GeometricShapesService : IGeometricShapesService
    {
        public IList<GeometricShape> GetAllPossibleShapes()
        {
            List<GeometricShape> shapes = new List<GeometricShape>();

            shapes.Add(new GeometricShape("Square", "In geometry, a square is a regular quadrilateral, which means that it has four equal sides and four equal angles (90-degree angles, or (100-gradian angles or right angles).[1] It can also be defined as a rectangle in which two adjacent sides have equal length."));
            shapes.Add(new GeometricShape("Triangle", "A triangle is a polygon with three edges and three vertices. It is one of the basic shapes in geometry."));
            shapes.Add(new GeometricShape("Circle", "A circle is a shape consisting of all points in a plane that are a given distance from a given point, the centre; equivalently it is the curve traced out by a point that moves in a plane so that its distance from a given point is constant. The distance between any point of the circle and the centre is called the radius."));

            return shapes;
        }

        public double CalculateCircumference(GeometricShape shape)
        {
            double result = 0;
            if (shape.ShapeName == "Circle")
            {
                result = Math.Round(2 * shape.Radius * Math.PI, 2);
                return result;
            }
            else
            {
                return result;
            }

        }

        public double CalculateSurface(GeometricShape shape)
        {
            double result = 0;
            if (shape.ShapeName == "Circle")
            {
                result = Math.Round(Math.PI * Math.Pow(shape.Radius, 2), 2); 
                return result;
            }
            else
            {
                return result;
            }
        }



    }
}
