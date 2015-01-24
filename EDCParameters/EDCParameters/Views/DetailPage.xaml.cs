using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EDCParameters
{		
	public class ListViewCell : ViewCell
	{
		Label label = null;

		public ListViewCell ()
		{			
			label = new Label { Font = Font.SystemFontOfSize(NamedSize.Small) };

			View = new StackLayout {
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (15, 5, 5, 5),
				Children = { label }
			};
		}

		protected override void OnBindingContextChanged ()
		{
			base.OnBindingContextChanged ();

			string c = (string)BindingContext;

			label.Text = c;
			label.TextColor = Color.FromRgb (255, 127, 39);
		}
	}

	public partial class DetailPage : ContentPage
	{	
		public DetailPage ()
		{
			var listView = new ListView ();

			// TODO: Call service and bind source
			listView.ItemsSource = new [] { "a", "b", "c" };
			listView.ItemTemplate = new DataTemplate(typeof(ListViewCell));

			Label label = new Label { Text = "EDC Parameters", TextColor = Color.FromRgb (144, 144, 144), Font = Font.SystemFontOfSize(NamedSize.Medium), HorizontalOptions=LayoutOptions.Center };

			Content = new StackLayout {
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness (15, 5, 5, 5),
				Children = {label, listView}
			};
		}
	}
}

