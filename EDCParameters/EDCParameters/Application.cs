using System;
using Xamarin.Forms;

namespace EDCParameters
{
	public abstract class Application
	{
		protected ISimpleStorage storage = null;
		protected AccountManager AccountMgr = null;
		protected EDCManager EDCMgr = null;

		public ISimpleStorage Storage
		{
			get { return storage; }
			set { storage = value; }
		}

		public AccountManager GetAccountManager()
		{
			if (storage == null) {
				return null;
			}

			if (AccountMgr == null) {
				AccountMgr = new AccountManager (storage);
			}

			return AccountMgr;
		}

		public EDCManager GetEDCManager()
		{
			if (EDCMgr == null) {
				EDCMgr = new EDCManager ();
			}

			return EDCMgr;
		}

		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};

		}
	}
}

