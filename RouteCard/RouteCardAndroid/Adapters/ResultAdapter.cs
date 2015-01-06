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
			// gives us some performance gains by not always inflating a new view
			// will sound familiar to MonoTouch developers with UITableViewCell.DequeueReusableCell()
			LinearLayout view = (convertView ?? context.LayoutInflater.Inflate(Resource.Layout.QueryResultItem, parent, false)) as LinearLayout;

			// Set color
			view.SetBackgroundColor(Color.ParseColor(item.Color));

			// Find references to each subview in the list item's view
			TextView facilityTextView = view.FindViewById<TextView>(Resource.Id.textViewFacility);
			TextView productionLevelTextView = view.FindViewById<TextView>(Resource.Id.textViewProductionLevel);
			TextView operationTextView = view.FindViewById<TextView>(Resource.Id.textViewOperation);
			TextView arrivalDateTextView = view.FindViewById<TextView>(Resource.Id.textViewArrivalDate);
			TextView arrivalTimeTextView = view.FindViewById<TextView>(Resource.Id.textViewArrivalTime);
			TextView processingTimeTextView = view.FindViewById<TextView>(Resource.Id.textViewProcessingTime);

			// Assign item's values to the various subviews
			facilityTextView.SetText(item.Facility, TextView.BufferType.Normal);
			productionLevelTextView.SetText(item.ProductionLevel, TextView.BufferType.Normal);
			operationTextView.SetText(item.OperationNumber.ToString(), TextView.BufferType.Normal);
			arrivalDateTextView.SetText(item.ArrivalDate, TextView.BufferType.Normal);
			arrivalTimeTextView.SetText(item.ArrivalTime, TextView.BufferType.Normal);
			processingTimeTextView.SetText(item.ProcessingTime, TextView.BufferType.Normal);

			//Finally return the view
			return view;
		}
	}
}

