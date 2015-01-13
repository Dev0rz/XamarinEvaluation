using System;
using Xamarin.Forms;

namespace EDCParameters
{
	public class EDCParametersApp : Application
	{
		protected ISimpleStorage storage = null;
		protected AccountManager AccountMgr = null;
		protected EDCManager EDCMgr = null;

		public void Init()
		{
			EDCMgr = new EDCManager ();
			AccountMgr = new AccountManager (storage);

			MainPage = new EDCParameters.MainPage (this);
		}

		public ISimpleStorage Storage
		{
			get { return storage; }
			set { storage = value; }
		}

		public AccountManager AccountManager
		{
			get { return AccountMgr; }
		}

		public EDCManager EDCManager
		{
			get { return EDCMgr; }
		}

		public EDCParametersApp()
		{
		}
	}
}

