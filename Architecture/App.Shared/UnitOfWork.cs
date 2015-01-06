using System;
using System.Collections.Generic;
using App.Shared;

//using App.Shared.Interfaces;
using App.Data;

//using Tasky.DL.SQLiteBase;
using App.Shared.Interfaces;

namespace App.Shared
{
	public enum DataSource
	{
		Database,
		File,
		WebService
	}

	public interface IConfigurator
	{
		UnitOfWork GetUnitOfWork ();
	}

	public class UnitOfWork : IUnitOfWork
	{
		#region IUnitOfWork implementation

		public void Commit ()
		{
			con.Commit ();
		}

		public void Rollback ()
		{
			con.Rollback ();
		}

		#endregion

		public ISQLiteConnection con;
		private Dictionary<Type, object> repositories;

		public UnitOfWork (ISQLiteConnection connection)
		{
			con = connection;
			repositories = new Dictionary<Type, object> ();

			repositories.Add (typeof(Song), new SongRepository(this));
		}

		/// <summary>
		/// Get the Repository
		/// </summary>
		/// <returns>Repository<TEntity.</returns>
		/// <typeparam name="TEntity">Entity type for the repository.</typeparam>
		public IRepository<TEntity> GetRepository<TEntity> () where TEntity : IEntity
		{    
			if (repositories.ContainsKey (typeof(TEntity)))
				return repositories [typeof(TEntity)] as Repository<TEntity>;

			throw new Exception ("Repository not found.");
		}
	}
}

