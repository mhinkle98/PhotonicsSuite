using System.Windows.Controls;

namespace PhotonicsSuite.Controls
{
    public partial class SimpleTextBox : UserControl
    {
        public SimpleTextBox(string contentStart = "")
        {
            InitializeComponent();
            TextBoxElement.Text = contentStart;
        }
    }
}