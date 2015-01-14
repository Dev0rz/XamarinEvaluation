using System;
using RouteCard.Core;

namespace RouteCard
{
	public abstract class Application
	{
		protected ISimpleStorage storage = null;
		public ISimpleStorage Storage
		{
			get { return storage; }
		}

		protected AccountManager accountManager = null;
		public AccountManager AccountManager
		{
			get { return accountManager; }
		}

		protected RouteManager routeManager = null;
		public RouteManager RouteManager
		{
			get { return routeManager; }
		}

		public void Init ()
		{
			accountManager = new AccountManagerLocal (storage);
			routeManager = new RouteManagerLocal ();
		}
	}
}

