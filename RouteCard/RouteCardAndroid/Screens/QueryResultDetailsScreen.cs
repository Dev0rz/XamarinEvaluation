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

namespace RouteCardAndroid.Screens
{
	[Activity (Label = "QueryResultDetails", Icon="@drawable/icon", Theme="@android:style/Theme.Holo.Light")]			
	public class QueryResultDetailsScreen : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// get data from intent
			String type = Intent.GetStringExtra ("Type");
			String productType = Intent.GetStringExtra ("ProductType");
			String product = Intent.GetStringExtra ("Product");
			String plant = Intent.GetStringExtra ("Plant");
			String facility = Intent.GetStringExtra ("Facility");
			String productionLevel = Intent.GetStringExtra ("ProductionLevel");
			String route = Intent.GetStringExtra ("Route");
			String version = Intent.GetStringExtra ("Version");
			String position = Intent.GetStringExtra ("Position");
			String operation = Intent.GetStringExtra ("OperationNumber");
			String operationText = Intent.GetStringExtra ("OperationText");
			String cTPlan = Intent.GetStringExtra ("CTPlan");
			String cTQ = Intent.GetStringExtra ("CTQ");
			String rPT = Intent.GetStringExtra ("RPT");

			// set layout
			SetContentView (Resource.Layout.QueryResultDetails);

			// fill views
			(FindViewById<TextView> (Resource.Id.textViewTypeValue)).Text = type;
			(FindViewById<TextView> (Resource.Id.textViewProductTypeValue)).Text = productType;
			(FindViewById<TextView> (Resource.Id.textViewProductValue)).Text = product;
			(FindViewById<TextView> (Resource.Id.textViewPlantValue)).Text = plant;
			(FindViewById<TextView> (Resource.Id.textViewFacilityValue)).Text = facility;
			(FindViewById<TextView> (Resource.Id.textViewProductionLevelValue)).Text = productionLevel;
			(FindViewById<TextView> (Resource.Id.textViewRouteValue)).Text = route;
			(FindViewById<TextView> (Resource.Id.textViewVersionValue)).Text = version;
			(FindViewById<TextView> (Resource.Id.textViewPositionValue)).Text = position;
			(FindViewById<TextView> (Resource.Id.textViewOperationNumberValue)).Text = operation;
			(FindViewById<TextView> (Resource.Id.textViewOperationTextValue)).Text = operationText;
			(FindViewById<TextView> (Resource.Id.textViewCTPlanValue)).Text = cTPlan;
			(FindViewById<TextView> (Resource.Id.textViewCTQValue)).Text = cTQ;
			(FindViewById<TextView> (Resource.Id.textViewRPTValue)).Text = rPT;
		}
	}
}

