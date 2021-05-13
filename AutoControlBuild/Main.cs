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
		public List<ParamItem> ControlItemsGlobal;
		public int IDGenerateCurrentNumber;
		public Main()
		{
			InitializeComponent();
			ControlItemsGlobal = new List<ParamItem>();
			ucParamsSetting.LinkParams(ControlItemsGlobal);
			IDGenerateCurrentNumber = 0;
		}


		private void AddControlItemToGlobalList(string dataType, string paramType)
		{
			ParamItem tempControlItem = new ParamItem(IDGenerateCurrentNumber.ToString(), dataType, paramType);
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
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString(), "CtrlIn");

		}
		private void btnAddItem2_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString(), "CtrlOut");
		}
		private void btnAddItem3_Click(object sender, EventArgs e)
		{
			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString(), "IconicIn");
		}
		private void btnAddItem4_Click(object sender, EventArgs e)
		{
			if (GlobalVars.HdevHelp == null) GlobalVars.HdevHelp = new HDevHelper();
			ControlItemsGlobal.Clear();
			ControlItemsGlobal.AddRange(GlobalVars.HdevHelp.LoadParamsFromHdevFile(""));
			UpdateListViewControlItem();

			if (cbItemType.SelectedIndex < 0) return;
			//
			AddControlItemToGlobalList(cbItemType.SelectedItem.ToString(), "IconicOut");

		}



	}
}
