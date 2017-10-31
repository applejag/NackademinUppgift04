using System;
using System.Data;
using System.Data.SqlClient;

namespace Adressbok.DAL
{
	public class DataAccess : IDisposable
	{
		private readonly SqlConnection conn;

		public DataAccess()
		{
			string setting = Properties.Settings.Default.Adressbok2ConnectionString;
			conn = new SqlConnection(setting);
			conn.Open();
		}

		public int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
		{
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(parameters);
				return cmd.ExecuteNonQuery();
			}
		}

		public DataSet ExecuteSelectCommand(string commandText, params SqlParameter[] parameters)
		{
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(parameters);
				
				using (var adapter = new SqlDataAdapter(cmd))
				{
					var set = new DataSet();
					adapter.Fill(set);
					return set;
				}
			}
		}

		~DataAccess()
		{
			Dispose();
		}

		public void Dispose()
		{
			conn?.Dispose();
		}
	}
}