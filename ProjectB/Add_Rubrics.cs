﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
	class Add_Rubrics
	{      /// <summary>  
		   ///  default constructor
		   /// </summary>
		public Add_Rubrics()
		{
			CloId = 0;
			Details = null;
			
		}
		/// <summary>  
		///  data members
		///  getter setter
		/// </summary>

		///<param>
		//</param>
		private string Details;
		private int CloId;

		public string get_Details()
		{
			return Details;
		}
		public void set_Details(string value)
		{
			if (value != "")
			{
				Details = value;
			}

		}
		public int get_CloId()
		{
			return CloId;
		}
		public void set_CloId(string value)
		{
			if (value != "")
			{
				CloId = Convert.ToInt16(value);
			}

		}
	}
}