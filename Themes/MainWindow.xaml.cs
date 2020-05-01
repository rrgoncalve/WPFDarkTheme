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
using Themes.ViewModels;

namespace Themes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App CurrentApp;
        public enum Theme
        {
            Dark, Light
        }
        public MainWindow(App currApp)
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel(this);
            DataContext = mainViewModel;
            CurrentApp = currApp;
            SetTheme(Theme.Dark);
        }

        public void SetTheme(Theme theme)
        {
            if (CurrentApp != null)
                CurrentApp.SetTheme(theme);
        }
    }
}
