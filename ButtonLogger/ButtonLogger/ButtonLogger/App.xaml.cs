using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonLogger
{
    public partial class App : Application
    {
        const string displayLabelText = "displayLabelText";

        public App()
        {
            if (Properties.ContainsKey(displayLabelText))
            {
                DisplayLabelText = (string)Properties[displayLabelText];
            }

            //MainPage = new ButtonLoggerPage();
            //MainPage = new TwoButtonsPage();
            //MainPage = new ButtonLambdasPage();
            //MainPage = new SimplestKeypadPage();
            MainPage = new PersistentKeypadPage();
        }

        public string DisplayLabelText { set; get; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            Properties[displayLabelText] = DisplayLabelText;
        }

        protected override void OnResume()
        {
        }
    }
}
