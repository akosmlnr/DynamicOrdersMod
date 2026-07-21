using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	[Serializable]
	public class EntityVisualState
	{
		// Token: 0x060017F0 RID: 6128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public EntityVisualState()
		{
		}

		// Token: 0x040014EF RID: 5359
		[Token(Token = "0x40014EF")]
		[FieldOffset(Offset = "0x10")]
		public EVisualState state;

		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40014F0")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		[FieldOffset(Offset = "0x20")]
		public Action stateDestroyed;
	}
}
