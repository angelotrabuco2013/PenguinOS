using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class blackness : Form
	{
		// Token: 0x060000CA RID: 202 RVA: 0x000328E0 File Offset: 0x00030CE0
		[DebuggerNonUserCode]
		public blackness()
		{
			base.Load += this.blackness_Load;
			List<WeakReference> _ENCList = blackness.__ENCList;
			lock (_ENCList)
			{
				blackness.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00032A3C File Offset: 0x00030E3C
		private void blackness_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040000DF RID: 223
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
