using System;
using EDCParameters;
using PerpetualEngine.Storage;
using Android.Content;

namespace EDCParametersAndroid
{
	public class AndroidApp : EDCParametersApp
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

		public void Init(Context ctx)
		{
			SimpleStorage.SetContext(ctx);
			base.Init ();
		}

		internal AndroidApp ()
		{
			Storage = new SimpleStorageAndroid ();
		}
	}
}

