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

			// try to auto authenticate
			try {
				if (!app.AccountManager.AutoAuthenticate()) {
					Navigation.PushModalAsync (new LoginPage (app.AccountManager));
				}
			} catch (Exception ex) {
				// TODO Change to dialog
				Navigation.PushModalAsync (new LoginPage (app.AccountManager));
			}
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Entry e = this.Content.FindByName<Entry> ("RouteCardEntry");
			Navigation.PushModalAsync (new DetailPage ());
		}
	}
}

