﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace In_Class_API_Consumption.Models
{
	public class Parks
	{
		public string total { get; set; }
		public string limit { get; set; }
		public string start { get; set; }
		public Park[] data { get; set; }
	}

	public class Park
	{
		public string id { get; set; }
		public string url { get; set; }
		public string fullName { get; set; }
		public string parkCode { get; set; }
		public string description { get; set; }
		public string latitude { get; set; }
		public string longitude { get; set; }
		public string latLong { get; set; }

		public string states { get; set; }

		public object[] fees { get; set; }
		public string directionsInfo { get; set; }
		public string directionsUrl { get; set; }
		public string weatherInfo { get; set; }
		public string name { get; set; }
		public string designation { get; set; }
	}
}
