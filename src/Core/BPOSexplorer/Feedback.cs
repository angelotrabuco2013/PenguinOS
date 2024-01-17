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
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class Feedback : Form
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00033820 File Offset: 0x00031C20
		[DebuggerNonUserCode]
		public Feedback()
		{
			List<WeakReference> _ENCList = Feedback.__ENCList;
			lock (_ENCList)
			{
				Feedback.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00033A24 File Offset: 0x00031E24
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00033A3C File Offset: 0x00031E3C
		internal virtual WebBrowser WebBrowser1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WebBrowser1 = value;
			}
		}

		// Token: 0x040000EF RID: 239
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;
	}
}
