using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SomeChildView.xaml
    /// </summary>
    public partial class SomeChildView : UserControl
    {
        public SomeChildView()
        {
            InitializeComponent();


            // If you cannot find a specific event for a specific property, you can use DependencyPropertyDescriptor to
            // create an event on that specific property.
            DependencyPropertyDescriptor dpd =
                DependencyPropertyDescriptor.FromProperty(Button.IsFocusedProperty, typeof(Button));

            dpd.AddValueChanged(saveButton, (sender, args) =>
            {
                if (!saveButton.IsFocused)
                {
                    MessageBox.Show("Save button lost focus.");
                }
            });


        }
        

        public static readonly RoutedEvent DataIsDirtyChangedEvent = EventManager.RegisterRoutedEvent("DataIsChanged",
            RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<bool>), typeof(SomeChildView));

        public event RoutedPropertyChangedEventHandler<bool> DataIsChanged
        {
            add => AddHandler(DataIsDirtyChangedEvent, value);
            remove => RemoveHandler(DataIsDirtyChangedEvent, value);
        }


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            RoutedPropertyChangedEventArgs<bool> args = new RoutedPropertyChangedEventArgs<bool>(false, true, DataIsDirtyChangedEvent);
            RaiseEvent(args);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RoutedPropertyChangedEventArgs<bool> args = new RoutedPropertyChangedEventArgs<bool>(true, false, DataIsDirtyChangedEvent);
            RaiseEvent(args);

        }
    }
}
