using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x2000BD7")]
	[Serializable]
	public class AudioZoneTrack
	{
		// Token: 0x060059E2 RID: 23010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x9AB060", Offset = "0x9AA260", VA = "0x1809AB060")]
		public void Init()
		{
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x9AB2B0", Offset = "0x9AA4B0", VA = "0x1809AB2B0")]
		public void Update(float multiplier)
		{
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0x9AB150", Offset = "0x9AA350", VA = "0x1809AB150")]
		public void UpdateTimeMultiplier(int time)
		{
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0x9AB350", Offset = "0x9AA550", VA = "0x1809AB350")]
		public AudioZoneTrack()
		{
		}

		// Token: 0x04003C0F RID: 15375
		[Token(Token = "0x4003C0F")]
		[FieldOffset(Offset = "0x10")]
		public AudioSourceController Source;

		// Token: 0x04003C10 RID: 15376
		[Token(Token = "0x4003C10")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.01f, 2f)]
		public float Volume;

		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		[FieldOffset(Offset = "0x1C")]
		public int StartTime;

		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		[FieldOffset(Offset = "0x20")]
		public int EndTime;

		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		[FieldOffset(Offset = "0x24")]
		public int FadeTime;

		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		[FieldOffset(Offset = "0x28")]
		private float timeVolMultiplier;

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		[FieldOffset(Offset = "0x2C")]
		private int fadeInStart;

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		[FieldOffset(Offset = "0x30")]
		private int fadeInEnd;

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		[FieldOffset(Offset = "0x34")]
		private int fadeOutStart;

		// Token: 0x04003C18 RID: 15384
		[Token(Token = "0x4003C18")]
		[FieldOffset(Offset = "0x38")]
		private int fadeOutEnd;

		// Token: 0x04003C19 RID: 15385
		[Token(Token = "0x4003C19")]
		[FieldOffset(Offset = "0x3C")]
		private int fadeInStartMinSum;

		// Token: 0x04003C1A RID: 15386
		[Token(Token = "0x4003C1A")]
		[FieldOffset(Offset = "0x40")]
		private int fadeInEndMinSum;

		// Token: 0x04003C1B RID: 15387
		[Token(Token = "0x4003C1B")]
		[FieldOffset(Offset = "0x44")]
		private int fadeOutStartMinSum;

		// Token: 0x04003C1C RID: 15388
		[Token(Token = "0x4003C1C")]
		[FieldOffset(Offset = "0x48")]
		private int fadeOutEndMinSum;
	}
}
