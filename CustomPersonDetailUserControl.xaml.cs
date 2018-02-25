using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfPractices.Data;

namespace WpfPractices
{
    /// <summary>
    /// Interaction logic for CustomPersonDetailUserControl.xaml
    /// </summary>
    public partial class CustomPersonDetailUserControl : UserControl
    {
        public CustomPersonDetailUserControl()
        {
            InitializeComponent();


        }





        public Person SelectedPerson
        {
            get => (Person)GetValue(SelectedPersonProperty);
            set => SetValue(SelectedPersonProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectedPerson.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedPersonProperty =
            DependencyProperty.Register("SelectedPerson", typeof(Person), typeof(CustomPersonDetailUserControl));

        
    }
}
