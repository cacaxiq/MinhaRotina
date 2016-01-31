using System;

namespace MInhaRotina
{
	public class SQLite : ISQLite
	{
		public SQLite ()
		{
		}

		public TodoItemDatabase() {
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<TodoItem>();
		}
	}
}

