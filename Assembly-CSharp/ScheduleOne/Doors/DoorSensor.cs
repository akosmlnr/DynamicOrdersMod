using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	[RequireComponent(typeof(Rigidbody))]
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06002E76 RID: 11894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x745950", Offset = "0x744B50", VA = "0x180745950")]
		private void Awake()
		{
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E77")]
		[Address(RVA = "0x7463F0", Offset = "0x7455F0", VA = "0x1807463F0")]
		private void UpdateCollider()
		{
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E78")]
		[Address(RVA = "0x745B50", Offset = "0x744D50", VA = "0x180745B50")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x745EB0", Offset = "0x7450B0", VA = "0x180745EB0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7A")]
		[Address(RVA = "0x7460C0", Offset = "0x7452C0", VA = "0x1807460C0")]
		private void RemoveInvalidContacts()
		{
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x7466C0", Offset = "0x7458C0", VA = "0x1807466C0")]
		public DoorSensor()
		{
		}

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		public const float ActivationDistance = 30f;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0x20")]
		public EDoorSide DetectorSide;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0x28")]
		public DoorController Door;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x30")]
		private Collider collider;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x38")]
		private List<Collider> exclude;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x40")]
		private List<NPC> npcsInContact;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x48")]
		private List<Player> playersInContact;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x50")]
		private float maxContactDistanceSqr;
	}
}
