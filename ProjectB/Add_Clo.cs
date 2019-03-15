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
	public partial class Add_Clo : Form
	{
		public Add_Clo()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				CLO s = new CLO();
				s.set_Name(Name.Text);
				s.set_Data_Created(dateTimePicker1.Value);
				s.set_Data_Updated(dateTimePicker2.Value);

				if ((s.get_Name() == "" || (s.get_Name() == null))||(s.get_Data_Created()==null)||(s.get_Data_Updated()==null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();

					string s2 = string.Format("INSERT INTO Clo(Name,DateCreated,DateUpdated) values('" + s.get_Name() + "','" + s.get_Data_Created() + "','" + s.get_Data_Updated()+"')");
					SqlCommand a2 = new SqlCommand(s2, c);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("CLO Added");
						this.Close();
						Manage_Clo h = new Manage_Clo();
						h.Show();
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
			this.Close();
			Manage_Clo c = new Manage_Clo();
			c.Show();
		}

		private void Add_Clo_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
