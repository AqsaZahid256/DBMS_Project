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
	public partial class Manage_Rubric : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Manage_Rubric()
		{
			InitializeComponent();
			panel4.Hide();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			string s2 = string.Format("SELECT r.Id ,a.Details,r.MeasurementLevel,r.Details FROM RubricLevel r Inner Join Rubric a ON a.Id = r.RubricId");
			SqlCommand d = new SqlCommand(s2, c);
			SqlDataReader dr = d.ExecuteReader();
			try
			{
				while (dr.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
					dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
					dataGridView1.Rows[n].Cells[2].Value = (int)dr.GetValue(2);
					dataGridView1.Rows[n].Cells[3].Value = dr.GetString(3);
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

					string Id = string.Format("DELETE FROM RubricLevel WHERE Id=@Id");
					SqlCommand p = new SqlCommand(Id, conn);
					p.Parameters.AddWithValue("@Id", Reg);
					int i = p.ExecuteNonQuery();
					if (i != 0)
					{
						MessageBox.Show("Data deleted");
						this.Hide();
						Manage_Rubric d1 = new Manage_Rubric();
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


				//int f = dataGridView1.CurrentCell.RowIndex;
				int id4 = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
				//MessageBox.Show("Updating this entry");
				/**SqlDataAdapter da = new SqlDataAdapter("select Id FROM Clo", conn);
				DataTable t = new DataTable();
				da.Fill(t);
				comboBox1.DisplayMember = "id";
				comboBox1.DataSource = t;
				//SqlDataReader dr = com.ExecuteReader();**/

				string s2 = string.Format("SELECT Details, MeasurementLevel, RubricId from RubricLevel where Id=@Id");
				//string s2 = string.Format("SELECT Details,MeasurementLevel FROM RubricLevel Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, conn);
				d.Parameters.Add(new SqlParameter("@Id", id4));
				SqlDataReader dr = d.ExecuteReader();
				comboBox2.Items.Clear();
	
				try
				{
					int h = 0;
					while (dr.Read())
					{
						
						//comboBox1.Text = dr.GetString(0);
						comboBox2.Text = Convert.ToString(dr.GetValue(1));
						textBox3.Text = dr.GetString(0);
						h = (int)dr.GetValue(2);


					}
					dr.Close();

					comboBox1.Items.Clear();
					string sg = string.Format("SELECT Details From Rubric");
					SqlCommand db = new SqlCommand(sg, conn);
					//db.Parameters.Add(new SqlParameter("@id", h));
					//SqlDataReader dr = d.ExecuteReader();
					dr = db.ExecuteReader();
					while (dr.Read())
					{
						comboBox1.Items.Add(dr.GetString(0));
					}
					
					panel4.Show();
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

				if ((comboBox1.Text == "") || (comboBox2.Text == "") || (textBox3.Text == ""))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{

					int f = dataGridView1.CurrentCell.RowIndex;
					int id4 = (int)(dataGridView1.Rows[f].Cells["Id"].Value);
					string sg = string.Format("SELECT Id From Rubric where  Details=@Details");
					SqlCommand db = new SqlCommand(sg, c);
					string d = "";
					d = comboBox1.Text;
					db.Parameters.Add(new SqlParameter("@Details", d));
					int g = (int)db.ExecuteScalar();
					//comboBox1.Text = g;


					string s1 = string.Format("UPDATE RubricLevel SET Details=@Details, MeasurementLevel=@MeasurementLevel, RubricId=@RubricId where Id=@Id");
					
					


					SqlCommand a2 = new SqlCommand(s1, c);

					a2.Parameters.Add(new SqlParameter("@Id", id4));

					a2.Parameters.Add(new SqlParameter("@Details", SqlDbType.VarChar));
					a2.Parameters["@Details"].Value = textBox3.Text;
					a2.Parameters.Add(new SqlParameter("@MeasurementLevel", SqlDbType.Int));
					a2.Parameters["@MeasurementLevel"].Value = Convert.ToInt16(comboBox2.Text);
					a2.Parameters.Add(new SqlParameter("@RubricId", SqlDbType.Int));
					a2.Parameters["@RubricId"].Value = g;

					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("RubricsLevel Updated");
						c.Close();
						panel4.Hide();
						this.Close();
						Manage_Rubric j = new Manage_Rubric();
						j.Show();
					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
