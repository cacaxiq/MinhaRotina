using System;
using SQLite;

namespace MInhaRotina
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

