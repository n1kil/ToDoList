﻿using System;
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
using ToDoList.Models;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ToDoModel> _toDoData;
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void dgToDoApp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _toDoData = new BindingList<ToDoModel>()
            {
                new ToDoModel(){Text = "fgdgd", IsDone = true},
                new ToDoModel(){Text = "test"}
            };



            dgToDoApp.ItemsSource = _toDoData;
        }
    }
}
