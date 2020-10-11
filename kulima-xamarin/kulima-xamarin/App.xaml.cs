﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using kulima_xamarin.Services;
using kulima_xamarin.Views;

namespace kulima_xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
