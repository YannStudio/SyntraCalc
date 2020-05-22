using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraCalc.Models
{
    public class GeometricShape
    {
        public string ShapeName { get; set; }
        public string Description { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set;}
        public double Radius { get; set; }
        public double Circumference { get; set; }
        public double Surface { get; set; }

        public GeometricShape()
        {

        }

        public GeometricShape(string shapeName, string description)
        {
            ShapeName = shapeName;
            Description = description;
        }   

    }
}
