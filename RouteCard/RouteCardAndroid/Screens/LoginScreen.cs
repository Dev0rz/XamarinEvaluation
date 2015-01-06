using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using RouteCard.Core;
using RouteCardAndroid;

namespace RouteCardAndroid.Screens
{
	[Activity (Label = "Route Card", MainLauncher = true, Icon="@drawable/icon")]			
	public class LoginScreen : Activity
	{
		EditText usernameEditText;
		EditText passwordEditText;
		Button loginButton;

		public static AndroidApp App = null;

		protected override void OnCreate(Bundle bundle)
		{
			App = new AndroidApp ();

			base.OnCreate(bundle);

			// set layout
			SetContentView(Resource.Layout.Login);

			// find our controls
			usernameEditText = FindViewById<EditText>(Resource.Id.editTextUsername);
			passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
			loginButton = FindViewById<Button>(Resource.Id.buttonLogin);

			// set click handler
			loginButton.Click += (sender, e) =>
			{
				// User credentials
				String username = usernameEditText.Text;
				String password = passwordEditText.Text;

				bool IsAuthorized = App.Authorize(username, password);

				// if user is authorized
				if (IsAuthorized) {
					// create intent
					Intent queryResultIntent = new Intent (this, typeof(QueryScreen));

					// start activity
					StartActivity (queryResultIntent);
				}
				else {
					// show toast
					Toast.MakeText (this, Resource.String.toast_login_invalid, ToastLength.Long).Show();
				}
			};
		}

		protected override void OnStart()
		{
			base.OnStart();

		}

		protected override void OnResume()
		{
			base.OnResume();
		}
	}
}

