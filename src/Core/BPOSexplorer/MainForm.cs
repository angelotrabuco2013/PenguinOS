using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000027 RID: 39
	[DesignerGenerated]
	public partial class MainForm : Form
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00039D5C File Offset: 0x0003815C
		public MainForm()
		{
			base.Load += this.MainForm_Load;
			List<WeakReference> _ENCList = MainForm.__ENCList;
			lock (_ENCList)
			{
				MainForm.__ENCList.Add(new WeakReference(this));
			}
			this.wallpaperFileName = null;
			this.InitializeComponent();
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0003A650 File Offset: 0x00038A50
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0003A668 File Offset: 0x00038A68
		private virtual RadioButton radFit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radFit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radFit = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0003A674 File Offset: 0x00038A74
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0003A68C File Offset: 0x00038A8C
		private virtual Button btnSetWallpaper
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSetWallpaper;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnSetWallpaper_Click);
				bool flag = this._btnSetWallpaper != null;
				if (flag)
				{
					this._btnSetWallpaper.Click -= eventHandler;
				}
				this._btnSetWallpaper = value;
				flag = this._btnSetWallpaper != null;
				if (flag)
				{
					this._btnSetWallpaper.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0003A6EC File Offset: 0x00038AEC
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0003A704 File Offset: 0x00038B04
		private virtual RadioButton radFill
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radFill;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radFill = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0003A710 File Offset: 0x00038B10
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0003A728 File Offset: 0x00038B28
		private virtual Label label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._label2 = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0003A734 File Offset: 0x00038B34
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0003A74C File Offset: 0x00038B4C
		private virtual PictureBox pctPreview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pctPreview;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pctPreview = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0003A758 File Offset: 0x00038B58
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0003A770 File Offset: 0x00038B70
		private virtual ToolTip toolTip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._toolTip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._toolTip = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0003A77C File Offset: 0x00038B7C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0003A794 File Offset: 0x00038B94
		private virtual TextBox tbWallpaperFileName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tbWallpaperFileName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tbWallpaperFileName = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0003A7A0 File Offset: 0x00038BA0
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0003A7B8 File Offset: 0x00038BB8
		private virtual GroupBox groupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._groupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._groupBox1 = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0003A7C4 File Offset: 0x00038BC4
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0003A7DC File Offset: 0x00038BDC
		private virtual RadioButton radStretch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radStretch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radStretch = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0003A7E8 File Offset: 0x00038BE8
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0003A800 File Offset: 0x00038C00
		private virtual RadioButton radCenter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radCenter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radCenter = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0003A80C File Offset: 0x00038C0C
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0003A824 File Offset: 0x00038C24
		private virtual RadioButton radTile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._radTile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._radTile = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0003A830 File Offset: 0x00038C30
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0003A848 File Offset: 0x00038C48
		private virtual Button btnBrowseWallpaper
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnBrowseWallpaper;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.btnBrowseWallpaper_Click);
				bool flag = this._btnBrowseWallpaper != null;
				if (flag)
				{
					this._btnBrowseWallpaper.Click -= eventHandler;
				}
				this._btnBrowseWallpaper = value;
				flag = this._btnBrowseWallpaper != null;
				if (flag)
				{
					this._btnBrowseWallpaper.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0003A8A8 File Offset: 0x00038CA8
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0003A8C0 File Offset: 0x00038CC0
		private virtual OpenFileDialog wallpaperOpenFileDialog
		{
			[DebuggerNonUserCode]
			get
			{
				return this._wallpaperOpenFileDialog;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._wallpaperOpenFileDialog = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0003A8CC File Offset: 0x00038CCC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0003A8E4 File Offset: 0x00038CE4
		private virtual Label label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._label1 = value;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0003A8F0 File Offset: 0x00038CF0
		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0003A8F4 File Offset: 0x00038CF4
		private void btnBrowseWallpaper_Click(object sender, EventArgs e)
		{
			bool flag = DialogResult.OK == this.wallpaperOpenFileDialog.ShowDialog();
			checked
			{
				if (flag)
				{
					this.wallpaperFileName = this.wallpaperOpenFileDialog.FileName;
					this.tbWallpaperFileName.Text = this.wallpaperFileName;
					Image image = Image.FromFile(this.wallpaperFileName);
					flag = image.Width < this.pctPreview.Width && image.Height < this.pctPreview.Height;
					if (flag)
					{
						this.pctPreview.Image = image;
					}
					else
					{
						float num = (float)image.Width / (float)image.Height;
						float num2 = (float)this.pctPreview.Width / (float)this.pctPreview.Height;
						flag = num >= num2;
						if (flag)
						{
							this.pctPreview.Image = image.GetThumbnailImage(this.pctPreview.Width, (int)Math.Round((double)((float)this.pctPreview.Width / num)), null, IntPtr.Zero);
						}
						else
						{
							this.pctPreview.Image = image.GetThumbnailImage((int)Math.Round((double)(unchecked((float)this.pctPreview.Height * num))), this.pctPreview.Height, null, IntPtr.Zero);
						}
					}
				}
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0003AA38 File Offset: 0x00038E38
		private void btnSetWallpaper_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.wallpaperFileName);
			if (flag)
			{
				Wallpaper.SetDesktopWallpaper(this.wallpaperFileName, this.SelectedWallpaperStyle);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0003AA6C File Offset: 0x00038E6C
		private WallpaperStyle SelectedWallpaperStyle
		{
			get
			{
				bool flag = this.radTile.Checked;
				WallpaperStyle wallpaperStyle;
				if (flag)
				{
					wallpaperStyle = WallpaperStyle.Tile;
				}
				else
				{
					flag = this.radCenter.Checked;
					if (flag)
					{
						wallpaperStyle = WallpaperStyle.Center;
					}
					else
					{
						flag = this.radStretch.Checked;
						if (flag)
						{
							wallpaperStyle = WallpaperStyle.Stretch;
						}
						else
						{
							flag = this.radFit.Checked;
							if (flag)
							{
								wallpaperStyle = WallpaperStyle.Fit;
							}
							else
							{
								wallpaperStyle = WallpaperStyle.Fill;
							}
						}
					}
				}
				return wallpaperStyle;
			}
		}

		// Token: 0x04000171 RID: 369
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000173 RID: 371
		[AccessedThroughProperty("radFit")]
		private RadioButton _radFit;

		// Token: 0x04000174 RID: 372
		[AccessedThroughProperty("btnSetWallpaper")]
		private Button _btnSetWallpaper;

		// Token: 0x04000175 RID: 373
		[AccessedThroughProperty("radFill")]
		private RadioButton _radFill;

		// Token: 0x04000176 RID: 374
		[AccessedThroughProperty("label2")]
		private Label _label2;

		// Token: 0x04000177 RID: 375
		[AccessedThroughProperty("pctPreview")]
		private PictureBox _pctPreview;

		// Token: 0x04000178 RID: 376
		[AccessedThroughProperty("toolTip")]
		private ToolTip _toolTip;

		// Token: 0x04000179 RID: 377
		[AccessedThroughProperty("tbWallpaperFileName")]
		private TextBox _tbWallpaperFileName;

		// Token: 0x0400017A RID: 378
		[AccessedThroughProperty("groupBox1")]
		private GroupBox _groupBox1;

		// Token: 0x0400017B RID: 379
		[AccessedThroughProperty("radStretch")]
		private RadioButton _radStretch;

		// Token: 0x0400017C RID: 380
		[AccessedThroughProperty("radCenter")]
		private RadioButton _radCenter;

		// Token: 0x0400017D RID: 381
		[AccessedThroughProperty("radTile")]
		private RadioButton _radTile;

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("btnBrowseWallpaper")]
		private Button _btnBrowseWallpaper;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("wallpaperOpenFileDialog")]
		private OpenFileDialog _wallpaperOpenFileDialog;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("label1")]
		private Label _label1;

		// Token: 0x04000181 RID: 385
		private string wallpaperFileName;
	}
}
