using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BPOSexplorer.My;
using BPOSexplorer.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace BPOSexplorer
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class Form : Form
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00033F9C File Offset: 0x0003239C
		public Form()
		{
			base.Load += this.Form1_Load;
			base.FormClosing += this.Form_FormClosing;
			List<WeakReference> _ENCList = Form.__ENCList;
			lock (_ENCList)
			{
				Form.__ENCList.Add(new WeakReference(this));
			}
			this.buttonsInitialized = false;
			this.labels = new string[] { "T", "L", "B", "R", "F" };
			this.InitializeComponent();
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00035278 File Offset: 0x00033678
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00035290 File Offset: 0x00033690
		internal virtual ToolStrip Taskbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Taskbar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(this.Taskbar_ItemClicked);
				bool flag = this._Taskbar != null;
				if (flag)
				{
					this._Taskbar.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._Taskbar = value;
				flag = this._Taskbar != null;
				if (flag)
				{
					this._Taskbar.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000352F0 File Offset: 0x000336F0
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00035308 File Offset: 0x00033708
		internal virtual ToolStripDropDownButton ToolStripButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripButton1 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00035314 File Offset: 0x00033714
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0003532C File Offset: 0x0003372C
		internal virtual ToolStripMenuItem NotepaderToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NotepaderToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NotepaderToolStripMenuItem_Click);
				bool flag = this._NotepaderToolStripMenuItem != null;
				if (flag)
				{
					this._NotepaderToolStripMenuItem.Click -= eventHandler;
				}
				this._NotepaderToolStripMenuItem = value;
				flag = this._NotepaderToolStripMenuItem != null;
				if (flag)
				{
					this._NotepaderToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0003538C File Offset: 0x0003378C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000353A4 File Offset: 0x000337A4
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000353B0 File Offset: 0x000337B0
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000353C8 File Offset: 0x000337C8
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
				bool flag = this._ExitToolStripMenuItem != null;
				if (flag)
				{
					this._ExitToolStripMenuItem.Click -= eventHandler;
				}
				this._ExitToolStripMenuItem = value;
				flag = this._ExitToolStripMenuItem != null;
				if (flag)
				{
					this._ExitToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00035428 File Offset: 0x00033828
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00035440 File Offset: 0x00033840
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0003544C File Offset: 0x0003384C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00035464 File Offset: 0x00033864
		internal virtual Timer clocktime
		{
			[DebuggerNonUserCode]
			get
			{
				return this._clocktime;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.clocktime_Tick);
				bool flag = this._clocktime != null;
				if (flag)
				{
					this._clocktime.Tick -= eventHandler;
				}
				this._clocktime = value;
				flag = this._clocktime != null;
				if (flag)
				{
					this._clocktime.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000354C4 File Offset: 0x000338C4
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000354DC File Offset: 0x000338DC
		internal virtual ToolStripMenuItem AboutToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AboutToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.AboutToolStripMenuItem_Click);
				bool flag = this._AboutToolStripMenuItem != null;
				if (flag)
				{
					this._AboutToolStripMenuItem.Click -= eventHandler;
				}
				this._AboutToolStripMenuItem = value;
				flag = this._AboutToolStripMenuItem != null;
				if (flag)
				{
					this._AboutToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0003553C File Offset: 0x0003393C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00035554 File Offset: 0x00033954
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00035560 File Offset: 0x00033960
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00035578 File Offset: 0x00033978
		internal virtual ContextMenuStrip taskbaroptions
		{
			[DebuggerNonUserCode]
			get
			{
				return this._taskbaroptions;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._taskbaroptions = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00035584 File Offset: 0x00033984
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0003559C File Offset: 0x0003399C
		internal virtual ToolStripSeparator ToolStripSeparator7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator7 = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000355A8 File Offset: 0x000339A8
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000355C0 File Offset: 0x000339C0
		internal virtual ToolStripButton ToolStripButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton4_Click);
				bool flag = this._ToolStripButton4 != null;
				if (flag)
				{
					this._ToolStripButton4.Click -= eventHandler;
				}
				this._ToolStripButton4 = value;
				flag = this._ToolStripButton4 != null;
				if (flag)
				{
					this._ToolStripButton4.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00035620 File Offset: 0x00033A20
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00035638 File Offset: 0x00033A38
		internal virtual ToolStripMenuItem SettingsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SettingsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SettingsToolStripMenuItem_Click);
				bool flag = this._SettingsToolStripMenuItem != null;
				if (flag)
				{
					this._SettingsToolStripMenuItem.Click -= eventHandler;
				}
				this._SettingsToolStripMenuItem = value;
				flag = this._SettingsToolStripMenuItem != null;
				if (flag)
				{
					this._SettingsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00035698 File Offset: 0x00033A98
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000356B0 File Offset: 0x00033AB0
		internal virtual ToolStripMenuItem ProcessesManagerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProcessesManagerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ProcessesManagerToolStripMenuItem_Click);
				bool flag = this._ProcessesManagerToolStripMenuItem != null;
				if (flag)
				{
					this._ProcessesManagerToolStripMenuItem.Click -= eventHandler;
				}
				this._ProcessesManagerToolStripMenuItem = value;
				flag = this._ProcessesManagerToolStripMenuItem != null;
				if (flag)
				{
					this._ProcessesManagerToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00035710 File Offset: 0x00033B10
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00035728 File Offset: 0x00033B28
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00035734 File Offset: 0x00033B34
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0003574C File Offset: 0x00033B4C
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00035758 File Offset: 0x00033B58
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00035770 File Offset: 0x00033B70
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem3 = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0003577C File Offset: 0x00033B7C
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00035794 File Offset: 0x00033B94
		internal virtual ToolStripDropDownButton ToolStripDropDownButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripDropDownButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripDropDownButton1 = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000357A0 File Offset: 0x00033BA0
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000357B8 File Offset: 0x00033BB8
		internal virtual ToolStripMenuItem EaseOfAccessToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EaseOfAccessToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EaseOfAccessToolStripMenuItem = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000357C4 File Offset: 0x00033BC4
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000357DC File Offset: 0x00033BDC
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000357E8 File Offset: 0x00033BE8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00035800 File Offset: 0x00033C00
		internal virtual ToolStripMenuItem RunToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RunToolStripMenuItem_Click);
				bool flag = this._RunToolStripMenuItem != null;
				if (flag)
				{
					this._RunToolStripMenuItem.Click -= eventHandler;
				}
				this._RunToolStripMenuItem = value;
				flag = this._RunToolStripMenuItem != null;
				if (flag)
				{
					this._RunToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00035860 File Offset: 0x00033C60
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00035878 File Offset: 0x00033C78
		internal virtual ToolStripMenuItem ToolStripMenuItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem4_Click);
				bool flag = this._ToolStripMenuItem4 != null;
				if (flag)
				{
					this._ToolStripMenuItem4.Click -= eventHandler;
				}
				this._ToolStripMenuItem4 = value;
				flag = this._ToolStripMenuItem4 != null;
				if (flag)
				{
					this._ToolStripMenuItem4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000358D8 File Offset: 0x00033CD8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000358F0 File Offset: 0x00033CF0
		internal virtual ToolStripMenuItem OnScreenKeyboardToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OnScreenKeyboardToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OnScreenKeyboardToolStripMenuItem_Click);
				bool flag = this._OnScreenKeyboardToolStripMenuItem != null;
				if (flag)
				{
					this._OnScreenKeyboardToolStripMenuItem.Click -= eventHandler;
				}
				this._OnScreenKeyboardToolStripMenuItem = value;
				flag = this._OnScreenKeyboardToolStripMenuItem != null;
				if (flag)
				{
					this._OnScreenKeyboardToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00035950 File Offset: 0x00033D50
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00035968 File Offset: 0x00033D68
		internal virtual ToolStripMenuItem NewExplorerBETAToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewExplorerBETAToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NewExplorerBETAToolStripMenuItem_Click);
				bool flag = this._NewExplorerBETAToolStripMenuItem != null;
				if (flag)
				{
					this._NewExplorerBETAToolStripMenuItem.Click -= eventHandler;
				}
				this._NewExplorerBETAToolStripMenuItem = value;
				flag = this._NewExplorerBETAToolStripMenuItem != null;
				if (flag)
				{
					this._NewExplorerBETAToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000359C8 File Offset: 0x00033DC8
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000359E0 File Offset: 0x00033DE0
		internal virtual ToolStripButton ToolStripMenuItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem5_Click);
				bool flag = this._ToolStripMenuItem5 != null;
				if (flag)
				{
					this._ToolStripMenuItem5.Click -= eventHandler;
				}
				this._ToolStripMenuItem5 = value;
				flag = this._ToolStripMenuItem5 != null;
				if (flag)
				{
					this._ToolStripMenuItem5.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00035A40 File Offset: 0x00033E40
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00035A58 File Offset: 0x00033E58
		internal virtual ToolStripMenuItem GoogleChromeToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GoogleChromeToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GoogleChromeToolStripMenuItem_Click);
				bool flag = this._GoogleChromeToolStripMenuItem != null;
				if (flag)
				{
					this._GoogleChromeToolStripMenuItem.Click -= eventHandler;
				}
				this._GoogleChromeToolStripMenuItem = value;
				flag = this._GoogleChromeToolStripMenuItem != null;
				if (flag)
				{
					this._GoogleChromeToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00035AB8 File Offset: 0x00033EB8
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00035AD0 File Offset: 0x00033ED0
		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator5 = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00035ADC File Offset: 0x00033EDC
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00035AF4 File Offset: 0x00033EF4
		internal virtual ToolStripLabel ToolStripLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripLabel1 = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00035B00 File Offset: 0x00033F00
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00035B18 File Offset: 0x00033F18
		internal virtual ToolStripLabel ToolStripLabel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripLabel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripLabel2 = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00035B24 File Offset: 0x00033F24
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00035B3C File Offset: 0x00033F3C
		internal virtual ToolStripMenuItem BPOSSoftwareCenterToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BPOSSoftwareCenterToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BPOSSoftwareCenterToolStripMenuItem_Click);
				bool flag = this._BPOSSoftwareCenterToolStripMenuItem != null;
				if (flag)
				{
					this._BPOSSoftwareCenterToolStripMenuItem.Click -= eventHandler;
				}
				this._BPOSSoftwareCenterToolStripMenuItem = value;
				flag = this._BPOSSoftwareCenterToolStripMenuItem != null;
				if (flag)
				{
					this._BPOSSoftwareCenterToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00035B9C File Offset: 0x00033F9C
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00035BB4 File Offset: 0x00033FB4
		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator6 = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00035BC0 File Offset: 0x00033FC0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00035BD8 File Offset: 0x00033FD8
		internal virtual ToolStripSeparator ToolStripSeparator8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripSeparator8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripSeparator8 = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00035BE4 File Offset: 0x00033FE4
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00035BFC File Offset: 0x00033FFC
		internal virtual ToolStripMenuItem BarSettingsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BarSettingsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BarSettingsToolStripMenuItem_Click_1);
				bool flag = this._BarSettingsToolStripMenuItem != null;
				if (flag)
				{
					this._BarSettingsToolStripMenuItem.Click -= eventHandler;
				}
				this._BarSettingsToolStripMenuItem = value;
				flag = this._BarSettingsToolStripMenuItem != null;
				if (flag)
				{
					this._BarSettingsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00035C5C File Offset: 0x0003405C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00035C74 File Offset: 0x00034074
		internal virtual ToolStripMenuItem SearchToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SearchToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SearchToolStripMenuItem_Click_1);
				bool flag = this._SearchToolStripMenuItem != null;
				if (flag)
				{
					this._SearchToolStripMenuItem.Click -= eventHandler;
				}
				this._SearchToolStripMenuItem = value;
				flag = this._SearchToolStripMenuItem != null;
				if (flag)
				{
					this._SearchToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00035CD4 File Offset: 0x000340D4
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00035CEC File Offset: 0x000340EC
		internal virtual ToolStripMenuItem UsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.UsToolStripMenuItem_Click);
				bool flag = this._UsToolStripMenuItem != null;
				if (flag)
				{
					this._UsToolStripMenuItem.Click -= eventHandler;
				}
				this._UsToolStripMenuItem = value;
				flag = this._UsToolStripMenuItem != null;
				if (flag)
				{
					this._UsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00035D4C File Offset: 0x0003414C
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00035D64 File Offset: 0x00034164
		internal virtual ToolStripLabel userin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._userin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._userin = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00035D70 File Offset: 0x00034170
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00035D88 File Offset: 0x00034188
		internal virtual ToolStripButton ToolStripButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton2_Click);
				bool flag = this._ToolStripButton2 != null;
				if (flag)
				{
					this._ToolStripButton2.Click -= eventHandler;
				}
				this._ToolStripButton2 = value;
				flag = this._ToolStripButton2 != null;
				if (flag)
				{
					this._ToolStripButton2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00035DE8 File Offset: 0x000341E8
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00035E00 File Offset: 0x00034200
		internal virtual ToolStripMenuItem MagnifyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MagnifyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.MagnifyToolStripMenuItem_Click);
				bool flag = this._MagnifyToolStripMenuItem != null;
				if (flag)
				{
					this._MagnifyToolStripMenuItem.Click -= eventHandler;
				}
				this._MagnifyToolStripMenuItem = value;
				flag = this._MagnifyToolStripMenuItem != null;
				if (flag)
				{
					this._MagnifyToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00035E60 File Offset: 0x00034260
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00035E78 File Offset: 0x00034278
		internal virtual ToolStripMenuItem NarratorToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NarratorToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NarratorToolStripMenuItem_Click);
				bool flag = this._NarratorToolStripMenuItem != null;
				if (flag)
				{
					this._NarratorToolStripMenuItem.Click -= eventHandler;
				}
				this._NarratorToolStripMenuItem = value;
				flag = this._NarratorToolStripMenuItem != null;
				if (flag)
				{
					this._NarratorToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00035ED8 File Offset: 0x000342D8
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00035EF0 File Offset: 0x000342F0
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00035F50 File Offset: 0x00034350
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00035F68 File Offset: 0x00034368
		internal virtual ToolStripMenuItem User2ToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._User2ToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.User2ToolStripMenuItem_Click);
				bool flag = this._User2ToolStripMenuItem != null;
				if (flag)
				{
					this._User2ToolStripMenuItem.Click -= eventHandler;
				}
				this._User2ToolStripMenuItem = value;
				flag = this._User2ToolStripMenuItem != null;
				if (flag)
				{
					this._User2ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00035FC8 File Offset: 0x000343C8
		protected override void WndProc(ref Message M)
		{
			bool flag = M.Msg == 537;
			checked
			{
				if (flag)
				{
					IntPtr wparam = M.WParam;
					bool flag2 = wparam == (IntPtr)32768;
					if (flag2)
					{
						int num = Marshal.ReadInt32(M.LParam, 4);
						flag2 = num == 2;
						if (flag2)
						{
							Form.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME = default(Form.DEV_BROADCAST_VOLUME);
							object obj = Marshal.PtrToStructure(M.LParam, typeof(Form.DEV_BROADCAST_VOLUME));
							Form.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME2;
							dev_BROADCAST_VOLUME = ((obj != null) ? ((Form.DEV_BROADCAST_VOLUME)obj) : dev_BROADCAST_VOLUME2);
							flag2 = dev_BROADCAST_VOLUME.Dbcv_Flags == 0;
							if (flag2)
							{
								int num2 = 0;
								for (;;)
								{
									flag = Math.Pow(2.0, (double)num2) == (double)dev_BROADCAST_VOLUME.Dbcv_Unitmask;
									if (flag)
									{
										break;
									}
									num2++;
									int num3 = num2;
									int num4 = 20;
									if (num3 > num4)
									{
										goto IL_196;
									}
								}
								string text = Conversions.ToString(Strings.Chr(65 + num2)) + ":\\";
								Interaction.MsgBox("Looks like a USB device was plugged in!\r\n\r\nThe drive letter is: " + text.ToString(), MsgBoxStyle.OkOnly, null);
								MyProject.Forms.NewExplorer.ComboBox1.Items.Clear();
								foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
								{
									MyProject.Forms.NewExplorer.ComboBox1.Items.Add(driveInfo);
								}
								MyProject.Forms.NewExplorer.Show();
								MyProject.Forms.NewExplorer.WebBrowser1.Navigate("file://" + text.ToString());
							}
							IL_196:;
						}
					}
					else
					{
						flag2 = wparam == (IntPtr)32772;
						if (flag2)
						{
							int num5 = Marshal.ReadInt32(M.LParam, 4);
							flag2 = num5 == 2;
							if (flag2)
							{
								Form.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME3 = default(Form.DEV_BROADCAST_VOLUME);
								object obj2 = Marshal.PtrToStructure(M.LParam, typeof(Form.DEV_BROADCAST_VOLUME));
								Form.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME2;
								dev_BROADCAST_VOLUME3 = ((obj2 != null) ? ((Form.DEV_BROADCAST_VOLUME)obj2) : dev_BROADCAST_VOLUME2);
								flag2 = dev_BROADCAST_VOLUME3.Dbcv_Flags == 0;
								if (flag2)
								{
									int num6 = 0;
									for (;;)
									{
										flag = Math.Pow(2.0, (double)num6) == (double)dev_BROADCAST_VOLUME3.Dbcv_Unitmask;
										if (flag)
										{
											break;
										}
										num6++;
										int num7 = num6;
										int num4 = 20;
										if (num7 > num4)
										{
											goto IL_282;
										}
									}
									string text2 = Conversions.ToString(Strings.Chr(65 + num6)) + ":\\";
									Interaction.MsgBox("Looks like a volume device was removed!\r\n\r\nThe drive letter is: " + text2.ToString(), MsgBoxStyle.OkOnly, null);
								}
								IL_282:;
							}
						}
					}
				}
				base.WndProc(ref M);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00036264 File Offset: 0x00034664
		public bool OSXIsOn()
		{
			int num = Process.GetProcessesByName("winlogon").Count<Process>();
			return num == 0;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0003628C File Offset: 0x0003468C
		private void NewWinToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00036290 File Offset: 0x00034690
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.blackness.Show();
			MyProject.Forms.endsession.Show();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000362B4 File Offset: 0x000346B4
		private void NotepaderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("Notepad.exe");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Bob Pony OS couldn't open Notepad! Please reinstall Bob Pony OS to fix this problem.", MsgBoxStyle.Exclamation, "An error has occured!");
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00036304 File Offset: 0x00034704
		private void InternetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00036308 File Offset: 0x00034708
		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0003630C File Offset: 0x0003470C
		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00036318 File Offset: 0x00034718
		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00036324 File Offset: 0x00034724
		private void clocktime_Tick(object sender, EventArgs e)
		{
			this.ToolStripLabel1.Text = Strings.Format(DateAndTime.Now, "HH:mm:ss tt");
			bool isAvailable = MyProject.Computer.Network.IsAvailable;
			if (isAvailable)
			{
				this.ToolStripLabel2.Enabled = true;
			}
			else
			{
				this.ToolStripLabel2.Enabled = false;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00036384 File Offset: 0x00034784
		private void Form1_Load(object sender, EventArgs e)
		{
			bool flag = Conversions.ToBoolean(Operators.NotObject(Wallpaper.SupportFitFillWallpaperStyles));
			if (flag)
			{
				ProjectData.EndApp();
			}
			this.Taskbar.BackColor = MySettingsProperty.Settings.BarColor;
			this.userin.Text = Environment.UserName;
			this.User2ToolStripMenuItem.Text = Environment.UserName;
			this.clocktime.Start();
			this.Timer1.Start();
			this.Timer1_Tick(RuntimeHelpers.GetObjectValue(sender), e);
			this.BottomMiddleDock();
			PowerStatus powerStatus = SystemInformation.PowerStatus;
			flag = powerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery;
			if (flag)
			{
				this.UsToolStripMenuItem.Visible = false;
			}
			this.Width = Screen.PrimaryScreen.Bounds.Width;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00036450 File Offset: 0x00034850
		private void BottomMiddleDock()
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			Point point = new Point(0, checked(height - 35));
			this.Location = point;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0003649C File Offset: 0x0003489C
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.about.Hide();
			MyProject.Forms.about.Show();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000364C0 File Offset: 0x000348C0
		private void BackgroundSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000364C4 File Offset: 0x000348C4
		private void BottomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Taskbar.Dock = DockStyle.Bottom;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000364D8 File Offset: 0x000348D8
		private void TopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Taskbar.Dock = DockStyle.Top;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000364EC File Offset: 0x000348EC
		private void LeftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Taskbar.Dock = DockStyle.Left;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00036500 File Offset: 0x00034900
		private void RightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Taskbar.Dock = DockStyle.Right;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00036514 File Offset: 0x00034914
		private void BarSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.barsetting.Hide();
			MyProject.Forms.barsetting.Show();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00036538 File Offset: 0x00034938
		private void GadgetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0003653C File Offset: 0x0003493C
		private void ToolStripButton4_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("sndvol.exe");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("An error has occured. Please reinstall Bob Pony OS.", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00036588 File Offset: 0x00034988
		private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Interaction.Shell("C:\\Windows\\system32\\control.exe desk.cpl", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0003659C File Offset: 0x0003499C
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000365A0 File Offset: 0x000349A0
		private void DevToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Interaction.Shell("cmd", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000365B4 File Offset: 0x000349B4
		private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Interaction.Shell("logoff.exe", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000365C8 File Offset: 0x000349C8
		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.runbox.Show();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000365DC File Offset: 0x000349DC
		private void BarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.barsetting.Hide();
			MyProject.Forms.barsetting.Show();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00036600 File Offset: 0x00034A00
		private void PaneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.pane.Hide();
			MyProject.Forms.pane.Show();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00036624 File Offset: 0x00034A24
		private void ScreenshotToolToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00036628 File Offset: 0x00034A28
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.helptopics.Hide();
			MyProject.Forms.helptopics.Show();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0003664C File Offset: 0x00034A4C
		private void ToolStripDropDownButton2_ButtonClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00036658 File Offset: 0x00034A58
		private void NewExplorerBETAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.NewExplorer.Hide();
			MyProject.Forms.NewExplorer.Show();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0003667C File Offset: 0x00034A7C
		private void ProcessesManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("taskmgr");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0003668C File Offset: 0x00034A8C
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Feedback.Hide();
			MyProject.Forms.Feedback.Show();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000366B0 File Offset: 0x00034AB0
		private void GoogleChromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("firefox");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Bob Pony OS couldn't open Mozilla Firefox! Please reinstall Bob Pony OS to fix this problem.", MsgBoxStyle.Exclamation, "An error has occured!");
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00036700 File Offset: 0x00034B00
		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.pane.Show();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00036714 File Offset: 0x00034B14
		private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00036718 File Offset: 0x00034B18
		private void BPOSSoftwareCenterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Interaction.Shell("bpossc.exe", AppWinStyle.MinimizedFocus, false, -1);
			}
			catch (Exception ex)
			{
				MyProject.Forms.bpsc.Show();
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00036768 File Offset: 0x00034B68
		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("bpossc.exe -installedapps");
			}
			catch (Exception ex)
			{
				MyProject.Forms.bpsc.Show();
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000367B8 File Offset: 0x00034BB8
		private void SearchToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Enter Search Term:", "NewExplorer Search", "", -1, -1);
			string text2 = Resources.SearchDoc.ToString().ToString().ToString()
				.ToString();
			string text3 = text2.Replace("abcdefg", text);
			bool flag = !MyProject.Computer.FileSystem.FileExists(Application.UserAppDataPath + "\\tempsearch.search-ms");
			if (flag)
			{
				File.Create(Application.UserAppDataPath + "\\tempsearch.search-ms").Dispose();
			}
			StreamWriter streamWriter = new StreamWriter(Application.UserAppDataPath + "\\tempsearch.search-ms");
			streamWriter.Write(text3);
			streamWriter.Close();
			MyProject.Forms.NewExplorer.WebBrowser1.Navigate(Application.UserAppDataPath + "\\tempsearch.search-ms");
			MyProject.Forms.NewExplorer.Text = "Search Results for " + text + " in C:\\";
			MyProject.Forms.NewExplorer.Show();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000368C0 File Offset: 0x00034CC0
		private void UsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PowerStatus powerStatus = SystemInformation.PowerStatus;
			MessageBox.Show("BatteryChargeStatus : " + Conversions.ToString((int)powerStatus.BatteryChargeStatus));
			MessageBox.Show("BatteryFullLifetime : " + Conversions.ToString(powerStatus.BatteryFullLifetime));
			MessageBox.Show("BatteryLifePercent : " + Conversions.ToString(powerStatus.BatteryLifePercent));
			MessageBox.Show("BatteryLifeRemaining : " + Conversions.ToString(powerStatus.BatteryLifeRemaining));
			MessageBox.Show("PowerLineStatus : " + Conversions.ToString((int)powerStatus.PowerLineStatus));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0003695C File Offset: 0x00034D5C
		private void OnScreenKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("osk.exe");
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0003696C File Offset: 0x00034D6C
		private void MagnifyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("magnify.exe");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0003697C File Offset: 0x00034D7C
		private void NarratorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("narrator.exe");
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0003698C File Offset: 0x00034D8C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\bpossc-config.xml");
			if (flag)
			{
				this.Timer1.Stop();
			}
			else
			{
				try
				{
					string text = "http://ipg29.ml/bpos.repo/updstatus";
					WebClient webClient = new WebClient();
					StreamReader streamReader = new StreamReader(webClient.OpenRead(text));
					flag = Operators.CompareString(streamReader.ReadToEnd(), "BPOS-SC_available", false) == 0;
					if (flag)
					{
						MsgBoxResult msgBoxResult = Interaction.MsgBox("The Bob Pony OS Software Center is here! Would you like to install it?", MsgBoxStyle.YesNo | MsgBoxStyle.Information, "BP OS Software Center");
						bool flag2 = msgBoxResult == MsgBoxResult.Yes;
						if (flag2)
						{
							MyProject.Computer.Network.DownloadFile("http://ipg29.ml/BPOS.repo/activeupdate.exe", Application.StartupPath + "\\bpossc.exe", "bobponyos", "updatercheck", true, 10000, true, UICancelOption.DoNothing);
							Interaction.MsgBox("Downloaded the Software Center! Press OK to launch.", MsgBoxStyle.OkOnly, null);
							Process.Start("bpossc.exe");
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("bpos-sc fail");
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00036AA4 File Offset: 0x00034EA4
		private void Taskbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00036AA8 File Offset: 0x00034EA8
		private void User2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.NewExplorer.WebBrowser1.Navigate("file://C:\\Users\\" + Environment.UserName + "\\");
			MyProject.Forms.NewExplorer.Show();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00036AE8 File Offset: 0x00034EE8
		private void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00036AF4 File Offset: 0x00034EF4
		private void BarSettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.barsetting.Show();
		}

		// Token: 0x040000F8 RID: 248
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("Taskbar")]
		private ToolStrip _Taskbar;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripDropDownButton _ToolStripButton1;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("NotepaderToolStripMenuItem")]
		private ToolStripMenuItem _NotepaderToolStripMenuItem;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("clocktime")]
		private Timer _clocktime;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("AboutToolStripMenuItem")]
		private ToolStripMenuItem _AboutToolStripMenuItem;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("taskbaroptions")]
		private ContextMenuStrip _taskbaroptions;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("ToolStripSeparator7")]
		private ToolStripSeparator _ToolStripSeparator7;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("ToolStripButton4")]
		private ToolStripButton _ToolStripButton4;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("SettingsToolStripMenuItem")]
		private ToolStripMenuItem _SettingsToolStripMenuItem;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("ProcessesManagerToolStripMenuItem")]
		private ToolStripMenuItem _ProcessesManagerToolStripMenuItem;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("ToolStripDropDownButton1")]
		private ToolStripDropDownButton _ToolStripDropDownButton1;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("EaseOfAccessToolStripMenuItem")]
		private ToolStripMenuItem _EaseOfAccessToolStripMenuItem;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("RunToolStripMenuItem")]
		private ToolStripMenuItem _RunToolStripMenuItem;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripMenuItem _ToolStripMenuItem4;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("OnScreenKeyboardToolStripMenuItem")]
		private ToolStripMenuItem _OnScreenKeyboardToolStripMenuItem;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("NewExplorerBETAToolStripMenuItem")]
		private ToolStripMenuItem _NewExplorerBETAToolStripMenuItem;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("ToolStripMenuItem5")]
		private ToolStripButton _ToolStripMenuItem5;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("GoogleChromeToolStripMenuItem")]
		private ToolStripMenuItem _GoogleChromeToolStripMenuItem;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("ToolStripLabel2")]
		private ToolStripLabel _ToolStripLabel2;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("BPOSSoftwareCenterToolStripMenuItem")]
		private ToolStripMenuItem _BPOSSoftwareCenterToolStripMenuItem;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("ToolStripSeparator6")]
		private ToolStripSeparator _ToolStripSeparator6;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("ToolStripSeparator8")]
		private ToolStripSeparator _ToolStripSeparator8;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("BarSettingsToolStripMenuItem")]
		private ToolStripMenuItem _BarSettingsToolStripMenuItem;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("SearchToolStripMenuItem")]
		private ToolStripMenuItem _SearchToolStripMenuItem;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("UsToolStripMenuItem")]
		private ToolStripMenuItem _UsToolStripMenuItem;

		// Token: 0x0400011D RID: 285
		[AccessedThroughProperty("userin")]
		private ToolStripLabel _userin;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		// Token: 0x0400011F RID: 287
		[AccessedThroughProperty("MagnifyToolStripMenuItem")]
		private ToolStripMenuItem _MagnifyToolStripMenuItem;

		// Token: 0x04000120 RID: 288
		[AccessedThroughProperty("NarratorToolStripMenuItem")]
		private ToolStripMenuItem _NarratorToolStripMenuItem;

		// Token: 0x04000121 RID: 289
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000122 RID: 290
		[AccessedThroughProperty("User2ToolStripMenuItem")]
		private ToolStripMenuItem _User2ToolStripMenuItem;

		// Token: 0x04000123 RID: 291
		private int i;

		// Token: 0x04000124 RID: 292
		private Button[] dockButton;

		// Token: 0x04000125 RID: 293
		private bool buttonsInitialized;

		// Token: 0x04000126 RID: 294
		private string[] labels;

		// Token: 0x04000127 RID: 295
		private int m_ChildFormNumber;

		// Token: 0x04000128 RID: 296
		private const int WM_DEVICECHANGE = 537;

		// Token: 0x04000129 RID: 297
		private const int DBT_DEVICEARRIVAL = 32768;

		// Token: 0x0400012A RID: 298
		private const int DBT_DEVICEREMOVECOMPLETE = 32772;

		// Token: 0x0400012B RID: 299
		private const int DBT_DEVTYP_VOLUME = 2;

		// Token: 0x0200001E RID: 30
		private struct DEV_BROADCAST_VOLUME
		{
			// Token: 0x0400012C RID: 300
			public int Dbcv_Size;

			// Token: 0x0400012D RID: 301
			public int Dbcv_Devicetype;

			// Token: 0x0400012E RID: 302
			public int Dbcv_Reserved;

			// Token: 0x0400012F RID: 303
			public int Dbcv_Unitmask;

			// Token: 0x04000130 RID: 304
			public short Dbcv_Flags;
		}
	}
}
