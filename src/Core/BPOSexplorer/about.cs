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
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class about : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00031C54 File Offset: 0x00030054
		[DebuggerNonUserCode]
		public about()
		{
			base.Load += this.about_Load;
			List<WeakReference> _ENCList = about.__ENCList;
			lock (_ENCList)
			{
				about.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00032560 File Offset: 0x00030960
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00032578 File Offset: 0x00030978
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00032584 File Offset: 0x00030984
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0003259C File Offset: 0x0003099C
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000325FC File Offset: 0x000309FC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00032614 File Offset: 0x00030A14
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00032674 File Offset: 0x00030A74
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0003268C File Offset: 0x00030A8C
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00032698 File Offset: 0x00030A98
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000326B0 File Offset: 0x00030AB0
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000326BC File Offset: 0x00030ABC
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000326D4 File Offset: 0x00030AD4
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000326E0 File Offset: 0x00030AE0
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000326F8 File Offset: 0x00030AF8
		internal virtual Label ownername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ownername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ownername = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00032704 File Offset: 0x00030B04
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0003271C File Offset: 0x00030B1C
		internal virtual Label org
		{
			[DebuggerNonUserCode]
			get
			{
				return this._org;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._org = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00032728 File Offset: 0x00030B28
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00032740 File Offset: 0x00030B40
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0003274C File Offset: 0x00030B4C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00032764 File Offset: 0x00030B64
		internal virtual Label cpu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cpu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cpu = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00032770 File Offset: 0x00030B70
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00032788 File Offset: 0x00030B88
		internal virtual Label ram
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ram;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ram = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00032794 File Offset: 0x00030B94
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000327AC File Offset: 0x00030BAC
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000327B8 File Offset: 0x00030BB8
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000327D0 File Offset: 0x00030BD0
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000327DC File Offset: 0x00030BDC
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000327E8 File Offset: 0x00030BE8
		private void Button2_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Feedback.Hide();
			MyProject.Forms.Feedback.Show();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0003280C File Offset: 0x00030C0C
		private void about_Load(object sender, EventArgs e)
		{
			string text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString", null));
			this.cpu.Text = text;
			this.ram.Text = Conversions.ToString(Math.Round(MyProject.Computer.Info.TotalPhysicalMemory / 1048576.0));
			this.ownername.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", null));
			this.org.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOrganization", null));
		}

		// Token: 0x0400001A RID: 26
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("ownername")]
		private Label _ownername;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("org")]
		private Label _org;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("cpu")]
		private Label _cpu;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("ram")]
		private Label _ram;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("Label6")]
		private Label _Label6;
	}
}
