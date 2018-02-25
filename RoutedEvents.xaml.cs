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
using System.Windows.Shapes;

namespace WpfPractices
{
    /// <summary>
    /// Interaction logic for RoutedEvents.xaml
    /// </summary>
    public partial class RoutedEvents : Window
    {
        public RoutedEvents()
        {
            InitializeComponent();
        }

        private void RoutedEvents_OnDataIsChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            if (e.NewValue)
            {
                this.Background = new SolidColorBrush(Colors.Yellow);
            }
            else
            {
                this.Background = new SolidColorBrush(Colors.White);
            }
            
        }
    }
}
