using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EDCParameters
{	
	public partial class MyPage : NavigationPage
	{	
		public String State = "";

		public MyPage ()
		{
			this.Navigation.PushAsync(new MainPage(this));
		}
	}
}

