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
using RouteCard;

namespace RouteCardAndroid.Screens
{
	[Activity (Label = "Route Card", Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light")]			
	public class LoginScreen : Activity
	{
		EditText usernameEditText;
		EditText passwordEditText;
		Button loginButton;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set layout
			SetContentView (Resource.Layout.Login);

			// find our controls
			usernameEditText = FindViewById<EditText> (Resource.Id.editTextUsername);
			passwordEditText = FindViewById<EditText> (Resource.Id.editTextPassword);
			loginButton = FindViewById<Button> (Resource.Id.buttonLogin);

			// set click handler
			loginButton.Click += (sender, e) => {
				// get user credentials
				String username = usernameEditText.Text;
				String password = passwordEditText.Text;
				bool IsAuthorized = false;

				try {
					IsAuthorized = AndroidApp.App.AccountManager.Authenticate (username, password);
				} catch (AuthorizationException ex) {
					Toast.MakeText (this, ex.Message, ToastLength.Long).Show ();
					return;
				}

				// if user is authenticated
				if (IsAuthorized) {
					// close activity with Ok result
					SetResult (Result.Ok);
					Finish ();
				} else {
					// show toast
					Toast.MakeText (this, Resource.String.toast_login_invalid, ToastLength.Long).Show ();
				}
			};
		}

		protected override void OnStart ()
		{
			base.OnStart ();
		}

		protected override void OnResume ()
		{
			base.OnResume ();
		}
	}
}

