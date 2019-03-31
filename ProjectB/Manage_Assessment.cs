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
	public partial class Manage_Assessment : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Manage_Assessment()
		{
				InitializeComponent();
				panel4.Hide();
			panel1.Hide();
				SqlConnection c = new SqlConnection(constr);
				c.Open();
				string s2 = string.Format("SELECT Title,DateCreated,TotalMarks,TotalWeightage, Id FROM Assessment");
				SqlCommand d = new SqlCommand(s2, c);
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{
						int n = dataGridView1.Rows.Add();
						dataGridView1.Rows[n].Cells[1].Value = dr.GetString(0);
					    dataGridView1.Rows[n].Cells[2].Value = dr.GetDateTime(1);
					    dataGridView1.Rows[n].Cells[3].Value = dr.GetValue(2);
					    dataGridView1.Rows[n].Cells[4].Value = dr.GetValue(3);
					    dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(4);
					    
						
						
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

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Manage_Assessment_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
		{
			string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
			SqlConnection conn = new SqlConnection(constr);
			conn.Open();
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
			{
				try
				{
					MessageBox.Show("you are going to delete this row");
					int Reg = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
					string Id = string.Format("DELETE FROM Assessment WHERE Id=@Id");
					SqlCommand p = new SqlCommand(Id, conn);
					p.Parameters.AddWithValue("@Id", Reg);
					int i = p.ExecuteNonQuery();
					if (i != 0)
					{
						MessageBox.Show("Data deleted");
						
						this.Hide();
						Manage_Assessment m = new Manage_Assessment();
						m.Show();
						//StudentGrid d1 = new StudentGrid();
						//d1.Show();
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
				SqlConnection c = new SqlConnection(constr);
				c.Open();
				panel4.Show();
				int f = dataGridView1.CurrentCell.RowIndex;
				int id4 = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
				//MessageBox.Show("Updating this entry");

				string s2 = string.Format("SELECT Title,DateCreated,TotalMarks,TotalWeightage FROM Assessment Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, c);
				d.Parameters.Add(new SqlParameter("@Id", id4));
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{
						textBox5.Text = dr.GetString(0);
						dateTimePicker1.Value = (DateTime)dr.GetValue(1);
						textBox3.Text = Convert.ToString(dr.GetValue(2));
						textBox2.Text = Convert.ToString(dr.GetValue(3));

					}
					dr.Close();
					panel4.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		
			else if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1" && (e.RowIndex >= 0))
			{
				SqlConnection c = new SqlConnection(constr);
				c.Open();
				//panel4.Show();
				int f = dataGridView1.CurrentCell.RowIndex;
				int id4 = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
				//MessageBox.Show("Updating this entry");

				string s2 = string.Format("SELECT DateCreated,TotalMarks FROM Assessment Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, c);
				d.Parameters.Add(new SqlParameter("@Id", id4));
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{
						//textBox5.Text = dr.GetString(0);
						dateTimePicker1.Value = (DateTime)dr.GetValue(0);
					    textBox1.Text = Convert.ToString(dr.GetValue(1));
						//comboBox3.Text = Convert.ToString(dr.GetValue(2));

					}
					dr.Close();

					SqlConnection b = new SqlConnection(constr);
					b.Open();
					SqlDataAdapter da = new SqlDataAdapter("select Id FROM Rubric", b);
					DataTable t = new DataTable();
					da.Fill(t);
					comboBox2.DisplayMember = "Id";
					comboBox2.DataSource = t;

					panel1.Show();
					b.Close();


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
				if ((textBox5.Text == "") || (dateTimePicker1.Value == null) || (textBox3.Text == "") || (textBox2.Text == ""))
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

					string s1 = string.Format("UPDATE Assessment SET Title=@Title, DateCreated=@DateCreated,TotalMarks=@TotalMarks,TotalWeightage=@TotalWeightage where Id=@Id");

					//values('" + s.get_FirstName() + "',  '" + s.get_LastName() + "','" + s.get_Contact() + "','" + s.get_Email() + "','" + s.get_Registration_No() + "','" + id + "')");

					//string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", s.get_FirstName(), s.get_LastName(), s.get_Contact(), s.get_Email(), s.get_Registration_No(), id);
					SqlCommand a2 = new SqlCommand(s1, c);
					//GetExample(a2, p.ToArray());

					a2.Parameters.Add(new SqlParameter("Id", id4));

					a2.Parameters.Add(new SqlParameter("@Title", SqlDbType.VarChar));
					a2.Parameters["@Title"].Value = textBox5.Text;
					a2.Parameters.Add(new SqlParameter("@DateCreated", SqlDbType.DateTime));
					a2.Parameters["@DateCreated"].Value = dateTimePicker1.Value;
					a2.Parameters.Add(new SqlParameter("@TotalMarks", SqlDbType.VarChar));
					a2.Parameters["@TotalMarks"].Value = textBox3.Text;
					a2.Parameters.Add(new SqlParameter("@Totalweightage", SqlDbType.VarChar));
					a2.Parameters["@TotalWeightage"].Value = textBox2.Text;

					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Assesement Updated");
						c.Close();
						panel4.Hide();
						this.Close();
						Manage_Assessment j = new Manage_Assessment();
						j.Show();
					}

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if ((TitleName.Text == "") || (dateTimePicker3.Value == null) || (textBox1.Text == "") || (comboBox2.Text == null) || (dateTimePicker2.Value == null))
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

					string s2 = string.Format("INSERT INTO AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + TitleName.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + dateTimePicker3.Value+ "','" + dateTimePicker2.Value + "','" + id4+"')");
					SqlCommand a2 = new SqlCommand(s2, c);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Component Added");
						panel1.Hide();
				
					}
					c.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//this.Hide();
			panel4.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//this.Hide();
			panel1.Hide();
		}
	}
}
