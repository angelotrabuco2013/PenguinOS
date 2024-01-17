using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer.My
{
	// Token: 0x02000023 RID: 35
	[CompilerGenerated]
	[StandardModule]
	[HideModuleName]
	[DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00030F48 File Offset: 0x0002F348
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
