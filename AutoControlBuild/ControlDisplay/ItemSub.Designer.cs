
namespace AutoControlBuild
{
	partial class ItemSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSub));
			this.lblItemTitle = new System.Windows.Forms.Label();
			this.txtItemValue = new System.Windows.Forms.TextBox();
			this.lblItemType = new System.Windows.Forms.Label();
			this.pbLink = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbLink)).BeginInit();
			this.SuspendLayout();
			// 
			// lblItemTitle
			// 
			this.lblItemTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItemTitle.Location = new System.Drawing.Point(0, 0);
			this.lblItemTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblItemTitle.Name = "lblItemTitle";
			this.lblItemTitle.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.lblItemTitle.Size = new System.Drawing.Size(125, 28);
			this.lblItemTitle.TabIndex = 0;
			this.lblItemTitle.Text = "Float Value demo";
			this.lblItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtItemValue
			// 
			this.txtItemValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtItemValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtItemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItemValue.Location = new System.Drawing.Point(125, 5);
			this.txtItemValue.Margin = new System.Windows.Forms.Padding(0);
			this.txtItemValue.Name = "txtItemValue";
			this.txtItemValue.Size = new System.Drawing.Size(234, 21);
			this.txtItemValue.TabIndex = 1;
			// 
			// lblItemType
			// 
			this.lblItemType.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItemType.Location = new System.Drawing.Point(387, 0);
			this.lblItemType.Name = "lblItemType";
			this.lblItemType.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.lblItemType.Size = new System.Drawing.Size(100, 28);
			this.lblItemType.TabIndex = 0;
			this.lblItemType.Text = "(loading...)";
			this.lblItemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbLink
			// 
			this.pbLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbLink.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbLink.Image = ((System.Drawing.Image)(resources.GetObject("pbLink.Image")));
			this.pbLink.Location = new System.Drawing.Point(362, 0);
			this.pbLink.Margin = new System.Windows.Forms.Padding(0);
			this.pbLink.Name = "pbLink";
			this.pbLink.Size = new System.Drawing.Size(25, 28);
			this.pbLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbLink.TabIndex = 2;
			this.pbLink.TabStop = false;
			// 
			// ItemSub
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pbLink);
			this.Controls.Add(this.txtItemValue);
			this.Controls.Add(this.lblItemType);
			this.Controls.Add(this.lblItemTitle);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ItemSub";
			this.Size = new System.Drawing.Size(487, 28);
			((System.ComponentModel.ISupportInitialize)(this.pbLink)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblItemTitle;
		private System.Windows.Forms.TextBox txtItemValue;
		private System.Windows.Forms.Label lblItemType;
		private System.Windows.Forms.PictureBox pbLink;
	}
}
