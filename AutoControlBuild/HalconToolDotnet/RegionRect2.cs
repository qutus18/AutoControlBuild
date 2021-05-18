using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace AutoControlBuild
{
	public class RegionRect2
	{
		public HRegion Region { get; set; }
		public float Row { get; set; }
		public float Column { get; set; }
		public float Phi { get; set; }
		public float Len1 { get; set; }
		public float Len2 { get; set; }

		public RegionRect2()
		{

		}
		
	}
}
