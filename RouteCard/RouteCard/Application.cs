using System;
using RouteCard.Core;

namespace RouteCard
{
	public abstract class Application
	{
		public static Application App = null;

		public AccountManager AccountMgr = null;
		public RouteManager RouteMgr = null;

		public Application ()
		{
			App = this;

			AccountMgr = new AccountManager ();
			RouteMgr = new RouteManager ();
		}

		public bool Authorize (String username, String password)
		{
			return AccountMgr.Authorize (username, password);
		}
	}
}

