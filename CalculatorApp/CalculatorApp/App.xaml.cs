﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new CalcMainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

