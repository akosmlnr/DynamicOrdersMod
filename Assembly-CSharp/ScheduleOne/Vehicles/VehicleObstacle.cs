using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x6C53A0", Offset = "0x6C45A0", VA = "0x1806C53A0")]
		public VehicleObstacle()
		{
		}

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x20")]
		public Collider col;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public bool twoSided;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x2C")]
		public VehicleObstacle.EObstacleType type;

		// Token: 0x020002AA RID: 682
		[Token(Token = "0x20002AA")]
		public enum EObstacleType
		{
			// Token: 0x04000E5E RID: 3678
			[Token(Token = "0x4000E5E")]
			Generic,
			// Token: 0x04000E5F RID: 3679
			[Token(Token = "0x4000E5F")]
			TrafficLight
		}
	}
}
