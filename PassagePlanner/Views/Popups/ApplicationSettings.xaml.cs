﻿using MahApps.Metro.Controls;
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

using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace PassagePlanner
{
    /// <summary>
    /// Interaction logic for ApplicationSettings.xaml
    /// </summary>
    public partial class ApplicationSettings : MetroWindow
    {
        public ApplicationSettings()
        {
            InitializeComponent();
        }


        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
