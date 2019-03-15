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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Add_Student o = new Add_Student();
			o.Show();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Add_Clo l = new Add_Clo();
			l.Show();
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Rubric r = new Rubric();
			r.Show();
		}

		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			StudentGrid h = new StudentGrid();
			h.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			StudentGrid g = new StudentGrid();
			g.Show();
		}

		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_Rubrics r = new Manage_Rubrics();
			r.Show();
		}

		private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_Clo c = new Manage_Clo();
			c.Show();
		}
	}
}
