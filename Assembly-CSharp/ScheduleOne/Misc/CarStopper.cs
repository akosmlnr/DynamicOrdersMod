using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Misc
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x66CC80", Offset = "0x66BE80", VA = "0x18066CC80", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x66CDA0", Offset = "0x66BFA0", VA = "0x18066CDA0")]
		public CarStopper()
		{
		}

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected Transform blocker;

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x30")]
		public NavMeshObstacle Obstacle;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x38")]
		private float moveTime;
	}
}
