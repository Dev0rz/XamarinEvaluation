using System.Collections.Generic;
using System.ServiceModel;
using App.Mock.WebService;

namespace RouteCard.Core
{
	public class RouteManager
	{
		BasicHttpBinding binding = new BasicHttpBinding ();
		EndpointAddress addr = new EndpointAddress (@"http://46.163.111.88/MockService.svc");

		public RouteManager ()
		{
		
		}

		public virtual Route QueryRouteForLot (string lotNumber)
		{
			Route r = new Route (lotNumber);

			MockServiceClient client = new MockServiceClient (binding, addr);
			App.Mock.WebService.RouteOperation[] routeOperation = client.GetRouteOperations (lotNumber);

			foreach (var item in routeOperation) {

				RouteOperation op = new RouteOperation () {
					Type = item.Type,
					ProductType  = item.Product_Type,
					Product  = item.Product,
					Plant = item.Plant,
					Facility = item.Manufacturing_Line,
					ProductionLevel = item.Production_Level, 
					Route = item.Route, 
					Version = item.Version,
					Position = item.Op_Seq,
					OperationNumber = item.Op, 
					OperationText = item.Position,
					CTPlan = item.CT_Plan, 
					CTQ = item.CT_Q,
					RPT = item.RPT, 
					Color = item.Color
				};

				r.addOperation (op);
			}

			return r;
		}
	}
}

