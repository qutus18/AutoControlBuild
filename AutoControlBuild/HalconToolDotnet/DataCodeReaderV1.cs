using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace AutoControlBuild
{
	public class DataCodeReaderV1 : LinkableTool
	{
		public RegionRect2 ROI { get; set; }
		public int Timeout { get; set; } = 1000;
		public int NumberCodeToFind { get; set; } = 1;
		public string CodeType { get; set; } = "QR Code";
		public DataCodeReaderV1()
		{

		}
	}
}
