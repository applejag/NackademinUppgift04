using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Adressbok.DAL
{
	internal static class DataAccess
	{
		private static readonly SqlConnection _conn;

		static DataAccess()
		{
			string setting = Properties.Settings.Default.SQLConnection;
			_conn = new SqlConnection(setting);
		}

		public static async Task<bool> ExecuteNonQueryAsync(string commandText, params SqlParameter[] param)
		{
			using (_conn)
			using (SqlCommand cmd = _conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(param);

				await _conn.OpenAsync();
				return await cmd.ExecuteNonQueryAsync() >= 1;
			}
		}

		public static async Task<DataTable> ExecuteSelectCommandAsync(string commandText, params SqlParameter[] param)
		{
			using (_conn)
			using (SqlCommand cmd = _conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(param);

				//var dataset = new DataSet();
				var table = new DataTable();

				await _conn.OpenAsync();
				using (var da = new SqlDataAdapter(cmd))
				{
					da.Fill(table);
				}

				//dataset.Tables.Add(table);
				return table;
			}
		}

	}
}