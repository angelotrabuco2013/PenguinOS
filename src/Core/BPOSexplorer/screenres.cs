using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000029 RID: 41
	[DesignerGenerated]
	public partial class screenres : Form
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0003D2A4 File Offset: 0x0003B6A4
		public screenres()
		{
			base.Load += this.screenres_Load;
			List<WeakReference> _ENCList = screenres.__ENCList;
			lock (_ENCList)
			{
				screenres.__ENCList.Add(new WeakReference(this));
			}
			this.DirName = "C:\\WINDOWS\\system32\\";
			this.StyleDir = "C:\\WINDOWS\\Resources\\Themes";
			this.InitializeComponent();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0003D3EC File Offset: 0x0003B7EC
		private void screenres_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040001B1 RID: 433
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001B3 RID: 435
		private int FixHeight;

		// Token: 0x040001B4 RID: 436
		private int FixWidth;

		// Token: 0x040001B5 RID: 437
		private short XRes;

		// Token: 0x040001B6 RID: 438
		private short YRes;

		// Token: 0x040001B7 RID: 439
		private bool DidResChange;

		// Token: 0x040001B8 RID: 440
		private string DirName;

		// Token: 0x040001B9 RID: 441
		private string StyleDir;

		// Token: 0x040001BA RID: 442
		private string StyleColorDir;

		// Token: 0x040001BB RID: 443
		private string[] ScreenNames;

		// Token: 0x040001BC RID: 444
		private string[] StyleNames;

		// Token: 0x040001BD RID: 445
		private string StyleFont;

		// Token: 0x040001BE RID: 446
		private string StyleColor;

		// Token: 0x040001BF RID: 447
		private string StyleDisplayName;
	}
}
