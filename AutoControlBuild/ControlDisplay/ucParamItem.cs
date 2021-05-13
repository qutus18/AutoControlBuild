using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlBuild
{
	public partial class ucParamItem : UserControl
	{
		private ParamItem item;

		public ParamItem Item
		{
			get { return item; }
			set { item = value; UpdateItemSubView(); }
		}

		private void UpdateItemSubView()
		{
			lblItemTitle.Text = item.Name.ToString();
			lblItemType.Text = $"({item.DataType})";
		}

		public ucParamItem()
		{
			InitializeComponent();
		}
	}
}
