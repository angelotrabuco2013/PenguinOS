namespace BPOSexplorer
{
	// Token: 0x02000026 RID: 38
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class barsetting : global::System.Windows.Forms.Form
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00038EE0 File Offset: 0x000372E0
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

		// Token: 0x06000203 RID: 515 RVA: 0x00038F30 File Offset: 0x00037330
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.rbTop = new global::System.Windows.Forms.RadioButton();
			this.rbRight = new global::System.Windows.Forms.RadioButton();
			this.rbBottom = new global::System.Windows.Forms.RadioButton();
			this.rbLeft = new global::System.Windows.Forms.RadioButton();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.cbAutoHide = new global::System.Windows.Forms.CheckBox();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Button5 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.ColorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.FontDialog1 = new global::System.Windows.Forms.FontDialog();
			this.GroupBox1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.rbTop);
			this.GroupBox1.Controls.Add(this.rbRight);
			this.GroupBox1.Controls.Add(this.rbBottom);
			this.GroupBox1.Controls.Add(this.rbLeft);
			this.GroupBox1.Enabled = false;
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(12, 12);
			groupBox.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(71, 126);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Dock";
			this.rbTop.AutoSize = true;
			global::System.Windows.Forms.Control rbTop = this.rbTop;
			point = new global::System.Drawing.Point(6, 88);
			rbTop.Location = point;
			this.rbTop.Name = "rbTop";
			global::System.Windows.Forms.Control rbTop2 = this.rbTop;
			size = new global::System.Drawing.Size(44, 17);
			rbTop2.Size = size;
			this.rbTop.TabIndex = 3;
			this.rbTop.Text = "Top";
			this.rbTop.UseVisualStyleBackColor = true;
			this.rbRight.AutoSize = true;
			global::System.Windows.Forms.Control rbRight = this.rbRight;
			point = new global::System.Drawing.Point(6, 65);
			rbRight.Location = point;
			this.rbRight.Name = "rbRight";
			global::System.Windows.Forms.Control rbRight2 = this.rbRight;
			size = new global::System.Drawing.Size(50, 17);
			rbRight2.Size = size;
			this.rbRight.TabIndex = 2;
			this.rbRight.Text = "Right";
			this.rbRight.UseVisualStyleBackColor = true;
			this.rbBottom.AutoSize = true;
			this.rbBottom.Checked = true;
			global::System.Windows.Forms.Control rbBottom = this.rbBottom;
			point = new global::System.Drawing.Point(6, 42);
			rbBottom.Location = point;
			this.rbBottom.Name = "rbBottom";
			global::System.Windows.Forms.Control rbBottom2 = this.rbBottom;
			size = new global::System.Drawing.Size(58, 17);
			rbBottom2.Size = size;
			this.rbBottom.TabIndex = 1;
			this.rbBottom.TabStop = true;
			this.rbBottom.Text = "Bottom";
			this.rbBottom.UseVisualStyleBackColor = true;
			this.rbLeft.AutoSize = true;
			global::System.Windows.Forms.Control rbLeft = this.rbLeft;
			point = new global::System.Drawing.Point(6, 19);
			rbLeft.Location = point;
			this.rbLeft.Name = "rbLeft";
			global::System.Windows.Forms.Control rbLeft2 = this.rbLeft;
			size = new global::System.Drawing.Size(43, 17);
			rbLeft2.Size = size;
			this.rbLeft.TabIndex = 0;
			this.rbLeft.Text = "Left";
			this.rbLeft.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(186, 144);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.cbAutoHide);
			this.GroupBox3.Controls.Add(this.Button4);
			this.GroupBox3.Controls.Add(this.Button5);
			this.GroupBox3.Controls.Add(this.Button3);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox3;
			point = new global::System.Drawing.Point(89, 12);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox3;
			size = new global::System.Drawing.Size(172, 126);
			groupBox4.Size = size;
			this.GroupBox3.TabIndex = 3;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Appearance";
			this.cbAutoHide.AutoSize = true;
			this.cbAutoHide.Enabled = false;
			global::System.Windows.Forms.Control cbAutoHide = this.cbAutoHide;
			point = new global::System.Drawing.Point(43, 59);
			cbAutoHide.Location = point;
			this.cbAutoHide.Name = "cbAutoHide";
			global::System.Windows.Forms.Control cbAutoHide2 = this.cbAutoHide;
			size = new global::System.Drawing.Size(71, 17);
			cbAutoHide2.Size = size;
			this.cbAutoHide.TabIndex = 5;
			this.cbAutoHide.Text = "Auto-hide";
			this.cbAutoHide.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button3 = this.Button4;
			point = new global::System.Drawing.Point(87, 19);
			button3.Location = point;
			this.Button4.Name = "Button4";
			global::System.Windows.Forms.Control button4 = this.Button4;
			size = new global::System.Drawing.Size(75, 23);
			button4.Size = size;
			this.Button4.TabIndex = 6;
			this.Button4.Text = "Font";
			this.Button4.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button5 = this.Button5;
			point = new global::System.Drawing.Point(43, 82);
			button5.Location = point;
			this.Button5.Name = "Button5";
			global::System.Windows.Forms.Control button6 = this.Button5;
			size = new global::System.Drawing.Size(75, 23);
			button6.Size = size;
			this.Button5.TabIndex = 9;
			this.Button5.Text = "Reset";
			this.Button5.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button7 = this.Button3;
			point = new global::System.Drawing.Point(6, 19);
			button7.Location = point;
			this.Button3.Name = "Button3";
			global::System.Windows.Forms.Control button8 = this.Button3;
			size = new global::System.Drawing.Size(75, 23);
			button8.Size = size;
			this.Button3.TabIndex = 8;
			this.Button3.Text = "Color";
			this.Button3.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button9 = this.Button2;
			point = new global::System.Drawing.Point(12, 144);
			button9.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button10 = this.Button2;
			size = new global::System.Drawing.Size(112, 23);
			button10.Size = size;
			this.Button2.TabIndex = 4;
			this.Button2.Text = "Send Feedback";
			this.Button2.UseVisualStyleBackColor = true;
			this.FontDialog1.AllowScriptChange = false;
			this.FontDialog1.AllowVectorFonts = false;
			this.FontDialog1.AllowVerticalFonts = false;
			this.FontDialog1.MaxSize = 18;
			this.FontDialog1.MinSize = 8;
			this.FontDialog1.ShowColor = true;
			this.FontDialog1.ShowEffects = false;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(267, 174);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "barsetting";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bob Pony OS Bar Settings";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x04000162 RID: 354
		private global::System.ComponentModel.IContainer components;
	}
}
