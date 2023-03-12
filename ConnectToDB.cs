using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Victoria_Brown_C969_PA.Database
{
	public class ConnectToDB
	{
		//conection string for SQL database
		public static string connectionString = ConfigurationManager.ConnectionStrings["MySQLDB"].ConnectionString;
		public static MySqlConnection conn { get; set; }

		//starting connection
		public static void startConnection()
		{
			try
			{
			
				conn = new MySqlConnection(connectionString);
					conn.Open();
				MessageBox.Show("Connection is open.");
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//closing connection
		public static void closeConnection()
		{
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
				conn = null;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		
		//new connection
		public static MySqlConnection newConnection()
		{
			MySqlConnection conn = new MySqlConnection(connectionString);
			try
			{
				conn.Open();
				return conn;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return null;
		}
	}

}
