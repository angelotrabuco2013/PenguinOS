using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BPOSexplorer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class history : Form
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00033A58 File Offset: 0x00031E58
		[DebuggerNonUserCode]
		public history()
		{
			List<WeakReference> _ENCList = history.__ENCList;
			lock (_ENCList)
			{
				history.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00033E08 File Offset: 0x00032208
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00033E20 File Offset: 0x00032220
		internal virtual ToolStrip ToolStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00033E2C File Offset: 0x0003222C
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00033E44 File Offset: 0x00032244
		internal virtual ToolStripButton NewToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NewToolStripButton_Click);
				bool flag = this._NewToolStripButton != null;
				if (flag)
				{
					this._NewToolStripButton.Click -= eventHandler;
				}
				this._NewToolStripButton = value;
				flag = this._NewToolStripButton != null;
				if (flag)
				{
					this._NewToolStripButton.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00033EA4 File Offset: 0x000322A4
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00033EBC File Offset: 0x000322BC
		internal virtual ToolStripButton HelpToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.HelpToolStripButton_Click);
				bool flag = this._HelpToolStripButton != null;
				if (flag)
				{
					this._HelpToolStripButton.Click -= eventHandler;
				}
				this._HelpToolStripButton = value;
				flag = this._HelpToolStripButton != null;
				if (flag)
				{
					this._HelpToolStripButton.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00033F1C File Offset: 0x0003231C
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00033F34 File Offset: 0x00032334
		internal virtual ListView ListView1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListView1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ListView1 = value;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00033F40 File Offset: 0x00032340
		private void NewToolStripButton_Click(object sender, EventArgs e)
		{
			MsgBoxResult msgBoxResult = Interaction.MsgBox("Are you sure you want to clear history?", MsgBoxStyle.YesNo | MsgBoxStyle.Information, "NewExplorer");
			bool flag = msgBoxResult == MsgBoxResult.Yes;
			if (flag)
			{
				this.ListView1.Clear();
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00033F78 File Offset: 0x00032378
		private void HelpToolStripButton_Click(object sender, EventArgs e)
		{
			MyProject.Forms.helptopics.Show();
		}

		// Token: 0x040000F2 RID: 242
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("NewToolStripButton")]
		private ToolStripButton _NewToolStripButton;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("HelpToolStripButton")]
		private ToolStripButton _HelpToolStripButton;

		// Token: 0x040000F7 RID: 247
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;
	}
}
