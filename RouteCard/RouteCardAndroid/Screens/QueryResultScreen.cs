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
	[Activity (Label = "Route Card Result", Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light")]			
	public class QueryResultScreen : Activity
	{
		ListView queryResultListView;

		IList<RouteOperation> routeOperations;
		Adapters.ResultAdapter routeOperationsAdapter;

		public QueryResultScreen ()
		{
			routeOperations = new List<RouteOperation> ();
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set layout
			SetContentView (Resource.Layout.QueryResult);

			// find list view and attach listener
			queryResultListView = FindViewById<ListView> (Resource.Id.listViewQueryResult);
			queryResultListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				RouteOperation operation = routeOperations [e.Position];
				sendQueryResultDetailIntent(operation);
			};
		}

		protected override void OnStart ()
		{
			base.OnStart ();

			// get lot number from intent
			String lotNumber = Intent.GetStringExtra ("LotNumber");

			// execute query
			Route route = AndroidApp.App.RouteManager.QueryRouteForLot (lotNumber);
			routeOperations = route.RouteOperations;

			// create list view adapter
			routeOperationsAdapter = new Adapters.ResultAdapter (this, routeOperations);

			// hook up adapter to list view
			queryResultListView.Adapter = routeOperationsAdapter;
		}

		protected override void OnResume ()
		{
			base.OnResume ();
		}

		private void sendQueryResultDetailIntent(RouteOperation operation)
		{
			// create intent
			Intent queryResultDetailIntent = new Intent (this, typeof(QueryResultDetailsScreen));
			// insert data in intent
			queryResultDetailIntent.PutExtra ("Type", operation.Type);
			queryResultDetailIntent.PutExtra ("ProductType", operation.ProductType);
			queryResultDetailIntent.PutExtra ("Product", operation.Product);
			queryResultDetailIntent.PutExtra ("Plant", operation.Plant);
			queryResultDetailIntent.PutExtra ("Facility", operation.Facility);
			queryResultDetailIntent.PutExtra ("ProductionLevel", operation.ProductionLevel);
			queryResultDetailIntent.PutExtra ("Route", operation.Route);
			queryResultDetailIntent.PutExtra ("Version", operation.Version);
			queryResultDetailIntent.PutExtra ("Position", operation.Position);
			queryResultDetailIntent.PutExtra ("OperationNumber", operation.OperationNumber);
			queryResultDetailIntent.PutExtra ("OperationText", operation.OperationText);
			queryResultDetailIntent.PutExtra ("CTPlan", operation.CTPlan);
			queryResultDetailIntent.PutExtra ("CTQ", operation.CTQ);
			queryResultDetailIntent.PutExtra ("RPT", operation.RPT);
			// start activity
			StartActivity (queryResultDetailIntent);
		}
	}

}

