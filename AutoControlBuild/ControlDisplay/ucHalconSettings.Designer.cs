
namespace AutoControlBuild.ControlDisplay
{
	partial class ucHalconSettings
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHalconSettings));
			this.hsWindow = new HalconDotNet.HSmartWindowControl();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlSetting = new System.Windows.Forms.Panel();
			this.pnlParams = new System.Windows.Forms.Panel();
			this.pnlSplit = new System.Windows.Forms.Panel();
			this.pnlSettingTitle = new System.Windows.Forms.Panel();
			this.lblSettingTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlMain.SuspendLayout();
			this.pnlSetting.SuspendLayout();
			this.pnlSettingTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// hsWindow
			// 
			this.hsWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.hsWindow.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.hsWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hsWindow.HDoubleClickToFitContent = true;
			this.hsWindow.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
			this.hsWindow.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
			this.hsWindow.HKeepAspectRatio = true;
			this.hsWindow.HMoveContent = true;
			this.hsWindow.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
			this.hsWindow.Location = new System.Drawing.Point(354, 0);
			this.hsWindow.Margin = new System.Windows.Forms.Padding(0);
			this.hsWindow.Name = "hsWindow";
			this.hsWindow.Size = new System.Drawing.Size(546, 500);
			this.hsWindow.TabIndex = 0;
			this.hsWindow.WindowSize = new System.Drawing.Size(546, 500);
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.hsWindow);
			this.pnlMain.Controls.Add(this.pnlSetting);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(900, 500);
			this.pnlMain.TabIndex = 1;
			// 
			// pnlSetting
			// 
			this.pnlSetting.Controls.Add(this.pnlParams);
			this.pnlSetting.Controls.Add(this.pnlSplit);
			this.pnlSetting.Controls.Add(this.pnlSettingTitle);
			this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSetting.Location = new System.Drawing.Point(0, 0);
			this.pnlSetting.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSetting.MaximumSize = new System.Drawing.Size(400, 1500);
			this.pnlSetting.MinimumSize = new System.Drawing.Size(350, 500);
			this.pnlSetting.Name = "pnlSetting";
			this.pnlSetting.Size = new System.Drawing.Size(354, 500);
			this.pnlSetting.TabIndex = 1;
			// 
			// pnlParams
			// 
			this.pnlParams.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlParams.Location = new System.Drawing.Point(0, 37);
			this.pnlParams.Name = "pnlParams";
			this.pnlParams.Size = new System.Drawing.Size(354, 463);
			this.pnlParams.TabIndex = 2;
			// 
			// pnlSplit
			// 
			this.pnlSplit.BackColor = System.Drawing.Color.Black;
			this.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSplit.Location = new System.Drawing.Point(0, 35);
			this.pnlSplit.Name = "pnlSplit";
			this.pnlSplit.Size = new System.Drawing.Size(354, 2);
			this.pnlSplit.TabIndex = 1;
			// 
			// pnlSettingTitle
			// 
			this.pnlSettingTitle.Controls.Add(this.lblSettingTitle);
			this.pnlSettingTitle.Controls.Add(this.pictureBox1);
			this.pnlSettingTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSettingTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlSettingTitle.Name = "pnlSettingTitle";
			this.pnlSettingTitle.Size = new System.Drawing.Size(354, 35);
			this.pnlSettingTitle.TabIndex = 0;
			// 
			// lblSettingTitle
			// 
			this.lblSettingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSettingTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSettingTitle.Location = new System.Drawing.Point(37, 0);
			this.lblSettingTitle.Name = "lblSettingTitle";
			this.lblSettingTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lblSettingTitle.Size = new System.Drawing.Size(317, 35);
			this.lblSettingTitle.TabIndex = 1;
			this.lblSettingTitle.Text = "TOOL NAME";
			this.lblSettingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 35);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// ucHalconSettings
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.pnlMain);
			this.Name = "ucHalconSettings";
			this.Size = new System.Drawing.Size(900, 500);
			this.pnlMain.ResumeLayout(false);
			this.pnlSetting.ResumeLayout(false);
			this.pnlSettingTitle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private HalconDotNet.HSmartWindowControl hsWindow;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlSetting;
		private System.Windows.Forms.Panel pnlSettingTitle;
		private System.Windows.Forms.Label lblSettingTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnlSplit;
		private System.Windows.Forms.Panel pnlParams;
	}
}
