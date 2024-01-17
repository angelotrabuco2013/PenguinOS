namespace BPOSexplorer
{
	// Token: 0x0200001A RID: 26
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class bpsc : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00033420 File Offset: 0x00031820
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

		// Token: 0x060000EA RID: 234 RVA: 0x00033470 File Offset: 0x00031870
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(8, 5);
			label.Location = point;
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Windows.Forms.Padding padding = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Margin = padding;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label3 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(211, 31);
			label3.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Coming soon...";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label4 = this.Label2;
			point = new global::System.Drawing.Point(12, 50);
			label4.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label5 = this.Label2;
			size = new global::System.Drawing.Size(388, 48);
			label5.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "The place where you can get apps for Bob Pony OS.\r\n\r\nLater on, there will be an update that will add the Software Center.";
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(183, 132);
			button.Location = point;
			global::System.Windows.Forms.Control button2 = this.Button1;
			padding = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			button2.Margin = padding;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button3 = this.Button1;
			size = new global::System.Drawing.Size(75, 24);
			button3.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Close";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(8f, 16f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(415, 167);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Margin = padding;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "bpsc";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bob Pony Software Center";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000EB RID: 235
		private global::System.ComponentModel.IContainer components;
	}
}
