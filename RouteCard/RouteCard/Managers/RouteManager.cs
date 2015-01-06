using System.Collections.Generic;
using App.Mock.WebService;
using System.ServiceModel;

namespace RouteCard.Core
{
	public class RouteManager
	{
		private static MockServiceClient client = null;
		private static MockServiceClient Client
		{
			get
			{ 
				if (client == null) {
					BasicHttpBinding binding = new BasicHttpBinding ();
					EndpointAddress addr = new EndpointAddress (@"http://46.163.111.88/MockService.svc");
					client = new MockServiceClient (binding, addr);
				}
				return client;
			}
		}

		public RouteManager ()
		{

		}

		public static Route queryRouteForLot(string lotNumber)
		{
			Route r = new Route (lotNumber);

			App.Mock.WebService.RouteOperation[] routeOperation = Client.GetRouteOperations (lotNumber);
			foreach (var item in routeOperation) {

				RouteOperation op = new RouteOperation () {
					Equipment = item.Equipment,
					Hold_Reason = item.Hold_Reason,
					Hold_Category = item.Hold_Category,
					Hold_Note = item.Hold_Note,
					Hold_Name = item.Hold_Name,
					Planed_Hold = item.Planed_Hold,
					Color = item.Color
				};

				r.addOperation (op);
			}

			return r;
		}
	}
}

