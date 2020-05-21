using SyntraCalc.Models;
using System.Collections.Generic;

namespace SyntraCalc.Services
{
    public interface IGeometricShapesService
    {
        IList<GeometricShape> GetAllPossibleShapes();
    }
}