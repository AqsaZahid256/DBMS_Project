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
	public partial class StudentGrid : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public StudentGrid()
		{
			InitializeComponent();
			panel1.Hide();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			string s2 = string.Format("SELECT FirstName,LastName,Contact,Email,RegistrationNumber,Status FROM STUDENT");
			SqlCommand d = new SqlCommand(s2, c);
			SqlDataReader dr = d.ExecuteReader();
			try
			{
				while (dr.Read())
				{
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = dr.GetString(0);
					dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
					dataGridView1.Rows[n].Cells[2].Value = dr.GetString(2);
					dataGridView1.Rows[n].Cells[3].Value = dr.GetString(3);
					dataGridView1.Rows[n].Cells[4].Value = dr.GetString(4);
					dataGridView1.Rows[n].Cells[5].Value = dr.GetValue(5);
					//dataGridView1.Rows[n].Cells[6].Value = (int)dr.GetValue(6);
				}
				c.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}



		}

		private void StudentGrid_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
			SqlConnection conn = new SqlConnection(constr);
			conn.Open();
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
			{
				try
				{
					MessageBox.Show("you are going to delete this row");


					string Reg = (string)(dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value);
					string Reg_No = string.Format("SELECT ID FROM STUDENT WHERE RegistrationNumber=@RegistrationNumber");
					SqlCommand o = new SqlCommand(Reg_No, conn);
					o.Parameters.Add(new SqlParameter("@RegistrationNumber", Reg));
					int t = (int)o.ExecuteScalar();
					string Id = string.Format("DELETE FROM STUDENT WHERE Id=@Id");
					SqlCommand p = new SqlCommand(Id, conn);
					p.Parameters.AddWithValue("@Id", t);
					int i = p.ExecuteNonQuery();
					if (i != 0)
					{
						MessageBox.Show("Data deleted");
						conn.Close();
						this.Hide();
						StudentGrid d1 = new StudentGrid();
						d1.Show();
					}

				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

			else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
			{
				//SqlConnection c = new SqlConnection(constr);
				//conn.Open();
				panel1.Show();
				int f = dataGridView1.CurrentCell.RowIndex;
				string id4 = (string)(dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value);
				//MessageBox.Show("Updating this entry");
				string Reg = (string)(dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value);
				string Reg_No = string.Format("SELECT Id FROM STUDENT WHERE RegistrationNumber=@RegistrationNumber");
				SqlCommand o = new SqlCommand(Reg_No, conn);
				o.Parameters.Add(new SqlParameter("@RegistrationNumber", Reg));
				int t = (int)o.ExecuteScalar();

				string s2 = string.Format("SELECT FirstName,LastName,Contact,Email,RegistrationNumber,Status FROM STUDENT Where Id=@Id");
				SqlCommand d = new SqlCommand(s2, conn);
				d.Parameters.Add(new SqlParameter("@Id", t));
				SqlDataReader dr = d.ExecuteReader();
				try
				{
					while (dr.Read())
					{
						textBox5.Text = dr.GetString(0);
						textBox4.Text = dr.GetString(1);
						textBox3.Text = dr.GetString(2);
						textBox2.Text = dr.GetString(3);
						textBox1.Text = dr.GetString(4);
						if ((int)dr.GetValue(5) == 5)
						{
							comboBox1.Text = "Active";
						}
						else
						{
							comboBox1.Text = "InActive";
						}



					}
					dr.Close();
					panel1.Show();
					/**
					string Reg = (string)(dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value);
					string Reg_No = string.Format("SELECT Id FROM STUDENT WHERE RegistrationNumber=@RegistrationNumber");
					SqlCommand o = new SqlCommand(Reg_No, c);
					o.Parameters.Add(new SqlParameter("@RegistrationNumber", Reg));
					int t = (int)o.ExecuteScalar();
					SqlCommand com = new SqlCommand("UPDATE STUDENT SET FirstName = @FirstName, LastName = @LastName,Contact = @Contact,Email =@Email,RegistrationNumber=@RegistrationNumber,Status=@Status WHERE Id ='" + t + "'");
					com.Parameters.Add("");
	**/
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
				Student s = new Student();
				s.set_FirstName(textBox5.Text);
				s.set_LastName(textBox4.Text);
				s.set_Registration_No(textBox1.Text);
				s.set_Contact(textBox3.Text);
				s.set_Email(textBox2.Text);
				s.set_Status(comboBox1.Text);
				if ((s.get_FirstName() == null) || (s.get_LastName() == null) || (s.get_Contact() == null) || (s.get_Registration_No() == null) || (s.get_Email() == null) || (s.get_Status() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();

					string s2 = string.Format("SELECT LookupId FROM Lookup WHERE Category=@Category and Name =@Name");
					SqlCommand a = new SqlCommand(s2, c);
					a.Parameters.Add(new SqlParameter("@Category", "STUDENT_STATUS"));
					a.Parameters.Add(new SqlParameter("@Name", this.comboBox1.Text));
					int id = (int)a.ExecuteScalar();

					int f = dataGridView1.CurrentCell.RowIndex;
					string id4 = (string)(dataGridView1.Rows[f].Cells["RegistrationNumber"].Value);
					//MessageBox.Show("Updating this entry");
					string Reg = (string)(dataGridView1.Rows[f].Cells["RegistrationNumber"].Value);
					string Reg_No = string.Format("SELECT Id FROM STUDENT WHERE RegistrationNumber=@RegistrationNumber");
					SqlCommand o = new SqlCommand(Reg_No, c);
					o.Parameters.Add(new SqlParameter("@RegistrationNumber", Reg));
					int t = (int)o.ExecuteScalar();

					string s1 = string.Format("UPDATE STUDENT SET FirstName=@FirstName, LastName=@LastName,Contact=@Contact,Email=@Email,RegistrationNumber=@RegistrationNumber,Status=@Status where Id=@Id");

					//values('" + s.get_FirstName() + "',  '" + s.get_LastName() + "','" + s.get_Contact() + "','" + s.get_Email() + "','" + s.get_Registration_No() + "','" + id + "')");

					//string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", s.get_FirstName(), s.get_LastName(), s.get_Contact(), s.get_Email(), s.get_Registration_No(), id);
					List<SqlParameter> p = new List<SqlParameter>();
					SqlCommand a2 = new SqlCommand(s1, c);
					//GetExample(a2, p.ToArray());
					
					a2.Parameters.Add(new SqlParameter("Id", t));

					a2.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar));
					a2.Parameters["@FirstName"].Value = s.get_FirstName();
					a2.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar));
					a2.Parameters["@LastName"].Value = s.get_LastName();
					a2.Parameters.Add(new SqlParameter("@Contact", SqlDbType.VarChar));
					a2.Parameters["@Contact"].Value = s.get_Contact();
					a2.Parameters.Add(new SqlParameter("@RegistrationNumber", SqlDbType.VarChar ));
					a2.Parameters["@RegistrationNumber"].Value = s.get_Registration_No();
					a2.Parameters.Add(new SqlParameter("@Status", SqlDbType.VarChar));
					a2.Parameters["@Status"].Value = id;
					a2.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
					a2.Parameters["@Email"].Value = s.get_Email();

					/**
					a2.Parameters.AddWithValue("@FirstName" , s.get_FirstName());
					a2.Parameters.AddWithValue("@LastName", s.get_LastName());
					a2.Parameters.AddWithValue("@ContactName", s.get_Contact());
					a2.Parameters.AddWithValue("@RegistrationNumber", s.get_Registration_No());
					a2.Parameters.AddWithValue("@Status", id);
					a2.Parameters.AddWithValue("@Email", s.get_Email());**/

					//int rows = DatabaseConnection.getInstance().exectuteQuery(s1);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Student Updated");
						panel1.Hide();
						StudentGrid m = new StudentGrid();
						m.Show();
						c.Close();
					}
					
				}

			}
			catch (Exception ex)
			{
				   MessageBox.Show(ex.Message);
			}

		}
		public void GetExample(SqlCommand command, params SqlParameter[] p)
{
  if (p != null && p.Any()){
        command.Parameters.AddRange(p);
   }

}

		private void button2_Click(object sender, EventArgs e)
		{
			panel1.Hide();
		}

		private void label9_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
