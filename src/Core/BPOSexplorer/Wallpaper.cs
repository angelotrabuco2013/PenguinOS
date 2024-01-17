using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace BPOSexplorer
{
	// Token: 0x0200002A RID: 42
	public class Wallpaper
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00030F60 File Offset: 0x0002F360
		[DebuggerNonUserCode]
		public Wallpaper()
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00030F6C File Offset: 0x0002F36C
		public static object SupportJpgAsWallpaper
		{
			get
			{
				return Environment.OSVersion.Version >= new Version(6, 0);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00030F9C File Offset: 0x0002F39C
		public static object SupportFitFillWallpaperStyles
		{
			get
			{
				return Environment.OSVersion.Version >= new Version(6, 1);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00030FCC File Offset: 0x0002F3CC
		public static void SetDesktopWallpaper(string path, WallpaperStyle style)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			switch (style)
			{
			case WallpaperStyle.Tile:
				registryKey.SetValue("WallpaperStyle", "0");
				registryKey.SetValue("TileWallpaper", "1");
				break;
			case WallpaperStyle.Center:
				registryKey.SetValue("WallpaperStyle", "0");
				registryKey.SetValue("TileWallpaper", "0");
				break;
			case WallpaperStyle.Stretch:
				registryKey.SetValue("WallpaperStyle", "2");
				registryKey.SetValue("TileWallpaper", "0");
				break;
			case WallpaperStyle.Fit:
				registryKey.SetValue("WallpaperStyle", "6");
				registryKey.SetValue("TileWallpaper", "0");
				break;
			case WallpaperStyle.Fill:
				registryKey.SetValue("WallpaperStyle", "10");
				registryKey.SetValue("TileWallpaper", "0");
				break;
			}
			registryKey.Close();
			string extension = Path.GetExtension(path);
			object obj;
			if (!Conversions.ToBoolean(!extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase) && !extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)))
			{
				if (!Conversions.ToBoolean(extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)) || !Conversions.ToBoolean(Operators.NotObject(Wallpaper.SupportJpgAsWallpaper)))
				{
					obj = false;
					goto IL_176;
				}
			}
			obj = true;
			IL_176:
			bool flag = Conversions.ToBoolean(obj);
			if (flag)
			{
				Image image = Image.FromFile(path);
				try
				{
					path = string.Format("{0}\\Microsoft\\Windows\\Themes\\{1}.bmp", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Path.GetFileNameWithoutExtension(path));
					image.Save(path, ImageFormat.Bmp);
				}
				finally
				{
					flag = image != null;
					if (flag)
					{
						((IDisposable)image).Dispose();
					}
				}
			}
			flag = !Wallpaper.SystemParametersInfo(20U, 0U, path, 3U);
			if (flag)
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x060002B9 RID: 697
		[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

		// Token: 0x040001C0 RID: 448
		private const uint SPI_SETDESKWALLPAPER = 20U;

		// Token: 0x040001C1 RID: 449
		private const uint SPIF_SENDWININICHANGE = 2U;

		// Token: 0x040001C2 RID: 450
		private const uint SPIF_UPDATEINIFILE = 1U;
	}
}
