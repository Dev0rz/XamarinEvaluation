using System;
using EDCParameters;
using PerpetualEngine.Storage;
using Android.Content;

namespace EDCParametersAndroid
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

