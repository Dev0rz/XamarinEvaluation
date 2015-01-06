using System;
using System.ServiceModel;

namespace RouteCard
{
	public class AccountManager
	{
		BasicHttpBinding binding = new BasicHttpBinding();
		EndpointAddress addr = new EndpointAddress(@"http://46.163.111.88/MockService.svc");

		ISimpleStorage storage = null;

		public AccountManager (ISimpleStorage storage)
		{
			this.storage = storage;
		}

		private bool isAuthorized = false;
		public bool IsAuthorized()
		{
			return false;
		}

		public bool AutoAuthorize()
		{
			User u = GetCredentials ();

			if (u == null) {
				return false;
			}

			isAuthorized = _Authorize (u.UserName, u.Password);
			return isAuthorized;
		}

		private User GetCredentials()
		{
			User u = new User ();

			u.UserName = storage.GetString ("user");
			u.Password = storage.GetString ("pass");

			if (u.UserName == String.Empty || u.Password == String.Empty) {
				return null;
			} else {
				return u;
			}
		}

		private void StoreCredentials(String userName, String password)
		{
			storage.PutString ("user", userName);
			storage.PutString ("pass", password);
		}

		public bool Authorize (String username, String password)
		{
			if (_Authorize (username, password)) {
				StoreCredentials (username, password);
				isAuthorized = true;
				return true;
			}

			return false;
		}

		private bool _Authorize (String username, String password)
		{
			try {
				MockServiceClient client = new MockServiceClient (binding, addr);
				return client.IsValidUser(username, password);
			}
			catch (EndpointNotFoundException) {
				throw new AuthorizationException ("Server not found.");
			}
			catch (CommunicationException) {
				throw new AuthorizationException ("Communication to server failed.");
			}
			catch (TimeoutException) {
				throw new AuthorizationException ("Server not reachable.");
			}
			catch (Exception) {
				throw new AuthorizationException ("Undefined error occured.");
			}
		}
	}
}

