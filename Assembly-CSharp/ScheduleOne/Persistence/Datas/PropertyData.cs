using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x616810", Offset = "0x615A10", VA = "0x180616810")]
		public PropertyData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, DynamicSaveData[] employees, DynamicSaveData[] objects)
		{
		}

		// Token: 0x0400173D RID: 5949
		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x28")]
		public string PropertyCode;

		// Token: 0x0400173E RID: 5950
		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x30")]
		public bool IsOwned;

		// Token: 0x0400173F RID: 5951
		[Token(Token = "0x400173F")]
		[FieldOffset(Offset = "0x38")]
		public bool[] SwitchStates;

		// Token: 0x04001740 RID: 5952
		[Token(Token = "0x4001740")]
		[FieldOffset(Offset = "0x40")]
		public bool[] ToggleableStates;

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		[FieldOffset(Offset = "0x48")]
		public DynamicSaveData[] Employees;

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x50")]
		public DynamicSaveData[] Objects;
	}
}
