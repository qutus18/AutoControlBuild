using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlBuild.ControlDisplay
{
	public partial class ucHalconSettings : UserControl
	{
		public LinkableTool LinkedTool { get; set; } = new DataCodeReaderV1();
		public ucHalconSettings()
		{
			InitializeComponent();
		}

		public void UpdateDisplay()
		{
			LoadAllParamsOfClass();
			Type toolType = LinkedTool.GetType();
			foreach (var item in toolType.GetProperties(BindingFlags.Public))
			{
				Console.WriteLine((item as PropertyInfo).Name);
			}

		}

		private void LoadAllParamsOfClass()
		{
			
		}
	}
}
