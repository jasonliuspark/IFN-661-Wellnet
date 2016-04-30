using System;
using System.IO;
using Xamarin.Forms;
using SQLite;

namespace wellnet.Droid
{
	[assembly:Dependency (typeof(DB_android))]
	public class DB_android:ISQLite
	{
		public DB_android (){}
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqlFilename="wellnet.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath,sqlFilename);
			var conn = new SQLiteConnection (path);
			return conn;
		}

	}
}

