﻿namespace MauiApp21
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }
    }
}
