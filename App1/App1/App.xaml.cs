using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{ 
        public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new App1.MainPage());

            MainPage = new NavigationPage(new MainPage()); 

            NavigationPage.SetHasBackButton(new MainPage(), true);
            NavigationPage.SetHasNavigationBar(new MainPage(), true);
            NavigationPage.SetBackButtonTitle(new MainPage(), "Badjoras");  
        }
        //async Task NavigateLater()
        //{
        //    bool clearBackstack = true;
        //    await Task.Delay(10000);
        //    await _navPage.PushAsync(new SecondPage(), true);

        //    NavigationPage.SetHasBackButton(_navPage, false);
        //    NavigationPage.SetHasNavigationBar(_navPage, false);
        //    NavigationPage.SetBackButtonTitle(_navPage, "Badjoras");
        //}
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
