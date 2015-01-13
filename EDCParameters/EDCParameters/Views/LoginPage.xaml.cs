using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EDCParameters
{	
	public partial class LoginPage : ContentPage
	{	
		private bool IsAuthenticated = false;
		private AccountManager AccountMgr = null;

		public LoginPage (AccountManager mgr)
		{
			InitializeComponent ();

			AccountMgr = mgr;
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Entry username = this.FindByName<Entry> ("UsernameEntry");
			Entry password = this.FindByName<Entry> ("PasswordEntry");

			try {

				IsAuthenticated = AccountMgr.Authenticate (username.Text, password.Text);

				if (IsAuthenticated) {
					this.Navigation.PopModalAsync ();
				} else {
					DisplayAlert ("Authentication Error", "Could not authenticate User.", "Re-try");
				}
			} catch (Exception ex) {
				DisplayAlert ("Authentication Error", ex.Message, "Re-try");
			}
		}

		protected override bool OnBackButtonPressed()
		{
			return !IsAuthenticated;
//			if (!IsAuthenticated) 
//				return ;
//			base.OnBackButtonPressed ();
		}
	}
}

