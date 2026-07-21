using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CA RID: 1482
	[Token(Token = "0x20005CA")]
	[Serializable]
	public class PatrolInstance
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000608")]
		public PatrolGroup ActiveGroup
		{
			[Token(Token = "0x6002200")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002201")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x67B880", Offset = "0x67AA80", VA = "0x18067B880")]
		public void Evaluate()
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x67BD30", Offset = "0x67AF30", VA = "0x18067BD30")]
		public void StartPatrol()
		{
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002204")]
		[Address(RVA = "0x67BB80", Offset = "0x67AD80", VA = "0x18067BB80")]
		private void MinPass()
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x67B750", Offset = "0x67A950", VA = "0x18067B750")]
		public void EndPatrol()
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002206")]
		[Address(RVA = "0x67BF30", Offset = "0x67B130", VA = "0x18067BF30")]
		public PatrolInstance()
		{
		}

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x10")]
		public FootPatrolRoute Route;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0x18")]
		public int Members;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x1C")]
		public int StartTime;

		// Token: 0x04001B7D RID: 7037
		[Token(Token = "0x4001B7D")]
		[FieldOffset(Offset = "0x20")]
		public int EndTime;

		// Token: 0x04001B7E RID: 7038
		[Token(Token = "0x4001B7E")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		[FieldOffset(Offset = "0x28")]
		public bool OnlyIfCurfewEnabled;
	}
}
