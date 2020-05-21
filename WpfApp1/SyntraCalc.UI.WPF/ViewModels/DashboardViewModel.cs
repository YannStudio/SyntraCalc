using GalaSoft.MvvmLight;
using SyntraCalc.Models;
using SyntraCalc.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SyntraCalc.UI.WPF.ViewModels
{
    public class DashboardViewModel:ViewModelBase
    {
        #region Fields        
        private readonly IGeometricShapesService _geometricShapesServices;
        private ObservableCollection<GeometricShape> _geometricShapes;
        private GeometricShape _selectedShape;
        private string _shapeControls;
        #endregion

        #region Properties
        public ObservableCollection<GeometricShape> GeometricShapes
        {
            get => _geometricShapes;
            set
            {
                _geometricShapes = value;
                RaisePropertyChanged();
            }
        }
        
        public GeometricShape SelectedShape
        {
            get => _selectedShape;
            set
            {
                _selectedShape = value;
                ShapeControls = $"ShapeControls/{_selectedShape.ShapeName}";
                RaisePropertyChanged();
            }
        }

        public string ShapeControls
        {
            get => _shapeControls;
            set
            {
                _shapeControls = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Constructors
        public DashboardViewModel(IGeometricShapesService geometricShapesService)
        {
            _geometricShapesServices = geometricShapesService;
            IList<GeometricShape> shapes = _geometricShapesServices.GetAllPossibleShapes();
            GeometricShapes = new ObservableCollection<GeometricShape>(shapes);
        }
        #endregion
    }
}
