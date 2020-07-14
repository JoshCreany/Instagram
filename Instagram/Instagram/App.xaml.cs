using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinForms.Views;

using XamarinForms.Models;
using XamarinForms.ViewModels;

namespace Instagram
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InstagramViewPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts  
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps  
        }

        protected override void OnResume()
        {
            // Handle when your app resumes  
        }
    }
}