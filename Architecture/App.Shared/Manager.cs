using System;
using App.Data;
using System.Linq;

namespace App.Shared
{
	public class Manager
	{
		IUnitOfWork uow;

		public Manager (IUnitOfWork UnitOfWork)
		{
			uow = UnitOfWork;
		}

		public void RateSong (String Title, int Rating)
		{
			SongRepository rep = (SongRepository)uow.GetRepository<Song> ();
			var song = from i in rep.GetAll2 ()
					where i.Title == Title
					select i;

			foreach (var item in song) {
				item.Rating = Rating;
				rep.Update (item);
			}

			uow.Commit ();
		}
	}
}

