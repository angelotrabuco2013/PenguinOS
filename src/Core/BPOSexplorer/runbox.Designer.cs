namespace BPOSexplorer
{
	// Token: 0x02000025 RID: 37
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class runbox : global::System.Windows.Forms.Form
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000388C4 File Offset: 0x00036CC4
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

		// Token: 0x060001F4 RID: 500 RVA: 0x00038914 File Offset: 0x00036D14
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.SuspendLayout();
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(273, 72);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Cancel";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(192, 72);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(75, 23);
			button4.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Run";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(9, 9);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(327, 26);
			label2.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Type the command of a program, website address, or directory then \r\nBob Pony OS will open it for you.";
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(12, 46);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(336, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 3;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(352, 105);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "runbox";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Run";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400015C RID: 348
		private global::System.ComponentModel.IContainer components;
	}
}
