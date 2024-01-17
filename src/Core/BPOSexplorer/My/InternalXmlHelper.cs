using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace BPOSexplorer.My
{
	// Token: 0x02000008 RID: 8
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal sealed class InternalXmlHelper
	{
		// Token: 0x06000038 RID: 56 RVA: 0x0002E0B4 File Offset: 0x0002C4B4
		[EditorBrowsable(EditorBrowsableState.Never)]
		private InternalXmlHelper()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0002E0C0 File Offset: 0x0002C4C0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0002E120 File Offset: 0x0002C520
		public static string Value
		{
			get
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						return xelement.Value;
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
				return null;
			}
			set
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						xelement.Value = value;
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0002E180 File Offset: 0x0002C580
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0002E1E8 File Offset: 0x0002C5E8
		public static string AttributeValue
		{
			get
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						return (string)xelement.Attribute(name);
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
				return null;
			}
			set
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						xelement.SetAttributeValue(name, value);
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					bool flag = enumerator != null;
					if (flag)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0002E248 File Offset: 0x0002C648
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0002E268 File Offset: 0x0002C668
		public static string AttributeValue
		{
			get
			{
				return (string)source.Attribute(name);
			}
			set
			{
				source.SetAttributeValue(name, value);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0002E278 File Offset: 0x0002C678
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateAttribute(XName name, object value)
		{
			bool flag = value == null;
			XAttribute xattribute;
			if (flag)
			{
				xattribute = null;
			}
			else
			{
				xattribute = new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
			}
			return xattribute;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0002E2A4 File Offset: 0x0002C6A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
		{
			XAttribute xattribute = new XAttribute(name, ns.NamespaceName);
			xattribute.AddAnnotation(ns);
			return xattribute;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0002E2CC File Offset: 0x0002C6CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
		{
			bool flag = obj != null;
			if (flag)
			{
				XElement xelement = obj as XElement;
				flag = xelement != null;
				if (flag)
				{
					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement);
				}
				IEnumerable enumerable = obj as IEnumerable;
				flag = enumerable != null;
				if (flag)
				{
					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
				}
			}
			return obj;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0002E32C File Offset: 0x0002C72C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
		{
			bool flag = obj != null;
			IEnumerable enumerable2;
			if (flag)
			{
				IEnumerable<XElement> enumerable = obj as IEnumerable<XElement>;
				flag = enumerable != null;
				if (flag)
				{
					enumerable2 = enumerable.Select(new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement));
				}
				else
				{
					enumerable2 = obj.Cast<object>().Select(new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
				}
			}
			else
			{
				enumerable2 = obj;
			}
			return enumerable2;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0002E3A0 File Offset: 0x0002C7A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
		{
			bool flag = e != null;
			checked
			{
				if (flag)
				{
					XAttribute nextAttribute;
					for (XAttribute xattribute = e.FirstAttribute; xattribute != null; xattribute = nextAttribute)
					{
						nextAttribute = xattribute.NextAttribute;
						flag = xattribute.IsNamespaceDeclaration;
						if (flag)
						{
							XNamespace xnamespace = xattribute.Annotation<XNamespace>();
							string localName = xattribute.Name.LocalName;
							flag = xnamespace != null;
							if (flag)
							{
								bool flag2 = inScopePrefixes != null && inScopeNs != null;
								if (flag2)
								{
									int num = inScopePrefixes.Length - 1;
									int num2 = 0;
									int num3 = num;
									int num4 = num2;
									XNamespace xnamespace2;
									for (;;)
									{
										int num5 = num4;
										int num6 = num3;
										if (num5 > num6)
										{
											goto IL_BF;
										}
										string text = inScopePrefixes[num4];
										xnamespace2 = inScopeNs[num4];
										flag2 = localName.Equals(text);
										if (flag2)
										{
											break;
										}
										num4++;
									}
									flag = xnamespace == xnamespace2;
									if (flag)
									{
										xattribute.Remove();
									}
									xattribute = null;
								}
								IL_BF:
								flag2 = xattribute != null;
								if (flag2)
								{
									flag = attributes != null;
									bool flag3;
									if (flag)
									{
										int num7 = attributes.Count - 1;
										int num8 = 0;
										int num9 = num7;
										int num10 = num8;
										XNamespace xnamespace3;
										for (;;)
										{
											int num11 = num10;
											int num6 = num9;
											if (num11 > num6)
											{
												goto IL_15C;
											}
											XAttribute xattribute2 = attributes[num10];
											string localName2 = xattribute2.Name.LocalName;
											xnamespace3 = xattribute2.Annotation<XNamespace>();
											flag2 = xnamespace3 != null;
											if (flag2)
											{
												flag = localName.Equals(localName2);
												if (flag)
												{
													break;
												}
											}
											num10++;
										}
										flag3 = xnamespace == xnamespace3;
										if (flag3)
										{
											xattribute.Remove();
										}
										xattribute = null;
									}
									IL_15C:
									flag3 = xattribute != null;
									if (flag3)
									{
										xattribute.Remove();
										attributes.Add(xattribute);
									}
								}
							}
						}
					}
				}
				return e;
			}
		}

		// Token: 0x02000009 RID: 9
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CompilerGenerated]
		private sealed class RemoveNamespaceAttributesClosure
		{
			// Token: 0x06000044 RID: 68 RVA: 0x0002E544 File Offset: 0x0002C944
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
			{
				this.m_inScopePrefixes = inScopePrefixes;
				this.m_inScopeNs = inScopeNs;
				this.m_attributes = attributes;
			}

			// Token: 0x06000045 RID: 69 RVA: 0x0002E564 File Offset: 0x0002C964
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal XElement ProcessXElement(XElement elem)
			{
				return InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
			}

			// Token: 0x06000046 RID: 70 RVA: 0x0002E590 File Offset: 0x0002C990
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal object ProcessObject(object obj)
			{
				XElement xelement = obj as XElement;
				bool flag = xelement != null;
				object obj2;
				if (flag)
				{
					obj2 = InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, xelement);
				}
				else
				{
					obj2 = obj;
				}
				return obj2;
			}

			// Token: 0x04000017 RID: 23
			private readonly string[] m_inScopePrefixes;

			// Token: 0x04000018 RID: 24
			private readonly XNamespace[] m_inScopeNs;

			// Token: 0x04000019 RID: 25
			private readonly List<XAttribute> m_attributes;
		}
	}
}
