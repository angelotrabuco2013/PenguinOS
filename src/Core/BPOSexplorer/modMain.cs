using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer
{
	// Token: 0x02000020 RID: 32
	[StandardModule]
	internal sealed class modMain
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00030BA0 File Offset: 0x0002EFA0
		public static void main()
		{
			modMain.formMain = new Form();
			modMain.formSettings = new barsetting();
			modMain.niMain.MouseDoubleClick += modMain.niMain_MouseDoubleClick;
			modMain.niMain.MouseDown += modMain.niMain_MouseDown;
			modMain.niMain.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			modMain.niMain.Visible = true;
			modMain.MainFormLoaded = false;
			modMain.frmToload = modMain.formMain;
			modMain.frmToload.Show();
			Application.Run();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00030C34 File Offset: 0x0002F034
		public static void ExitApp()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00030C38 File Offset: 0x0002F038
		private static void niMain_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			modMain.formMain.Activate();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00030C48 File Offset: 0x0002F048
		private static void niMain_MouseDown(object sender, MouseEventArgs e)
		{
			modMain.mainMenu.MenuItems.Clear();
			bool mainFormLoaded = modMain.MainFormLoaded;
			if (mainFormLoaded)
			{
				MenuItem menuItem = modMain.mainMenu.MenuItems.Add("&Show");
				menuItem.Name = "mnuShow";
				menuItem.Click += modMain.mainMenu_Click;
			}
			MenuItem menuItem2 = modMain.mainMenu.MenuItems.Add("&Donate");
			menuItem2.Name = "mnuDonate";
			menuItem2.Click += modMain.mainMenu_Click;
			MenuItem menuItem3 = modMain.mainMenu.MenuItems.Add("&About");
			menuItem3.Name = "mnuAbout";
			menuItem3.Click += modMain.mainMenu_Click;
			MenuItem menuItem4 = modMain.mainMenu.MenuItems.Add("&Exit");
			menuItem4.Name = "mnuExit";
			menuItem4.Click += modMain.mainMenu_Click;
			modMain.niMain.ContextMenu = modMain.mainMenu;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00030D5C File Offset: 0x0002F15C
		private static void mainMenu_Click(object sender, EventArgs e)
		{
			string name = ((MenuItem)sender).Name;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00030D7C File Offset: 0x0002F17C
		public static void donate()
		{
			Process.Start("http://www.aiglemedia.com/donate.php");
		}

		// Token: 0x0400013E RID: 318
		public const string strDonate = "http://www.aiglemedia.com/donate.php";

		// Token: 0x0400013F RID: 319
		public static Form formMain;

		// Token: 0x04000140 RID: 320
		public static barsetting formSettings;

		// Token: 0x04000141 RID: 321
		public static ApplicationBar BPOSexplorer;

		// Token: 0x04000142 RID: 322
		public static NotifyIcon niMain = new NotifyIcon();

		// Token: 0x04000143 RID: 323
		private static Form frmToload = new Form();

		// Token: 0x04000144 RID: 324
		private static ContextMenu mainMenu = new ContextMenu();

		// Token: 0x04000145 RID: 325
		public static bool MainFormLoaded;
	}
}
