using System;

namespace RouteCard
{
	public interface ISimpleStorage
	{
		void PutString(String key, String value);
		String GetString(String key);
	}
}

