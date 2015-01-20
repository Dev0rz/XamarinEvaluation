using System.Collections.Generic;

using Android.App;
using Android.Widget;
using Android.Graphics;

using RouteCard.Core;
using RouteCardAndroid;

namespace RouteCardAndroid.Adapters
{
	public class ResultAdapter : BaseAdapter<RouteOperation>
	{
		Activity context;
		IList<RouteOperation> routeOperations;

		public ResultAdapter (Activity context, IList<RouteOperation> routeOperations) : base ()
		{
			this.context = context;
			this.routeOperations = routeOperations;
		}

		public override RouteOperation this[int position]
		{
			get { return routeOperations[position]; }
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override int Count
		{
			get { return routeOperations.Count; }
		}

		public override Android.Views.View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			// Get our object for position
			RouteOperation item = routeOperations[position];			

			// Try to reuse convertView if it's not  null, otherwise inflate it from our item layout
			// gives us some performance gains by not always inflating a new view will sound
			// familiar to MonoTouch developers with UITableViewCell.DequeueReusableCell()
			LinearLayout view = (convertView ?? context.LayoutInflater.Inflate(Resource.Layout.QueryResultItem, parent, false)) as LinearLayout;

			// Find references to each subview in the list item's view
			TextView colorTextView = view.FindViewById<TextView>(Resource.Id.textViewColor);
			TextView typeTextView = view.FindViewById<TextView>(Resource.Id.textViewType);
			TextView productTypeTextView = view.FindViewById<TextView>(Resource.Id.textViewProductType);
			TextView facilityTextView = view.FindViewById<TextView>(Resource.Id.textViewFacility);
			TextView productionLevelTextView = view.FindViewById<TextView>(Resource.Id.textViewProductionLevel);
			TextView routeTextView = view.FindViewById<TextView>(Resource.Id.textViewRoute);
			TextView versionTextView = view.FindViewById<TextView>(Resource.Id.textViewVersion);
			TextView positionTextView = view.FindViewById<TextView>(Resource.Id.textViewPosition);
			TextView operationTextView = view.FindViewById<TextView>(Resource.Id.textViewOperation);
			TextView cTPlanTextView = view.FindViewById<TextView>(Resource.Id.textViewCTPlan);
			TextView cTQTextView = view.FindViewById<TextView>(Resource.Id.textViewCTQ);
			TextView rPTTextView = view.FindViewById<TextView>(Resource.Id.textViewRPT);

			// Assign item's values to the various subviews
			// (Some views won't be in the layout, so check before assigning value)
			colorTextView.SetBackgroundColor(Color.ParseColor(item.Color));
			if (typeTextView != null) { typeTextView.SetText(item.Type, TextView.BufferType.Normal); }
			if (productTypeTextView != null) { productTypeTextView.SetText(item.ProductType, TextView.BufferType.Normal); }
			if (facilityTextView != null) { facilityTextView.SetText(item.Facility, TextView.BufferType.Normal); }
			if (productionLevelTextView != null) { productionLevelTextView.SetText(item.ProductionLevel, TextView.BufferType.Normal); }
			if (routeTextView != null) { routeTextView.SetText(item.Route.ToString(), TextView.BufferType.Normal); }
			if (versionTextView != null) { versionTextView.SetText(item.Version.ToString(), TextView.BufferType.Normal); }
			if (positionTextView != null) { positionTextView.SetText(item.Position.ToString(), TextView.BufferType.Normal); }
			if (operationTextView != null) { operationTextView.SetText(item.OperationNumber.ToString(), TextView.BufferType.Normal); }
			if (cTPlanTextView != null) { cTPlanTextView.SetText(item.CTPlan, TextView.BufferType.Normal); }
			if (cTQTextView != null) { cTQTextView.SetText(item.CTQ, TextView.BufferType.Normal); }
			if (rPTTextView != null) { rPTTextView.SetText(item.RPT, TextView.BufferType.Normal); }

			//Finally return the view
			return view;
		}
	}
}

