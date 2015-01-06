using System.Collections.Generic;
using App.Mock.WebService;
using System.ServiceModel;

namespace RouteCard.Core
{
	public class RouteManager
	{
		public RouteManager ()
		{

		}

		public static Route queryRouteForLot(string lotNumber)
		{
			Route r = new Route (lotNumber);

			BasicHttpBinding binding = new BasicHttpBinding();
			EndpointAddress addr = new EndpointAddress(@"http://46.163.111.88/MockService.svc");
			MockServiceClient client = new MockServiceClient (binding, addr);

			Lot[] lots = client.GetLot (lotNumber);

			foreach (var item in lots) {

				RouteOperation op = new RouteOperation () {
					Equipment = item.Equipment,
					Hold_Reason = item.Hold_Reason,
					Hold_Category = item.Hold_Category,
					Hold_Note = item.Hold_Note,
					Hold_Name = item.Hold_Name,
					Planed_Hold = item.Planed_Hold,
				};

				r.addOperation (op);
			}

			return r;
		}
	}
}

