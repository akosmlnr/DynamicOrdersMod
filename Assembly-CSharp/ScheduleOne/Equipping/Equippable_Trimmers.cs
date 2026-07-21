using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200094F RID: 2383
	[Token(Token = "0x200094F")]
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x06003FD4 RID: 16340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x859C00", Offset = "0x858E00", VA = "0x180859C00", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x858100", Offset = "0x857300", VA = "0x180858100")]
		public Equippable_Trimmers()
		{
		}

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x60")]
		public bool CanClickAndDrag;

		// Token: 0x04002E81 RID: 11905
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0x68")]
		public AudioSourceController SoundLoopPrefab;
	}
}
