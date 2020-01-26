using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsAppDataReader
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			string constr = @"Server=DESKTOP-I43KRTU\MSSQLSERVER2019;Database=Northwind;Trusted_Connection=True";

			SqlConnection conn = new SqlConnection(constr);
			conn.Open();

			string cmdText = "SELECT CategoryID,CategoryName,Description,Picture FROM Categories";

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
						//WriteLine(reader[0].ToString());
						cmbKategoriID.Items.Add(reader[0]);
						lsbCategoryName.Items.Add(reader[1]);
						lsbDescription.Items.Add(reader[2]);
						lsbPictures.Items.Add(reader[3].ToString());
						
						
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

		}
	}
}
