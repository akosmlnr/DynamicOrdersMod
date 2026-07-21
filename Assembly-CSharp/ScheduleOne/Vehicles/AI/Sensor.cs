using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	public class Sensor : MonoBehaviour
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0xB049C0", Offset = "0xB03BC0", VA = "0x180B049C0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0xB03FE0", Offset = "0xB031E0", VA = "0x180B03FE0")]
		public void Check()
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0xB04B70", Offset = "0xB03D70", VA = "0x180B04B70")]
		public Sensor()
		{
		}

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x20")]
		public bool Enabled;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x28")]
		public Collider obstruction;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x30")]
		public float obstructionDistance;

		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		public const float checkRate = 0.33f;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x34")]
		[Header("Settings")]
		[SerializeField]
		protected float minDetectionRange;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float maxDetectionRange;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x3C")]
		public float checkRadius;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x40")]
		public LayerMask checkMask;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x48")]
		private LandVehicle vehicle;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float calculatedDetectionRange;

		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x54")]
		private RaycastHit hit;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x80")]
		private List<RaycastHit> hits;
	}
}
