using System.Windows;
using System.Windows.Controls;

namespace BindingTest.Control
{
    public partial class CheckboxControl : UserControl
    {
        public bool Checked
        {
            get { return (bool)GetValue(CheckboxProperty); }
            set
            {
                SetValue(CheckboxProperty, value);
                _CheckBox.IsChecked = value;
            }
        }

        public static readonly DependencyProperty CheckboxProperty = DependencyProperty.Register(
            "Checked",
            typeof(bool),
            typeof(CheckboxControl),
            new PropertyMetadata(new PropertyChangedCallback(CheckboxControl.StateChanged)));

        private static void StateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as CheckboxControl).Checked = (bool)e.NewValue;
        }

        public CheckboxControl()
        {
            InitializeComponent();
        }

        private void _CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Checked = (bool)(sender as CheckBox).IsChecked;
        }

        private void _CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Checked = (bool)(sender as CheckBox).IsChecked;
        }
    }
}
