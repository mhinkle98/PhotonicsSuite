using System;
using System.Windows;
using System.Windows.Controls;

namespace PhotonicsSuite.Controls
{
    public partial class SimpleButton : UserControl
    {
        private readonly Action _action;

        public SimpleButton(string content, Action action)
        {
            InitializeComponent();
            ButtonElement.Content = content ?? throw new ArgumentNullException(nameof(content));
            _action = action ?? throw new ArgumentNullException(nameof(action));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _action?.Invoke();
        }
    }
}