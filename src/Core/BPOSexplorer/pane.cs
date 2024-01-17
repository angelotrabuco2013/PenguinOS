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
	// Token: 0x02000028 RID: 40
	[DesignerGenerated]
	public partial class pane : Form
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0003AAE0 File Offset: 0x00038EE0
		public pane()
		{
			List<WeakReference> _ENCList = pane.__ENCList;
			lock (_ENCList)
			{
				pane.__ENCList.Add(new WeakReference(this));
			}
			this.DirName = "C:\\WINDOWS\\system32\\";
			this.InitializeComponent();
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0003C5E4 File Offset: 0x0003A9E4
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0003C5FC File Offset: 0x0003A9FC
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel1 = value;
				flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0003C65C File Offset: 0x0003AA5C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0003C674 File Offset: 0x0003AA74
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0003C680 File Offset: 0x0003AA80
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0003C698 File Offset: 0x0003AA98
		internal virtual LinkLabel LinkLabel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
				bool flag = this._LinkLabel2 != null;
				if (flag)
				{
					this._LinkLabel2.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel2 = value;
				flag = this._LinkLabel2 != null;
				if (flag)
				{
					this._LinkLabel2.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0003C6F8 File Offset: 0x0003AAF8
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0003C710 File Offset: 0x0003AB10
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0003C71C File Offset: 0x0003AB1C
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0003C734 File Offset: 0x0003AB34
		internal virtual LinkLabel LinkLabel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
				bool flag = this._LinkLabel3 != null;
				if (flag)
				{
					this._LinkLabel3.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel3 = value;
				flag = this._LinkLabel3 != null;
				if (flag)
				{
					this._LinkLabel3.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0003C794 File Offset: 0x0003AB94
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0003C7AC File Offset: 0x0003ABAC
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0003C7B8 File Offset: 0x0003ABB8
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0003C7D0 File Offset: 0x0003ABD0
		internal virtual LinkLabel LinkLabel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
				bool flag = this._LinkLabel4 != null;
				if (flag)
				{
					this._LinkLabel4.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel4 = value;
				flag = this._LinkLabel4 != null;
				if (flag)
				{
					this._LinkLabel4.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0003C830 File Offset: 0x0003AC30
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0003C848 File Offset: 0x0003AC48
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0003C854 File Offset: 0x0003AC54
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0003C86C File Offset: 0x0003AC6C
		internal virtual LinkLabel LinkLabel5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel5_LinkClicked);
				bool flag = this._LinkLabel5 != null;
				if (flag)
				{
					this._LinkLabel5.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel5 = value;
				flag = this._LinkLabel5 != null;
				if (flag)
				{
					this._LinkLabel5.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0003C8CC File Offset: 0x0003ACCC
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0003C8E4 File Offset: 0x0003ACE4
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0003C8F0 File Offset: 0x0003ACF0
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0003C908 File Offset: 0x0003AD08
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0003C914 File Offset: 0x0003AD14
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0003C92C File Offset: 0x0003AD2C
		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0003C938 File Offset: 0x0003AD38
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0003C950 File Offset: 0x0003AD50
		internal virtual PictureBox PictureBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox4 = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0003C95C File Offset: 0x0003AD5C
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0003C974 File Offset: 0x0003AD74
		internal virtual PictureBox PictureBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox5 = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0003C980 File Offset: 0x0003AD80
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0003C998 File Offset: 0x0003AD98
		internal virtual PictureBox PictureBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox6 = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0003C9A4 File Offset: 0x0003ADA4
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0003C9BC File Offset: 0x0003ADBC
		internal virtual LinkLabel LinkLabel6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel6_LinkClicked);
				bool flag = this._LinkLabel6 != null;
				if (flag)
				{
					this._LinkLabel6.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel6 = value;
				flag = this._LinkLabel6 != null;
				if (flag)
				{
					this._LinkLabel6.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0003CA1C File Offset: 0x0003AE1C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0003CA34 File Offset: 0x0003AE34
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0003CA40 File Offset: 0x0003AE40
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0003CA58 File Offset: 0x0003AE58
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0003CA64 File Offset: 0x0003AE64
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0003CA7C File Offset: 0x0003AE7C
		internal virtual PictureBox PictureBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox7 = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0003CA88 File Offset: 0x0003AE88
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0003CAA0 File Offset: 0x0003AEA0
		internal virtual PictureBox PictureBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PictureBox8_Click);
				bool flag = this._PictureBox8 != null;
				if (flag)
				{
					this._PictureBox8.Click -= eventHandler;
				}
				this._PictureBox8 = value;
				flag = this._PictureBox8 != null;
				if (flag)
				{
					this._PictureBox8.Click += eventHandler;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0003CB00 File Offset: 0x0003AF00
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0003CB18 File Offset: 0x0003AF18
		internal virtual LinkLabel LinkLabel7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel7_LinkClicked);
				bool flag = this._LinkLabel7 != null;
				if (flag)
				{
					this._LinkLabel7.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel7 = value;
				flag = this._LinkLabel7 != null;
				if (flag)
				{
					this._LinkLabel7.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0003CB78 File Offset: 0x0003AF78
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0003CB90 File Offset: 0x0003AF90
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0003CB9C File Offset: 0x0003AF9C
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0003CBB4 File Offset: 0x0003AFB4
		internal virtual LinkLabel LinkLabel8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel8_LinkClicked);
				bool flag = this._LinkLabel8 != null;
				if (flag)
				{
					this._LinkLabel8.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel8 = value;
				flag = this._LinkLabel8 != null;
				if (flag)
				{
					this._LinkLabel8.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0003CC14 File Offset: 0x0003B014
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0003CC2C File Offset: 0x0003B02C
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0003CC38 File Offset: 0x0003B038
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0003CC50 File Offset: 0x0003B050
		internal virtual PictureBox PictureBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox9 = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0003CC5C File Offset: 0x0003B05C
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0003CC74 File Offset: 0x0003B074
		internal virtual PictureBox PictureBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox10 = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0003CC80 File Offset: 0x0003B080
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0003CC98 File Offset: 0x0003B098
		internal virtual LinkLabel LinkLabel9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel9_LinkClicked);
				bool flag = this._LinkLabel9 != null;
				if (flag)
				{
					this._LinkLabel9.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel9 = value;
				flag = this._LinkLabel9 != null;
				if (flag)
				{
					this._LinkLabel9.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0003CCF8 File Offset: 0x0003B0F8
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0003CD10 File Offset: 0x0003B110
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0003CD1C File Offset: 0x0003B11C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0003CD34 File Offset: 0x0003B134
		internal virtual PictureBox PictureBox11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox11 = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0003CD40 File Offset: 0x0003B140
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0003CD58 File Offset: 0x0003B158
		internal virtual LinkLabel LinkLabel10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel10_LinkClicked);
				bool flag = this._LinkLabel10 != null;
				if (flag)
				{
					this._LinkLabel10.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel10 = value;
				flag = this._LinkLabel10 != null;
				if (flag)
				{
					this._LinkLabel10.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0003CDB8 File Offset: 0x0003B1B8
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0003CDD0 File Offset: 0x0003B1D0
		internal virtual PictureBox PictureBox12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox12 = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0003CDDC File Offset: 0x0003B1DC
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0003CDF4 File Offset: 0x0003B1F4
		internal virtual LinkLabel LinkLabel11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel11_LinkClicked);
				bool flag = this._LinkLabel11 != null;
				if (flag)
				{
					this._LinkLabel11.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel11 = value;
				flag = this._LinkLabel11 != null;
				if (flag)
				{
					this._LinkLabel11.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0003CE54 File Offset: 0x0003B254
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0003CE6C File Offset: 0x0003B26C
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0003CE78 File Offset: 0x0003B278
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0003CE90 File Offset: 0x0003B290
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0003CE9C File Offset: 0x0003B29C
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0003CEB4 File Offset: 0x0003B2B4
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0003CEC0 File Offset: 0x0003B2C0
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0003CED8 File Offset: 0x0003B2D8
		internal virtual LinkLabel LinkLabel13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel13_LinkClicked);
				bool flag = this._LinkLabel13 != null;
				if (flag)
				{
					this._LinkLabel13.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel13 = value;
				flag = this._LinkLabel13 != null;
				if (flag)
				{
					this._LinkLabel13.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0003CF38 File Offset: 0x0003B338
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0003CF50 File Offset: 0x0003B350
		internal virtual LinkLabel LinkLabel14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel14_LinkClicked);
				bool flag = this._LinkLabel14 != null;
				if (flag)
				{
					this._LinkLabel14.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel14 = value;
				flag = this._LinkLabel14 != null;
				if (flag)
				{
					this._LinkLabel14.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0003CFB0 File Offset: 0x0003B3B0
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0003CFC8 File Offset: 0x0003B3C8
		internal virtual LinkLabel LinkLabel15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel15_LinkClicked);
				bool flag = this._LinkLabel15 != null;
				if (flag)
				{
					this._LinkLabel15.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel15 = value;
				flag = this._LinkLabel15 != null;
				if (flag)
				{
					this._LinkLabel15.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0003D028 File Offset: 0x0003B428
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0003D040 File Offset: 0x0003B440
		internal virtual LinkLabel LinkLabel17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler linkLabelLinkClickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel17_LinkClicked);
				bool flag = this._LinkLabel17 != null;
				if (flag)
				{
					this._LinkLabel17.LinkClicked -= linkLabelLinkClickedEventHandler;
				}
				this._LinkLabel17 = value;
				flag = this._LinkLabel17 != null;
				if (flag)
				{
					this._LinkLabel17.LinkClicked += linkLabelLinkClickedEventHandler;
				}
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0003D0A0 File Offset: 0x0003B4A0
		private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control mmsys.cpl sounds", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0003D0B4 File Offset: 0x0003B4B4
		private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control main.cpl", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0003D0C8 File Offset: 0x0003B4C8
		private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control desk.cpl,screensaver,@screensaver", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0003D0DC File Offset: 0x0003B4DC
		private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.MainForm.Show();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0003D0F0 File Offset: 0x0003B4F0
		private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			checked
			{
				this.XRes = (short)Screen.PrimaryScreen.Bounds.Width;
				this.YRes = (short)Screen.PrimaryScreen.Bounds.Height;
				MessageBox.Show(string.Concat(new string[]
				{
					"Horizontal Resolution = ",
					this.XRes.ToString(),
					Environment.NewLine,
					"Vertical Resolution = ",
					this.YRes.ToString()
				}));
				Interaction.Shell("control screen.cpl", AppWinStyle.MinimizedFocus, false, -1);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0003D18C File Offset: 0x0003B58C
		private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control intl.cpl", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0003D1A0 File Offset: 0x0003B5A0
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.barsetting.Show();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0003D1B4 File Offset: 0x0003B5B4
		private void LinkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control userpasswords2", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0003D1C8 File Offset: 0x0003B5C8
		private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,5", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0003D1DC File Offset: 0x0003B5DC
		private void LinkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.NewExplorer.WebBrowser1.Navigate("C:\\WINDOWS\\FONTS");
			MyProject.Forms.NewExplorer.Show();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0003D20C File Offset: 0x0003B60C
		private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control TimeDate.cpl", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0003D220 File Offset: 0x0003B620
		private void PictureBox8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0003D224 File Offset: 0x0003B624
		private void LinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("legacywincp.exe");
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0003D234 File Offset: 0x0003B634
		private void LinkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.helptopics.Show();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0003D248 File Offset: 0x0003B648
		private void LinkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MyProject.Forms.Feedback.Show();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0003D25C File Offset: 0x0003B65C
		private void LinkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("OptionalFeatures.exe");
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0003D26C File Offset: 0x0003B66C
		private void LinkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("rundll32.exe shell32.dll,Options_RunDLL 0", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0003D280 File Offset: 0x0003B680
		private void LinkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Interaction.Shell("control.exe sysdm.cpl", AppWinStyle.MinimizedFocus, false, -1);
		}

		// Token: 0x04000182 RID: 386
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("LinkLabel2")]
		private LinkLabel _LinkLabel2;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("LinkLabel3")]
		private LinkLabel _LinkLabel3;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("LinkLabel4")]
		private LinkLabel _LinkLabel4;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("LinkLabel5")]
		private LinkLabel _LinkLabel5;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("PictureBox4")]
		private PictureBox _PictureBox4;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("PictureBox5")]
		private PictureBox _PictureBox5;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("PictureBox6")]
		private PictureBox _PictureBox6;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("LinkLabel6")]
		private LinkLabel _LinkLabel6;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("PictureBox7")]
		private PictureBox _PictureBox7;

		// Token: 0x04000197 RID: 407
		[AccessedThroughProperty("PictureBox8")]
		private PictureBox _PictureBox8;

		// Token: 0x04000198 RID: 408
		[AccessedThroughProperty("LinkLabel7")]
		private LinkLabel _LinkLabel7;

		// Token: 0x04000199 RID: 409
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400019A RID: 410
		[AccessedThroughProperty("LinkLabel8")]
		private LinkLabel _LinkLabel8;

		// Token: 0x0400019B RID: 411
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400019C RID: 412
		[AccessedThroughProperty("PictureBox9")]
		private PictureBox _PictureBox9;

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("PictureBox10")]
		private PictureBox _PictureBox10;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("LinkLabel9")]
		private LinkLabel _LinkLabel9;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("PictureBox11")]
		private PictureBox _PictureBox11;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("LinkLabel10")]
		private LinkLabel _LinkLabel10;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("PictureBox12")]
		private PictureBox _PictureBox12;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("LinkLabel11")]
		private LinkLabel _LinkLabel11;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("LinkLabel13")]
		private LinkLabel _LinkLabel13;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("LinkLabel14")]
		private LinkLabel _LinkLabel14;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("LinkLabel15")]
		private LinkLabel _LinkLabel15;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("LinkLabel17")]
		private LinkLabel _LinkLabel17;

		// Token: 0x040001AB RID: 427
		private int FixHeight;

		// Token: 0x040001AC RID: 428
		private int FixWidth;

		// Token: 0x040001AD RID: 429
		private short XRes;

		// Token: 0x040001AE RID: 430
		private short YRes;

		// Token: 0x040001AF RID: 431
		private bool DidResChange;

		// Token: 0x040001B0 RID: 432
		private string DirName;
	}
}
