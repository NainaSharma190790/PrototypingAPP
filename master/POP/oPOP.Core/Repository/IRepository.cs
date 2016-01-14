using System;
using System.Collections.Generic;

namespace oPOP.Core
{
	public interface IRepository<T,Tk> where T : class, new()
	{
		/// <summary>
		/// Get the specified id.
		/// </summary>
		/// <param name="id">Identifier.</param>
		T Get(Tk id);

		/// <summary>
		/// Saves the or update.
		/// </summary>
		/// <param name="entity">Entity.</param>
		void AddUpdate(T entity);

		/// <summary>
		/// Delete the specified entity.
		/// </summary>
		/// <param name="entity">Entity.</param>
		void Delete(T entity);

		/// <summary>
		/// List this instance.
		/// </summary>
		IList<T> List();
	}
}

