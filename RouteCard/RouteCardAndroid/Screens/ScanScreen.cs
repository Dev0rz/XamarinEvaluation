using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Scandit;

namespace RouteCardAndroid.Screens
{
	[Activity (Label = "Route Scanner", Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo")]
	public class ScanScreen : Activity, Scandit.Interfaces.IScanditSDKListener
	{
		private ScanditSDKBarcodePicker picker;
		public static string appKey = "1z72juMXTN+xUthUDoMR0JHZo9ISjQQESqF+/nzCzWA";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Setup the barcode scanner
			picker = new ScanditSDKBarcodePicker (this, appKey);
			picker.OverlayView.AddListener (this);

			// Start scanning
			picker.StartScanning ();

			// Show scan user interface
			SetContentView (picker);
		}

		public void DidScanBarcode (string barcode, string symbology)
		{
			Console.WriteLine ("barcode(" + symbology + ") scanned: " + barcode);

			if (barcode.Length < 12) {
				// show toast
				Toast.MakeText (this, "No valid barcode", ToastLength.Long).Show ();
				return;
			}

			string code = barcode.Substring (0, 12);

			if (code.Equals("123456789012")) {
				// create intent
				Intent queryResultIntent = new Intent (this, typeof(QueryResultScreen));
				// insert data in intent
				queryResultIntent.PutExtra ("LotNumber", "B124506R");
				// start activity
				StartActivity (queryResultIntent);
			}
			else if (code.Equals("111222333444")) {
				// create intent
				Intent queryResultIntent = new Intent (this, typeof(QueryResultScreen));
				// insert data in intent
				queryResultIntent.PutExtra ("LotNumber", "B124711B");
				// start activity
				StartActivity (queryResultIntent);
			}
			else {
				// show toast
				Toast.MakeText (this, Resource.String.toast_lot_not_found, ToastLength.Long).Show ();
			}
		}

		public void DidCancel ()
		{

		}

		public void DidManualSearch (string text)
		{

		}
	}
}

