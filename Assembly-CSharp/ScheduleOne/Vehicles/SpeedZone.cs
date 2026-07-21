using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	[RequireComponent(typeof(BoxCollider))]
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0xAFB070", Offset = "0xAFA270", VA = "0x180AFB070", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0xAFB140", Offset = "0xAFA340", VA = "0x180AFB140")]
		public static IEnumerable<SpeedZone> GetSpeedZones(Vector3 point)
		{
			return null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0xAFB440", Offset = "0xAFA640", VA = "0x180AFB440")]
		public SpeedZone()
		{
		}

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x0")]
		public static List<SpeedZone> speedZones;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider col;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x8")]
		private static List<SpeedZone> query;
	}
}
