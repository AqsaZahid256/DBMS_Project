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
	public partial class Student_Data : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Student_Data()
		{
			InitializeComponent();



		}

		private void Student_Data_Load(object sender, EventArgs e)
		{

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
					}

				}
				this.Hide();
				Student_Data d1 = new Student_Data();
				d1.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			/**if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
			{

				SqlConnection c = new SqlConnection(constr);
				c.Open();
				DialogResult res;
				res = MessageBox.Show("Are you sure want to update?", "Conformation", MessageBoxButtons.YesNo);
				if (res == System.Windows.Forms.DialogResult.Yes)
				{
					//Edit_Student u = new Edit_Student();
					//u.Show();

					//Auto filling code
					SqlConnection c = new SqlConnection(constr);
					c.Open();
					string s2 = string.Format("SELECT FirstName,LastName,Contact,Email,RegistrationNumber,Status FROM STUDENT");
					SqlCommand d = new SqlCommand(s2, c);
					SqlDataReader dr = d.ExecuteReader();
					try
					{
						while (dr.Read())
						{
							Edit_Student u = new Edit_Student();
							u.FirstName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

						}


						string Reg = (string)(dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value);
						string Reg_No = string.Format("SELECT Id FROM STUDENT WHERE RegistrationNumber=@RegistrationNumber");
						SqlCommand o = new SqlCommand(Reg_No, c);
						o.Parameters.Add(new SqlParameter("@RegistrationNumber", Reg));
						int t = (int)o.ExecuteScalar();
						SqlCommand com = new SqlCommand("UPDATE STUDENT SET FirstName = @FirstName, LastName = @LastName,Contact = @Contact,Email =@Email,RegistrationNumber=@RegistrationNumber,Status=@Status WHERE Id ='" + t + "'");
						com.Parameters.Add

				}
			}**/
		}

	}
}
