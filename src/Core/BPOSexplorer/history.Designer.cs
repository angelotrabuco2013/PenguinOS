namespace BPOSexplorer
{
	// Token: 0x0200001C RID: 28
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class history : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00033AB0 File Offset: 0x00031EB0
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

		// Token: 0x060000FB RID: 251 RVA: 0x00033B00 File Offset: 0x00031F00
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BPOSexplorer.history));
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.NewToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.HelpToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ToolStrip1.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.NewToolStripButton, this.HelpToolStripButton });
			global::System.Windows.Forms.Control toolStrip = this.ToolStrip1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			toolStrip.Location = point;
			this.ToolStrip1.Name = "ToolStrip1";
			global::System.Windows.Forms.Control toolStrip2 = this.ToolStrip1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(552, 25);
			toolStrip2.Size = size;
			this.ToolStrip1.TabIndex = 0;
			this.ToolStrip1.Text = "ToolStrip1";
			this.NewToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewToolStripButton.Image");
			this.NewToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.NewToolStripButton.Name = "NewToolStripButton";
			global::System.Windows.Forms.ToolStripItem newToolStripButton = this.NewToolStripButton;
			size = new global::System.Drawing.Size(89, 22);
			newToolStripButton.Size = size;
			this.NewToolStripButton.Text = "Clear History";
			this.HelpToolStripButton.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.HelpToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.HelpToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HelpToolStripButton.Image");
			this.HelpToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.HelpToolStripButton.Name = "HelpToolStripButton";
			global::System.Windows.Forms.ToolStripItem helpToolStripButton = this.HelpToolStripButton;
			size = new global::System.Drawing.Size(23, 22);
			helpToolStripButton.Size = size;
			this.HelpToolStripButton.Text = "He&lp";
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control listView = this.ListView1;
			point = new global::System.Drawing.Point(0, 25);
			listView.Location = point;
			this.ListView1.Name = "ListView1";
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			size = new global::System.Drawing.Size(552, 441);
			listView2.Size = size;
			this.ListView1.TabIndex = 1;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.List;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(552, 466);
			this.ClientSize = size;
			this.Controls.Add(this.ListView1);
			this.Controls.Add(this.ToolStrip1);
			this.Name = "history";
			this.Text = "Codename \"NewExplorer\" History";
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000F3 RID: 243
		private global::System.ComponentModel.IContainer components;
	}
}
