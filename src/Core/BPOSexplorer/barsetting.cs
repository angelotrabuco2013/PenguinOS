using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BPOSexplorer.My;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class barsetting : Form
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00038E88 File Offset: 0x00037288
		[DebuggerNonUserCode]
		public barsetting()
		{
			List<WeakReference> _ENCList = barsetting.__ENCList;
			lock (_ENCList)
			{
				barsetting.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000397D0 File Offset: 0x00037BD0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000397E8 File Offset: 0x00037BE8
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000397F4 File Offset: 0x00037BF4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0003980C File Offset: 0x00037C0C
		internal virtual RadioButton rbTop
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbTop;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rbTop_CheckedChanged);
				bool flag = this._rbTop != null;
				if (flag)
				{
					this._rbTop.CheckedChanged -= eventHandler;
				}
				this._rbTop = value;
				flag = this._rbTop != null;
				if (flag)
				{
					this._rbTop.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0003986C File Offset: 0x00037C6C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00039884 File Offset: 0x00037C84
		internal virtual RadioButton rbRight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbRight;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbRight = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00039890 File Offset: 0x00037C90
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000398A8 File Offset: 0x00037CA8
		internal virtual RadioButton rbBottom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbBottom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbBottom = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000398B4 File Offset: 0x00037CB4
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000398CC File Offset: 0x00037CCC
		internal virtual RadioButton rbLeft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rbLeft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rbLeft = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000398D8 File Offset: 0x00037CD8
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000398F0 File Offset: 0x00037CF0
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00039950 File Offset: 0x00037D50
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00039968 File Offset: 0x00037D68
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00039974 File Offset: 0x00037D74
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0003998C File Offset: 0x00037D8C
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				bool flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000399EC File Offset: 0x00037DEC
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00039A04 File Offset: 0x00037E04
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				bool flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00039A64 File Offset: 0x00037E64
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00039A7C File Offset: 0x00037E7C
		internal virtual ColorDialog ColorDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColorDialog1 = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00039A88 File Offset: 0x00037E88
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00039AA0 File Offset: 0x00037EA0
		internal virtual CheckBox cbAutoHide
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbAutoHide;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbAutoHide = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00039AAC File Offset: 0x00037EAC
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00039AC4 File Offset: 0x00037EC4
		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				bool flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click -= eventHandler;
				}
				this._Button4 = value;
				flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00039B24 File Offset: 0x00037F24
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00039B3C File Offset: 0x00037F3C
		internal virtual FontDialog FontDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FontDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FontDialog1 = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00039B48 File Offset: 0x00037F48
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00039B60 File Offset: 0x00037F60
		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				bool flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click -= eventHandler;
				}
				this._Button5 = value;
				flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00039BC0 File Offset: 0x00037FC0
		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Feedback.Hide();
			MyProject.Forms.Feedback.Show();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00039BE4 File Offset: 0x00037FE4
		private void Button3_Click(object sender, EventArgs e)
		{
			this.ColorDialog1.ShowDialog();
			MyProject.Forms.Form.Taskbar.BackColor = this.ColorDialog1.Color;
			MySettingsProperty.Settings.BarColor = MyProject.Forms.Form.Taskbar.BackColor;
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00039C4C File Offset: 0x0003804C
		private void Button4_Click(object sender, EventArgs e)
		{
			this.FontDialog1.ShowDialog();
			MyProject.Forms.Form.Taskbar.Font = this.FontDialog1.Font;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00039C7C File Offset: 0x0003807C
		private void Button5_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form.Taskbar.BackColor = Color.White;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00039C9C File Offset: 0x0003809C
		private void rbTop_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00039CA0 File Offset: 0x000380A0
		private void InitDialog()
		{
			ApplicationBar bposexplorer = modMain.BPOSexplorer;
			this.cbAutoHide.Checked = bposexplorer.AutoHide;
			this.rbLeft.Checked = bposexplorer.Edge == ApplicationBar.ABEdge.abeLeft;
			this.rbTop.Checked = bposexplorer.Edge == ApplicationBar.ABEdge.abeTop;
			this.rbRight.Checked = bposexplorer.Edge == ApplicationBar.ABEdge.abeRight;
			this.rbBottom.Checked = bposexplorer.Edge == ApplicationBar.ABEdge.abeBottom;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00039D20 File Offset: 0x00038120
		private void Button1_Click(object sender, EventArgs e)
		{
			this.ApplyChanges();
			this.Close();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00039D34 File Offset: 0x00038134
		private void ApplyChanges()
		{
			ApplicationBar bposexplorer = modMain.BPOSexplorer;
		}

		// Token: 0x04000161 RID: 353
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000163 RID: 355
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000164 RID: 356
		[AccessedThroughProperty("rbTop")]
		private RadioButton _rbTop;

		// Token: 0x04000165 RID: 357
		[AccessedThroughProperty("rbRight")]
		private RadioButton _rbRight;

		// Token: 0x04000166 RID: 358
		[AccessedThroughProperty("rbBottom")]
		private RadioButton _rbBottom;

		// Token: 0x04000167 RID: 359
		[AccessedThroughProperty("rbLeft")]
		private RadioButton _rbLeft;

		// Token: 0x04000168 RID: 360
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000169 RID: 361
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400016A RID: 362
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400016B RID: 363
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400016C RID: 364
		[AccessedThroughProperty("ColorDialog1")]
		private ColorDialog _ColorDialog1;

		// Token: 0x0400016D RID: 365
		[AccessedThroughProperty("cbAutoHide")]
		private CheckBox _cbAutoHide;

		// Token: 0x0400016E RID: 366
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x0400016F RID: 367
		[AccessedThroughProperty("FontDialog1")]
		private FontDialog _FontDialog1;

		// Token: 0x04000170 RID: 368
		[AccessedThroughProperty("Button5")]
		private Button _Button5;
	}
}
