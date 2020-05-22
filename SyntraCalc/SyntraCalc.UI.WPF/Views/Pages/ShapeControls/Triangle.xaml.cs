using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace SyntraCalc.UI.WPF.Views.Pages.ShapeControls
{
    /// <summary>
    /// Interaction logic for Triangle.xaml
    /// </summary>
    public partial class Triangle : Page
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void UiVerificationNumberTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var binding = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();

        }
    }
}
