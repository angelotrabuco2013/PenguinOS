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
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class bpsc : Form
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000333C8 File Offset: 0x000317C8
		[DebuggerNonUserCode]
		public bpsc()
		{
			List<WeakReference> _ENCList = bpsc.__ENCList;
			lock (_ENCList)
			{
				bpsc.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00033744 File Offset: 0x00031B44
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0003375C File Offset: 0x00031B5C
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00033768 File Offset: 0x00031B68
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00033780 File Offset: 0x00031B80
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0003378C File Offset: 0x00031B8C
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000337A4 File Offset: 0x00031BA4
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

		// Token: 0x060000F1 RID: 241 RVA: 0x00033804 File Offset: 0x00031C04
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x040000EA RID: 234
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
