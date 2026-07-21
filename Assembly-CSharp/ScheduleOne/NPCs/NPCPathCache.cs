using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A5F RID: 2655
	[Token(Token = "0x2000A5F")]
	public class NPCPathCache
	{
		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004CC2 RID: 19650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE9")]
		public List<NPCPathCache.PathCache> Paths
		{
			[Token(Token = "0x6004CC1")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CC2")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x92AD60", Offset = "0x929F60", VA = "0x18092AD60")]
		public NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			return null;
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x92AC40", Offset = "0x929E40", VA = "0x18092AC40")]
		public void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x92AF50", Offset = "0x92A150", VA = "0x18092AF50")]
		public NPCPathCache()
		{
		}

		// Token: 0x02000A60 RID: 2656
		[Token(Token = "0x2000A60")]
		[Serializable]
		public class PathCache
		{
			// Token: 0x06004CC6 RID: 19654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0x92E9D0", Offset = "0x92DBD0", VA = "0x18092E9D0")]
			public PathCache(Vector3 start, Vector3 end, NavMeshPath path)
			{
			}

			// Token: 0x040035D8 RID: 13784
			[Token(Token = "0x40035D8")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Start;

			// Token: 0x040035D9 RID: 13785
			[Token(Token = "0x40035D9")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 End;

			// Token: 0x040035DA RID: 13786
			[Token(Token = "0x40035DA")]
			[FieldOffset(Offset = "0x28")]
			public NavMeshPath Path;
		}
	}
}
