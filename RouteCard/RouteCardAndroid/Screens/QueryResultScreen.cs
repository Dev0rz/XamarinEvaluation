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
	[Activity (Label = "Route Card Result", Icon="@drawable/icon")]			
	public class QueryResultScreen : Activity
	{
		ListView queryResultListView;

		IList<RouteOperation> routeOperations;
		Adapters.ResultAdapter routeOperationsAdapter;

		public QueryResultScreen()
		{
			routeOperations = new List<RouteOperation>();
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// set layout
			SetContentView(Resource.Layout.QueryResult);

			// find list view
			queryResultListView = FindViewById<ListView>(Resource.Id.listViewQueryResult);
		}

		protected override void OnStart()
		{
			base.OnStart();

			// get lot number from intent
			String lotNumber = Intent.GetStringExtra("LotNumber");

			// execute query
			Route route = RouteManager.queryRouteForLot(lotNumber);
			routeOperations = route.RouteOperations;

			// create list view adapter
			routeOperationsAdapter = new Adapters.ResultAdapter(this, routeOperations);

			// hook up adapter to list view
			queryResultListView.Adapter = routeOperationsAdapter;
		}

		protected override void OnResume()
		{
			base.OnResume();
		}
	}

}

