using System;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	[Serializable]
	public class ManorData : PropertyData
	{
		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x60E950", Offset = "0x60DB50", VA = "0x18060E950")]
		public ManorData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates, DynamicSaveData[] employees, DynamicSaveData[] objects, Manor.EManorState state, int daysSinceStateChange, bool tunnelDug)
		{
		}

		// Token: 0x040016B3 RID: 5811
		[Token(Token = "0x40016B3")]
		[FieldOffset(Offset = "0x58")]
		public Manor.EManorState ManorState;

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x5C")]
		public int DaysSinceStateChange;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x60")]
		public bool TunnelDug;
	}
}
