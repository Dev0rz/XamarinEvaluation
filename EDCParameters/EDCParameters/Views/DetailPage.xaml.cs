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

	public class ParameterView
	{
		public Label Name;
		public List<Entry> Entries;

		public ParameterView(string name)
		{
			Name = new Label() { Text = name};
			Entries = new List<Entry> ();
		}
	}

	public partial class DetailPage : ContentPage
	{	
		String routeCard = String.Empty;
		Button button = null;
		List<ParameterView> paramView = new List<ParameterView>();

		void OnButtonClicked(object sender, EventArgs e)
		{
			bool Error = false;
			foreach (var item in paramView) {
				foreach (var item2 in item.Entries) {
					if (item2.Text == String.Empty) {
						Error = true;
					}
				}
			}

			if(Error)
				DisplayAlert ("Error", "Please enter all fields.", "OK");

			MockClient client = new MockClient ();
			List<EDCParameter> list = new List<EDCParameter> ();

			foreach (var item in paramView) {
				EDCParameter param = new EDCParameter ();
				param.Parameters = new List<string> ();
				foreach (var item2 in item.Entries) {
					param.Parameters.Add (item2.Text);
				}
				list.Add (param);
			}

			if (client.ValidateEDCParameter (routeCard, list))
				DisplayAlert ("Success", "The parameters are valid.", "OK");
			else
				DisplayAlert ("Failed", "The parameters are not valid.", "OK");
		}


		public DetailPage (String RouteCard)
		{
			routeCard = RouteCard;

			button = new Button
			{
				Text = "Check",
			};

			StackLayout stack = new StackLayout();
			var view = new ScrollView {
				Content = stack,
			};
			stack.Padding = new Thickness (20);


			MockClient client = new MockClient ();
			List<EDCParameter> list = client.GetEDCParameter (RouteCard);

			foreach (var item in list) {
				ParameterView pView = new ParameterView(item.Name);
				for (int i = 0; i < item.NumberOfParameters; i++) {
					pView.Entries.Add (new Entry () { Text = "" });
				}
				paramView.Add (pView);
			}

			foreach (var item in paramView) {
				stack.Children.Add (item.Name);
				foreach (var entry in item.Entries) {
					stack.Children.Add (entry);
				}
			}

			stack.Children.Add (button);
			button.Clicked += OnButtonClicked;

			Content = view;
		}
	}
}

