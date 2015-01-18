using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EDCParameters
{	
	public partial class DetailPage : ContentPage
	{	
		// Not used, only for reference
		private void ItemTabbedHandler(ListView listView)
		{
			listView.ItemTapped += async (sender, e) => {
				await DisplayAlert("Tapped", e.Item + " row was tapped", "OK");
				((ListView)sender).SelectedItem = null; // de-select the row
			};
		}

		// Not used, only for reference
		private void ItemSelectedHandler(ListView listView)
		{
			 listView.ItemSelected += (sender, e) => {
			 	if (e.SelectedItem == null) return;
			 	((ListView)sender).SelectedItem = null; // de-select the row
			 };
		}

		public DetailPage ()
		{
			var listView = new ListView ();

			// TODO: Call service and bind source
			listView.ItemsSource = new [] { "a", "b", "c" };

			Padding = new Thickness (0,20,0,0);
			Content = listView;
		}
	}
}

