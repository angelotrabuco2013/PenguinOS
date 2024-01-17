using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer.My.Resources
{
	// Token: 0x02000021 RID: 33
	[HideModuleName]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[StandardModule]
	[DebuggerNonUserCode]
	internal sealed class Resources
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00030D8C File Offset: 0x0002F18C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("BPOSexplorer.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00030DD4 File Offset: 0x0002F1D4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00030DEC File Offset: 0x0002F1EC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00030DF8 File Offset: 0x0002F1F8
		internal static string SearchDoc
		{
			get
			{
				return Resources.ResourceManager.GetString("SearchDoc", Resources.resourceCulture);
			}
		}

		// Token: 0x04000146 RID: 326
		private static ResourceManager resourceMan;

		// Token: 0x04000147 RID: 327
		private static CultureInfo resourceCulture;
	}
}
