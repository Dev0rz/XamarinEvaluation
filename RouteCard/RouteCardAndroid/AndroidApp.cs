﻿using System;
using RouteCard;
using Android.Content;
using PerpetualEngine.Storage;

namespace RouteCardAndroid
{
	public class AndroidApp : Application
	{
		protected static AndroidApp app = null;
		public static AndroidApp App 
		{
			get 
			{ 
				if (app == null) {
					app = new AndroidApp ();
				}
				return app;
			}
		}

		public void SetContext(Context ctx)
		{
			SimpleStorage.SetContext(ctx);
		}

		internal AndroidApp ()
		{
			Storage = new SimpleStorageAndroid ();
		}
	}
}

