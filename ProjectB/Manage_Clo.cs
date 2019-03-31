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
			panel1.Hide();
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
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
			{
				try
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
						if (rows2 != 0 )
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
							

							this.Hide();
							Manage_Clo d1 = new Manage_Clo();
							d1.Show();
						}
						conn.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && (e.RowIndex >= 0))
			{
				SqlConnection c = new SqlConnection(constr);
				c.Open();
				panel1.Show();
				int f = dataGridView1.CurrentCell.RowIndex;
				int id4 = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
				//MessageBox.Show("Updating this entry");

				string s2 = string.Format("SELECT Name,DateCreated,DateUpdated FROM Clo Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, c);
				d.Parameters.Add(new SqlParameter("@Id", id4));
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{
						text1.Text = dr.GetString(0);
						dateTimePicker3.Value = (DateTime)dr.GetValue(1);
						dateTimePicker4.Value = (DateTime)dr.GetValue(2);

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
				MessageBox.Show("No data Here");
			}



		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				CLO s = new CLO();
				s.set_Name(text1.Text);
				s.set_Data_Created(dateTimePicker3.Value);
				s.set_Data_Updated(dateTimePicker4.Value);
				
				if ((s.get_Name() == null || s.get_Name() =="") || (s.get_Data_Created() == null) || (s.get_Data_Updated() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();
					int f = dataGridView1.CurrentCell.RowIndex;
					int id4 = (int)(dataGridView1.Rows[f].Cells["Id"].Value);
					//MessageBox.Show("Updating this entry"

					string s1 = string.Format("UPDATE clo SET Name=@Name, DateCreated=@DateCreated,DateUpdated=@DateUpdated where Id=@Id");

					//values('" + s.get_FirstName() + "',  '" + s.get_LastName() + "','" + s.get_Contact() + "','" + s.get_Email() + "','" + s.get_Registration_No() + "','" + id + "')");

					//string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", s.get_FirstName(), s.get_LastName(), s.get_Contact(), s.get_Email(), s.get_Registration_No(), id);
					SqlCommand a2 = new SqlCommand(s1, c);
					//GetExample(a2, p.ToArray());

					a2.Parameters.Add(new SqlParameter("Id", id4));

					a2.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
					a2.Parameters["@Name"].Value = s.get_Name();
					a2.Parameters.Add(new SqlParameter("@DateCreated", SqlDbType.DateTime));
					a2.Parameters["@DateCreated"].Value = s.get_Data_Created();
					a2.Parameters.Add(new SqlParameter("@DateUpdated", SqlDbType.DateTime));
					a2.Parameters["@DateUpdated"].Value = s.get_Data_Updated();
				
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("CLO Updated");
						c.Close();
						panel1.Hide();
						this.Close();
						Manage_Clo j = new Manage_Clo();
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
			panel1.Hide();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
