using System;
using System.Windows.Controls;

namespace PhotonicsSuite.Controls
{
    public partial class ButtonWithInput : UserControl
    {
        private readonly SimpleTextBox _textBox;

        public ButtonWithInput(string buttonContent, Action<string> action, string defaultText)
        {
            InitializeComponent();
            var button = new SimpleButton(buttonContent, () => action(_textBox.TextBoxElement.Text));
            _textBox = new SimpleTextBox(defaultText);
            var stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(button);
            stackPanel.Children.Add(_textBox);
            Content = stackPanel;
        }
    }
}