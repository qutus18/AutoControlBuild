using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoControlBuild
{
	public class ControlItem
	{
		public int ID { get; set; }
		public string Type { get; set; }

		public ControlItem(int id, string type)
		{
			ID = id;
			Type = type;
		}
	}
}
