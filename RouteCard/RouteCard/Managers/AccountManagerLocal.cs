using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace RouteCard
{
	public class AccountManagerLocal : AccountManager
	{
		static List<User> users;

		public AccountManagerLocal (ISimpleStorage storage) : base (storage)
		{
			Init ();
		}

		private void Init ()
		{
			users = new List<User> ();
			users.Add (new User () { UserName = "tc", Password = "abc" });
			users.Add (new User () { UserName = "moody", Password = "xyz" });
			users.Add (new User () { UserName = "philip", Password = "123" });
		}

		virtual protected bool _Authenticate (String username, String password)
		{
			foreach (User u in users) {
				if (username.Equals (u.UserName) && password.Equals (u.Password)) {
					return true;
				}
			}
			return false;
		}
	}
}

