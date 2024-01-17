using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace BPOSexplorer
{
	// Token: 0x0200000B RID: 11
	public class ApplicationBar : NativeWindow
	{
		// Token: 0x06000069 RID: 105
		[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern uint SHBPOSexplorerMessage(int dwMessage, ref ApplicationBar.BPOSexplorerDATA pData);

		// Token: 0x0600006A RID: 106
		[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int RegisterWindowMessage([MarshalAs(UnmanagedType.VBByRefStr)] ref string msg);

		// Token: 0x0600006B RID: 107
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600006C RID: 108
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern short GetAsyncKeyState(IntPtr vKey);

		// Token: 0x0600006D RID: 109
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetClientRect(IntPtr hwnd, ref Rectangle lpRect);

		// Token: 0x0600006E RID: 110
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetTickCount();

		// Token: 0x0600006F RID: 111
		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowLongA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetWindowLong(IntPtr hwnd, IntPtr nIndex);

		// Token: 0x06000070 RID: 112
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr KillTimer(IntPtr hwnd, IntPtr nIDEvent);

		// Token: 0x06000071 RID: 113
		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "MessageBoxA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr MessageBox(IntPtr hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpText, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpCaption, IntPtr wType);

		// Token: 0x06000072 RID: 114
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr SetTimer(IntPtr hWnd, IntPtr nIDEvent, IntPtr uElapse, IntPtr lpTimerFunc);

		// Token: 0x06000073 RID: 115
		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "SetWindowLongA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr SetWindowLong(IntPtr hwnd, IntPtr nIndex, IntPtr dwNewLong);

		// Token: 0x06000074 RID: 116
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr SetWindowPos(IntPtr hwnd, IntPtr hWndInsertAfter, IntPtr x, IntPtr y, IntPtr cx, IntPtr cy, IntPtr wFlags);

		// Token: 0x06000075 RID: 117
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr ShowWindow(IntPtr hwnd, IntPtr nCmdShow);

		// Token: 0x06000076 RID: 118
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr UpdateWindow(IntPtr hwnd);

		// Token: 0x06000077 RID: 119
		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr RegCloseKey(IntPtr hKey);

		// Token: 0x06000078 RID: 120
		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegCreateKeyExA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr RegCreateKeyEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, IntPtr Reserved, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClass, IntPtr dwOptions, IntPtr samDesired, ref IntPtr lpSecurityAttributes, ref IntPtr phkResult, ref IntPtr lpdwDisposition);

		// Token: 0x06000079 RID: 121
		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegOpenKeyExA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr RegOpenKeyEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, IntPtr ulOptions, IntPtr samDesired, ref IntPtr phkResult);

		// Token: 0x0600007A RID: 122
		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr RegQueryValueEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, IntPtr lpReserved, ref IntPtr lpType, IntPtr lpData, ref IntPtr lpcbData);

		// Token: 0x0600007B RID: 123
		[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegSetValueExA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr RegSetValueEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, IntPtr Reserved, IntPtr dwType, IntPtr lpData, IntPtr cbData);

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0002E5E4 File Offset: 0x0002C9E4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0002E5FC File Offset: 0x0002C9FC
		private virtual Form dockForm
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dockForm;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dockForm = value;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0002E608 File Offset: 0x0002CA08
		public ApplicationBar()
		{
			List<WeakReference> _ENCList = ApplicationBar.__ENCList;
			lock (_ENCList)
			{
				ApplicationBar.__ENCList.Add(new WeakReference(this));
			}
			this.CallbackMessageID = Convert.ToUInt32(0);
			this.IsBPOSexplorerMode = false;
			this.ResetApplicationBar();
			this.ABS.cbSize = Strings.Len(this.ABS);
			this.ABS.abEdge = ApplicationBar.ABEdge.abeFloat;
			this.ABS.abFlags = (ApplicationBar.ABFlags)31;
			this.ABS.bAutoHide = false;
			this.ABS.bAlwaysOnTop = true;
			this.ABS.nTimerInterval = 400;
			this.ABS.szSizeInc.cx = 1;
			this.ABS.szSizeInc.cy = 1;
			this.ABS.szDockSize.Width = 32;
			this.ABS.szDockSize.Height = 32;
			this.ABS.rcFloat.X = 0;
			this.ABS.rcFloat.Y = 0;
			this.ABS.rcFloat.Width = 0;
			this.ABS.rcFloat.Height = 0;
			this.ABS.nMinSize = new Size(0, 0);
			this.ABS.nMaxSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			this.ABS.szMinDockSize.Width = 35;
			this.ABS.szMinDockSize.Height = 35;
			this.ABS.szMaxDockSize.Width = this.ABS.nMaxSize.Width;
			this.ABS.szMaxDockSize.Height = this.ABS.nMaxSize.Height;
			this.ABS.abTaskEntry = ApplicationBar.ABTaskEntry.abtFloatDependent;
			this.FabEdgeProposedPrev = ApplicationBar.ABEdge.abeUnknown;
			this.FbFullScreenAppOpen = false;
			this.FbAutoHideIsVisible = false;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0002E830 File Offset: 0x0002CC30
		public void Extends(Form dForm)
		{
			this.dockForm = dForm;
			this.CallbackMessageID = this.registerCallbackMessage();
			bool flag = this.CallbackMessageID.Equals(0);
			if (flag)
			{
				throw new Exception("RegisterCallbackMessage failed");
			}
			base.AssignHandle(this.dockForm.Handle);
			this.OnCreate();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0002E890 File Offset: 0x0002CC90
		internal void OnDestroy()
		{
			ApplicationBar.KillTimer(this.dockForm.Handle, (IntPtr)100);
			this.Edge = ApplicationBar.ABEdge.abeUnknown;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0002E8B4 File Offset: 0x0002CCB4
		public void Detach()
		{
			this.OnDestroy();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0002E8C0 File Offset: 0x0002CCC0
		internal void OnCreate()
		{
			ApplicationBar.SetTimer(this.dockForm.Handle, (IntPtr)100, (IntPtr)this.ABS.nTimerInterval, (IntPtr)0);
			this.ABS.rcFloat = this.dockForm.DesktopBounds;
			this.BPOSexplorerNew();
			this.UpdateBar();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0002E924 File Offset: 0x0002CD24
		public void UpdateBar()
		{
			this.Edge = this.Edge;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0002E938 File Offset: 0x0002CD38
		private bool BPOSexplorerNew()
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.uEdge = 5;
				return !ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(0), ref bposexplorerDATA).Equals(0);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0002E9B4 File Offset: 0x0002CDB4
		private bool BPOSexplorerRemove()
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				return Conversions.ToBoolean(Interaction.IIf(!ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(1), ref bposexplorerDATA).Equals(0), true, false));
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0002EA3C File Offset: 0x0002CE3C
		private void BPOSexplorerQueryPos(ref Rectangle appRect, ApplicationBar.ABEdge abEdge)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.uEdge = (int)Convert.ToUInt32((int)abEdge);
				bposexplorerDATA.rc = appRect;
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(2), ref bposexplorerDATA);
				appRect = bposexplorerDATA.rc;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0002EAC4 File Offset: 0x0002CEC4
		private void BPOSexplorerSetPos(ref Rectangle appRect, ApplicationBar.ABEdge abEdge)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.uEdge = (int)Convert.ToUInt32((int)abEdge);
				bposexplorerDATA.rc = appRect;
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(3), ref bposexplorerDATA);
				appRect = bposexplorerDATA.rc;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0002EB4C File Offset: 0x0002CF4C
		private void BPOSexplorerActivate()
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(6), ref bposexplorerDATA);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0002EBAC File Offset: 0x0002CFAC
		private void BPOSexplorerWindowPosChanged()
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(9), ref bposexplorerDATA);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0002EC0C File Offset: 0x0002D00C
		public bool BPOSexplorerSetAutoHideBar(bool hideValue, ApplicationBar.ABEdge abEdge)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.hWnd = this.dockForm.Handle;
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.uEdge = (int)Convert.ToUInt32((int)abEdge);
				if (hideValue)
				{
					bposexplorerDATA.lParam = (IntPtr)1;
				}
				else
				{
					bposexplorerDATA.lParam = (IntPtr)0;
				}
				return Conversions.ToBoolean(Interaction.IIf(!ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(8), ref bposexplorerDATA).Equals(0), true, false));
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0002ECC4 File Offset: 0x0002D0C4
		private IntPtr BPOSexplorerGetAutoHideBar(ApplicationBar.ABEdge abEdge)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.uEdge = (int)Convert.ToUInt32((int)abEdge);
				return (IntPtr)Convert.ToInt64(ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(7), ref bposexplorerDATA));
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0002ED2C File Offset: 0x0002D12C
		private ApplicationBar.BPOSexplorerStates BPOSexplorerGetTaskbarState()
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				uint num = ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(4), ref bposexplorerDATA);
				return (ApplicationBar.BPOSexplorerStates)Convert.ToInt32(num);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0002ED84 File Offset: 0x0002D184
		private void BPOSexplorerSetTaskbarState(ApplicationBar.BPOSexplorerStates state)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				bposexplorerDATA.lParam = (IntPtr)((int)state);
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(10), ref bposexplorerDATA);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0002EDE0 File Offset: 0x0002D1E0
		private void BPOSexplorerGetTaskbarPos(ref Rectangle taskRect)
		{
			ApplicationBar.BPOSexplorerDATA bposexplorerDATA = default(ApplicationBar.BPOSexplorerDATA);
			checked
			{
				bposexplorerDATA.cbSize = (int)Convert.ToUInt32(Marshal.SizeOf(bposexplorerDATA));
				bposexplorerDATA.uCallbackMessage = (int)this.CallbackMessageID;
				ApplicationBar.SHBPOSexplorerMessage((int)Convert.ToUInt32(5), ref bposexplorerDATA);
				taskRect = bposexplorerDATA.rc;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0002EE3C File Offset: 0x0002D23C
		private uint registerCallbackMessage()
		{
			string text = Guid.NewGuid().ToString();
			return checked((uint)ApplicationBar.RegisterWindowMessage(ref text));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0002EE6C File Offset: 0x0002D26C
		private ApplicationBar.ABEdge GetAutohideEdge()
		{
			bool flag = this.dockForm.Handle == this.BPOSexplorerGetAutoHideBar(ApplicationBar.ABEdge.abeLeft);
			ApplicationBar.ABEdge abedge;
			if (flag)
			{
				abedge = ApplicationBar.ABEdge.abeLeft;
			}
			else
			{
				flag = this.dockForm.Handle == this.BPOSexplorerGetAutoHideBar(ApplicationBar.ABEdge.abeTop);
				if (flag)
				{
					abedge = ApplicationBar.ABEdge.abeTop;
				}
				else
				{
					flag = this.dockForm.Handle == this.BPOSexplorerGetAutoHideBar(ApplicationBar.ABEdge.abeRight);
					if (flag)
					{
						abedge = ApplicationBar.ABEdge.abeRight;
					}
					else
					{
						flag = this.dockForm.Handle == this.BPOSexplorerGetAutoHideBar(ApplicationBar.ABEdge.abeBottom);
						if (flag)
						{
							abedge = ApplicationBar.ABEdge.abeBottom;
						}
						else
						{
							abedge = ApplicationBar.ABEdge.abeUnknown;
						}
					}
				}
			}
			return abedge;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0002EEFC File Offset: 0x0002D2FC
		internal void OnBPOSexplorerForcedToDocked()
		{
			IntPtr handle = this.dockForm.Handle;
			string text = "There is already an auto hidden window on this edge.\n\rOnly one auto hidden window is allowed on each edge.";
			Form dockForm = this.dockForm;
			string text2 = dockForm.Text;
			ApplicationBar.MessageBox(handle, ref text, ref text2, (IntPtr)64L);
			dockForm.Text = text2;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0002EF44 File Offset: 0x0002D344
		private void GetRect(ApplicationBar.ABEdge abEdgeProposed, ref Rectangle rcProposed)
		{
			bool flag = abEdgeProposed == ApplicationBar.ABEdge.abeFloat;
			checked
			{
				if (!flag)
				{
					rcProposed.X = 0;
					rcProposed.Y = 0;
					rcProposed.Width = Screen.PrimaryScreen.Bounds.Width;
					rcProposed.Height = Screen.PrimaryScreen.Bounds.Height;
					flag = !this.AutoHide;
					if (flag)
					{
						this.BPOSexplorerQueryPos(ref rcProposed, abEdgeProposed);
					}
					switch (abEdgeProposed)
					{
					case ApplicationBar.ABEdge.abeLeft:
						rcProposed.X = rcProposed.Left;
						rcProposed.Width = this.ABS.szDockSize.Width;
						break;
					case ApplicationBar.ABEdge.abeTop:
						rcProposed.Y = rcProposed.Top;
						rcProposed.Height = this.ABS.szDockSize.Height;
						break;
					case ApplicationBar.ABEdge.abeRight:
						rcProposed.X = rcProposed.Right - this.ABS.szDockSize.Width;
						rcProposed.Width = this.ABS.szDockSize.Width;
						break;
					case ApplicationBar.ABEdge.abeBottom:
						rcProposed.Y = rcProposed.Bottom - this.ABS.szDockSize.Height;
						rcProposed.Height = this.ABS.szDockSize.Height;
						break;
					}
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0002F09C File Offset: 0x0002D49C
		private bool AdjustLocationForAutohide(bool bShow, ref Rectangle rc)
		{
			bool flag = (this.Edge == ApplicationBar.ABEdge.abeUnknown) | (this.Edge == ApplicationBar.ABEdge.abeFloat) | !this.AutoHide;
			checked
			{
				bool flag2;
				if (flag)
				{
					flag2 = false;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					if (bShow)
					{
						switch (this.Edge)
						{
						case ApplicationBar.ABEdge.abeRight:
							num = Screen.PrimaryScreen.Bounds.Width - rc.Width;
							break;
						case ApplicationBar.ABEdge.abeBottom:
							num2 = Screen.PrimaryScreen.Bounds.Height - rc.Height;
							break;
						}
					}
					else
					{
						int num3 = 2 * SystemInformation.BorderSize.Width;
						int num4 = 2 * SystemInformation.BorderSize.Height;
						switch (this.Edge)
						{
						case ApplicationBar.ABEdge.abeLeft:
							num = 0 - (rc.Width - num3);
							break;
						case ApplicationBar.ABEdge.abeTop:
							num2 = 0 - (rc.Height - num4);
							break;
						case ApplicationBar.ABEdge.abeRight:
							num = Screen.PrimaryScreen.Bounds.Width - num3;
							break;
						case ApplicationBar.ABEdge.abeBottom:
							num2 = Screen.PrimaryScreen.Bounds.Height - num4;
							break;
						}
					}
					rc.X = num;
					rc.Y = num2;
					flag2 = true;
				}
				return flag2;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0002F1EC File Offset: 0x0002D5EC
		private void ShowHiddenBPOSexplorer(bool bShow)
		{
			Rectangle bounds = this.dockForm.Bounds;
			this.FbAutoHideIsVisible = true;
			bool flag = this.AdjustLocationForAutohide(bShow, ref bounds);
			if (flag)
			{
				this.FbAutoHideIsVisible = bShow;
			}
			Form dockForm = this.dockForm;
			dockForm.Location = bounds.Location;
			dockForm.Size = bounds.Size;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0002F248 File Offset: 0x0002D648
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0002F280 File Offset: 0x0002D680
		internal ApplicationBar.ABEdge Edge
		{
			get
			{
				bool flag = this.FabEdgeProposedPrev != ApplicationBar.ABEdge.abeUnknown;
				ApplicationBar.ABEdge abedge;
				if (flag)
				{
					abedge = this.FabEdgeProposedPrev;
				}
				else
				{
					abedge = this.ABS.abEdge;
				}
				return abedge;
			}
			set
			{
				ApplicationBar.ABEdge autohideEdge = this.GetAutohideEdge();
				bool flag = autohideEdge != ApplicationBar.ABEdge.abeUnknown;
				if (flag)
				{
					this.BPOSexplorerSetAutoHideBar(false, autohideEdge);
				}
				this.ABS.abEdge = value;
				switch (value)
				{
				case ApplicationBar.ABEdge.abeUnknown:
					this.BPOSexplorerRemove();
					return;
				case ApplicationBar.ABEdge.abeFloat:
				{
					Rectangle rectangle;
					rectangle.X = 0;
					rectangle.Y = 0;
					rectangle.Width = 0;
					rectangle.Height = 0;
					this.BPOSexplorerSetPos(ref rectangle, value);
					Form dockForm = this.dockForm;
					dockForm.Location = this.ABS.rcFloat.Location;
					dockForm.Size = this.ABS.rcFloat.Size;
					dockForm.MinimumSize = this.ABS.nMinSize;
					dockForm.MaximumSize = this.ABS.nMaxSize;
					break;
				}
				default:
				{
					flag = this.AutoHide && !(-(this.BPOSexplorerSetAutoHideBar(true, this.Edge) > false));
					if (flag)
					{
						this.ABS.bAutoHide = false;
						this.OnBPOSexplorerForcedToDocked();
					}
					Rectangle rectangle2;
					this.GetRect(this.Edge, ref rectangle2);
					flag = this.AutoHide;
					if (flag)
					{
						Rectangle rectangle;
						rectangle.X = 0;
						rectangle.Y = 0;
						rectangle.Width = 0;
						rectangle.Height = 0;
						this.BPOSexplorerSetPos(ref rectangle, ApplicationBar.ABEdge.abeLeft);
					}
					else
					{
						this.BPOSexplorerSetPos(ref rectangle2, value);
					}
					this.AdjustLocationForAutohide(this.FbAutoHideIsVisible, ref rectangle2);
					Form dockForm2 = this.dockForm;
					dockForm2.Location = rectangle2.Location;
					dockForm2.Size = rectangle2.Size;
					dockForm2.MinimumSize = this.ABS.szMinDockSize;
					dockForm2.MaximumSize = this.ABS.szMaxDockSize;
					break;
				}
				}
				int num = -2;
				flag = this.ABS.bAlwaysOnTop;
				if (flag)
				{
					num = -1;
					flag = this.FbFullScreenAppOpen;
					if (flag)
					{
						num = 1;
					}
				}
				ApplicationBar.SetWindowPos(this.dockForm.Handle, (IntPtr)num, (IntPtr)0, (IntPtr)0, (IntPtr)0, (IntPtr)0, (IntPtr)19);
				this.BPOSexplorerActivate();
				this.OnBPOSexplorerStateChange(false, value);
				switch (this.ABS.abTaskEntry)
				{
				case ApplicationBar.ABTaskEntry.abtShow:
					this.ModifyStyle((int)this.dockForm.Handle, -20, 0, 262144, 0, true);
					break;
				case ApplicationBar.ABTaskEntry.abtHide:
					this.ModifyStyle((int)this.dockForm.Handle, -20, 262144, 0, 0, true);
					break;
				case ApplicationBar.ABTaskEntry.abtFloatDependent:
					switch (value)
					{
					case ApplicationBar.ABEdge.abeLeft:
					case ApplicationBar.ABEdge.abeTop:
					case ApplicationBar.ABEdge.abeRight:
					case ApplicationBar.ABEdge.abeBottom:
						this.ModifyStyle((int)this.dockForm.Handle, -20, 262144, 0, 0, true);
						break;
					case ApplicationBar.ABEdge.abeFloat:
						this.ModifyStyle((int)this.dockForm.Handle, -20, 0, 262144, 0, true);
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0002F5B8 File Offset: 0x0002D9B8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0002F5D4 File Offset: 0x0002D9D4
		internal ApplicationBar.ABFlags Flags
		{
			get
			{
				return this.ABS.abFlags;
			}
			set
			{
				this.ABS.abFlags = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0002F5E4 File Offset: 0x0002D9E4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0002F600 File Offset: 0x0002DA00
		internal bool AutoHide
		{
			get
			{
				return this.ABS.bAutoHide;
			}
			set
			{
				this.ABS.bAutoHide = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0002F610 File Offset: 0x0002DA10
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0002F62C File Offset: 0x0002DA2C
		internal bool AlwaysOnTop
		{
			get
			{
				return this.ABS.bAlwaysOnTop;
			}
			set
			{
				this.ABS.bAlwaysOnTop = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0002F63C File Offset: 0x0002DA3C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0002F65C File Offset: 0x0002DA5C
		internal int HorzSizeInc
		{
			get
			{
				return this.ABS.szSizeInc.cx;
			}
			set
			{
				this.ABS.szSizeInc.cx = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0002F674 File Offset: 0x0002DA74
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0002F694 File Offset: 0x0002DA94
		internal int VertSizeInc
		{
			get
			{
				return this.ABS.szSizeInc.cy;
			}
			set
			{
				this.ABS.szSizeInc.cy = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0002F6AC File Offset: 0x0002DAAC
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0002F6CC File Offset: 0x0002DACC
		internal int HorzDockSize
		{
			get
			{
				return this.ABS.szDockSize.Height;
			}
			set
			{
				this.ABS.szDockSize.Height = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0002F6E4 File Offset: 0x0002DAE4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0002F704 File Offset: 0x0002DB04
		internal int VertDockSize
		{
			get
			{
				return this.ABS.szDockSize.Width;
			}
			set
			{
				this.ABS.szDockSize.Width = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0002F71C File Offset: 0x0002DB1C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0002F738 File Offset: 0x0002DB38
		internal Size MinSize
		{
			get
			{
				return this.ABS.nMinSize;
			}
			set
			{
				this.ABS.nMinSize = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0002F748 File Offset: 0x0002DB48
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0002F764 File Offset: 0x0002DB64
		internal Size MaxSize
		{
			get
			{
				return this.ABS.nMaxSize;
			}
			set
			{
				this.ABS.nMaxSize = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0002F774 File Offset: 0x0002DB74
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0002F790 File Offset: 0x0002DB90
		internal Size MinDockSize
		{
			get
			{
				return this.ABS.szMinDockSize;
			}
			set
			{
				this.ABS.szMinDockSize = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0002F7A0 File Offset: 0x0002DBA0
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0002F7BC File Offset: 0x0002DBBC
		internal Size MaxDockSize
		{
			get
			{
				return this.ABS.szMaxDockSize;
			}
			set
			{
				this.ABS.szMaxDockSize = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0002F7CC File Offset: 0x0002DBCC
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0002F7E8 File Offset: 0x0002DBE8
		internal ApplicationBar.ABTaskEntry TaskEntry
		{
			get
			{
				return this.ABS.abTaskEntry;
			}
			set
			{
				this.ABS.abTaskEntry = value;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0002F7F8 File Offset: 0x0002DBF8
		private ApplicationBar.RECT RectangleToRECT(Rectangle rect)
		{
			ApplicationBar.RECT rect2;
			rect2.left = rect.Left;
			rect2.right = rect.Right;
			rect2.top = rect.Top;
			rect2.bottom = rect.Bottom;
			return rect2;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0002F848 File Offset: 0x0002DC48
		private Rectangle RECTtoRectangle(ApplicationBar.RECT rect)
		{
			Point point = new Point(rect.left, rect.top);
			Rectangle rectangle;
			rectangle.Location = point;
			Size size = checked(new Size(rect.right - rect.left, rect.bottom - rect.top));
			rectangle.Size = size;
			return rectangle;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0002F8AC File Offset: 0x0002DCAC
		internal void OnBPOSexplorerTimer()
		{
			bool bAutoHide = this.ABS.bAutoHide;
			checked
			{
				if (bAutoHide)
				{
					bool flag = ApplicationBar.GetForegroundWindow() != this.dockForm.Handle;
					if (flag)
					{
						Point position = Cursor.Position;
						Rectangle bounds = this.dockForm.Bounds;
						bounds.Inflate(2 * SystemInformation.DoubleClickSize.Width, 2 * SystemInformation.DoubleClickSize.Height);
						flag = !bounds.Contains(position);
						if (flag)
						{
							this.ShowHiddenBPOSexplorer(false);
						}
					}
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0002F93C File Offset: 0x0002DD3C
		internal void OnNcMouseMove()
		{
			this.ShowHiddenBPOSexplorer(true);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0002F948 File Offset: 0x0002DD48
		internal int OnEnterSizeMove()
		{
			this.FabEdgeProposedPrev = this.Edge;
			return 0;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0002F968 File Offset: 0x0002DD68
		internal int OnExitSizeMove()
		{
			ApplicationBar.ABEdge fabEdgeProposedPrev = this.FabEdgeProposedPrev;
			this.FabEdgeProposedPrev = ApplicationBar.ABEdge.abeUnknown;
			Rectangle bounds = this.dockForm.Bounds;
			bool flag = this.Edge == fabEdgeProposedPrev;
			if (flag)
			{
				switch (this.Edge)
				{
				case ApplicationBar.ABEdge.abeLeft:
				case ApplicationBar.ABEdge.abeRight:
					this.ABS.szDockSize.Width = bounds.Width;
					break;
				case ApplicationBar.ABEdge.abeTop:
				case ApplicationBar.ABEdge.abeBottom:
					this.ABS.szDockSize.Height = bounds.Height;
					break;
				}
			}
			flag = fabEdgeProposedPrev == ApplicationBar.ABEdge.abeFloat;
			if (flag)
			{
				bool flag2 = this.Edge == ApplicationBar.ABEdge.abeFloat;
				if (flag2)
				{
					this.ABS.rcFloat = bounds;
				}
				else
				{
					int num = bounds.Width;
					int num2 = bounds.Height;
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					flag2 = (num >= workingArea.Width) | (num2 >= workingArea.Height);
					if (flag2)
					{
						num = this.ABS.rcFloat.Width;
						num2 = this.ABS.rcFloat.Height;
					}
					this.ABS.rcFloat.X = bounds.Left;
					this.ABS.rcFloat.Y = bounds.Top;
					this.ABS.rcFloat.Width = num;
					this.ABS.rcFloat.Height = num2;
				}
			}
			this.Edge = fabEdgeProposedPrev;
			return 0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0002FAEC File Offset: 0x0002DEEC
		internal int onMoving(Message msg)
		{
			ApplicationBar.RECT rect = (ApplicationBar.RECT)Marshal.PtrToStructure(msg.LParam, typeof(ApplicationBar.RECT));
			Rectangle rectangle = this.RECTtoRectangle(rect);
			Point position = Cursor.Position;
			ApplicationBar.ABEdge edgeFromPoint = this.GetEdgeFromPoint(this.ABS.abFlags, ref position);
			bool flag = this.FabEdgeProposedPrev != ApplicationBar.ABEdge.abeFloat && edgeFromPoint == ApplicationBar.ABEdge.abeFloat;
			if (flag)
			{
				rectangle = this.ABS.rcFloat;
				int width = rectangle.Width;
				int height = rectangle.Height;
				rectangle.X = checked(position.X - width / 2);
				rectangle.Y = position.Y;
			}
			this.FabEdgeProposedPrev = edgeFromPoint;
			this.GetRect(edgeFromPoint, ref rectangle);
			this.OnBPOSexplorerStateChange(true, edgeFromPoint);
			rect = this.RectangleToRECT(rectangle);
			Marshal.StructureToPtr(rect, msg.LParam, true);
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0002FBD8 File Offset: 0x0002DFD8
		internal ApplicationBar.ABEdge GetEdgeFromPoint(ApplicationBar.ABFlags abFlags, ref Point pt)
		{
			bool flag = (ApplicationBar.ABFlags.abfAllowFloat & abFlags) > (ApplicationBar.ABFlags)0;
			checked
			{
				if (flag)
				{
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					workingArea.Inflate(0 - SystemInformation.VerticalScrollBarWidth, 0 - SystemInformation.HorizontalScrollBarHeight);
					flag = workingArea.Contains(pt) || !this.IsDockable(abFlags);
					if (flag)
					{
						return ApplicationBar.ABEdge.abeFloat;
					}
				}
				int width = Screen.PrimaryScreen.Bounds.Width;
				int width2 = Screen.PrimaryScreen.Bounds.Width;
				Point point;
				point.X = width / 2;
				point.Y = width2 / 2;
				Point point2;
				point2.X = pt.X - point.X;
				point2.Y = pt.Y - point.Y;
				bool flag2 = Math.Abs(point2.Y) * width <= Math.Abs(point2.X) * width2;
				flag = flag2;
				bool flag3;
				ApplicationBar.ABEdge abedge;
				if (flag)
				{
					flag3 = 0 <= point2.X;
					if (flag3)
					{
						abedge = ApplicationBar.ABEdge.abeRight;
					}
					else
					{
						abedge = ApplicationBar.ABEdge.abeLeft;
					}
				}
				else
				{
					flag3 = 0 <= point2.Y;
					if (flag3)
					{
						abedge = ApplicationBar.ABEdge.abeBottom;
					}
					else
					{
						abedge = ApplicationBar.ABEdge.abeTop;
					}
				}
				flag3 = (ApplicationBar.ABFlags.abfAllowFloat & abFlags) > (ApplicationBar.ABFlags)0;
				ApplicationBar.ABEdge abedge2;
				if (flag3)
				{
					abedge2 = ApplicationBar.ABEdge.abeFloat;
				}
				else
				{
					abedge2 = this.ABS.abEdge;
				}
				switch (abedge)
				{
				case ApplicationBar.ABEdge.abeLeft:
					flag3 = (ApplicationBar.ABFlags.abfAllowLeft & abFlags) <= (ApplicationBar.ABFlags)0;
					if (flag3)
					{
						abedge = abedge2;
					}
					break;
				case ApplicationBar.ABEdge.abeTop:
					flag3 = (ApplicationBar.ABFlags.abfAllowTop & abFlags) <= (ApplicationBar.ABFlags)0;
					if (flag3)
					{
						abedge = abedge2;
					}
					break;
				case ApplicationBar.ABEdge.abeRight:
					flag3 = (ApplicationBar.ABFlags.abfAllowRight & abFlags) <= (ApplicationBar.ABFlags)0;
					if (flag3)
					{
						abedge = abedge2;
					}
					break;
				case ApplicationBar.ABEdge.abeBottom:
					flag3 = (ApplicationBar.ABFlags.abfAllowBottom & abFlags) <= (ApplicationBar.ABFlags)0;
					if (flag3)
					{
						abedge = abedge2;
					}
					break;
				}
				return abedge;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0002FDAC File Offset: 0x0002E1AC
		internal void OnBPOSexplorerStateChange(bool bProposed, ApplicationBar.ABEdge abEdgeProposed)
		{
			bool flag = SystemInformation.DragFullWindows || !bProposed;
			if (flag)
			{
				bool flag2 = abEdgeProposed == ApplicationBar.ABEdge.abeFloat;
				if (flag2)
				{
					this.ModifyStyle((int)this.dockForm.Handle, -16, 0, 13107200, 32, false);
				}
				else
				{
					this.ModifyStyle((int)this.dockForm.Handle, -16, 13107200, 0, 32, false);
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0002FE20 File Offset: 0x0002E220
		private bool ModifyStyle(int hwnd, int nStyleOffset, int dwRemove, int dwAdd, int nFlags, bool bRefresh)
		{
			int num = (int)ApplicationBar.GetWindowLong((IntPtr)hwnd, (IntPtr)nStyleOffset);
			int num2 = (num & ~dwRemove) | dwAdd;
			bool flag = num == num2;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				if (bRefresh)
				{
					ApplicationBar.ShowWindow((IntPtr)hwnd, (IntPtr)0);
				}
				ApplicationBar.SetWindowLong((IntPtr)hwnd, (IntPtr)nStyleOffset, (IntPtr)num2);
				if (bRefresh)
				{
					ApplicationBar.ShowWindow((IntPtr)hwnd, (IntPtr)5);
				}
				flag = nFlags != 0;
				if (flag)
				{
					ApplicationBar.SetWindowPos((IntPtr)hwnd, (IntPtr)0, (IntPtr)0, (IntPtr)0, (IntPtr)0, (IntPtr)0, (IntPtr)(23 | nFlags));
				}
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0002FEEC File Offset: 0x0002E2EC
		internal bool IsDocked()
		{
			return (this.Edge == ApplicationBar.ABEdge.abeLeft) | (this.Edge == ApplicationBar.ABEdge.abeRight) | (this.Edge == ApplicationBar.ABEdge.abeTop) | (this.Edge == ApplicationBar.ABEdge.abeBottom);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0002FF30 File Offset: 0x0002E330
		internal bool IsDockable(ApplicationBar.ABFlags abFlags)
		{
			return (abFlags & (ApplicationBar.ABFlags)15) > (ApplicationBar.ABFlags)0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0002FF48 File Offset: 0x0002E348
		internal bool IsEdgeLeftOrRight(ApplicationBar.ABEdge abEdge)
		{
			return abEdge == ApplicationBar.ABEdge.abeLeft || abEdge == ApplicationBar.ABEdge.abeRight;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0002FF70 File Offset: 0x0002E370
		internal bool IsEdgeTopOrBottom(ApplicationBar.ABEdge abEdge)
		{
			return abEdge == ApplicationBar.ABEdge.abeTop || abEdge == ApplicationBar.ABEdge.abeBottom;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0002FF98 File Offset: 0x0002E398
		internal void OnABNFullScreenApp(bool bOpen)
		{
			bool fbFullScreenAppOpen = this.FbFullScreenAppOpen;
			this.FbFullScreenAppOpen = bOpen;
			bool flag = fbFullScreenAppOpen != bOpen;
			if (flag)
			{
				this.UpdateBar();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0002FFC8 File Offset: 0x0002E3C8
		internal void OnABNPosChanged()
		{
			bool flag = this.Edge != ApplicationBar.ABEdge.abeFloat && !this.AutoHide;
			if (flag)
			{
				this.UpdateBar();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0002FFF8 File Offset: 0x0002E3F8
		internal void OnABNWindowArrange(bool bBeginning)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0002FFFC File Offset: 0x0002E3FC
		internal int onBPOSexplorerNotification(Message msg)
		{
			switch (msg.WParam.ToInt32())
			{
			case 1:
				this.OnABNPosChanged();
				break;
			case 2:
				this.OnABNFullScreenApp(msg.LParam.ToInt32() != 0);
				break;
			case 3:
				this.OnABNWindowArrange(msg.LParam.ToInt32() != 0);
				break;
			}
			return 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00030078 File Offset: 0x0002E478
		private IntPtr onNcHitTest(ref Message msg)
		{
			base.DefWndProc(ref msg);
			IntPtr result = msg.Result;
			int num = result.ToInt32();
			int x = Cursor.Position.X;
			int y = Cursor.Position.Y;
			bool flag = -(SystemInformation.MouseButtonsSwapped > false);
			int num2;
			if (flag)
			{
				num2 = 2;
			}
			else
			{
				num2 = 1;
			}
			bool flag2 = ((int)ApplicationBar.GetAsyncKeyState((IntPtr)num2) & 32768) != 0;
			Point point;
			point.X = x;
			point.Y = y;
			point = this.dockForm.PointToClient(point);
			flag = (num == 1 && flag2) & !this.ControlAtPos(ref point, false);
			if (flag)
			{
				num = 2;
			}
			flag = (this.Edge == ApplicationBar.ABEdge.abeFloat) & (10 <= num) & (num <= 17);
			bool flag3;
			if (flag)
			{
				switch (num)
				{
				case 10:
				case 11:
					flag3 = this.ABS.szSizeInc.cx == 0;
					if (flag3)
					{
						num = 18;
					}
					break;
				case 12:
				case 15:
					flag3 = this.ABS.szSizeInc.cy == 0;
					if (flag3)
					{
						num = 18;
					}
					break;
				case 13:
					flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy == 0);
					if (flag3)
					{
						num = 18;
					}
					else
					{
						flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy != 0);
						if (flag3)
						{
							num = 12;
						}
						else
						{
							flag3 = (this.ABS.szSizeInc.cx != 0) & (this.ABS.szSizeInc.cy == 0);
							if (flag3)
							{
								num = 10;
							}
						}
					}
					break;
				case 14:
					flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy == 0);
					if (flag3)
					{
						num = 18;
					}
					else
					{
						flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy != 0);
						if (flag3)
						{
							num = 12;
						}
						else
						{
							flag3 = (this.ABS.szSizeInc.cx != 0) & (this.ABS.szSizeInc.cy == 0);
							if (flag3)
							{
								num = 11;
							}
						}
					}
					break;
				case 16:
					flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy == 0);
					if (flag3)
					{
						num = 18;
					}
					else
					{
						flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy != 0);
						if (flag3)
						{
							num = 15;
						}
						else
						{
							flag3 = (this.ABS.szSizeInc.cx != 0) & (this.ABS.szSizeInc.cy == 0);
							if (flag3)
							{
								num = 10;
							}
						}
					}
					break;
				case 17:
					flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy == 0);
					if (flag3)
					{
						num = 18;
					}
					else
					{
						flag3 = (this.ABS.szSizeInc.cx == 0) & (this.ABS.szSizeInc.cy != 0);
						if (flag3)
						{
							num = 15;
						}
						else
						{
							flag3 = (this.ABS.szSizeInc.cx != 0) & (this.ABS.szSizeInc.cy == 0);
							if (flag3)
							{
								num = 11;
							}
						}
					}
					break;
				}
			}
			flag3 = (this.Edge != ApplicationBar.ABEdge.abeFloat) & (this.Edge != ApplicationBar.ABEdge.abeUnknown) & (10 <= num) & (num <= 17);
			if (flag3)
			{
				flag = (this.IsEdgeLeftOrRight(this.Edge) & (this.ABS.szSizeInc.cx == 0)) | (!this.IsEdgeLeftOrRight(this.Edge) & (this.ABS.szSizeInc.cy == 0));
				if (flag)
				{
					num = 18;
				}
				else
				{
					ApplicationBar.RECT rect = this.RectangleToRECT(this.dockForm.ClientRectangle);
					point.X = rect.left;
					point.Y = rect.top;
					point = this.dockForm.PointToScreen(point);
					rect.left = point.X;
					rect.top = point.Y;
					point.X = rect.right;
					point.Y = rect.bottom;
					point = this.dockForm.PointToScreen(point);
					rect.right = point.X;
					rect.bottom = point.Y;
					num = 18;
					switch (this.Edge)
					{
					case ApplicationBar.ABEdge.abeLeft:
						flag3 = x > rect.right;
						if (flag3)
						{
							num = 11;
						}
						break;
					case ApplicationBar.ABEdge.abeTop:
						flag3 = y > rect.bottom;
						if (flag3)
						{
							num = 15;
						}
						break;
					case ApplicationBar.ABEdge.abeRight:
						flag3 = x < rect.left;
						if (flag3)
						{
							num = 10;
						}
						break;
					case ApplicationBar.ABEdge.abeBottom:
						flag3 = y < rect.top;
						if (flag3)
						{
							num = 12;
						}
						break;
					}
				}
			}
			result = new IntPtr(num);
			msg.Result = result;
			IntPtr intPtr;
			return intPtr;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0003062C File Offset: 0x0002EA2C
		private bool ControlAtPos(ref Point Pos, bool AllowDisabled)
		{
			bool flag = false;
			checked
			{
				try
				{
					foreach (object obj in this.dockForm.Controls)
					{
						Control control = (Control)obj;
						Control control2 = control;
						Point point;
						point.X = Pos.X - control2.Left;
						point.Y = Pos.Y - control2.Top;
						Rectangle rectangle;
						rectangle.X = 0;
						rectangle.Y = 0;
						rectangle.Width = control2.Width;
						rectangle.Height = control2.Height;
						bool flag2 = rectangle.Contains(point) & control2.Visible & (control2.Enabled || AllowDisabled);
						if (flag2)
						{
							flag = true;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag2 = enumerator is IDisposable;
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				return flag;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00030730 File Offset: 0x0002EB30
		protected override void WndProc(ref Message uMsg)
		{
			bool flag = uMsg.HWnd == this.dockForm.Handle;
			if (flag)
			{
				uMsg.Result = (IntPtr)(-1);
				int msg = uMsg.Msg;
				flag = msg == checked((int)this.CallbackMessageID);
				if (flag)
				{
					uMsg.Result = (IntPtr)this.onBPOSexplorerNotification(uMsg);
				}
				else
				{
					flag = msg == 561;
					if (flag)
					{
						uMsg.Result = (IntPtr)this.OnEnterSizeMove();
					}
					else
					{
						flag = msg == 562;
						if (flag)
						{
							uMsg.Result = (IntPtr)this.OnExitSizeMove();
						}
						else
						{
							flag = msg == 36;
							if (!flag)
							{
								flag = msg == 534;
								if (flag)
								{
									uMsg.Result = (IntPtr)this.onMoving(uMsg);
								}
								else
								{
									flag = msg == 160;
									if (flag)
									{
										this.OnNcMouseMove();
									}
									else
									{
										flag = msg == 532;
										if (!flag)
										{
											flag = msg == 275;
											if (flag)
											{
												this.OnBPOSexplorerTimer();
											}
											else
											{
												flag = msg == 6;
												if (flag)
												{
													bool flag2 = uMsg.WParam == (IntPtr)0;
													if (flag2)
													{
														this.ShowHiddenBPOSexplorer(false);
													}
													this.BPOSexplorerActivate();
												}
												else
												{
													bool flag2 = msg == 132;
													if (flag2)
													{
														this.onNcHitTest(ref uMsg);
														return;
													}
													flag2 = msg == 71;
													if (flag2)
													{
														this.BPOSexplorerWindowPosChanged();
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				base.WndProc(ref uMsg);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000308C4 File Offset: 0x0002ECC4
		internal void ResetApplicationBar()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000308C8 File Offset: 0x0002ECC8
		protected override void Finalize()
		{
			this.ResetApplicationBar();
			base.Finalize();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000308DC File Offset: 0x0002ECDC
		public bool LoadBPOSexplorerSettings()
		{
			byte[] array = new byte[0];
			ApplicationBar.ABSettings absettings;
			int num = Marshal.SizeOf(absettings);
			bool flag = false;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + Application.ProductName, false);
				bool flag2 = registryKey == null;
				if (flag2)
				{
					flag = flag;
				}
				else
				{
					registryKey.GetValue("ABSet");
					flag2 = registryKey.GetValue("ABSet") != null;
					if (flag2)
					{
						array = (byte[])registryKey.GetValue("ABSet");
						flag2 = num > array.Length;
						if (flag2)
						{
							flag = flag;
						}
						else
						{
							IntPtr intPtr = Marshal.AllocHGlobal(num);
							Marshal.Copy(array, 0, intPtr, num);
							absettings = (ApplicationBar.ABSettings)Marshal.PtrToStructure(intPtr, typeof(ApplicationBar.ABSettings));
							Marshal.FreeHGlobal(intPtr);
							this.ABS = absettings;
							this.UpdateBar();
							flag = true;
						}
					}
					else
					{
						flag = flag;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				flag = false;
			}
			return flag;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00030A08 File Offset: 0x0002EE08
		public bool SaveBPOSexplorerSettings()
		{
			bool flag = false;
			try
			{
				byte[] array = new byte[checked(Marshal.SizeOf(this.ABS) - 1 + 1)];
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(this.ABS));
				Marshal.StructureToPtr(this.ABS, intPtr, true);
				Marshal.Copy(intPtr, array, 0, Marshal.SizeOf(this.ABS));
				Marshal.FreeHGlobal(intPtr);
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + Application.ProductName, true);
				bool flag2 = registryKey == null;
				if (flag2)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + Application.ProductName);
				}
				registryKey.SetValue("ABSet", array, RegistryValueKind.Binary);
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00030AF4 File Offset: 0x0002EEF4
		public bool DeleteBPOSexplorerSettings()
		{
			bool flag = false;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + Application.ProductName, true);
				bool flag2 = registryKey == null;
				if (flag2)
				{
					flag = flag;
				}
				else
				{
					flag2 = registryKey.GetValue("ABSet") != null;
					if (flag2)
					{
						registryKey.DeleteValue("ABSet");
					}
					flag = true;
				}
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x04000029 RID: 41
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400002A RID: 42
		private const long GWL_WNDPROC = -4L;

		// Token: 0x0400002B RID: 43
		private const int WM_ACTIVATE = 6;

		// Token: 0x0400002C RID: 44
		private const int WM_GETMINMAXINFO = 36;

		// Token: 0x0400002D RID: 45
		private const int WM_ENTERSIZEMOVE = 561;

		// Token: 0x0400002E RID: 46
		private const int WM_EXITSIZEMOVE = 562;

		// Token: 0x0400002F RID: 47
		private const int WM_MOVING = 534;

		// Token: 0x04000030 RID: 48
		private const int WM_NCHITTEST = 132;

		// Token: 0x04000031 RID: 49
		private const int WM_NCMOUSEMOVE = 160;

		// Token: 0x04000032 RID: 50
		private const int WM_SIZING = 532;

		// Token: 0x04000033 RID: 51
		private const int WM_TIMER = 275;

		// Token: 0x04000034 RID: 52
		private const int WM_WINDOWPOSCHANGED = 71;

		// Token: 0x04000035 RID: 53
		private const int WMSZ_LEFT = 1;

		// Token: 0x04000036 RID: 54
		private const int WMSZ_RIGHT = 2;

		// Token: 0x04000037 RID: 55
		private const int WMSZ_TOP = 3;

		// Token: 0x04000038 RID: 56
		private const int WMSZ_TOPLEFT = 4;

		// Token: 0x04000039 RID: 57
		private const int WMSZ_TOPRIGHT = 5;

		// Token: 0x0400003A RID: 58
		private const int WMSZ_BOTTOM = 6;

		// Token: 0x0400003B RID: 59
		private const int WMSZ_BOTTOMLEFT = 7;

		// Token: 0x0400003C RID: 60
		private const int WMSZ_BOTTOMRIGHT = 8;

		// Token: 0x0400003D RID: 61
		private const int ABM_NEW = 0;

		// Token: 0x0400003E RID: 62
		private const int ABM_REMOVE = 1;

		// Token: 0x0400003F RID: 63
		private const int ABM_QUERYPOS = 2;

		// Token: 0x04000040 RID: 64
		private const int ABM_SETPOS = 3;

		// Token: 0x04000041 RID: 65
		private const int ABM_GETSTATE = 4;

		// Token: 0x04000042 RID: 66
		private const int ABM_GETTASKBARPOS = 5;

		// Token: 0x04000043 RID: 67
		private const int ABM_ACTIVATE = 6;

		// Token: 0x04000044 RID: 68
		private const int ABM_GETAUTOHIDEBAR = 7;

		// Token: 0x04000045 RID: 69
		private const int ABM_SETAUTOHIDEBAR = 8;

		// Token: 0x04000046 RID: 70
		private const int ABM_WINDOWPOSCHANGED = 9;

		// Token: 0x04000047 RID: 71
		private const int ABM_SETSTATE = 10;

		// Token: 0x04000048 RID: 72
		private const int ABE_LEFT = 0;

		// Token: 0x04000049 RID: 73
		private const int ABE_TOP = 1;

		// Token: 0x0400004A RID: 74
		private const int ABE_RIGHT = 2;

		// Token: 0x0400004B RID: 75
		private const int ABE_BOTTOM = 3;

		// Token: 0x0400004C RID: 76
		private const int ABE_UNKNOWN = 4;

		// Token: 0x0400004D RID: 77
		private const int ABE_FLOAT = 5;

		// Token: 0x0400004E RID: 78
		private const int ABF_ALLOWLEFT = 1;

		// Token: 0x0400004F RID: 79
		private const int ABF_ALLOWRIGHT = 2;

		// Token: 0x04000050 RID: 80
		private const int ABF_ALLOWTOP = 4;

		// Token: 0x04000051 RID: 81
		private const int ABF_ALLOWBOTTOM = 8;

		// Token: 0x04000052 RID: 82
		private const int ABF_ALLOWFLOAT = 16;

		// Token: 0x04000053 RID: 83
		private const int ABN_POSCHANGED = 1;

		// Token: 0x04000054 RID: 84
		private const int ABN_FULLSCREENAPP = 2;

		// Token: 0x04000055 RID: 85
		private const int ABN_WINDOWARRANGE = 3;

		// Token: 0x04000056 RID: 86
		private const int VK_LBUTTON = 1;

		// Token: 0x04000057 RID: 87
		private const int VK_RBUTTON = 2;

		// Token: 0x04000058 RID: 88
		private const int VK_CONTROL = 17;

		// Token: 0x04000059 RID: 89
		private const long MB_OK = 0L;

		// Token: 0x0400005A RID: 90
		private const long MB_ICONINFORMATION = 64L;

		// Token: 0x0400005B RID: 91
		private const int GWL_STYLE = -16;

		// Token: 0x0400005C RID: 92
		private const int GWL_EXSTYLE = -20;

		// Token: 0x0400005D RID: 93
		private const int WS_CAPTION = 12582912;

		// Token: 0x0400005E RID: 94
		private const int WS_SYSMENU = 524288;

		// Token: 0x0400005F RID: 95
		private const int WS_EX_APPWINDOW = 262144;

		// Token: 0x04000060 RID: 96
		private const int WS_BORDER = 8388608;

		// Token: 0x04000061 RID: 97
		private const int SWP_NOSIZE = 1;

		// Token: 0x04000062 RID: 98
		private const int SWP_NOMOVE = 2;

		// Token: 0x04000063 RID: 99
		private const int SWP_NOZORDER = 4;

		// Token: 0x04000064 RID: 100
		private const int SWP_NOACTIVATE = 16;

		// Token: 0x04000065 RID: 101
		private const int SWP_DRAWFRAME = 32;

		// Token: 0x04000066 RID: 102
		private const int HWND_NOTOPMOST = -2;

		// Token: 0x04000067 RID: 103
		private const int HWND_TOPMOST = -1;

		// Token: 0x04000068 RID: 104
		private const int HWND_BOTTOM = 1;

		// Token: 0x04000069 RID: 105
		private const int SW_HIDE = 0;

		// Token: 0x0400006A RID: 106
		private const int SW_SHOW = 5;

		// Token: 0x0400006B RID: 107
		private const int WA_INACTIVE = 0;

		// Token: 0x0400006C RID: 108
		private const int AB_DEF_SIZE_INC = 1;

		// Token: 0x0400006D RID: 109
		private const int AB_DEF_DOCK_SIZE = 32;

		// Token: 0x0400006E RID: 110
		private const int AUTO_HIDE_TIMER_ID = 100;

		// Token: 0x0400006F RID: 111
		private const int SLIDE_DEF_TIMER_INTERVAL = 400;

		// Token: 0x04000070 RID: 112
		private const int INHERIT_DEFAULT_CALLBACK = -1;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("dockForm")]
		private Form _dockForm;

		// Token: 0x04000072 RID: 114
		private ApplicationBar.ABSettings ABS;

		// Token: 0x04000073 RID: 115
		private ApplicationBar.ABEdge FabEdgeProposedPrev;

		// Token: 0x04000074 RID: 116
		private uint CallbackMessageID;

		// Token: 0x04000075 RID: 117
		private bool IsBPOSexplorerMode;

		// Token: 0x04000076 RID: 118
		private bool FbFullScreenAppOpen;

		// Token: 0x04000077 RID: 119
		private bool FbAutoHideIsVisible;

		// Token: 0x0200000C RID: 12
		public enum ABMsg
		{
			// Token: 0x04000079 RID: 121
			abmNew,
			// Token: 0x0400007A RID: 122
			abmRemove,
			// Token: 0x0400007B RID: 123
			abmQueryPos,
			// Token: 0x0400007C RID: 124
			abmSetPos,
			// Token: 0x0400007D RID: 125
			abmGetState,
			// Token: 0x0400007E RID: 126
			abmGetTaskBarPos,
			// Token: 0x0400007F RID: 127
			abmActivate,
			// Token: 0x04000080 RID: 128
			abmGetAutoHideBar,
			// Token: 0x04000081 RID: 129
			abmSetAutoHideBar,
			// Token: 0x04000082 RID: 130
			abmWindowPosChanged,
			// Token: 0x04000083 RID: 131
			abmSetState
		}

		// Token: 0x0200000D RID: 13
		public enum ABEdge
		{
			// Token: 0x04000085 RID: 133
			abeLeft,
			// Token: 0x04000086 RID: 134
			abeTop,
			// Token: 0x04000087 RID: 135
			abeRight,
			// Token: 0x04000088 RID: 136
			abeBottom,
			// Token: 0x04000089 RID: 137
			abeUnknown,
			// Token: 0x0400008A RID: 138
			abeFloat
		}

		// Token: 0x0200000E RID: 14
		public enum ABFlags
		{
			// Token: 0x0400008C RID: 140
			abfAllowLeft = 1,
			// Token: 0x0400008D RID: 141
			abfAllowTop = 4,
			// Token: 0x0400008E RID: 142
			abfAllowRight = 2,
			// Token: 0x0400008F RID: 143
			abfAllowBottom = 8,
			// Token: 0x04000090 RID: 144
			abfAllowFloat = 16
		}

		// Token: 0x0200000F RID: 15
		public enum ABTaskEntry
		{
			// Token: 0x04000092 RID: 146
			abtShow,
			// Token: 0x04000093 RID: 147
			abtHide,
			// Token: 0x04000094 RID: 148
			abtFloatDependent
		}

		// Token: 0x02000010 RID: 16
		public enum BPOSexplorerStates
		{
			// Token: 0x04000096 RID: 150
			AutoHide = 1,
			// Token: 0x04000097 RID: 151
			AlwaysOnTop
		}

		// Token: 0x02000011 RID: 17
		public enum MousePositionCodes
		{
			// Token: 0x04000099 RID: 153
			HTERROR = -2,
			// Token: 0x0400009A RID: 154
			HTTRANSPARENT,
			// Token: 0x0400009B RID: 155
			HTNOWHERE,
			// Token: 0x0400009C RID: 156
			HTCLIENT,
			// Token: 0x0400009D RID: 157
			HTCAPTION,
			// Token: 0x0400009E RID: 158
			HTSYSMENU,
			// Token: 0x0400009F RID: 159
			HTGROWBOX,
			// Token: 0x040000A0 RID: 160
			HTSIZE = 4,
			// Token: 0x040000A1 RID: 161
			HTMENU,
			// Token: 0x040000A2 RID: 162
			HTHSCROLL,
			// Token: 0x040000A3 RID: 163
			HTVSCROLL,
			// Token: 0x040000A4 RID: 164
			HTMINBUTTON,
			// Token: 0x040000A5 RID: 165
			HTMAXBUTTON,
			// Token: 0x040000A6 RID: 166
			HTLEFT,
			// Token: 0x040000A7 RID: 167
			HTRIGHT,
			// Token: 0x040000A8 RID: 168
			HTTOP,
			// Token: 0x040000A9 RID: 169
			HTTOPLEFT,
			// Token: 0x040000AA RID: 170
			HTTOPRIGHT,
			// Token: 0x040000AB RID: 171
			HTBOTTOM,
			// Token: 0x040000AC RID: 172
			HTBOTTOMLEFT,
			// Token: 0x040000AD RID: 173
			HTBOTTOMRIGHT,
			// Token: 0x040000AE RID: 174
			HTBORDER,
			// Token: 0x040000AF RID: 175
			HTREDUCE = 8,
			// Token: 0x040000B0 RID: 176
			HTZOOM,
			// Token: 0x040000B1 RID: 177
			HTSIZEFIRST,
			// Token: 0x040000B2 RID: 178
			HTSIZELAST = 17,
			// Token: 0x040000B3 RID: 179
			HTOBJECT = 19,
			// Token: 0x040000B4 RID: 180
			HTCLOSE,
			// Token: 0x040000B5 RID: 181
			HTHELP
		}

		// Token: 0x02000012 RID: 18
		public enum MouseClicks
		{
			// Token: 0x040000B7 RID: 183
			WM_LBUTTONDBLCLK = 515,
			// Token: 0x040000B8 RID: 184
			WM_LBUTTONDOWN = 513,
			// Token: 0x040000B9 RID: 185
			WM_LBUTTONUP,
			// Token: 0x040000BA RID: 186
			WM_MBUTTONDBLCLK = 521,
			// Token: 0x040000BB RID: 187
			WM_MBUTTONDOWN = 519,
			// Token: 0x040000BC RID: 188
			WM_MBUTTONUP,
			// Token: 0x040000BD RID: 189
			WM_RBUTTONDBLCLK = 518,
			// Token: 0x040000BE RID: 190
			WM_RBUTTONDOWN = 516,
			// Token: 0x040000BF RID: 191
			WM_RBUTTONUP
		}

		// Token: 0x02000013 RID: 19
		private struct mySize
		{
			// Token: 0x040000C0 RID: 192
			public int cx;

			// Token: 0x040000C1 RID: 193
			public int cy;
		}

		// Token: 0x02000014 RID: 20
		private struct RECT
		{
			// Token: 0x040000C2 RID: 194
			public int left;

			// Token: 0x040000C3 RID: 195
			public int top;

			// Token: 0x040000C4 RID: 196
			public int right;

			// Token: 0x040000C5 RID: 197
			public int bottom;
		}

		// Token: 0x02000015 RID: 21
		private struct ABSettings
		{
			// Token: 0x040000C6 RID: 198
			public int cbSize;

			// Token: 0x040000C7 RID: 199
			public ApplicationBar.ABEdge abEdge;

			// Token: 0x040000C8 RID: 200
			public ApplicationBar.ABFlags abFlags;

			// Token: 0x040000C9 RID: 201
			public bool bAutoHide;

			// Token: 0x040000CA RID: 202
			public bool bAlwaysOnTop;

			// Token: 0x040000CB RID: 203
			public int nTimerInterval;

			// Token: 0x040000CC RID: 204
			public ApplicationBar.mySize szSizeInc;

			// Token: 0x040000CD RID: 205
			public Size szDockSize;

			// Token: 0x040000CE RID: 206
			public Rectangle rcFloat;

			// Token: 0x040000CF RID: 207
			public Size nMinSize;

			// Token: 0x040000D0 RID: 208
			public Size nMaxSize;

			// Token: 0x040000D1 RID: 209
			public Size szMinDockSize;

			// Token: 0x040000D2 RID: 210
			public Size szMaxDockSize;

			// Token: 0x040000D3 RID: 211
			public ApplicationBar.ABTaskEntry abTaskEntry;
		}

		// Token: 0x02000016 RID: 22
		private struct MINMAXINFO
		{
			// Token: 0x040000D4 RID: 212
			public Point ptReserved;

			// Token: 0x040000D5 RID: 213
			public Point ptMaxSize;

			// Token: 0x040000D6 RID: 214
			public Point ptMaxPosition;

			// Token: 0x040000D7 RID: 215
			public Point ptMinTrackSize;

			// Token: 0x040000D8 RID: 216
			public Point ptMaxTrackSize;
		}

		// Token: 0x02000017 RID: 23
		private struct BPOSexplorerDATA
		{
			// Token: 0x040000D9 RID: 217
			public int cbSize;

			// Token: 0x040000DA RID: 218
			public IntPtr hWnd;

			// Token: 0x040000DB RID: 219
			public int uCallbackMessage;

			// Token: 0x040000DC RID: 220
			public int uEdge;

			// Token: 0x040000DD RID: 221
			public Rectangle rc;

			// Token: 0x040000DE RID: 222
			public IntPtr lParam;
		}
	}
}
