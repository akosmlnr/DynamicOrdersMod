using System;
using Il2CppDummyDll;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[RequireComponent(typeof(PlayerMovement))]
	public class LocalPlayerFootstepGenerator : GenericFootstepDetector
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x678AD0", Offset = "0x677CD0", VA = "0x180678AD0")]
		private void Awake()
		{
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x678B20", Offset = "0x677D20", VA = "0x180678B20")]
		protected void LateUpdate()
		{
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x678D60", Offset = "0x677F60", VA = "0x180678D60")]
		public LocalPlayerFootstepGenerator()
		{
		}

		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		private const float DistancePerStep = 1.25f;

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[FieldOffset(Offset = "0x40")]
		private PlayerMovement _movement;

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[FieldOffset(Offset = "0x48")]
		private float _currentDistance;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 _lastFramePosition;
	}
}
