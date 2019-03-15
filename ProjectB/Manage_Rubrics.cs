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
			panel1.Hide();
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
			string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
			SqlConnection conn = new SqlConnection(constr);
			conn.Open();
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
			{
				try
				{
					MessageBox.Show("you are going to delete this row");
					
					

					int Reg = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

					string Id = string.Format("DELETE FROM Rubric WHERE Id=@Id");
					SqlCommand p = new SqlCommand(Id, conn);
					p.Parameters.AddWithValue("@Id", Reg);
					int i = p.ExecuteNonQuery();
					if (i != 0)
					{
						MessageBox.Show("Data deleted");
						this.Hide();
						Manage_Rubrics d1 = new Manage_Rubrics();
						d1.Show();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				conn.Close();
			}
			else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && (e.RowIndex >= 0))
			{
				
				
				int f = dataGridView1.CurrentCell.RowIndex;
				int id4 = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
				//MessageBox.Show("Updating this entry");
				SqlDataAdapter da = new SqlDataAdapter("select Id FROM Clo", conn);
				DataTable t = new DataTable();
				da.Fill(t);
				comboBox1.DisplayMember = "id";
				comboBox1.DataSource = t;
				//SqlDataReader dr = com.ExecuteReader();


				string s2 = string.Format("SELECT CloId,Details FROM Rubric Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, conn);
				d.Parameters.Add(new SqlParameter("@Id", id4));
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{

						comboBox1.Text = (Convert.ToString(dr.GetValue(0)));
						Deta.Text = dr.GetString(1);


					}
					dr.Close();
					panel1.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("No Rows Availiable");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			try
			{
				Add_Rubrics  s = new Add_Rubrics();
				s.set_CloId(Convert.ToInt16(comboBox1.Text));
				s.set_Details(Deta.Text);

				if ((s.get_CloId() == 0) || (s.get_Details() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					
					int f = dataGridView1.CurrentCell.RowIndex;
					int id4 = (int)(dataGridView1.Rows[f].Cells["Id"].Value);

					string s1 = string.Format("UPDATE Rubric SET CloId=@CloId, Details=@Details where Id=@Id");
					SqlCommand a2 = new SqlCommand(s1, c);
					
					a2.Parameters.Add(new SqlParameter("Id", id4));

					a2.Parameters.Add(new SqlParameter("@CloId", SqlDbType.Int));
					a2.Parameters["@CloId"].Value = s.get_CloId();
					a2.Parameters.Add(new SqlParameter("@Details", SqlDbType.VarChar));
					a2.Parameters["@Details"].Value = s.get_Details();

					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Rubrics Updated");
						c.Close();
						panel1.Hide();
						this.Close();
						Manage_Rubrics j = new Manage_Rubrics();
						j.Show();
					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			panel1.Hide();
		}
	}
}
