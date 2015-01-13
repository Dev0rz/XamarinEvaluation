using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Android.Widget;

namespace EDCParameters
{	
	public partial class MainPage : ContentPage
	{	
		public bool UserIsAuthorized = false;

		public MainPage (EDCParametersApp app)
		{
			InitializeComponent ();

			Navigation.PushModalAsync (new LoginPage (app.AccountManager));
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Entry e = this.Content.FindByName<Entry> ("RouteCardEntry");
			Navigation.PushModalAsync (new DetailPage ());
		}
	}
}

