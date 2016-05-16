using System;
using System.IO;
using Xamarin.Forms;
using wellnet;
using wellnet.Droid;
using SQLite;

[assembly:Dependency (typeof(DB_android))]
namespace wellnet.Droid
{	
	public class DB_android:ISQLite
	{
		public DB_android (){
			
		}
		#region db android implemtation
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqlFilename="wellnet.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath,sqlFilename);
			var conn = new SQLiteConnection (path);
			return conn;
		}
		#endregion
	}
}

