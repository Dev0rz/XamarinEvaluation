using System;
using System.Linq;
using System.Linq.Expressions;
using App.Shared.Interfaces;

namespace App.Data
{
	public interface IRepository<T> where T : IEntity
	{
		IQueryable<T> GetAll();
		T GetSingle(int Id);
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}

