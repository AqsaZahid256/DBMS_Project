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
	public partial class Assessment : Form
	{
		public Assessment()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			try
			{
				Add_Assessment s = new Add_Assessment();
				s.set_Title(TitleName.Text);
				s.set_Date_Created(dateTimePicker1.Value);
				s.set_Total_Marks(Marks.Text);
				s.set_Total_Weightage(Weightage.Text);
				if ((s.get_Title() == "") || (s.get_Date_Created() == null) || (s.get_Total_Marks() == 0 || (s.get_Total_Weightage() == 0)))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();


					string s1 = string.Format("INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage) values('" + s.get_Title() + "',  '" + s.get_Date_Created() + "','" + s.get_Total_Marks() + "','" + s.get_Total_Weightage() + "')");

					//string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", s.get_FirstName(), s.get_LastName(), s.get_Contact(), s.get_Email(), s.get_Registration_No(), id);
					SqlCommand a2 = new SqlCommand(s1, c);
					//int rows = DatabaseConnection.getInstance().exectuteQuery(s1);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Added");
						this.Close();
						//StudentGrid n = new StudentGrid();
						//n.Show();
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
			Manage_Assessment m = new Manage_Assessment();
			this.Close();
			m.Show();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
