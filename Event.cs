using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
	[Serializable]
	public class Event
	{
		int eventNum;
		string location;

		public int EventNum { get => eventNum; set => eventNum = value; }
		public string Location { get => location; set => location = value; }
		
		public Event() { }
		public Event(int eventNum, string location) 
		{
			this.eventNum = eventNum;
			this.location = location;
		}
	}
}
