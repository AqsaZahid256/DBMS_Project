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
	public partial class Rubric : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
		
		private List<int> listitems = new List<int>();
		public List<int> Listitems1 { get => listitems; set => listitems = value; }
		public Rubric()
		{
			InitializeComponent();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			//SqlCommand com = new SqlCommand(, c);
			SqlDataAdapter da = new SqlDataAdapter("select Id FROM Clo", c);
			DataTable t = new DataTable();
			da.Fill(t);
			comboBox1.DisplayMember = "id";
			comboBox1.DataSource = t;
			//SqlDataReader dr = com.ExecuteReader();
			
			
			
				c.Close();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Add_Rubrics s = new Add_Rubrics();
				s.set_CloId(Convert.ToInt16(comboBox1.Text));
				s.set_Details(Details.Text);

				if ((s.get_CloId() == 0) || (s.get_Details() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					SqlConnection c = new SqlConnection(constr);
					c.Open();
					
					string s3 = string.Format("Select Id from Clo where Id=@Id");
					SqlCommand a3 = new SqlCommand(s3, c);
					//Listitems g = new Listitems();
					
					a3.Parameters.Add(new SqlParameter("Id", s.get_CloId()));
					if (a3.ExecuteScalar() != null)
					{
 						int rows2 = (int)a3.ExecuteScalar();
						if (rows2 != 0)
						{
							string s2 = string.Format("INSERT INTO Rubric(CloId,Details) values('" + s.get_CloId() + "','" + s.get_Details() + "')");
							SqlCommand a2 = new SqlCommand(s2, c);
							int rows = a2.ExecuteNonQuery();
							if (rows != 0)
							{
								MessageBox.Show("Rubric Added");
								this.Close();
								Manage_Rubrics t = new Manage_Rubrics();
								t.Show();
							}
							c.Close();
						}


					}
					else
					{
						MessageBox.Show("This CLO doesn't exist");
					}

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
			Manage_Rubrics c = new Manage_Rubrics();
			c.Show();
		}

		private void Rubric_Load(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
