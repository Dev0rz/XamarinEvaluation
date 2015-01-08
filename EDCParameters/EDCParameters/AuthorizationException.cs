using System;

namespace EDCParameters
{
	public class AuthorizationException : Exception
	{
		public AuthorizationException (String Message) : base(Message)
		{
		}
	}
}

