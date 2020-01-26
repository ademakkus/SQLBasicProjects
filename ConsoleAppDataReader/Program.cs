using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Console;
using static System.ConsoleColor;
namespace ConsoleAppDataReader
{
	class Program
	{
		static void Main(string[] args)
		{
			
			//string constr = "Data Source=.;Initial Catalog=Northwind;Integrated Security=true";
			//string constr = "Data Source=.;Initial Catalog=Northwind;Integrated Security=true";
			string constr = @"Server=DESKTOP-I43KRTU\MSSQLSERVER2019;Database=Northwind;Trusted_Connection=True";
			
			SqlConnection conn = new SqlConnection(constr);
			conn.Open();
			
			string cmdText = "SELECT CategoryName FROM Categories";
			
			SqlCommand cmd = new SqlCommand(cmdText, conn);

			if (conn.State != ConnectionState.Open)
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			
			
				try
				{
				if (reader.HasRows)
				{
						while (reader.Read())
						{
							WriteLine(reader[0].ToString());
						}
					}
				
				}
				catch (Exception exc)
				{

					throw exc;
				}
				finally
				{

					reader.Close();
					conn.Close();
					conn.Dispose();
					cmd.Dispose();
				}
			
			ReadKey();
		}
	}
}
