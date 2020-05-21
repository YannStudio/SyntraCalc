using SyntraCalc.Models;
using System.Collections.Generic;

namespace SyntraCalc.Services
{
    public interface IGeometricShapesService
    {
        IList<GeometricShape> GetAllPossibleShapes();
        double CalculateCircumference(GeometricShape item);
        double CalculateSurface(GeometricShape shape);
    }
}