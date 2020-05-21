using SyntraCalc.Models;

namespace SyntraCalc.UI.WPF.Messages
{
    public class SelectedShapeInformationMessage
    {
        public GeometricShape ShapeInfo { get; set; }
        public SelectedShapeInformationMessage(GeometricShape shapeInfo)
        {
            ShapeInfo = shapeInfo;
        }

    }
}
