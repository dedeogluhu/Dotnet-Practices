﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Horizontal

            };

            layout.Children.Add(new Label { Text = "Label 1" });

            Content = layout;
        }
    }
}