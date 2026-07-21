using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	public class PoliceBelt : Accessory
	{
		// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x7F3DC0", Offset = "0x7F2FC0", VA = "0x1807F3DC0")]
		public void SetBatonVisible(bool vis)
		{
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x7F3E40", Offset = "0x7F3040", VA = "0x1807F3E40")]
		public void SetTaserVisible(bool vis)
		{
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x7F3E00", Offset = "0x7F3000", VA = "0x1807F3E00")]
		public void SetGunVisible(bool vis)
		{
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x7F3540", Offset = "0x7F2740", VA = "0x1807F3540")]
		public PoliceBelt()
		{
		}

		// Token: 0x0400280E RID: 10254
		[Token(Token = "0x400280E")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		[SerializeField]
		protected GameObject BatonObject;

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected GameObject TaserObject;

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GameObject GunObject;
	}
}
