using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007E3 RID: 2019
	[Token(Token = "0x20007E3")]
	public class AvatarLODBoundsUpdater : MonoBehaviour
	{
		// Token: 0x0600368D RID: 13965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368D")]
		[Address(RVA = "0x7E83D0", Offset = "0x7E75D0", VA = "0x1807E83D0")]
		private void Awake()
		{
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x7E8570", Offset = "0x7E7770", VA = "0x1807E8570")]
		private void InfrequentUpdate()
		{
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x7E8500", Offset = "0x7E7700", VA = "0x1807E8500")]
		private void GetLODGroups()
		{
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x7E86F0", Offset = "0x7E78F0", VA = "0x1807E86F0")]
		private void Recalculate()
		{
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003691")]
		[Address(RVA = "0x7E88E0", Offset = "0x7E7AE0", VA = "0x1807E88E0")]
		public AvatarLODBoundsUpdater()
		{
		}

		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		public const float CHECK_RATE_SECONDS = 1f;

		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		public const float HIP_OFFSET_THRESHOLD = 5f;

		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		[FieldOffset(Offset = "0x20")]
		public Avatar Avatar;

		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x28")]
		private List<LODGroup> lodGroups;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 hipOffsetOnLastRefresh;
	}
}
