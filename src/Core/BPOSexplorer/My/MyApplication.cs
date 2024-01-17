using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace BPOSexplorer.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000311E0 File Offset: 0x0002F5E0
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0003121C File Offset: 0x0002F61C
		[DebuggerStepThrough]
		public MyApplication()
			: base(AuthenticationMode.Windows)
		{
			List<WeakReference> _ENCList = MyApplication.__ENCList;
			lock (_ENCList)
			{
				MyApplication.__ENCList.Add(new WeakReference(this));
			}
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00031290 File Offset: 0x0002F690
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form;
		}

		// Token: 0x04000001 RID: 1
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
