using App.Data;
using System.Collections.Generic;
using App.Shared.Interfaces;
using System.Linq;


public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
{
	public void Delete (TEntity entity)
	{
		throw new System.NotImplementedException ();
	}

	public void Update (TEntity entity)
	{
		con.Update (entity);
	}

	public System.Linq.IQueryable<TEntity> GetAll ()
	{
		throw new System.NotImplementedException ();
	}

	public System.Linq.IQueryable<Song> GetAll (bool test)
	{
		return con.Table<Song> ().AsQueryable();
		//		return (from i in con.Table<TEntity>() select i).ToList();

		//		return con.Table<TEntity> ().AsQueryable();
	}

	public TEntity GetSingle (int Id)
	{
		throw new System.NotImplementedException ();
	}

	public System.Linq.IQueryable<TEntity> FindBy (System.Linq.Expressions.Expression<System.Func<TEntity, bool>> predicate)
	{
		throw new System.NotImplementedException ();
	}

	public void Add (TEntity entity)
	{

		con.Insert (entity);
	}

	protected ISQLiteConnection con = null;
	public Repository(ISQLiteConnection connection)
	{
		con = connection;
		con.CreateTable<TEntity> ();
	}
}