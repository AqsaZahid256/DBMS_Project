using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
	public partial class Manage_Clo : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Manage_Clo()
		{
			InitializeComponent();
		}

		private void Manage_Clo_Load(object sender, EventArgs e)
		{
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			string s2 = string.Format("SELECT Id,Name,DateCreated,DateUpdated FROM Clo");
			SqlCommand d = new SqlCommand(s2, c);
			SqlDataReader dr = d.ExecuteReader();
			try
			{
				while (dr.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = dr.GetValue(0);
					dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
					dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(2);
					dataGridView1.Rows[n].Cells[3].Value = dr.GetValue(3);
				}
				c.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
				{
					MessageBox.Show("you are going to delete this row");
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection conn = new SqlConnection(constr);
					conn.Open();
					int i = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

					string s3 = string.Format("Select Id from Rubric where CloId=@Id");
					SqlCommand a3 = new SqlCommand(s3, conn);
					a3.Parameters.Add(new SqlParameter("Id", i));

					if (a3.ExecuteScalar() != null)
					{
						int rows2 = (int)a3.ExecuteScalar();
						if (rows2 != 0 || rows2 != null)
						{

							string Id = string.Format("DELETE FROM Rubric WHERE CloId=@Id");
							SqlCommand p = new SqlCommand(Id, conn);
							p.Parameters.AddWithValue("@Id", i);
							int iu = p.ExecuteNonQuery();
							string Id2 = string.Format("DELETE FROM Clo WHERE Id=@Id");

							SqlCommand p1 = new SqlCommand(Id2, conn);
							p1.Parameters.AddWithValue("@Id", i);
							int c = p1.ExecuteNonQuery();
							if (c != 0 && iu != 0)
							{
								MessageBox.Show("Data deleted");
								conn.Close();
							}
						}
					}
					else
					{
						string Id3 = string.Format("DELETE FROM Clo WHERE Id=@Id");

						SqlCommand p2 = new SqlCommand(Id3, conn);
						p2.Parameters.AddWithValue("@Id", i);
						int l = p2.ExecuteNonQuery();
						if (l != 0)
						{
							MessageBox.Show("Data deleted");
							conn.Close();
						}
					}
				}
				

				this.Hide();
				Manage_Clo d1 = new Manage_Clo();
				d1.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

	}
}
