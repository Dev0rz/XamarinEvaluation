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
					Type = item.Type,
					Product_Type  = item.Product_Type,
					Product  = item.Product,
					Plant = item.Plant,
					Manufacturing_Line = item.Manufacturing_Line,
					Production_Level = item.Production_Level, 
					Route = item.Route, 
					Version = item.Version,
					Op_Seq = item.Op_Seq,
					Op = item.Op, 
					Position = item.Position,
					CT_Plan = item.CT_Plan, 
					CT_Q = item.CT_Q,
					RPT = item.RPT, 
					Color = item.Color
				};

				r.addOperation (op);
			}

			return r;
		}
	}
}

