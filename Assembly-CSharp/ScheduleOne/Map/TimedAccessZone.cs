using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x632C70", Offset = "0x631E70", VA = "0x180632C70", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x632C30", Offset = "0x631E30", VA = "0x180632C30", Slot = "7")]
		protected virtual void OnUncappedMinPass()
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x632BA0", Offset = "0x631DA0", VA = "0x180632BA0", Slot = "8")]
		protected virtual bool GetIsOpen()
		{
			return default(bool);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x6204A0", Offset = "0x61F6A0", VA = "0x1806204A0")]
		public TimedAccessZone()
		{
		}

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x48")]
		[Header("Timing Settings")]
		public int OpenTime;

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x4C")]
		public int CloseTime;
	}
}
