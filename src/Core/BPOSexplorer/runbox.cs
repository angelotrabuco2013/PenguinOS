using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000025 RID: 37
	[DesignerGenerated]
	public partial class runbox : Form
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0003886C File Offset: 0x00036C6C
		[DebuggerNonUserCode]
		public runbox()
		{
			List<WeakReference> _ENCList = runbox.__ENCList;
			lock (_ENCList)
			{
				runbox.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00038BD0 File Offset: 0x00036FD0
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00038BE8 File Offset: 0x00036FE8
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
				EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00038C48 File Offset: 0x00037048
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00038C60 File Offset: 0x00037060
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00038CC0 File Offset: 0x000370C0
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00038CD8 File Offset: 0x000370D8
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00038CE4 File Offset: 0x000370E4
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00038CFC File Offset: 0x000370FC
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.TextBox1_KeyDown);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.KeyDown -= keyEventHandler;
				}
				this._TextBox1 = value;
				flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00038D5C File Offset: 0x0003715C
		private void Button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00038D68 File Offset: 0x00037168
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(this.TextBox1.Text);
				this.Hide();
			}
			catch (Exception ex)
			{
				this.Hide();
				Interaction.MsgBox("Bob Pony OS couldn't find " + this.TextBox1.Text + ". Please make sure you typed the command correctly or make sure that the file exists.", MsgBoxStyle.Exclamation, "An error has occured!");
				this.Show();
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00038DE8 File Offset: 0x000371E8
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				try
				{
					Process.Start(this.TextBox1.Text);
					this.Hide();
				}
				catch (Exception ex)
				{
					this.Hide();
					Interaction.MsgBox("Bob Pony OS couldn't find " + this.TextBox1.Text + ". Please make sure you typed the command correctly or make sure that the file exists.", MsgBoxStyle.Exclamation, "An error has occured!");
					this.Show();
				}
			}
		}

		// Token: 0x0400015B RID: 347
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400015D RID: 349
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400015E RID: 350
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400015F RID: 351
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000160 RID: 352
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;
	}
}
