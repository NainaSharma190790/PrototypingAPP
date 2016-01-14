using System;
using System.Linq;
using System.Collections.Generic;
using SQLite;
using oPOP.Core;

namespace oPOP.Data
{
	public class Database : SQLiteConnection
	{
		static object locker = new object ();

		SQLiteConnection database;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		public Database(string path) : base(path)
		{
			// create the tables
			CreateTable<Projects>();
			CreateTable<ProjectAssets>();
			CreateTable<ProjectsTeam>();
		}

		public IEnumerable<T> GetItems<T> () where T : oPOP.Core.IBusinessEntity, new ()
		{
			lock (locker) {
				return (from i in Table<T>() select i).ToList();
			}
		}

		public T GetItem<T> (int id) where T : oPOP.Core.IBusinessEntity, new ()
		{
			lock (locker) {
				return Table<T>().FirstOrDefault(x => x.ID == id);
				// Following throws NotSupportedException - thanks aliegeni
				//return (from i in Table<T> ()
				//        where i.ID == id
				//        select i).FirstOrDefault ();
			}
		}

		public int AddUpdateItem<T> (T item) where T : oPOP.Core.IBusinessEntity
		{
			lock (locker) {
				if (item.ID != 0) {
					Update (item);
					return item.ID;
				} else {
					return Insert (item);
				}
			}
		}

		public int DeleteItem<T>(int id) where T : oPOP.Core.IBusinessEntity, new ()
		{
			lock (locker) {
				return Delete<T>(new T() { ID = id });
			}
		}
	}
}

