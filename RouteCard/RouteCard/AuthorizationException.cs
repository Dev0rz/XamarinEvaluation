using System;

namespace RouteCard
{
	public class AuthorizationException : Exception
	{
		public AuthorizationException (String Message) : base(Message)
		{
		}
	}
}

