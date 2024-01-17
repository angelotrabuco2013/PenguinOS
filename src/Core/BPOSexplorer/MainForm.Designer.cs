namespace BPOSexplorer
{
	// Token: 0x02000027 RID: 39
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00039DD0 File Offset: 0x000381D0
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

		// Token: 0x0600022B RID: 555 RVA: 0x00039E20 File Offset: 0x00038220
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.radFit = new global::System.Windows.Forms.RadioButton();
			this.btnSetWallpaper = new global::System.Windows.Forms.Button();
			this.radFill = new global::System.Windows.Forms.RadioButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pctPreview = new global::System.Windows.Forms.PictureBox();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.tbWallpaperFileName = new global::System.Windows.Forms.TextBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.radStretch = new global::System.Windows.Forms.RadioButton();
			this.radCenter = new global::System.Windows.Forms.RadioButton();
			this.radTile = new global::System.Windows.Forms.RadioButton();
			this.btnBrowseWallpaper = new global::System.Windows.Forms.Button();
			this.wallpaperOpenFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pctPreview).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			this.radFit.AutoSize = true;
			global::System.Windows.Forms.Control radFit = this.radFit;
			global::System.Drawing.Point point = new global::System.Drawing.Point(7, 92);
			radFit.Location = point;
			this.radFit.Name = "radFit";
			global::System.Windows.Forms.Control radFit2 = this.radFit;
			global::System.Drawing.Size size = new global::System.Drawing.Size(36, 17);
			radFit2.Size = size;
			this.radFit.TabIndex = 3;
			this.radFit.Text = "Fit";
			this.radFit.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control btnSetWallpaper = this.btnSetWallpaper;
			point = new global::System.Drawing.Point(349, 283);
			btnSetWallpaper.Location = point;
			this.btnSetWallpaper.Name = "btnSetWallpaper";
			global::System.Windows.Forms.Control btnSetWallpaper2 = this.btnSetWallpaper;
			size = new global::System.Drawing.Size(88, 23);
			btnSetWallpaper2.Size = size;
			this.btnSetWallpaper.TabIndex = 14;
			this.btnSetWallpaper.Text = "Set Wallpaper";
			this.btnSetWallpaper.UseVisualStyleBackColor = true;
			this.radFill.AutoSize = true;
			global::System.Windows.Forms.Control radFill = this.radFill;
			point = new global::System.Drawing.Point(7, 116);
			radFill.Location = point;
			this.radFill.Name = "radFill";
			global::System.Windows.Forms.Control radFill2 = this.radFill;
			size = new global::System.Drawing.Size(37, 17);
			radFill2.Size = size;
			this.radFill.TabIndex = 4;
			this.radFill.Text = "Fill";
			this.radFill.UseVisualStyleBackColor = true;
			this.label2.AutoSize = true;
			global::System.Windows.Forms.Control label = this.label2;
			point = new global::System.Drawing.Point(7, 52);
			label.Location = point;
			this.label2.Name = "label2";
			global::System.Windows.Forms.Control label2 = this.label2;
			size = new global::System.Drawing.Size(80, 13);
			label2.Size = size;
			this.label2.TabIndex = 13;
			this.label2.Text = "Image Preview:";
			this.pctPreview.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control pctPreview = this.pctPreview;
			point = new global::System.Drawing.Point(10, 68);
			pctPreview.Location = point;
			this.pctPreview.Name = "pctPreview";
			global::System.Windows.Forms.Control pctPreview2 = this.pctPreview;
			size = new global::System.Drawing.Size(333, 239);
			pctPreview2.Size = size;
			this.pctPreview.TabIndex = 12;
			this.pctPreview.TabStop = false;
			global::System.Windows.Forms.Control tbWallpaperFileName = this.tbWallpaperFileName;
			point = new global::System.Drawing.Point(71, 10);
			tbWallpaperFileName.Location = point;
			this.tbWallpaperFileName.Name = "tbWallpaperFileName";
			this.tbWallpaperFileName.ReadOnly = true;
			global::System.Windows.Forms.Control tbWallpaperFileName2 = this.tbWallpaperFileName;
			size = new global::System.Drawing.Size(272, 20);
			tbWallpaperFileName2.Size = size;
			this.tbWallpaperFileName.TabIndex = 8;
			this.groupBox1.Controls.Add(this.radFill);
			this.groupBox1.Controls.Add(this.radFit);
			this.groupBox1.Controls.Add(this.radStretch);
			this.groupBox1.Controls.Add(this.radCenter);
			this.groupBox1.Controls.Add(this.radTile);
			global::System.Windows.Forms.Control groupBox = this.groupBox1;
			point = new global::System.Drawing.Point(349, 38);
			groupBox.Location = point;
			this.groupBox1.Name = "groupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.groupBox1;
			size = new global::System.Drawing.Size(88, 146);
			groupBox2.Size = size;
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Style";
			this.radStretch.AutoSize = true;
			this.radStretch.Checked = true;
			global::System.Windows.Forms.Control radStretch = this.radStretch;
			point = new global::System.Drawing.Point(7, 68);
			radStretch.Location = point;
			this.radStretch.Name = "radStretch";
			global::System.Windows.Forms.Control radStretch2 = this.radStretch;
			size = new global::System.Drawing.Size(59, 17);
			radStretch2.Size = size;
			this.radStretch.TabIndex = 2;
			this.radStretch.TabStop = true;
			this.radStretch.Text = "Stretch";
			this.radStretch.UseVisualStyleBackColor = true;
			this.radCenter.AutoSize = true;
			global::System.Windows.Forms.Control radCenter = this.radCenter;
			point = new global::System.Drawing.Point(7, 44);
			radCenter.Location = point;
			this.radCenter.Name = "radCenter";
			global::System.Windows.Forms.Control radCenter2 = this.radCenter;
			size = new global::System.Drawing.Size(56, 17);
			radCenter2.Size = size;
			this.radCenter.TabIndex = 1;
			this.radCenter.Text = "Center";
			this.radCenter.UseVisualStyleBackColor = true;
			this.radTile.AutoSize = true;
			global::System.Windows.Forms.Control radTile = this.radTile;
			point = new global::System.Drawing.Point(7, 20);
			radTile.Location = point;
			this.radTile.Name = "radTile";
			global::System.Windows.Forms.Control radTile2 = this.radTile;
			size = new global::System.Drawing.Size(42, 17);
			radTile2.Size = size;
			this.radTile.TabIndex = 0;
			this.radTile.Text = "Tile";
			this.radTile.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control btnBrowseWallpaper = this.btnBrowseWallpaper;
			point = new global::System.Drawing.Point(349, 8);
			btnBrowseWallpaper.Location = point;
			this.btnBrowseWallpaper.Name = "btnBrowseWallpaper";
			global::System.Windows.Forms.Control btnBrowseWallpaper2 = this.btnBrowseWallpaper;
			size = new global::System.Drawing.Size(88, 23);
			btnBrowseWallpaper2.Size = size;
			this.btnBrowseWallpaper.TabIndex = 10;
			this.btnBrowseWallpaper.Text = "Browse...";
			this.btnBrowseWallpaper.UseVisualStyleBackColor = true;
			this.wallpaperOpenFileDialog.Filter = "\"All Picture Files |*.bmp;*.gif;*.jpg;*.png;*.tif\"";
			this.wallpaperOpenFileDialog.Title = "Select Wallpaper";
			this.label1.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.label1;
			point = new global::System.Drawing.Point(7, 13);
			label3.Location = point;
			this.label1.Name = "label1";
			global::System.Windows.Forms.Control label4 = this.label1;
			size = new global::System.Drawing.Size(55, 13);
			label4.Size = size;
			this.label1.TabIndex = 9;
			this.label1.Text = "Wallpaper";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(445, 315);
			this.ClientSize = size;
			this.Controls.Add(this.btnSetWallpaper);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pctPreview);
			this.Controls.Add(this.tbWallpaperFileName);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnBrowseWallpaper);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Change Desktop Background";
			((global::System.ComponentModel.ISupportInitialize)this.pctPreview).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000172 RID: 370
		private global::System.ComponentModel.IContainer components;
	}
}
