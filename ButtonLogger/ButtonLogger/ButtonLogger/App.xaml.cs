﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonLogger
{
    public partial class App : Application
    {
        public App()
        {
            //MainPage = new ButtonLoggerPage();
            MainPage = new TwoButtonsPage();
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
