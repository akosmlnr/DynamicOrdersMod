using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x2000797")]
	public class CartelAmbushLocation : MonoBehaviour
	{
		// Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x790410", Offset = "0x78F610", VA = "0x180790410")]
		private void Awake()
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x790720", Offset = "0x78F920", VA = "0x180790720")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x7908C0", Offset = "0x78FAC0", VA = "0x1807908C0")]
		public CartelAmbushLocation()
		{
		}

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		public const int REQUIRED_AMBUSH_POINTS = 4;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[Range(2f, 20f)]
		public float DetectionRadius;

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] AmbushPoints;
	}
}
