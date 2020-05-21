using GalaSoft.MvvmLight;
using SyntraCalc.Models;
using SyntraCalc.Services;
using SyntraCalc.UI.WPF.Messages;

namespace SyntraCalc.UI.WPF.ViewModels
{
    public class ShapeControlViewModel:ViewModelBase
    {
        #region Fields
        private readonly IGeometricShapesService _geometricShapesServices;
        private double _radius;
        private double _length;
        private double _width;
        private double _circumference;
        private double _surface;
        private GeometricShape _selectedShape;
        #endregion

        #region Properties
        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                SelectedShape.Radius = Radius;
                Circumference = _geometricShapesServices.CalculateCircumference(SelectedShape);
                Surface = _geometricShapesServices.CalculateSurface(SelectedShape);
                RaisePropertyChanged();
            }
        }
        public double Length
        {
            get => _length;
            set
            {
                _length = value;
                RaisePropertyChanged();
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                _width = value;
                RaisePropertyChanged();
            }
        }

        public double Circumference
        {
            get => _circumference;
            set
            {
                _circumference = value;
                SelectedShape.Circumference = Circumference;
                RaisePropertyChanged();
            }
        }

        public double Surface
        {
            get => _surface;
            set 
            {
                _surface = value;
                SelectedShape.Surface = Surface;
                RaisePropertyChanged();            
            }
        }
        public GeometricShape SelectedShape
        {
            get => _selectedShape;
            set
            {
                _selectedShape = value;
                RaisePropertyChanged();
            }
        }
        #endregion  

        #region Constructors
        public ShapeControlViewModel(IGeometricShapesService geometricShapesService)
        {
            _geometricShapesServices = geometricShapesService;
            MessengerInstance.Register<SelectedShapeInformationMessage>(this, onEventDetailMessageReceived);

        }
        #endregion

        #region Methods
        private void onEventDetailMessageReceived(SelectedShapeInformationMessage message)
        {
            SelectedShape = message.ShapeInfo;
        }


        #endregion

    }
}
