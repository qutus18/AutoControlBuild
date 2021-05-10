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
	public partial class Main : Form
	{
		public List<ControlItem> ControlItemsGlobal;
		public int IDGenerateCurrentNumber;
		public Main()
		{
			InitializeComponent();
			ControlItemsGlobal = new List<ControlItem>();
			ucParamsSetting.LinkParams(ControlItemsGlobal);
			IDGenerateCurrentNumber = 0;
		}


		private void AddControlItemToGlobalList(string controlType)
		{
			ControlItem tempControlItem = new ControlItem(IDGenerateCurrentNumber, controlType);
			IDGenerateCurrentNumber++;
			ControlItemsGlobal.Add(tempControlItem);
			UpdateListViewControlItem();
		}

		private void UpdateListViewControlItem()
		{
			//dgvControlItems.Update();
			//var dataSource = new BindingSource(ControlItemsGlobal, null);
			dgvControlItems1.DataSource = null;
			dgvControlItems1.DataSource = ControlItemsGlobal;
			ucParamsSetting.UpdateParamsSettingDisplay();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
		}
		private void btnAddItem_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString());

		}
		private void btnAddItem2_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString());
		}
		private void btnAddItem3_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString());
		}
		private void btnAddItem4_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString());

		}



	}
}
