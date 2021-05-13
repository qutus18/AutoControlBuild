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
	public partial class ucParamsAutoGen : UserControl
	{
		public HProcedureItem HTool;
		public ucParamsAutoGen()
		{
			InitializeComponent();
			HTool = new HProcedureItem();
		}

		public void LinkParams(List<ParamItem> listParamsInput)
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
			// Xóa hiển thị cũ
			pnlCtrlInItems.Controls.Clear();
			pnlCtrlOutItems.Controls.Clear();
			pnlIconicInItems.Controls.Clear();
			pnlIconicOutItems.Controls.Clear();

			// Cập nhật hiển thị mới
			int numberOfParams = HTool.Params.Count;
			for (int i = 0; i < numberOfParams; i++)
			{
				if (HTool.Params[i].ParamType != "CtrlIn") continue;
				// Tạo user control tương tứng
				ucParamItem tempUcParam = new ucParamItem();
				tempUcParam.Dock = DockStyle.Bottom;
				tempUcParam.Item = HTool.Params[i];
				pnlCtrlInItems.Controls.Add(tempUcParam);
			}
			for (int i = 0; i < numberOfParams; i++)
			{
				if (HTool.Params[i].ParamType != "CtrlOut") continue;
				// Tạo user control tương tứng
				ucParamItem tempUcParam = new ucParamItem();
				tempUcParam.Dock = DockStyle.Bottom;
				tempUcParam.Item = HTool.Params[i];
				pnlCtrlOutItems.Controls.Add(tempUcParam);
			}
			for (int i = 0; i < numberOfParams; i++)
			{
				if (HTool.Params[i].ParamType != "IconicIn") continue;
				// Tạo user control tương tứng
				ucParamItem tempUcParam = new ucParamItem();
				tempUcParam.Dock = DockStyle.Bottom;
				tempUcParam.Item = HTool.Params[i];
				pnlIconicInItems.Controls.Add(tempUcParam);
			}
			for (int i = 0; i < numberOfParams; i++)
			{
				if (HTool.Params[i].ParamType != "IconicOut") continue;
				// Tạo user control tương tứng
				ucParamItem tempUcParam = new ucParamItem();
				tempUcParam.Dock = DockStyle.Bottom;
				tempUcParam.Item = HTool.Params[i];
				pnlIconicOutItems.Controls.Add(tempUcParam);
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{

		}
	}
}
