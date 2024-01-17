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
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class endsession : Form
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00032A50 File Offset: 0x00030E50
		[DebuggerNonUserCode]
		public endsession()
		{
			base.FormClosing += this.endsession_FormClosing;
			base.Load += this.endsession_Load;
			List<WeakReference> _ENCList = endsession.__ENCList;
			lock (_ENCList)
			{
				endsession.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0003305C File Offset: 0x0003145C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00033074 File Offset: 0x00031474
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

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00033080 File Offset: 0x00031480
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00033098 File Offset: 0x00031498
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000330F8 File Offset: 0x000314F8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00033110 File Offset: 0x00031510
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00033170 File Offset: 0x00031570
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00033188 File Offset: 0x00031588
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
				this._Button3 = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00033194 File Offset: 0x00031594
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000331AC File Offset: 0x000315AC
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0003320C File Offset: 0x0003160C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00033224 File Offset: 0x00031624
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00033284 File Offset: 0x00031684
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0003329C File Offset: 0x0003169C
		internal virtual Button Button6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				bool flag = this._Button6 != null;
				if (flag)
				{
					this._Button6.Click -= eventHandler;
				}
				this._Button6 = value;
				flag = this._Button6 != null;
				if (flag)
				{
					this._Button6.Click += eventHandler;
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000332FC File Offset: 0x000316FC
		private void Button1_Click(object sender, EventArgs e)
		{
			Interaction.Shell("shutdown -s -t 0", AppWinStyle.MinimizedFocus, false, -1);
			ProjectData.EndApp();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00033314 File Offset: 0x00031714
		private void Button2_Click(object sender, EventArgs e)
		{
			Interaction.Shell("shutdown -r -t 0", AppWinStyle.MinimizedFocus, false, -1);
			ProjectData.EndApp();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0003332C File Offset: 0x0003172C
		private void Button4_Click(object sender, EventArgs e)
		{
			Interaction.Shell("logoff", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00033340 File Offset: 0x00031740
		private void endsession_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			MyProject.Forms.blackness.Hide();
			this.Hide();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00033364 File Offset: 0x00031764
		private void Button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			MyProject.Forms.blackness.Hide();
			Interaction.Shell("tsdiscon", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00033390 File Offset: 0x00031790
		private void endsession_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0003339C File Offset: 0x0003179C
		private void Button6_Click(object sender, EventArgs e)
		{
			MyProject.Forms.blackness.Hide();
			this.Hide();
		}

		// Token: 0x040000E1 RID: 225
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("Button6")]
		private Button _Button6;
	}
}
