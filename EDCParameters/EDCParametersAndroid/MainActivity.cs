using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace EDCParametersAndroid
{
	[Activity (Label = "EDCParametersAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			Xamarin.Forms.Forms.Init(this, bundle);

			AndroidApp app = new AndroidApp ();
			app.Init (this);

			LoadApplication(app);
		}
	}
}


