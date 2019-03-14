using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
	class CLO
	{
		/// <summary>  
		///  default constructor
		/// </summary>
		public CLO()
		{
			Name = null;
			Data_Created = DateTime.MinValue;
			Data_Updated = DateTime.MinValue;

		}
		 /// <summary>  
		 ///  data members
		 ///  getter setter
		 /// </summary>

		///<param>
		//</param>
		private string Name;
		private DateTime Data_Created;
		private DateTime Data_Updated;

		public DateTime get_Data_Created()
		{
			return Data_Created;
		}
		public DateTime get_Data_Updated()
		{
			return Data_Updated;
		}
		public void set_Data_Updated(DateTime value)
		{
			Data_Updated = value;
		}
		public void set_Data_Created(DateTime value)
		{
			Data_Created = value;
		}
		public string get_Name()
		{
			return Name;
		}
		public void set_Name(string value)
		{
			bool f = true;
			foreach (char c in value)
			{
				if (!char.IsLetter(c))
				{
					f = false;

				}
			}
			if (f == true)
			{
				Name = value;
			}
			else
			{
				MessageBox.Show("Please enter only letter");
			}
		}
	}
}
