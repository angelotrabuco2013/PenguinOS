using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer.My
{
	// Token: 0x02000022 RID: 34
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00030E48 File Offset: 0x0002F248
		[DebuggerNonUserCode]
		public MySettings()
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00030F00 File Offset: 0x0002F300
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00030F30 File Offset: 0x0002F330
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public Color BarColor
		{
			get
			{
				object obj = this["BarColor"];
				Color color;
				return (obj != null) ? ((Color)obj) : color;
			}
			set
			{
				this["BarColor"] = value;
			}
		}
	}
}
