using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MInhaRotina
{
	public class Positions
	{
		
	}

	public class PersonPosition
	{
		public double acceleration_x { get; set; }
		public double acceleration_y { get; set; }
		public double acceleration_z { get; set; }
		public double roll { get; set; }
		public double pitch { get; set; }
		public double yaw { get; set; }
		public double lon { get; set; }
		public double lat { get; set; }
	}

	public class Payload
	{
		public PersonPosition PersonPosition { get; set; }
	}

	public class RootObject
	{
		public string _id { get; set; }
		public string _rev { get; set; }
		public string topic { get; set; }
		public Payload payload { get; set; }
		public string deviceId { get; set; }
		public string deviceType { get; set; }
		public string eventType { get; set; }
		public string format { get; set; }
		public string msgid { get; set; }
	}

}

