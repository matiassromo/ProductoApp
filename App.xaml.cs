﻿namespace ProductoAppMovil2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductoPage());
            //MainPage = new EditatProductoPage();
        }
    }
}