using System.Collections.Generic;

namespace RouteCard.Core
{
	public class Route
	{
		IList<RouteOperation> routeOperations;

		public string Lot { get; set; }
		public IList<RouteOperation> RouteOperations { get { return routeOperations; } }

		public Route (string lot)
		{
			this.Lot = lot;
			routeOperations = new List<RouteOperation>();
		}
			
		public void addOperation(RouteOperation operation) {
			routeOperations.Add(operation);
		}

		public RouteOperation getOperation(int pos) {
			return routeOperations[pos];
		}
	}
}

