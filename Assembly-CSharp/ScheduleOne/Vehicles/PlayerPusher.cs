using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	[RequireComponent(typeof(BoxCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0xAF8180", Offset = "0xAF7380", VA = "0x180AF8180")]
		private void Awake()
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0xAF8300", Offset = "0xAF7500", VA = "0x180AF8300")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0xAF87A0", Offset = "0xAF79A0", VA = "0x180AF87A0")]
		public void SetEnabled(bool isEnabled)
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0xAF8360", Offset = "0xAF7560", VA = "0x180AF8360")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0xAF87C0", Offset = "0xAF79C0", VA = "0x180AF87C0")]
		public PlayerPusher()
		{
		}

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x20")]
		private LandVehicle veh;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MinSpeedToPush;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxPushSpeed;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x30")]
		public float MinPushForce;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x34")]
		public float MaxPushForce;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x38")]
		private Collider collider;
	}
}
