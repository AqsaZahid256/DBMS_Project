using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
	class Attendence
	{
		///<param>
		//</param>
		private string Registration_No;
		private DateTime Attendence_Date;
		private string Student_Status;


		/// <summary>  
		///  default constructor
		/// </summary>
		public Attendence()
		{
			Registration_No = null;
			Attendence_Date = DateTime.MinValue;
			Student_Status = null;

		}
		/// <summary>  
		///  data members
		///  getter setter
		/// </summary>


		public DateTime get_Attendence_Date()
		{
			return Attendence_Date;
		}
		public string get_Student_Status()
		{
			return Student_Status;
		}
		public void set_Student_Status(string value)
		{
			if (value != "")
			{
				Student_Status = value;
			}
		}

		public void set_Attendence_Date(DateTime value)
		{
			Attendence_Date = value;
		}
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

			//Registration_No = value;
		}

	}
}

