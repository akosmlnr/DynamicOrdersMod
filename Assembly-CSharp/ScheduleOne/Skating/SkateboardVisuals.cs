using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardVisuals : MonoBehaviour
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x592860", Offset = "0x591A60", VA = "0x180592860")]
		private void Awake()
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x5928B0", Offset = "0x591AB0", VA = "0x1805928B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x5929B0", Offset = "0x591BB0", VA = "0x1805929B0")]
		public SkateboardVisuals()
		{
		}

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float MaxBoardLean;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x24")]
		public float BoardLeanRate;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform Board;

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0x30")]
		private Skateboard skateboard;
	}
}
