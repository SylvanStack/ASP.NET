using System;

namespace LibraryMIS.database
{
	/// <summary>
	/// dbConnection 的摘要说明。
	/// </summary>
	public class dbConnection
	{
		public dbConnection()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static string connection
		{
			get
			{return"Data Source=libraryMIS.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;";}
		}
	}
}
