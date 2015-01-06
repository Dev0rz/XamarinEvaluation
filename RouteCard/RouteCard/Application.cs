using System;
using RouteCard.Core;

namespace RouteCard
{
	public abstract class Application
	{
		protected ISimpleStorage storage = null;
		protected AccountManager AccountMgr = null;
		protected RouteManager RouteMgr = null;

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

		public RouteManager GetRouteManager()
		{
			if (RouteMgr == null) {
				RouteMgr = new RouteManager ();
			}

			return RouteMgr;
		}
	}
}

