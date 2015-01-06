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
	[Activity (Label = "Route Card", Icon="@drawable/icon")]			
	public class QueryScreen : Activity
	{
		EditText lotNumberEditText;
		Button searchButton;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// set layout
			SetContentView(Resource.Layout.Query);

			// find our controls
			lotNumberEditText = FindViewById<EditText>(Resource.Id.editTextLotNumber);
			searchButton = FindViewById<Button>(Resource.Id.buttonSearch);

			// set click handler
			searchButton.Click += (sender, e) =>
			{
				// search lot
				String lotNumber = lotNumberEditText.Text;
				Route r = RouteManager.queryRouteForLot(lotNumber);

				// if lot was found
				if (r != null) {
					// create intent
					Intent queryResultIntent = new Intent (this, typeof(QueryResultScreen));

					// insert data in intent
					queryResultIntent.PutExtra("LotNumber", lotNumber);

					// start activity
					StartActivity (queryResultIntent);
				}
				else {
					// show toast
					Toast.MakeText (this, Resource.String.toast_lot_not_found, ToastLength.Long).Show();
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

