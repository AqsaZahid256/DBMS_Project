using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
	class Add_Assessment
	{
		public Add_Assessment()
		{
		/// <summary>  
		///  default constructor
		/// </summary>
			Title = null;
			Date_Created = DateTime.MinValue;
			Total_Marks = 0;
			Total_Weightage = 0;
			
		}
		/// <summary>  
		///  data members
		///  getter setter
		/// </summary>

		///<param>
		//</param>
		private string Title;
		private DateTime Date_Created;
		private int Total_Marks;
		private int Total_Weightage;
		// Student Name getter setter
		public string get_Title()
		{
			return Title;
		}
	    public void set_Title(string value)
	    {
		    Title = value;
	    }
		public DateTime get_Date_Created()
		{
			return Date_Created;
		}
		public void set_Date_Created(DateTime value)
		{
			Date_Created = value;
		}
		public int get_Total_Marks()
		{
			return Total_Marks;
		}
		public void set_Total_Marks(string value)
		{
			if (value != "")
			{
				Total_Marks = Convert.ToInt16(value);
			}
			
		}
		public int get_Total_Weightage()
		{
			return Total_Weightage;
		}
		public void set_Total_Weightage(string value)
		{
			if (value != "")
			{
				Total_Marks = Convert.ToInt16(value);
			}
		}
	}
}
