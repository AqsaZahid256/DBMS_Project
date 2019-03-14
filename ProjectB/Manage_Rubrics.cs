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
	public partial class Manage_Rubrics : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Manage_Rubrics()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/**try
			{
				Manage_Rubrics s = new Manage_Rubrics();
				s.set_Details(Details.Text);
				s.set_CloId(CloId.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
	**/
		}

		private void Manage_Rubrics_Load(object sender, EventArgs e)
		{
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			string s2 = string.Format("SELECT Id,CloId,Details FROM Rubric");
			SqlCommand d = new SqlCommand(s2, c);
			SqlDataReader dr = d.ExecuteReader();
			try
			{
				while (dr.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = dr.GetValue(0);
					dataGridView1.Rows[n].Cells[1].Value = dr.GetValue(1);
					dataGridView1.Rows[n].Cells[2].Value = dr.GetString(2);
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

					int Reg = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
					
					string Id = string.Format("DELETE FROM Rubric WHERE Id=@Id");
					SqlCommand p = new SqlCommand(Id, conn);
					p.Parameters.AddWithValue("@Id", Reg);
					int i = p.ExecuteNonQuery();
					if (i != 0)
					{
						MessageBox.Show("Data deleted");
					}

				}
				this.Hide();
				Manage_Rubrics d1 = new Manage_Rubrics();
				d1.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
	
}
