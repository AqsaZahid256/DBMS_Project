using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
	public partial class AssessmentResult : Form
	{
		public AssessmentResult()
		{
			InitializeComponent();
		}

		private void AssessmentResult_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'Assessmentdataset.DataTable1' table. You can move, or remove it, as needed.
			this.DataTable1TableAdapter.Fill(this.Assessmentdataset.DataTable1);

			this.reportViewer1.RefreshReport();
		}
	}
}
