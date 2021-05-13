using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoControlBuild
{
	public class ParamItem
	{
		public string Name { get; set; }
		public string DataType { get; set; }
		public string ParamType { get; set; }

		public ParamItem(string name, string dataTypeIn, string paramTypeIn)
		{
			Name = name;
			DataType = dataTypeIn;
			ParamType = paramTypeIn;
		}
	}
}
