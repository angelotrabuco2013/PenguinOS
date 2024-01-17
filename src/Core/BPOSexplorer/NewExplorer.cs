using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BPOSexplorer.My;
using BPOSexplorer.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000024 RID: 36
	[DesignerGenerated]
	public partial class NewExplorer : Form
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00037640 File Offset: 0x00035A40
		[DebuggerNonUserCode]
		public NewExplorer()
		{
			base.Load += this.NewExplorer_Load;
			List<WeakReference> _ENCList = NewExplorer.__ENCList;
			lock (_ENCList)
			{
				NewExplorer.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00037F20 File Offset: 0x00036320
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00037F38 File Offset: 0x00036338
		internal virtual ToolStrip ToolStrip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00037F44 File Offset: 0x00036344
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00037F5C File Offset: 0x0003635C
		internal virtual ToolStripButton BackToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BackToolStripButton_Click);
				bool flag = this._BackToolStripButton != null;
				if (flag)
				{
					this._BackToolStripButton.Click -= eventHandler;
				}
				this._BackToolStripButton = value;
				flag = this._BackToolStripButton != null;
				if (flag)
				{
					this._BackToolStripButton.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00037FBC File Offset: 0x000363BC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00037FD4 File Offset: 0x000363D4
		internal virtual ToolStripButton ForwardToolStripButton
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ForwardToolStripButton;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ForwardToolStripButton_Click);
				bool flag = this._ForwardToolStripButton != null;
				if (flag)
				{
					this._ForwardToolStripButton.Click -= eventHandler;
				}
				this._ForwardToolStripButton = value;
				flag = this._ForwardToolStripButton != null;
				if (flag)
				{
					this._ForwardToolStripButton.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00038034 File Offset: 0x00036434
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0003804C File Offset: 0x0003644C
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00038058 File Offset: 0x00036458
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00038070 File Offset: 0x00036470
		internal virtual ToolStripComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_Click);
				EventHandler eventHandler2 = new EventHandler(this.ComboBox1_SelectedIndexChanged_1);
				EventHandler eventHandler3 = new EventHandler(this.ComboBox1_TextChanged);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.ComboBox1_KeyDown);
				bool flag = this._ComboBox1 != null;
				if (flag)
				{
					this._ComboBox1.Click -= eventHandler;
					this._ComboBox1.SelectedIndexChanged -= eventHandler2;
					this._ComboBox1.TextChanged -= eventHandler3;
					this._ComboBox1.KeyDown -= keyEventHandler;
				}
				this._ComboBox1 = value;
				flag = this._ComboBox1 != null;
				if (flag)
				{
					this._ComboBox1.Click += eventHandler;
					this._ComboBox1.SelectedIndexChanged += eventHandler2;
					this._ComboBox1.TextChanged += eventHandler3;
					this._ComboBox1.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0003814C File Offset: 0x0003654C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00038164 File Offset: 0x00036564
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00038170 File Offset: 0x00036570
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00038188 File Offset: 0x00036588
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000381E8 File Offset: 0x000365E8
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00038200 File Offset: 0x00036600
		internal virtual ToolStripButton ToolStripButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton3_Click);
				bool flag = this._ToolStripButton3 != null;
				if (flag)
				{
					this._ToolStripButton3.Click -= eventHandler;
				}
				this._ToolStripButton3 = value;
				flag = this._ToolStripButton3 != null;
				if (flag)
				{
					this._ToolStripButton3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00038260 File Offset: 0x00036660
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00038278 File Offset: 0x00036678
		internal virtual ToolStripSeparator ToolStripButton4
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
				this._ToolStripButton4 = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00038284 File Offset: 0x00036684
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0003829C File Offset: 0x0003669C
		internal virtual ToolStripButton ToolStripButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton5_Click);
				bool flag = this._ToolStripButton5 != null;
				if (flag)
				{
					this._ToolStripButton5.Click -= eventHandler;
				}
				this._ToolStripButton5 = value;
				flag = this._ToolStripButton5 != null;
				if (flag)
				{
					this._ToolStripButton5.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000382FC File Offset: 0x000366FC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00038314 File Offset: 0x00036714
		internal virtual ToolStripButton ToolStripButton1
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
				EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click);
				bool flag = this._ToolStripButton1 != null;
				if (flag)
				{
					this._ToolStripButton1.Click -= eventHandler;
				}
				this._ToolStripButton1 = value;
				flag = this._ToolStripButton1 != null;
				if (flag)
				{
					this._ToolStripButton1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00038374 File Offset: 0x00036774
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0003838C File Offset: 0x0003678C
		internal virtual ToolStripButton ToolStripButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton6_Click);
				bool flag = this._ToolStripButton6 != null;
				if (flag)
				{
					this._ToolStripButton6.Click -= eventHandler;
				}
				this._ToolStripButton6 = value;
				flag = this._ToolStripButton6 != null;
				if (flag)
				{
					this._ToolStripButton6.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000383EC File Offset: 0x000367EC
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00038404 File Offset: 0x00036804
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00038410 File Offset: 0x00036810
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00038428 File Offset: 0x00036828
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
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.WebBrowser1_NewWindowExtended);
				WebBrowserNavigatedEventHandler webBrowserNavigatedEventHandler = new WebBrowserNavigatedEventHandler(this.WebBrowser1_DocumentCompleted);
				bool flag = this._WebBrowser1 != null;
				if (flag)
				{
					this._WebBrowser1.NewWindow -= cancelEventHandler;
					this._WebBrowser1.Navigated -= webBrowserNavigatedEventHandler;
				}
				this._WebBrowser1 = value;
				flag = this._WebBrowser1 != null;
				if (flag)
				{
					this._WebBrowser1.NewWindow += cancelEventHandler;
					this._WebBrowser1.Navigated += webBrowserNavigatedEventHandler;
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000384B0 File Offset: 0x000368B0
		private void BackToolStripButton_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.GoBack();
			this.ForwardToolStripButton.Enabled = true;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000384D0 File Offset: 0x000368D0
		private void ForwardToolStripButton_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.GoForward();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000384E0 File Offset: 0x000368E0
		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000384E4 File Offset: 0x000368E4
		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000384E8 File Offset: 0x000368E8
		private void NewExplorer_Load(object sender, EventArgs e)
		{
			this.ComboBox1.Items.Clear();
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				this.ComboBox1.Items.Add(driveInfo);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00038538 File Offset: 0x00036938
		private void ComboBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0003853C File Offset: 0x0003693C
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.WebBrowser1.Navigate(this.ComboBox1.Text);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00038558 File Offset: 0x00036958
		private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0003855C File Offset: 0x0003695C
		private void TextLabels_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00038560 File Offset: 0x00036960
		private void WebBrowser1_DocumentCompleted(object sender, WebBrowserNavigatedEventArgs e)
		{
			bool flag = !this.WebBrowser1.Url.ToString().Contains("tempsearch.search-ms");
			if (flag)
			{
				this.Text = this.WebBrowser1.DocumentTitle + " - Codenamed NewExplorer";
				MyProject.Forms.history.ListView1.Items.Add(this.ComboBox1.Text);
				this.ComboBox1.Text = this.WebBrowser1.Url.ToString().Replace("file:///", "").ToString();
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00038604 File Offset: 0x00036A04
		private void ToolBarToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00038608 File Offset: 0x00036A08
		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Refresh();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00038618 File Offset: 0x00036A18
		private void ComboBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0003861C File Offset: 0x00036A1C
		private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			this.WebBrowser1.Navigate(this.ComboBox1.Text);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00038638 File Offset: 0x00036A38
		private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			this.BackToolStripButton.Enabled = true;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0003864C File Offset: 0x00036A4C
		private void ToolStripButton5_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Navigate(this.WebBrowser1.Url.ToString() + "/..");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00038678 File Offset: 0x00036A78
		private void ToolStripButton1_Click(object sender, EventArgs e)
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
			this.WebBrowser1.Navigate(Application.UserAppDataPath + "\\tempsearch.search-ms");
			this.Text = "Search Results for " + text + " in C:\\";
			this.ComboBox1.Text = "search://" + text;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00038774 File Offset: 0x00036B74
		private void WebBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			bool flag = !this.WebBrowser1.Url.ToString().Contains("tempsearch.search-ms");
			if (flag)
			{
				this.Text = this.WebBrowser1.Url.ToString().Replace("file:///", "").ToString();
				this.ToolStripButton5.Enabled = true;
			}
			else
			{
				this.ToolStripButton5.Enabled = false;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000387F0 File Offset: 0x00036BF0
		private void ToolStripButton6_Click(object sender, EventArgs e)
		{
			this.WebBrowser1.Navigate(this.ComboBox1.Text);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0003880C File Offset: 0x00036C0C
		private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.WebBrowser1.Navigate(this.ComboBox1.Text);
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00038844 File Offset: 0x00036C44
		private void ToolStripButton3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.history.Show();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00038858 File Offset: 0x00036C58
		private void WebBrowser1_NewWindowExtended(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0400014B RID: 331
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400014D RID: 333
		[AccessedThroughProperty("ToolStrip")]
		private ToolStrip _ToolStrip;

		// Token: 0x0400014E RID: 334
		[AccessedThroughProperty("BackToolStripButton")]
		private ToolStripButton _BackToolStripButton;

		// Token: 0x0400014F RID: 335
		[AccessedThroughProperty("ForwardToolStripButton")]
		private ToolStripButton _ForwardToolStripButton;

		// Token: 0x04000150 RID: 336
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000151 RID: 337
		[AccessedThroughProperty("ComboBox1")]
		private ToolStripComboBox _ComboBox1;

		// Token: 0x04000152 RID: 338
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000153 RID: 339
		[AccessedThroughProperty("ToolStripButton2")]
		private ToolStripButton _ToolStripButton2;

		// Token: 0x04000154 RID: 340
		[AccessedThroughProperty("ToolStripButton3")]
		private ToolStripButton _ToolStripButton3;

		// Token: 0x04000155 RID: 341
		[AccessedThroughProperty("ToolStripButton4")]
		private ToolStripSeparator _ToolStripButton4;

		// Token: 0x04000156 RID: 342
		[AccessedThroughProperty("ToolStripButton5")]
		private ToolStripButton _ToolStripButton5;

		// Token: 0x04000157 RID: 343
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		// Token: 0x04000158 RID: 344
		[AccessedThroughProperty("ToolStripButton6")]
		private ToolStripButton _ToolStripButton6;

		// Token: 0x04000159 RID: 345
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x0400015A RID: 346
		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;
	}
}
