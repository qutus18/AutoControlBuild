using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlBuild.ControlDisplay
{
	public partial class AutoAddItemsSetting : UserControl
	{
		public HProcedureItem HTool;
		public AutoAddItemsSetting()
		{
			InitializeComponent();
			HTool = new HProcedureItem();
		}

		public void LinkParams(List<ControlItem> listParamsInput)
		{
			HTool.Params = listParamsInput;
		}

		public void UpdateParamsSettingDisplay()
		{
			if (HTool.Params == null)
			{
				MessageBox.Show("Không có list params được kết nối!");
				return;
			}
			// Tiến hành update hiển thị
			pnlCtrlInItems.Controls.Clear();
			pnlCtrlOutItems.Controls.Clear();
			pnlIconicInItems.Controls.Clear();
			pnlIconicOutItems.Controls.Clear();
			foreach (ControlItem ctrlItem in HTool.Params)
			{
				ItemSub tempUC = new ItemSub();
				tempUC.Dock = DockStyle.Top;
				tempUC.Item = ctrlItem;
				pnlCtrlInItems.Controls.Add(tempUC);
			}
			foreach (ControlItem ctrlItem in HTool.Params)
			{
				ItemSub tempUC = new ItemSub();
				tempUC.Dock = DockStyle.Top;
				tempUC.Item = ctrlItem;
				pnlCtrlOutItems.Controls.Add(tempUC);
			}
			foreach (ControlItem ctrlItem in HTool.Params)
			{
				ItemSub tempUC = new ItemSub();
				tempUC.Dock = DockStyle.Top;
				tempUC.Item = ctrlItem;
				pnlIconicInItems.Controls.Add(tempUC);
			}
			foreach (ControlItem ctrlItem in HTool.Params)
			{
				ItemSub tempUC = new ItemSub();
				tempUC.Dock = DockStyle.Top;
				tempUC.Item = ctrlItem;
				pnlIconicOutItems.Controls.Add(tempUC);
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{

		}
	}
}
