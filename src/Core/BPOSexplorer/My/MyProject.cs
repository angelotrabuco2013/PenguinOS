using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BPOSexplorer.My
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000312EC File Offset: 0x0002F6EC
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00031308 File Offset: 0x0002F708
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00031324 File Offset: 0x0002F724
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00031340 File Offset: 0x0002F740
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0003135C File Offset: 0x0002F75C
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000C RID: 12 RVA: 0x00031378 File Offset: 0x0002F778
			// (set) Token: 0x0600001A RID: 26 RVA: 0x000315A8 File Offset: 0x0002F9A8
			public about about
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_about = MyProject.MyForms.Create__Instance__<about>(this.m_about);
					return this.m_about;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_about;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<about>(ref this.m_about);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000313A0 File Offset: 0x0002F7A0
			// (set) Token: 0x0600001B RID: 27 RVA: 0x000315EC File Offset: 0x0002F9EC
			public barsetting barsetting
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_barsetting = MyProject.MyForms.Create__Instance__<barsetting>(this.m_barsetting);
					return this.m_barsetting;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_barsetting;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<barsetting>(ref this.m_barsetting);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000E RID: 14 RVA: 0x000313C8 File Offset: 0x0002F7C8
			// (set) Token: 0x0600001C RID: 28 RVA: 0x00031630 File Offset: 0x0002FA30
			public blackness blackness
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_blackness = MyProject.MyForms.Create__Instance__<blackness>(this.m_blackness);
					return this.m_blackness;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_blackness;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<blackness>(ref this.m_blackness);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000F RID: 15 RVA: 0x000313F0 File Offset: 0x0002F7F0
			// (set) Token: 0x0600001D RID: 29 RVA: 0x00031674 File Offset: 0x0002FA74
			public bpsc bpsc
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_bpsc = MyProject.MyForms.Create__Instance__<bpsc>(this.m_bpsc);
					return this.m_bpsc;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_bpsc;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<bpsc>(ref this.m_bpsc);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000010 RID: 16 RVA: 0x00031418 File Offset: 0x0002F818
			// (set) Token: 0x0600001E RID: 30 RVA: 0x000316B8 File Offset: 0x0002FAB8
			public endsession endsession
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_endsession = MyProject.MyForms.Create__Instance__<endsession>(this.m_endsession);
					return this.m_endsession;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_endsession;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<endsession>(ref this.m_endsession);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000011 RID: 17 RVA: 0x00031440 File Offset: 0x0002F840
			// (set) Token: 0x0600001F RID: 31 RVA: 0x000316FC File Offset: 0x0002FAFC
			public Feedback Feedback
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Feedback = MyProject.MyForms.Create__Instance__<Feedback>(this.m_Feedback);
					return this.m_Feedback;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Feedback;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Feedback>(ref this.m_Feedback);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000012 RID: 18 RVA: 0x00031468 File Offset: 0x0002F868
			// (set) Token: 0x06000020 RID: 32 RVA: 0x00031740 File Offset: 0x0002FB40
			public Form Form
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Form = MyProject.MyForms.Create__Instance__<Form>(this.m_Form);
					return this.m_Form;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Form;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form>(ref this.m_Form);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000013 RID: 19 RVA: 0x00031490 File Offset: 0x0002F890
			// (set) Token: 0x06000021 RID: 33 RVA: 0x00031784 File Offset: 0x0002FB84
			public helptopics helptopics
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_helptopics = MyProject.MyForms.Create__Instance__<helptopics>(this.m_helptopics);
					return this.m_helptopics;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_helptopics;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<helptopics>(ref this.m_helptopics);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000014 RID: 20 RVA: 0x000314B8 File Offset: 0x0002F8B8
			// (set) Token: 0x06000022 RID: 34 RVA: 0x000317C8 File Offset: 0x0002FBC8
			public history history
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_history = MyProject.MyForms.Create__Instance__<history>(this.m_history);
					return this.m_history;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_history;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<history>(ref this.m_history);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000015 RID: 21 RVA: 0x000314E0 File Offset: 0x0002F8E0
			// (set) Token: 0x06000023 RID: 35 RVA: 0x0003180C File Offset: 0x0002FC0C
			public MainForm MainForm
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_MainForm = MyProject.MyForms.Create__Instance__<MainForm>(this.m_MainForm);
					return this.m_MainForm;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_MainForm;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MainForm>(ref this.m_MainForm);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00031508 File Offset: 0x0002F908
			// (set) Token: 0x06000024 RID: 36 RVA: 0x00031850 File Offset: 0x0002FC50
			public NewExplorer NewExplorer
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_NewExplorer = MyProject.MyForms.Create__Instance__<NewExplorer>(this.m_NewExplorer);
					return this.m_NewExplorer;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_NewExplorer;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewExplorer>(ref this.m_NewExplorer);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00031530 File Offset: 0x0002F930
			// (set) Token: 0x06000025 RID: 37 RVA: 0x00031894 File Offset: 0x0002FC94
			public pane pane
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_pane = MyProject.MyForms.Create__Instance__<pane>(this.m_pane);
					return this.m_pane;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_pane;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<pane>(ref this.m_pane);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000018 RID: 24 RVA: 0x00031558 File Offset: 0x0002F958
			// (set) Token: 0x06000026 RID: 38 RVA: 0x000318D8 File Offset: 0x0002FCD8
			public runbox runbox
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_runbox = MyProject.MyForms.Create__Instance__<runbox>(this.m_runbox);
					return this.m_runbox;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_runbox;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<runbox>(ref this.m_runbox);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000019 RID: 25 RVA: 0x00031580 File Offset: 0x0002F980
			// (set) Token: 0x06000027 RID: 39 RVA: 0x0003191C File Offset: 0x0002FD1C
			public screenres screenres
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_screenres = MyProject.MyForms.Create__Instance__<screenres>(this.m_screenres);
					return this.m_screenres;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_screenres;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<screenres>(ref this.m_screenres);
					}
				}
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00031960 File Offset: 0x0002FD60
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message });
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00031A9C File Offset: 0x0002FE9C
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00031AC8 File Offset: 0x0002FEC8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00031AD4 File Offset: 0x0002FED4
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00031AF4 File Offset: 0x0002FEF4
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00031B0C File Offset: 0x0002FF0C
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00031B28 File Offset: 0x0002FF28
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public about m_about;

			// Token: 0x04000008 RID: 8
			public barsetting m_barsetting;

			// Token: 0x04000009 RID: 9
			public blackness m_blackness;

			// Token: 0x0400000A RID: 10
			public bpsc m_bpsc;

			// Token: 0x0400000B RID: 11
			public endsession m_endsession;

			// Token: 0x0400000C RID: 12
			public Feedback m_Feedback;

			// Token: 0x0400000D RID: 13
			public Form m_Form;

			// Token: 0x0400000E RID: 14
			public helptopics m_helptopics;

			// Token: 0x0400000F RID: 15
			public history m_history;

			// Token: 0x04000010 RID: 16
			public MainForm m_MainForm;

			// Token: 0x04000011 RID: 17
			public NewExplorer m_NewExplorer;

			// Token: 0x04000012 RID: 18
			public pane m_pane;

			// Token: 0x04000013 RID: 19
			public runbox m_runbox;

			// Token: 0x04000014 RID: 20
			public screenres m_screenres;

			// Token: 0x04000015 RID: 21
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600002F RID: 47 RVA: 0x00031B40 File Offset: 0x0002FF40
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00031B60 File Offset: 0x0002FF60
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00031B78 File Offset: 0x0002FF78
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00031B94 File Offset: 0x0002FF94
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00031BAC File Offset: 0x0002FFAC
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T t;
				if (flag)
				{
					t = new T();
				}
				else
				{
					t = instance;
				}
				return t;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00031BD8 File Offset: 0x0002FFD8
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00031BF8 File Offset: 0x0002FFF8
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00031C04 File Offset: 0x00030004
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00031C38 File Offset: 0x00030038
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000016 RID: 22
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
