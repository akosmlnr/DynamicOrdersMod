using System;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	[Serializable]
	public class VehiclePatrolInstance
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700060A")]
		private PoliceStation nearestStation
		{
			[Token(Token = "0x6002212")]
			[Address(RVA = "0x689CC0", Offset = "0x688EC0", VA = "0x180689CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x689860", Offset = "0x688A60", VA = "0x180689860")]
		public void Evaluate()
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x6897C0", Offset = "0x6889C0", VA = "0x1806897C0")]
		private void CheckEnd()
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x689B80", Offset = "0x688D80", VA = "0x180689B80")]
		public void StartPatrol()
		{
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x689CA0", Offset = "0x688EA0", VA = "0x180689CA0")]
		public VehiclePatrolInstance()
		{
		}

		// Token: 0x04001B9B RID: 7067
		[Token(Token = "0x4001B9B")]
		[FieldOffset(Offset = "0x10")]
		public VehiclePatrolRoute Route;

		// Token: 0x04001B9C RID: 7068
		[Token(Token = "0x4001B9C")]
		[FieldOffset(Offset = "0x18")]
		public int StartTime;

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		[FieldOffset(Offset = "0x1C")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x20")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x28")]
		private PoliceOfficer activeOfficer;

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[FieldOffset(Offset = "0x30")]
		private int latestStartTime;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[FieldOffset(Offset = "0x34")]
		private bool startedThisCycle;
	}
}
