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
	public partial class Assessment_cmp : Form
	{
		string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";

		private List<int> listitems = new List<int>();
		public List<int> Listitems1 { get => listitems; set => listitems = value; }
		public Assessment_cmp()
		{
			/**InitializeComponent();
			SqlConnection c = new SqlConnection(constr);
			c.Open();
			SqlDataAdapter da = new SqlDataAdapter("select Id FROM Rubric", c);
			DataTable t = new DataTable();
			da.Fill(t);
			comboBox2.DisplayMember = "Id";
			comboBox2.DataSource = t;
			SqlDataAdapter dd = new SqlDataAdapter("select TotalMarks FROM Assessment", c);
			DataTable a = new DataTable();
			dd.Fill(a);
			comboBox1.DisplayMember = "TotalMarks";
			comboBox1.DataSource = a;
			SqlDataAdapter db = new SqlDataAdapter("select Id FROM Assessment", c);
			DataTable b = new DataTable();
			da.Fill(b);
			comboBox3.DisplayMember = "Id";
			comboBox3.DataSource = b;
			c.Close();**/
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Assessment_cmp_Load(object sender, EventArgs e)
		{

		}
	}
}
