using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Adressbok.DAL
{
	public class DataAccess : IDisposable
	{
		private readonly SqlConnection conn;

		public DataAccess()
		{
			RetryFromHere:
			string setting = Properties.Settings.Default.AdressbokConnectionString;
			conn = new SqlConnection(setting);

			try
			{
				conn.Open();
			}
			catch
			{
				DialogResult result = MessageBox.Show("Failed to open connection to database!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				if (result == DialogResult.Retry)
					goto RetryFromHere;

				throw;
			}
		}

		public int ExecuteNonQuery(string commandText, params SqlParameter[] parameters)
		{
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(parameters);

				try
				{
					return cmd.ExecuteNonQuery();
				}
				catch
				{
					return 0;
				}
			}
		}

		public object ExecuteScalar(string commandText, params SqlParameter[] parameters)
		{
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(parameters);

				try
				{
					return cmd.ExecuteScalar();
				}
				catch
				{
					return null;
				}
			}
		}

		public DataTable ExecuteSelectCommand(string commandText, params SqlParameter[] parameters)
		{
			using (SqlCommand cmd = conn.CreateCommand())
			{
				cmd.CommandText = commandText;
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddRange(parameters);

				try
				{
					using (var adapter = new SqlDataAdapter(cmd))
					{
						var table = new DataTable();
						adapter.Fill(table);
						return table;
					}
				}
				catch
				{
					return null;
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