﻿using System;
using RouteCard;
using PerpetualEngine.Storage;

namespace RouteCardAndroid
{
	public class SimpleStorageAndroid : ISimpleStorage
	{
		public SimpleStorageAndroid ()
		{
		}

		#region ISimpleStorage implementation

		public void PutString (string key, string value)
		{
			var storage = SimpleStorage.EditGroup("Credentials");
			storage.Put(key, value);
		}

		public string GetString (string key)
		{
			var storage = SimpleStorage.EditGroup("Credentials");
			return storage.Get(key);
		}

		#endregion

	}
}

