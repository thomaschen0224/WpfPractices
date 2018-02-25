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

namespace WpfPractices.UserControls
{
    /// <summary>
    /// Interaction logic for SpeedControl.xaml
    /// </summary>
    public partial class SpeedControl : UserControl
    {
        public SpeedControl()
        {
            InitializeComponent();
        }




        public string Speed
        {
            get => (string)GetValue(SpeedProperty);
            set => SetValue(SpeedProperty, value);
        }

        // Using a DependencyProperty as the backing store for Speed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpeedProperty =
            DependencyProperty.Register("Speed", typeof(string), typeof(SpeedControl),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, 
                    SpeedChanged, null, false, UpdateSourceTrigger.LostFocus));

        private static void SpeedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            var value = e.NewValue.ToString();
            ((SpeedControl) d).speedTextBox.Text = value;

        }


        private void speedTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (speedTextBox.IsFocused)
            {
                var value = speedTextBox.Text;
                Speed = value;
            }
            
        }



    }
}
