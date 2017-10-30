using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Adressbok.DAL
{
	internal static class DataAccess
	{
		private static readonly string connectionString;

		static DataAccess()
		{
			connectionString = Properties.Settings.Default.SQLConnection;
		}

		public static async Task<bool> ExecuteNonQueryAsync(string commandText, params SqlParameter[] param)
		{
			using (var conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(param);

				await conn.OpenAsync();
				return await cmd.ExecuteNonQueryAsync() >= 1;
			}
		}

		public static async Task<DataTable> ExecuteSelectCommandAsync(string commandText, params SqlParameter[] param)
		{
			using (var conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(param);

				var table = new DataTable();

				await conn.OpenAsync();
				using (var da = new SqlDataAdapter(cmd))
				{
					da.Fill(table);
				}

				return table;
			}
		}

	}
}