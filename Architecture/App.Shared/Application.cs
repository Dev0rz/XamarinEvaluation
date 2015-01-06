using System;

namespace App.Shared
{
	public abstract class Application
	{
		public static Application app = null;

		protected abstract IConfigurator GetConfigurator();

		private IUnitOfWork UnitOfWork { get; set;}

		public Application ()
		{
			UnitOfWork = GetConfigurator ().GetUnitOfWork ();
		}

		public Manager GetManager()
		{
			return new Manager (UnitOfWork);
		}

		public void RateSong (String Title, int Rating)
		{
			GetManager ().RateSong (Title, Rating);
		}
	}
}

