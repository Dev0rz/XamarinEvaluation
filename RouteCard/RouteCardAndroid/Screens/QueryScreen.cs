﻿using System;
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
	[Activity (Label = "Route Card", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light")]			
	public class QueryScreen : Activity
	{
		static readonly int LOGIN_REQUEST = 1;

		Button scanButton;
		EditText lotNumberEditText;
		Button searchButton;

		public static AndroidApp App = null;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// init app context for simple storage
			AndroidApp.App.Init (ApplicationContext);

			// activate the action bar and display it in navigation mode
			RequestWindowFeature (WindowFeatures.ActionBar);

			// set layout
			SetContentView (Resource.Layout.Query);

			// find scan controls
			scanButton = FindViewById<Button> (Resource.Id.buttonScan);

			// set scan button click handler
			scanButton.Click += (sender, e) => {
				// create intent
				Intent scanIntent = new Intent (this, typeof(ScanScreen));
				// start activity
				StartActivity (scanIntent);
			};

			// find search controls
			lotNumberEditText = FindViewById<EditText> (Resource.Id.editTextSearchLotNumber);
			searchButton = FindViewById<Button> (Resource.Id.buttonSearch);

			// set search button click handler
			searchButton.Click += (sender, e) => {
				// search lot
				String lotNumber = lotNumberEditText.Text;
				Route r = AndroidApp.App.RouteManager.QueryRouteForLot (lotNumber);

				// if lot was found
				if (r != null) {
					// create intent
					Intent queryResultIntent = new Intent (this, typeof(QueryResultScreen));
					// insert data in intent
					queryResultIntent.PutExtra ("LotNumber", lotNumber);
					// start activity
					StartActivity (queryResultIntent);
				}
				else {
					// show toast
					Toast.MakeText (this, Resource.String.toast_lot_not_found, ToastLength.Long).Show ();
				}
			};

			// try to auto authenticate
			if (!AndroidApp.App.AccountManager.AutoAuthenticate ()) {
				// create intent
				Intent LoginIntent = new Intent (this, typeof(LoginScreen));
				// start activity
				StartActivityForResult (LoginIntent, LOGIN_REQUEST);
			}
		}

		protected override void OnStart ()
		{
			base.OnStart ();
		}

		protected override void OnResume ()
		{
			base.OnResume ();
		}

		protected void onActivityResult (int requestCode, Result resultCode, Intent data)
		{
			// check which request we're responding to
			if (requestCode == LOGIN_REQUEST) {
				// if login was canceled close activity
				if (resultCode == Result.Canceled) {
					Finish ();
				}
			}
		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.query_menu, menu);       
			return true;
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Resource.Id.menuItemLogOffUser:
				// clear credentials
				AndroidApp.App.AccountManager.ClearCredentials ();
				// close activity
				Finish ();
				return true;
			case Resource.Id.menuItemChangeUser:
				// create intent
				Intent LoginIntent = new Intent (this, typeof(LoginScreen));
				// start activity
				StartActivityForResult (LoginIntent, LOGIN_REQUEST);
				return true;
			case Resource.Id.menuItemAbout:
				// TODO: start about activity
				return true;
			default:
				return base.OnOptionsItemSelected (item);
			}
		}
	}
}

