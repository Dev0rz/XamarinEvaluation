using System;
using App.Data;

namespace App.Shared
{
	public interface IUnitOfWork
	{
		void Commit();   // save changes
		void Rollback(); // discard changes
		IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity;
	}
}

