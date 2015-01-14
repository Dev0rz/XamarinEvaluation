using System.Collections.Generic;
using System.ServiceModel;
using App.Mock.WebService;

namespace RouteCard.Core
{
	public class RouteManagerLocal : RouteManager
	{
		static List<Route> routes;

		public RouteManagerLocal () : base ()
		{
			Init ();
		}

		private void Init()
		{
			routes = new List<Route>();

			Route r1 = new Route ("B124506R");
			r1.addOperation (new RouteOperation () {
				Type = "F4133T",
				ProductType = "F4133T00100",
				Product = "11000001",
				Plant = "BUR",
				Facility = "OSFE1",
				ProductionLevel = "FOL",
				Route = "V4133T",
				Version = "8",
				Position = "1",
				OperationNumber = "3012",
				OperationText = "Dummy text 1",
				CTPlan = "00:15",
				CTQ = "00:05",
				RPT = "00:10",
				Color = "#FFCC00"
			});
			r1.addOperation (new RouteOperation () {
				Type = "F4133T",
				ProductType = "F4133T00100",
				Product = "11000001",
				Plant = "BUR",
				Facility = "OSFE1",
				ProductionLevel = "FOL",
				Route = "V4133T",
				Version = "8",
				Position = "2",
				OperationNumber = "4117",
				OperationText = "Dummy text 2",
				CTPlan = "00:20",
				CTQ = "00:08",
				RPT = "00:12",
				Color = "#99CC00"
			});
			r1.addOperation (new RouteOperation () {
				Type = "F4133T",
				ProductType = "F4133T00100",
				Product = "11000001",
				Plant = "BUR",
				Facility = "OSFE1",
				ProductionLevel = "FOL",
				Route = "V4133T",
				Version = "8",
				Position = "3",
				OperationNumber = "5600",
				OperationText = "Dummy text 3",
				CTPlan = "00:10",
				CTQ = "00:02",
				RPT = "00:08",
				Color = "#FFFFFF"
			} );
			r1.addOperation (new RouteOperation () {
				Type = "F4133T",
				ProductType = "F4133T00100",
				Product = "11000001",
				Plant = "BUR",
				Facility = "OSFE1",
				ProductionLevel = "FOL",
				Route = "V4133T",
				Version = "8",
				Position = "4",
				OperationNumber = "3012",
				OperationText = "Dummy text 1",
				CTPlan = "00:20",
				CTQ = "00:06",
				RPT = "00:14",
				Color = "#FFFFFF"
			});
			routes.Add (r1);

			Route r2 = new Route ("B124711B");
			r2.addOperation (new RouteOperation () {
				Type = "F4135T",
				ProductType = "F4135T00200",
				Product = "11000002",
				Plant = "BUR",
				Facility = "OSFE2",
				ProductionLevel = "EOL",
				Route = "N4135T",
				Version = "10",
				Position = "1",
				OperationNumber = "5112",
				OperationText = "Dummy text 4",
				CTPlan = "00:17",
				CTQ = "00:05",
				RPT = "00:12",
				Color = "#FFCC00"
			});
			r2.addOperation (new RouteOperation () {
				Type = "F4135T",
				ProductType = "F4135T00200",
				Product = "11000002",
				Plant = "BUR",
				Facility = "OSFE2",
				ProductionLevel = "EOL",
				Route = "N4135T",
				Version = "10",
				Position = "2",
				OperationNumber = "5002",
				OperationText = "Dummy text 5",
				CTPlan = "00:18",
				CTQ = "00:06",
				RPT = "00:12",
				Color = "#99CC00"
			});
			r2.addOperation (new RouteOperation () {
				Type = "F4135T",
				ProductType = "F4135T00200",
				Product = "11000002",
				Plant = "BUR",
				Facility = "OSFE2",
				ProductionLevel = "EOL",
				Route = "N4135T",
				Version = "10",
				Position = "3",
				OperationNumber = "5600",
				OperationText = "Dummy text 8",
				CTPlan = "00:14",
				CTQ = "00:06",
				RPT = "00:08",
				Color = "#FFFFFF"
			});
			r2.addOperation (new RouteOperation () {
				Type = "F4135T",
				ProductType = "F4135T00200",
				Product = "11000002",
				Plant = "BUR",
				Facility = "OSFE2",
				ProductionLevel = "EOL",
				Route = "N4135T",
				Version = "10",
				Position = "4",
				OperationNumber = "4600",
				OperationText = "Dummy text 7",
				CTPlan = "00:20",
				CTQ = "00:06",
				RPT = "00:14",
				Color = "#FFFFFF"
			});
			r2.addOperation (new RouteOperation () {
				Type = "F4135T",
				ProductType = "F4135T00200",
				Product = "11000002",
				Plant = "BUR",
				Facility = "OSFE2",
				ProductionLevel = "EOL",
				Route = "N4135T",
				Version = "10",
				Position = "5",
				OperationNumber = "3015",
				OperationText = "Dummy text 6",
				CTPlan = "00:18",
				CTQ = "00:06",
				RPT = "00:12",
				Color = "#FFFFFF"
			});
			routes.Add (r2);
		}

		virtual public Route QueryRouteForLot (string lotNumber)
		{
			foreach (Route r in routes) {
				if (r.Lot.Equals(lotNumber)) {
					return r;
				}
			}
			return null;
		}
	}
}

