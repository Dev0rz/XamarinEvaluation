using System;
using System.Collections.Generic;
using App.Data;
using App.Shared;

namespace App.Shared
{
	public class SongRepository : Repository<Song>
	{
		private IUnitOfWork uow = null;

		public SongRepository (UnitOfWork UnitOfWork) : base (UnitOfWork.con)
		{
			uow = UnitOfWork;
		}

		public IEnumerable<Song> GetSongsByArtist(String artist)
		{
			IRepository<Song> rep = uow.GetRepository<Song> ();
			IEnumerable<Song> songs = rep.FindBy (x => x.Artist == artist);
			return songs;
		}

		public IEnumerable<Song> GetAll2()
		{
			return con.Table<Song> ();
		}
	}
}

