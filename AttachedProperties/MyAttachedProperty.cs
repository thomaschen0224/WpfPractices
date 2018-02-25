using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfPractices.AttachedProperties
{
    public static class MyAttachedProperty
    {




        public static string GetMyProperty(DependencyObject obj)
        {
            return (string)obj.GetValue(MyPropertyProperty);
        }

        public static void SetMyProperty(DependencyObject obj, string value)
        {
            obj.SetValue(MyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(string), typeof(MyAttachedProperty), 
                new FrameworkPropertyMetadata("default text", FrameworkPropertyMetadataOptions.Inherits));




    }
}
