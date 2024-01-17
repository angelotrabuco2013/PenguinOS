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
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class helptopics : Form
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00036B18 File Offset: 0x00034F18
		[DebuggerNonUserCode]
		public helptopics()
		{
			List<WeakReference> _ENCList = helptopics.__ENCList;
			lock (_ENCList)
			{
				helptopics.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000373DC File Offset: 0x000357DC
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000373F4 File Offset: 0x000357F4
		internal virtual TabControl TabControl1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabControl1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabControl1 = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00037400 File Offset: 0x00035800
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00037418 File Offset: 0x00035818
		internal virtual TabPage TabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage1 = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00037424 File Offset: 0x00035824
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0003743C File Offset: 0x0003583C
		internal virtual TabPage TabPage2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage2 = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00037448 File Offset: 0x00035848
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00037460 File Offset: 0x00035860
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0003746C File Offset: 0x0003586C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00037484 File Offset: 0x00035884
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00037490 File Offset: 0x00035890
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000374A8 File Offset: 0x000358A8
		internal virtual TabPage TabPage3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage3 = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000374B4 File Offset: 0x000358B4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x000374CC File Offset: 0x000358CC
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000374D8 File Offset: 0x000358D8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000374F0 File Offset: 0x000358F0
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00037550 File Offset: 0x00035950
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00037568 File Offset: 0x00035968
		internal virtual TabPage TabPage4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TabPage4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TabPage4 = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00037574 File Offset: 0x00035974
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0003758C File Offset: 0x0003598C
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00037598 File Offset: 0x00035998
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000375B0 File Offset: 0x000359B0
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel1 = value;
				flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00037610 File Offset: 0x00035A10
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0003761C File Offset: 0x00035A1C
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Feedback.Show();
		}

		// Token: 0x04000131 RID: 305
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000133 RID: 307
		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		// Token: 0x04000134 RID: 308
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000135 RID: 309
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		// Token: 0x04000136 RID: 310
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000137 RID: 311
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000138 RID: 312
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		// Token: 0x04000139 RID: 313
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400013A RID: 314
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400013B RID: 315
		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		// Token: 0x0400013C RID: 316
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400013D RID: 317
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;
	}
}
