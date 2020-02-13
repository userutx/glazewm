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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LarsWM.Bar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            // Temporary code for debugging purposes:

            //var people = new ObservableCollection<Person>();
            //// Populate people
            //DataContext = people;

            var numberButtons = Enumerable.Range(1, 30)
                .Select(r => new KeyValuePair<string, string>(r.ToString(), r.ToString()))
                .ToList();

            numberButtonItems.ItemsSource = numberButtons;
        }
    }
}