using System;
using Il2CppDummyDll;

namespace ScheduleOne.Variables
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	[Serializable]
	public class VariableCreator
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001107")]
		[Address(RVA = "0xB082C0", Offset = "0xB074C0", VA = "0x180B082C0")]
		public VariableCreator()
		{
		}

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x18")]
		public VariableDatabase.EVariableType Type;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x20")]
		public string InitialValue;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x28")]
		public bool Persistent;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x2C")]
		public EVariableMode Mode;
	}
}
