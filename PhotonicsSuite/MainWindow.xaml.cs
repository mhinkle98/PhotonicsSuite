using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhotonicsSuite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            var setPowerButton = new PhotonicsSuite.Controls.SimpleButton(
                "Set Power", () => MessageBox.Show("Set Power"));
            ((StackPanel)FindName("ControlsPanel"))?.Children.Add(setPowerButton);

            var setWavelengthButton = new PhotonicsSuite.Controls.ButtonWithInput(
                "Set Wavelength", wavelength => MessageBox.Show($"Wavelength: {wavelength}"), "1550");
            ((StackPanel)FindName("ControlsPanel"))?.Children.Add(setWavelengthButton);
        }
    }
}