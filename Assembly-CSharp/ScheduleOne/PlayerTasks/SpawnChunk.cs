using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Clickable))]
	public class SpawnChunk : Clickable
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x17000464")]
		private bool hasChildChunks
		{
			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x5C3830", Offset = "0x5C2A30", VA = "0x1805C3830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x5C2BF0", Offset = "0x5C1DF0", VA = "0x1805C2BF0")]
		private void Awake()
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x5C3290", Offset = "0x5C2490", VA = "0x1805C3290")]
		public void EnableChunk(Vector3 force, Vector3 torque)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x5C3110", Offset = "0x5C2310", VA = "0x1805C3110")]
		public void DisableChunk(bool recursive)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x5C2D60", Offset = "0x5C1F60", VA = "0x1805C2D60")]
		public void Break()
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x5C3470", Offset = "0x5C2670", VA = "0x1805C3470")]
		public bool GetIsBroken(bool recursive = true)
		{
			return default(bool);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x5C3750", Offset = "0x5C2950", VA = "0x1805C3750", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x5C35C0", Offset = "0x5C27C0", VA = "0x1805C35C0")]
		public void SetChunkOrder(int i)
		{
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x5C37B0", Offset = "0x5C29B0", VA = "0x1805C37B0")]
		public SpawnChunk()
		{
		}

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x50")]
		private MeshRenderer _meshRenderer;

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody _rb;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x60")]
		private Collider _collider;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x68")]
		private bool _isBroken;

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x70")]
		private List<SpawnChunk> _childChunks;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent OnBreak;
	}
}
