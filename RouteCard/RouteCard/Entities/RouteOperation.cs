using System;

namespace RouteCard.Core
{
	public class RouteOperation
	{
		public String Facility { get; set; }
		public String ProductionLevel { get; set; }
		public int OperationNumber { get; set; }
		public String OperationText { get; set; }
		public String Equipment { get; set; }
		public String Route { get; set; }			// Route with version
		public String Hold_Category { get; set; }
		public String Hold_Name { get; set; }
		public String Hold_Note { get; set; }
		public String Hold_Reason { get; set; }
		public String Hold_Release { get; set; }
		public String Planed_Hold { get; set; }
		public String HumanOperator { get; set; }
		public String Color { get; set; }

		// public String Process { get; set; }			// ???
		// public String Process_Nr { get; set; }		// ???
		// public String Specification { get; set; }	// ???
		// public String Comment { get; set; }			// ???

		public string ArrivalDate { get; set; }
		public string ArrivalTime { get; set; }
		public string ProcessingTime { get; set; }

		public RouteOperation ()
		{
		}

		public RouteOperation (String facility, String productionLevel, int operationNumber, String route, String humanOperator, String color, String arrivalDate, String arrivalTime, String processingTime)
		{
			this.Facility = facility;
			this.ProductionLevel = productionLevel;
			this.OperationNumber = operationNumber;
			this.Route = route;
			this.HumanOperator = humanOperator;
			this.Color = color;
			this.ArrivalDate = arrivalDate;
			this.ArrivalTime = arrivalTime;
			this.ProcessingTime = processingTime;
		}
	}
}

