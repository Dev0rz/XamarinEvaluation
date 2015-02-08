using System;
using System.ServiceModel;

namespace EDCParameters
{
	public class AccountManager
	{
//		BasicHttpBinding binding = new BasicHttpBinding();
//		EndpointAddress addr = new EndpointAddress(@"http://46.163.111.88/MockService.svc");

		ISimpleStorage storage = null;

		public AccountManager (ISimpleStorage storage)
		{
			this.storage = storage;
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

		public void ClearCredentials() {
			storage.PutString ("user", "");
			storage.PutString ("pass", "");
		}
			
		public bool AutoAuthenticate()
		{
			User u = GetCredentials ();

			if (u == null) {
				return false;
			}
				
			return _Authenticate (u.UserName, u.Password);
		}

		public bool Authenticate (String username, String password)
		{
			if (_Authenticate (username, password)) {
				StoreCredentials (username, password);
				return true;
			}

			return false;
		}

		private bool _Authenticate (String username, String password)
		{
			try {
				MockClient client = new MockClient ();
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

