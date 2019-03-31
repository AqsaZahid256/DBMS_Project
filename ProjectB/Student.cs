using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
	class Student
	{  /// <summary>  
	   ///  default constructor
	   /// </summary>
		public Student()
		{
			First_Name = null;
			Last_Name = null;
			Contact = null;
			Registration_No = null;
			Email = null;
			Status = null;
		}
		/// <summary>  
		///  data members
		///  getter setter
		/// </summary>

		///<param>
		//</param>
		private string First_Name;
		private string Last_Name;
		private string Contact;
		
	    private string Email;
		private string Registration_No;
		private string Status;

		// Student Name getter setter
		public string get_FirstName()
		{
			return First_Name;
		}
		public void set_FirstName(string value)
		{
			bool f = true;
			foreach (char c in value)
			{
				if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
				{
					f = false;

				}
			}
			if (f == true)
			{
				First_Name = value;
			}
			
		}
		// Student Name getter setter
		public string get_LastName()
		{
			return Last_Name;
		}
		public void set_LastName(string value)
		{
			bool f = true;
			foreach (char c in value)
			{
				if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
				{
					f = false;

				}
			}
			if (f == true)
			{
				Last_Name = value;
			}
		}
		//Reg no getter setter
		public string get_Registration_No()
		{
			return Registration_No;
		}
		public void set_Registration_No(string value)
		{
			int i = value.Length;
			if (i == 11)
			{
				bool f = true;
				int a = 0;
				for (a = 0; a < 4; a++)
				{
					if (!char.IsDigit(value[a]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (!(value[4] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				if (!(char.IsLetter(value[5]) && char.IsLetter(value[6])))
				{
					//MessageBox.Show("please enter only letter");
					f = false;
				}
				if (!(value[7] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				for (int b = 8; b < 11; b++)
				{
					if (!char.IsDigit(value[b]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (f == false)
				{
					//MessageBox.Show("Please enter according to format 2016-cs-256 OR 2016-cs-56 OR 2016-cs-6");
				}
				else
				{
					Registration_No = value;
				}
			}
			else if (i == 10)
			{
				bool f = true;
				int a = 0;
				for (a = 0; a < 4; a++)
				{
					if (!char.IsDigit(value[a]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (!(value[4] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				if (!(char.IsLetter(value[5]) && char.IsLetter(value[6])))
				{
					//MessageBox.Show("please enter only letter");
					f = false;
				}
				if (!(value[7] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				for (int b = 8; b < 10; b++)
				{
					if (!char.IsDigit(value[b]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (f == false)
				{
					//MessageBox.Show("please enter according to format 2016-cs-25");
				}
				else
				{
					Registration_No = value;
				}
			}
			else if (i == 9)
			{
				bool f = true;
				int a = 0;
				for (a = 0; a < 4; a++)
				{
					if (!char.IsDigit(value[a]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (!(value[4] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				if (!(char.IsLetter(value[5]) && char.IsLetter(value[6])))
				{
					//MessageBox.Show("please enter only letter");
					f = false;
				}
				if (!(value[7] == '-'))
				{
					//MessageBox.Show("please enter only symbol");
					f = false;
				}
				for (int b = 8; b < 9; b++)
				{
					if (!char.IsDigit(value[b]))
					{
						//MessageBox.Show("please enter only digits");
						f = false;
					}
				}
				if (f == false)
				{
					//MessageBox.Show("please enter according to format 2016-cs-2");
				}
				else
				{
					Registration_No = value;
				}
			}
			else
			{
				//MessageBox.Show("please enter according to format 2016-CS-256 OR 2016-CS-56 OR 2016-CS-6");
			}

			Registration_No = value;
		}

		public string get_Contact()
		{
			return Contact;
		}
		public void set_Contact(string value)
		{
			int i = value.Length;
			if (i == 11)
			{
				bool f = true;
				foreach (char c in value)
				{
					if (!char.IsDigit(c))
					{
						//MessageBox.Show("Please enter only digit");
						f = false;
					}
					if (value[0] != '0' && value[1] != '3')
					{
						f = false;
					}

				}
				if (f == false)
				{
					//MessageBox.Show("please enter only 13 digit");
				}
				else
				{
					Contact = value;
				}
			}
		}
		public string get_Email()
		{
			return Email;
		}
		public void set_Email(string value)
		{
			bool f = true;
			if (!string.IsNullOrWhiteSpace(value))
			{
				Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
				if (!reg.IsMatch(value))
				{
					//MessageBox.Show("Please Write a Valid Email Address");
					f = false;
				}
				else
				{
					Email = value;
				}
			}
		}
		public string get_Status()
		{
			return Status;
		}
		public void set_Status(string value)
		{
			if (value != "")
			{
				Status = value;
			}
		}
	}
}