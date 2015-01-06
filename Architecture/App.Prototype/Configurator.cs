using System;
using App.Shared;
using Tasky.DL.SQLite;
using System.IO;

namespace App.Prototype
{
	public class Configurator : IConfigurator
	{
		public Configurator ()
		{

		}

		#region IConfigurator implementation

		public UnitOfWork GetUnitOfWork ()
		{
			var sqliteFilename = "prototype.db3";
			string libraryPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var path = Path.Combine (libraryPath, sqliteFilename);

			Connection con = new Connection (path);
			UnitOfWork uow = new UnitOfWork (con);


			return uow;
		}

		#endregion
	}
}

