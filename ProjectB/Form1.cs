﻿using System;
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

		private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Mark_Attendence n = new Mark_Attendence();
			n.Show();
		}

		private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Rubric_Level r = new Rubric_Level();
			r.Show();
		}

		private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Assessment a = new Assessment();
			a.Show();
		}

		private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
		}

		private void linkLabel10_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_Rubric i = new Manage_Rubric();
			i.Show();
		}

		private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Student_Result l = new Student_Result();
			l.Show();
		}

		private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Manage_Assessment t = new Manage_Assessment();
			t.Show();
		}

		private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AssessmentResult l = new AssessmentResult();
			l.Show();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{

		}
	}
}
