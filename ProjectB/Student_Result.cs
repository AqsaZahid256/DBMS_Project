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
	public partial class Student_Result : Form
	{

		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";

		public Student_Result()
		{
			InitializeComponent();
			//mark.Hide();
			
			panel3.Hide();
			panel1.Hide();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			string s2 = string.Format("SELECT Id,FirstName,LastName,RegistrationNumber FROM STUDENT");
			SqlCommand d = new SqlCommand(s2, c);
			SqlDataReader dr = d.ExecuteReader();
			try
			{
				while (dr.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
					dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1) + dr.GetString(2);
					dataGridView1.Rows[n].Cells[2].Value = dr.GetString(3);

				}
				c.Close();
				dr.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlConnection c = new SqlConnection(constr);
			int Reg = (int)(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
			textBox1.Text = Convert.ToString(Reg);
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Mark_Assessment" && (e.RowIndex >= 0))
			{
				try
				{
					c.Open();
					SqlDataAdapter da1 = new SqlDataAdapter("SELECT Title FROM Assessment", c);
					DataTable g1 = new DataTable();
					da1.Fill(g1);
					da1.Dispose();

					comboBox5.DisplayMember = "Title";
					comboBox5.DataSource = g1;
					panel3.Show();
					//dataGridView1.Rows[e.RowIndex].Cells[2]. = ;
				}
				catch (Exception ex)
				{
					MessageBox.Show("");
				}
			}
			if (dataGridView1.Columns[e.ColumnIndex].Name == "" && (e.RowIndex >= 0))
			{

			}
		}

		private void Updation_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void mark_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlConnection c = new SqlConnection(constr);
			try
			{
				if (comboBox5.Text != "")
				{
					c.Open();
					string gv = string.Format("SELECT Id FROM Assessment WHERE Title=@Title ");
					SqlCommand p = new SqlCommand(gv, c);
					p.Parameters.AddWithValue("@Title", comboBox5.Text);
					int i = (int)p.ExecuteScalar();


					SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM AssessmentComponent WHERE AssessmentId=@AssessmentId", c);
					da.SelectCommand.Parameters.AddWithValue("@AssessmentId", i);
					DataTable g = new DataTable();
					da.Fill(g);

					if (g.Rows.Count > 0)
					{

						da.Dispose();
						name.DisplayMember = "Name";
						name.DataSource = g;
						SqlCommand da2 = new SqlCommand("SELECT RubricId FROM AssessmentComponent WHERE AssessmentId=@AssessmentId ", c);
						da2.Parameters.AddWithValue("@AssessmentId", i);
						int k = (int)da2.ExecuteScalar();
						textBox2.Text = Convert.ToString(k);

						comboBox3.Items.Clear();
						comboBox2.Items.Clear();

						string u = String.Format("Select Details, MeasurementLevel From RubricLevel where RubricId=@RubricId ");
						SqlCommand d = new SqlCommand(u, c);
						d.Parameters.AddWithValue("@RubricId", k);
						SqlDataReader q = d.ExecuteReader();
						while (q.Read())
						{
							comboBox3.Items.Add(q.GetString(0));
							comboBox2.Items.Add((int)q.GetValue(1));
						}
						q.Close();
						panel3.Hide();
						panel1.Show();

						/**SqlDataAdapter da1 = new SqlDataAdapter("SELECT Measur FROM AssessmentComponent", c);
						DataTable g1 = new DataTable();
						da1.Fill(g1);
						da1.Dispose();
						name.DisplayMember = "MeasurementLevel";
						name.DataSource = g1;**/
					}
					else
					{
						MessageBox.Show("Assessment Component Does not Exist");
					}
				}
				else
				{
					MessageBox.Show("Submission is not allowed with null values");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		} 
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox2.Text != "" && comboBox3.Text != "" && name.Text != "" && name.Text != null)
				{
					SqlConnection c = new SqlConnection(constr);
					c.Open();
					string g = string.Format("Select Id from AssessmentComponent where Name=@Name and RubricId=@RubricId");
					SqlCommand f = new SqlCommand(g, c);
					f.Parameters.AddWithValue("@Name", name.Text);
					f.Parameters.AddWithValue("@RubricId", Convert.ToInt16(textBox2.Text));
					int d = (int)f.ExecuteScalar();

					string g1 = string.Format("Select Id from RubricLevel where Details=@Details and RubricId=@RubricId");
					SqlCommand f1 = new SqlCommand(g1, c);
					f1.Parameters.AddWithValue("@Details", comboBox3.Text);
					f1.Parameters.AddWithValue("@RubricId", Convert.ToInt16(textBox2.Text));

					int d1 = (int)f1.ExecuteScalar();

					string g2 = string.Format("Insert INTO StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values('" + Convert.ToInt16(textBox1.Text) + "','" + d + "','" + d1 + "','" + DateTime.Now + "')");
					SqlCommand f2 = new SqlCommand(g1, c);
					int d2 = f1.ExecuteNonQuery();
					if (d2 != 0)
					{
						MessageBox.Show("Marked");
						panel1.Hide();
					}


				}
				else
				{
					MessageBox.Show("Submission is not allowed with null values");
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
	}
}
