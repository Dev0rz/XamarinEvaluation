using System;
using System.ServiceModel;

namespace RouteCard
{
	public class AccountManager
	{
		public AccountManager ()
		{
		}

		public bool Authorize (String username, String password)
		{
			try {
				BasicHttpBinding binding = new BasicHttpBinding();
				EndpointAddress addr = new EndpointAddress(@"http://46.163.111.88/MockService.svc");

				MockServiceClient client = new MockServiceClient (binding, addr);
				return client.IsValidUser(username, password);
			} catch (Exception ex) {
				return false;
			}
		}
	}
}

