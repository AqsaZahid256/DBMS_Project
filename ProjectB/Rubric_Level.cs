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
	public partial class Rubric_Level : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		public Rubric_Level()
		{
			InitializeComponent();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			//SqlCommand com = new SqlCommand(, c);
			SqlDataAdapter da = new SqlDataAdapter("select Details FROM Rubric", c);
			DataTable t = new DataTable();
			da.Fill(t);
			comboBox1.DisplayMember = "Details";
			comboBox1.DataSource = t;
			//SqlDataReader dr = com.ExecuteReader();



			c.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if ((comboBox1.Text == "") || (comboBox2.Text == "") || (Details.Text == ""))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					SqlConnection c = new SqlConnection(constr);
					c.Open();

					string s3 = string.Format("Select Id from Rubric where Details=@Details");
					SqlCommand a3 = new SqlCommand(s3, c);
					a3.Parameters.AddWithValue("@Details", comboBox1.Text);
					int rows = (int)a3.ExecuteScalar();
					string s2 = string.Format("INSERT INTO RubricLevel(Details,MeasurementLevel, RubricId) values('" + Details.Text + "','" + comboBox2.Text + "','" + rows +"')");
					SqlCommand a2 = new SqlCommand(s2, c);
					int rows1 = a2.ExecuteNonQuery();
					if (rows1 != 0)
					{
						MessageBox.Show("Rubric Added");
						this.Close();
						//Manage_Rubrics t = new Manage_Rubrics();
						//t.Show();
					}
					c.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
