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
using Microsoft.Win32;
using Word_Kurlishuk.Context;

namespace Word_Kurlishuk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadRooms();
        }

        public void LoadRooms()
        {
            for (int i = 1; i < 20; i++)
                parent.Children.Add(new Elements.Room(i));
        }

        private void Report(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Files (*.docx)|*.docx";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
                OwnerContext.Report(saveFileDialog.FileName);
        }
    }
}
