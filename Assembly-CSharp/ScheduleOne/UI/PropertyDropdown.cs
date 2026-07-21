using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C9C RID: 3228
	[Token(Token = "0x2000C9C")]
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x06005E70 RID: 24176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0xA0BF30", Offset = "0xA0B130", VA = "0x180A0BF30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xA0C320", Offset = "0xA0B520", VA = "0x180A0C320")]
		private void PropertyAcquired(Property p)
		{
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E72")]
		[Address(RVA = "0xA0C550", Offset = "0xA0B750", VA = "0x180A0C550")]
		private void ValueChanged(int newVal)
		{
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E73")]
		[Address(RVA = "0xA0C5D0", Offset = "0xA0B7D0", VA = "0x180A0C5D0")]
		public PropertyDropdown()
		{
		}

		// Token: 0x040040E5 RID: 16613
		[Token(Token = "0x40040E5")]
		[FieldOffset(Offset = "0x20")]
		public Property selectedProperty;

		// Token: 0x040040E6 RID: 16614
		[Token(Token = "0x40040E6")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Dropdown TMP_dropdown;

		// Token: 0x040040E7 RID: 16615
		[Token(Token = "0x40040E7")]
		[FieldOffset(Offset = "0x30")]
		private Dropdown dropdown;

		// Token: 0x040040E8 RID: 16616
		[Token(Token = "0x40040E8")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, Property> intToProperty;

		// Token: 0x040040E9 RID: 16617
		[Token(Token = "0x40040E9")]
		[FieldOffset(Offset = "0x40")]
		public Action onSelectionChanged;
	}
}
