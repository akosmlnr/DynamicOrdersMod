using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	[RequireComponent(typeof(Rigidbody))]
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0xAF6E90", Offset = "0xAF6090", VA = "0x180AF6E90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0xAF6F50", Offset = "0xAF6150", VA = "0x180AF6F50", Slot = "5")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0xAF78D0", Offset = "0xAF6AD0", VA = "0x180AF78D0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0xAF7DC0", Offset = "0xAF6FC0", VA = "0x180AF7DC0")]
		public ObstructionDetector()
		{
		}

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x20")]
		private LandVehicle vehicle;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x28")]
		public List<LandVehicle> vehicles;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x30")]
		public List<NPC> npcs;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerMovement> players;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x40")]
		public List<VehicleObstacle> vehicleObstacles;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x48")]
		public float closestObstructionDistance;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x4C")]
		public float range;
	}
}
