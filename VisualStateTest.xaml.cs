﻿using System;
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
    /// Interaction logic for VisualStateTest.xaml
    /// </summary>
    public partial class VisualStateTest : Window
    {
        public VisualStateTest()
        {
            InitializeComponent();
        }





        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(VisualStateTest), new PropertyMetadata(false));



        public void ToggleToolbar()
        {
            this.IsOpen = !this.IsOpen;
        }


    }
}
