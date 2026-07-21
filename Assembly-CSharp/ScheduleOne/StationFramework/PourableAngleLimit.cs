using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008EF RID: 2287
	[Token(Token = "0x20008EF")]
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06003D57 RID: 15703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x835C10", Offset = "0x834E10", VA = "0x180835C10")]
		private void Awake()
		{
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x835C30", Offset = "0x834E30", VA = "0x180835C30")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x835CE0", Offset = "0x834EE0", VA = "0x180835CE0")]
		public PourableAngleLimit()
		{
		}

		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		[FieldOffset(Offset = "0x20")]
		public PourableModule Pourable;

		// Token: 0x04002CD6 RID: 11478
		[Token(Token = "0x4002CD6")]
		[FieldOffset(Offset = "0x28")]
		public DraggableConstraint Constraint;

		// Token: 0x04002CD7 RID: 11479
		[Token(Token = "0x4002CD7")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float AngleAtMaxFill;

		// Token: 0x04002CD8 RID: 11480
		[Token(Token = "0x4002CD8")]
		[FieldOffset(Offset = "0x34")]
		public float AngleAtMinFill;

		// Token: 0x04002CD9 RID: 11481
		[Token(Token = "0x4002CD9")]
		[FieldOffset(Offset = "0x38")]
		public float PourAngleMaxFill;

		// Token: 0x04002CDA RID: 11482
		[Token(Token = "0x4002CDA")]
		[FieldOffset(Offset = "0x3C")]
		public float PourAngleMinFill;
	}
}
