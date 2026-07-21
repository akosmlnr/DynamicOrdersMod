using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	[Serializable]
	public class DryingOperation
	{
		// Token: 0x0600434B RID: 17227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x88BFF0", Offset = "0x88B1F0", VA = "0x18088BFF0")]
		public DryingOperation(string itemID, int quantity, EQuality startQuality, float time)
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DryingOperation()
		{
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x88BFE0", Offset = "0x88B1E0", VA = "0x18088BFE0")]
		public void IncreaseQuality()
		{
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x88BF10", Offset = "0x88B110", VA = "0x18088BF10")]
		public QualityItemInstance GetQualityItemInstance()
		{
			return null;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x88BFC0", Offset = "0x88B1C0", VA = "0x18088BFC0")]
		public EQuality GetQuality()
		{
			return EQuality.Trash;
		}

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x10")]
		public string ItemID;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x18")]
		public int Quantity;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x1C")]
		public EQuality StartQuality;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x20")]
		public float Time;
	}
}
