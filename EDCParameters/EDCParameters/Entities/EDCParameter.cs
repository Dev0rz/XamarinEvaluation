using System;
using System.Collections.Generic;

namespace EDCParameters
{
	public class EDCParameter
	{
		public String Name { get ; set;}
		public int NumberOfParameters { get ; set;}

		public List<String> Parameters = new List<string> ();

		public void AddParameter(String Parameter)
		{
			Parameters.Add (Parameter);
		}
	}
}

