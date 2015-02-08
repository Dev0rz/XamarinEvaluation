using System;
using System.Collections.Generic;

namespace EDCParameters
{
	public class MockClient
	{
		String _username = "marshll";
		String _password = "123";

		Dictionary<String, List<EDCParameter>> data = new Dictionary<String, List<EDCParameter>>();

		public MockClient ()
		{
			List<EDCParameter> lst = null;

			// EDC Parameters 1 
			lst = new List<EDCParameter> ();
			EDCParameter p1 = new EDCParameter ();
			p1.Name = "Parameter 1";
			p1.NumberOfParameters = 2;
			p1.Parameters.Add ("1");
			p1.Parameters.Add ("2");
			lst.Add (p1);

			EDCParameter p2 = new EDCParameter ();
			p2.Name = "Parameter 2";
			p2.NumberOfParameters = 1;
			p2.Parameters.Add ("3");
			lst.Add (p2);

			data.Add("1", lst);
		}

		public bool IsValidUser(string username, string password)
		{
			if(username == _username && password == _password)
				return true;
			else
				return false;
		}

		public bool EDCParameterExists(string name)
		{
			if (data.ContainsKey (name))
				return true;
			else
				return false;
		}

		public List<EDCParameter> GetEDCParameter(string name)
		{
			if (data.ContainsKey (name))
				return data [name];
			else
				return null;
		}

		public bool ValidateEDCParameter(string RouteCard, List<EDCParameter> Data)
		{
			if (data.ContainsKey (RouteCard)) {
				int i = 0;
				foreach (var item in data [RouteCard]) {
					int j = 0;
					foreach (var item2 in item.Parameters) {
						if (item2 != Data [i].Parameters [j])
							return false;
						j++;
					}
					i++;
				}
				return true;
			}
			return false;
		}
	}
}

