using System;
using System.IO;
using Xamarin.Forms;
using MInhaRotina.iOS;
using SQLite;

[assembly: Dependency (typeof(SQLite_iOS))]

namespace MInhaRotina.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS ()
		{
		}

		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var fileName = "TodoSQLite.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, fileName);


			var connection = new SQLiteConnection (path);

			return connection;
		}

		#endregion
	}

}

