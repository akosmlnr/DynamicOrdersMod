using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	[Serializable]
	public class CurfewInstance
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x0000B7D8 File Offset: 0x000099D8
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F9")]
		public bool Enabled
		{
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x66E350", Offset = "0x66D550", VA = "0x18066E350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x66E360", Offset = "0x66D560", VA = "0x18066E360")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x66E1A0", Offset = "0x66D3A0", VA = "0x18066E1A0")]
		public void Evaluate(bool ignoreSleepReq = false)
		{
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x66E270", Offset = "0x66D470", VA = "0x18066E270")]
		private void MinPass()
		{
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x66E000", Offset = "0x66D200", VA = "0x18066E000")]
		public void Enable()
		{
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x66DD90", Offset = "0x66CF90", VA = "0x18066DD90")]
		public void Disable()
		{
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x66E340", Offset = "0x66D540", VA = "0x18066E340")]
		public CurfewInstance()
		{
		}

		// Token: 0x04001B43 RID: 6979
		[Token(Token = "0x4001B43")]
		[FieldOffset(Offset = "0x0")]
		public static CurfewInstance ActiveInstance;

		// Token: 0x04001B44 RID: 6980
		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x10")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x15")]
		[HideInInspector]
		public bool shouldDisable;
	}
}
