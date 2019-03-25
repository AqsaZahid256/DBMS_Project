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
	public partial class Mark_Attendence : Form
	{
		public Mark_Attendence()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Attendence s = new Attendence();
				s.set_Registration_No(Std_Name.Text);
				s.set_Attendence_Date(dateTimePicker1.Value);
				s.set_Student_Status(comboBox1.Text);

				if ((s.get_Registration_No() == "" || (s.get_Attendence_Date() == null)) || (s.get_Student_Status() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();
					string s1 = string.Format("INSERT INTO ClassAttendance(AttendanceDate) values('" + s.get_Attendence_Date() + "' )");
					SqlCommand y = new SqlCommand(s1, c);
					int ros = y.ExecuteNonQuery();


					string s2 = string.Format("SELECT Id FROM Student WHERE RegistrationNumber =@RegistrationNumber");
					SqlCommand a = new SqlCommand(s2, c);
					a.Parameters.Add(new SqlParameter("@RegistrationNumber",s.get_Registration_No()));
					//a.Parameters.Add(new SqlParameter("@Name", this.Registration_Number.Text));
					int id = (int)a.ExecuteScalar();

					string s3 = string.Format("SELECT LookupId FROM Lookup WHERE Category=@Category and Name =@Name");
					SqlCommand b = new SqlCommand(s3, c);
					b.Parameters.Add(new SqlParameter("@Category", "ATTENDANCE_STATUS"));
					b.Parameters.Add(new SqlParameter("@Name", s.get_Student_Status()));
					int id1 = (int)b.ExecuteScalar();

					string s5 = string.Format("SELECT MAX(Id) FROM ClassAttendance");
					SqlCommand d = new SqlCommand(s5, c);
					int id4 = (int)d.ExecuteScalar();

					string s4 = string.Format("INSERT INTO StudentAttendance(StudentId,AttendanceId,AttendanceStatus) values('" + id + "','" + id4 + "','" + id1 + "')");
					SqlCommand a2 = new SqlCommand(s4, c);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0 && ros != 0)
					{
						MessageBox.Show("Attendence Added");
						this.Close();
						//Manage_Clo h = new Manage_Clo();
						//h.Show();
					}
					c.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
