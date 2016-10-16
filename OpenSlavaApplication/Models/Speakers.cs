using System;
using System.Collections.Generic;

namespace OpenSlavaApplication
{

	public class Speaker
	{
		public int id { get; set; }
		public string name { get; set; }
		public string company { get; set; }
		public string bio { get; set; }
		public string session_title { get; set; }
		public string session_text { get; set; }
		public string picture { get; set; }
	}

	public class Speakers
	{
		public string status { get; set; }
		public List<Speaker> speakers { get; set; }
	}

}
