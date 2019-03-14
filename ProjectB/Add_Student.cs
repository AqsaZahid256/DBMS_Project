﻿using System;
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
	public partial class Add_Student : Form
	{
		public Add_Student()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Student s = new Student();
				s.set_FirstName(FirstName.Text);
				s.set_LastName(LastName.Text);
				s.set_Registration_No(RegistrationNumber.Text);
				s.set_Contact(Contact.Text);
				s.set_Email(Email.Text);
				s.set_Status(Status.Text);
				if ((s.get_FirstName() == null) || (s.get_LastName() == null) || (s.get_Contact() == null) || (s.get_Registration_No() == null) || (s.get_Email() == null) || (s.get_Status() == null))
				{
					MessageBox.Show("Submssion is not allowed with null values");
				}
				else
				{
					string constr = "Data Source=DESKTOP-GP94IEM\\SQLEXPRESS;Initial Catalog=Projectb;Integrated Security=True";
					SqlConnection c = new SqlConnection(constr);
					c.Open();

					string s2 = string.Format("SELECT LookupId FROM Lookup WHERE Category=@Category and Name =@Name");
					SqlCommand a = new SqlCommand(s2, c);
					a.Parameters.Add(new SqlParameter("@Category", "STUDENT_STATUS"));
					a.Parameters.Add(new SqlParameter("@Name", this.Status.Text));
					int id = (int)a.ExecuteScalar();

					string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + s.get_FirstName()+ "',  '" + s.get_LastName() + "','" + s.get_Contact() + "','" + s.get_Email() + "','" + s.get_Registration_No() + "','" + id + "')");

					//string s1 = string.Format("INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", s.get_FirstName(), s.get_LastName(), s.get_Contact(), s.get_Email(), s.get_Registration_No(), id);
					SqlCommand a2 = new SqlCommand(s1, c);
					//int rows = DatabaseConnection.getInstance().exectuteQuery(s1);
					int rows = a2.ExecuteNonQuery();
					if (rows != 0)
					{
						MessageBox.Show("Student Added");
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
			Student_Data d = new Student_Data();
			d.Show();
		}
	}
}