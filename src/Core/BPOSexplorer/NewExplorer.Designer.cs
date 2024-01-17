namespace BPOSexplorer
{
	// Token: 0x02000024 RID: 36
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class NewExplorer : global::System.Windows.Forms.Form
	{
		// Token: 0x060001BD RID: 445 RVA: 0x000376AC File Offset: 0x00035AAC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000376FC File Offset: 0x00035AFC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BPOSexplorer.NewExplorer));
			this.ToolStrip = new global::System.Windows.Forms.ToolStrip();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.BackToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ForwardToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton5 = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.ComboBox1 = new global::System.Windows.Forms.ToolStripComboBox();
			this.ToolStripButton1 = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton3 = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton2 = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton6 = new global::System.Windows.Forms.ToolStripButton();
			this.WebBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.ToolStrip.SuspendLayout();
			this.SuspendLayout();
			this.ToolStrip.ContextMenuStrip = this.ContextMenuStrip1;
			this.ToolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.BackToolStripButton, this.ForwardToolStripButton, this.ToolStripButton5, this.ToolStripSeparator2, this.ToolStripLabel1, this.ComboBox1, this.ToolStripButton1, this.ToolStripButton3, this.ToolStripButton4, this.ToolStripButton2,
				this.ToolStripButton6
			});
			global::System.Windows.Forms.Control toolStrip = this.ToolStrip;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			toolStrip.Location = point;
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control toolStrip2 = this.ToolStrip;
			global::System.Drawing.Size size = new global::System.Drawing.Size(604, 39);
			toolStrip2.Size = size;
			this.ToolStrip.TabIndex = 2;
			this.ToolStrip.Text = "ToolStrip1";
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(61, 4);
			contextMenuStrip.Size = size;
			this.BackToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BackToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BackToolStripButton.Image");
			this.BackToolStripButton.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.BackToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Maroon;
			this.BackToolStripButton.Name = "BackToolStripButton";
			global::System.Windows.Forms.ToolStripItem backToolStripButton = this.BackToolStripButton;
			size = new global::System.Drawing.Size(36, 36);
			backToolStripButton.Size = size;
			this.BackToolStripButton.Text = "Back";
			this.BackToolStripButton.ToolTipText = "Back to the previous item";
			this.ForwardToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ForwardToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ForwardToolStripButton.Image");
			this.ForwardToolStripButton.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ForwardToolStripButton.ImageTransparentColor = global::System.Drawing.Color.DimGray;
			this.ForwardToolStripButton.Name = "ForwardToolStripButton";
			global::System.Windows.Forms.ToolStripItem forwardToolStripButton = this.ForwardToolStripButton;
			size = new global::System.Drawing.Size(36, 36);
			forwardToolStripButton.Size = size;
			this.ForwardToolStripButton.Text = "Forward";
			this.ForwardToolStripButton.ToolTipText = "Move forward to the next item";
			this.ToolStripButton5.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripButton5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton5.Image");
			this.ToolStripButton5.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ToolStripButton5.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton5.Name = "ToolStripButton5";
			global::System.Windows.Forms.ToolStripItem toolStripButton = this.ToolStripButton5;
			size = new global::System.Drawing.Size(36, 36);
			toolStripButton.Size = size;
			this.ToolStripButton5.Text = "Up";
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator2;
			size = new global::System.Drawing.Size(6, 39);
			toolStripSeparator.Size = size;
			this.ToolStripLabel1.Name = "ToolStripLabel1";
			global::System.Windows.Forms.ToolStripItem toolStripLabel = this.ToolStripLabel1;
			size = new global::System.Drawing.Size(50, 36);
			toolStripLabel.Size = size;
			this.ToolStripLabel1.Text = "Address:";
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.ToolStripControlHost comboBox = this.ComboBox1;
			size = new global::System.Drawing.Size(250, 39);
			comboBox.Size = size;
			this.ToolStripButton1.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ToolStripButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.ToolStripButton1.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ToolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton1.Name = "ToolStripButton1";
			global::System.Windows.Forms.ToolStripItem toolStripButton2 = this.ToolStripButton1;
			size = new global::System.Drawing.Size(36, 36);
			toolStripButton2.Size = size;
			this.ToolStripButton1.Text = "Search";
			this.ToolStripButton3.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ToolStripButton3.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripButton3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton3.Image");
			this.ToolStripButton3.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ToolStripButton3.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton3.Name = "ToolStripButton3";
			global::System.Windows.Forms.ToolStripItem toolStripButton3 = this.ToolStripButton3;
			size = new global::System.Drawing.Size(36, 36);
			toolStripButton3.Size = size;
			this.ToolStripButton3.Text = "History";
			this.ToolStripButton4.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ToolStripButton4.Name = "ToolStripButton4";
			global::System.Windows.Forms.ToolStripItem toolStripButton4 = this.ToolStripButton4;
			size = new global::System.Drawing.Size(6, 39);
			toolStripButton4.Size = size;
			this.ToolStripButton2.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ToolStripButton2.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.ToolStripButton2.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ToolStripButton2.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			global::System.Windows.Forms.ToolStripItem toolStripButton5 = this.ToolStripButton2;
			size = new global::System.Drawing.Size(36, 36);
			toolStripButton5.Size = size;
			this.ToolStripButton2.Text = "Refresh";
			this.ToolStripButton6.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton6.Image");
			this.ToolStripButton6.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton6.Name = "ToolStripButton6";
			global::System.Windows.Forms.ToolStripItem toolStripButton6 = this.ToolStripButton6;
			size = new global::System.Drawing.Size(24, 36);
			toolStripButton6.Size = size;
			this.ToolStripButton6.Text = "Go";
			this.WebBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control webBrowser = this.WebBrowser1;
			point = new global::System.Drawing.Point(0, 39);
			webBrowser.Location = point;
			global::System.Windows.Forms.Control webBrowser2 = this.WebBrowser1;
			size = new global::System.Drawing.Size(20, 20);
			webBrowser2.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			global::System.Windows.Forms.Control webBrowser3 = this.WebBrowser1;
			size = new global::System.Drawing.Size(604, 382);
			webBrowser3.Size = size;
			this.WebBrowser1.TabIndex = 5;
			this.WebBrowser1.Url = new global::System.Uri("C:\\", global::System.UriKind.Absolute);
			this.WebBrowser1.WebBrowserShortcutsEnabled = false;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(604, 421);
			this.ClientSize = size;
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.ToolStrip);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "NewExplorer";
			this.Text = "NewExplorer";
			this.ToolStrip.ResumeLayout(false);
			this.ToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400014C RID: 332
		private global::System.ComponentModel.IContainer components;
	}
}
