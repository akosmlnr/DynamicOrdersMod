using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008A9 RID: 2217
	[Token(Token = "0x20008A9")]
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x06003A66 RID: 14950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x7FDFC0", Offset = "0x7FD1C0", VA = "0x1807FDFC0")]
		public void TriggerExit(Collider other)
		{
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FunctionalSeed()
		{
		}

		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x20")]
		public Action onSeedExitVial;

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x28")]
		public Draggable Vial;

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x30")]
		public Collider SeedBlocker;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x38")]
		public VialCap Cap;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x40")]
		public Collider SeedCollider;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x48")]
		public Rigidbody SeedRigidbody;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x50")]
		public TrashItem TrashPrefab;
	}
}
