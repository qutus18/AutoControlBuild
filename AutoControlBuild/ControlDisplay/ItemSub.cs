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
	public partial class ItemSub : UserControl
	{
		private ControlItem item;

		public ControlItem Item
		{
			get { return item; }
			set { item = value; UpdateItemSubView(); }
		}

		private void UpdateItemSubView()
		{
			lblItemTitle.Text = item.ID.ToString();
			lblItemType.Text = $"({item.Type})";
		}

		public ItemSub()
		{
			InitializeComponent();
		}
	}
}
