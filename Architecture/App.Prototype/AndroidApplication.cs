using System;
using App.Shared;
using System.IO;
using Tasky.DL.SQLite;

namespace App.Prototype
{
	class ReleaseConfigurator : IConfigurator
	{
		public UnitOfWork GetUnitOfWork()
		{
			var sqliteFilename = "prototype.db3";
			string libraryPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var path = Path.Combine (libraryPath, sqliteFilename);
			Connection con = new Connection (path);
			return new UnitOfWork (con);
		}

	}

	public class AndroidApp : Application
	{
		#region implemented abstract members of Application

		protected override IConfigurator GetConfigurator ()
		{
			return new ReleaseConfigurator ();
		}

		#endregion

		public AndroidApp ()
		{
		}


	}
}

