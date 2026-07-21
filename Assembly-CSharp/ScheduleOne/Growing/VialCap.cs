using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	public class VialCap : Clickable
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x00011040 File Offset: 0x0000F240
		// (set) Token: 0x06003A69 RID: 14953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000920")]
		public bool Removed
		{
			[Token(Token = "0x6003A68")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A69")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x812670", Offset = "0x811870", VA = "0x180812670", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x8123B0", Offset = "0x8115B0", VA = "0x1808123B0")]
		private void Pop()
		{
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x8126C0", Offset = "0x8118C0", VA = "0x1808126C0")]
		public VialCap()
		{
		}

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x58")]
		public Collider Collider;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody RigidBody;
	}
}
