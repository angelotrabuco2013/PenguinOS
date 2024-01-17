namespace BPOSexplorer
{
	// Token: 0x0200001B RID: 27
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Feedback : global::BPOSexplorer.Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00033878 File Offset: 0x00031C78
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

		// Token: 0x060000F5 RID: 245
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.WebBrowser1 = new global::System.Windows.Forms.WebBrowser();
			base.SuspendLayout();
			this.WebBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
			global::System.Windows.Forms.Control webBrowser = this.WebBrowser1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			webBrowser.Location = point;
			global::System.Windows.Forms.Control webBrowser2 = this.WebBrowser1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(20, 20);
			webBrowser2.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.ScriptErrorsSuppressed = true;
			global::System.Windows.Forms.Control webBrowser3 = this.WebBrowser1;
			size = new global::System.Drawing.Size(566, 520);
			webBrowser3.Size = size;
			this.WebBrowser1.TabIndex = 0;
			this.WebBrowser1.Url = new global::System.Uri("http://127.0.0.1/underConstruction.php", global::System.UriKind.Absolute);
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = sizeF;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(566, 520);
			base.ClientSize = size;
			base.Controls.Add(this.WebBrowser1);
			base.MinimizeBox = false;
			base.Name = "Feedback";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Feedback Tool";
			base.ResumeLayout(false);
		}

		// Token: 0x040000F0 RID: 240
		private global::System.ComponentModel.IContainer components;
	}
}
