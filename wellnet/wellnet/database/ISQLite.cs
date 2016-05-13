using System;
using SQLite;

namespace wellnet
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

