﻿using System;

using PropertySample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PropertySample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }


    }
}
