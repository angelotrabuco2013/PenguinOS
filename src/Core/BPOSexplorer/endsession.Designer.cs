namespace BPOSexplorer
{
	// Token: 0x02000019 RID: 25
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class endsession : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00032AD0 File Offset: 0x00030ED0
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

		// Token: 0x060000D1 RID: 209 RVA: 0x00032B20 File Offset: 0x00030F20
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button6 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(4, 16);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(305, 20);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Choose how you want to end your session";
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(12, 52);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 42);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Shutdown";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(121, 52);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(75, 42);
			button4.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Restart";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button5 = this.Button3;
			point = new global::System.Drawing.Point(225, 52);
			button5.Location = point;
			this.Button3.Name = "Button3";
			global::System.Windows.Forms.Control button6 = this.Button3;
			size = new global::System.Drawing.Size(75, 42);
			button6.Size = size;
			this.Button3.TabIndex = 3;
			this.Button3.Text = "Hibernate";
			this.Button3.UseVisualStyleBackColor = true;
			this.Button4.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button7 = this.Button4;
			point = new global::System.Drawing.Point(65, 100);
			button7.Location = point;
			this.Button4.Name = "Button4";
			global::System.Windows.Forms.Control button8 = this.Button4;
			size = new global::System.Drawing.Size(75, 36);
			button8.Size = size;
			this.Button4.TabIndex = 4;
			this.Button4.Text = "Logoff";
			this.Button4.UseVisualStyleBackColor = true;
			this.Button5.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button9 = this.Button5;
			point = new global::System.Drawing.Point(171, 100);
			button9.Location = point;
			this.Button5.Name = "Button5";
			global::System.Windows.Forms.Control button10 = this.Button5;
			size = new global::System.Drawing.Size(95, 36);
			button10.Size = size;
			this.Button5.TabIndex = 5;
			this.Button5.Text = "Switch Users";
			this.Button5.UseVisualStyleBackColor = true;
			this.Button6.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button11 = this.Button6;
			point = new global::System.Drawing.Point(121, 174);
			button11.Location = point;
			this.Button6.Name = "Button6";
			global::System.Windows.Forms.Control button12 = this.Button6;
			size = new global::System.Drawing.Size(75, 23);
			button12.Size = size;
			this.Button6.TabIndex = 6;
			this.Button6.Text = "Cancel";
			this.Button6.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			size = new global::System.Drawing.Size(312, 205);
			this.ClientSize = size;
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "endsession";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "End Session";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000E2 RID: 226
		private global::System.ComponentModel.IContainer components;
	}
}
