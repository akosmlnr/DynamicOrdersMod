using System;
using Il2CppDummyDll;

namespace ScheduleOne.Law
{
	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x20005C6")]
	[Serializable]
	public class LawActivitySettings
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x673670", Offset = "0x672870", VA = "0x180673670")]
		public void Evaluate()
		{
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x673600", Offset = "0x672800", VA = "0x180673600")]
		public void End()
		{
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x6739A0", Offset = "0x672BA0", VA = "0x1806739A0")]
		public void OnLoaded()
		{
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public LawActivitySettings()
		{
		}

		// Token: 0x04001B5E RID: 7006
		[Token(Token = "0x4001B5E")]
		[FieldOffset(Offset = "0x10")]
		public PatrolInstance[] Patrols;

		// Token: 0x04001B5F RID: 7007
		[Token(Token = "0x4001B5F")]
		[FieldOffset(Offset = "0x18")]
		public CheckpointInstance[] Checkpoints;

		// Token: 0x04001B60 RID: 7008
		[Token(Token = "0x4001B60")]
		[FieldOffset(Offset = "0x20")]
		public CurfewInstance[] Curfews;

		// Token: 0x04001B61 RID: 7009
		[Token(Token = "0x4001B61")]
		[FieldOffset(Offset = "0x28")]
		public VehiclePatrolInstance[] VehiclePatrols;

		// Token: 0x04001B62 RID: 7010
		[Token(Token = "0x4001B62")]
		[FieldOffset(Offset = "0x30")]
		public SentryInstance[] Sentries;
	}
}
