using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D7 RID: 1751
	[Token(Token = "0x20006D7")]
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06002E82 RID: 11906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x74C120", Offset = "0x74B320", VA = "0x18074C120", Slot = "5")]
		public virtual void Opened(EDoorSide openSide)
		{
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x74C110", Offset = "0x74B310", VA = "0x18074C110", Slot = "6")]
		public virtual void Closed()
		{
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E85")]
		[Address(RVA = "0x74C1E0", Offset = "0x74B3E0", VA = "0x18074C1E0")]
		private void UpdateDoor()
		{
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x74C260", Offset = "0x74B460", VA = "0x18074C260")]
		public PivotDoor()
		{
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x74C170", Offset = "0x74B370", VA = "0x18074C170")]
		[CompilerGenerated]
		private IEnumerator <UpdateDoor>g__inner|10_0()
		{
			return null;
		}

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x28")]
		public bool FlipSide;

		// Token: 0x04002270 RID: 8816
		[Token(Token = "0x4002270")]
		[FieldOffset(Offset = "0x2C")]
		public float OpenInwardsAngle;

		// Token: 0x04002271 RID: 8817
		[Token(Token = "0x4002271")]
		[FieldOffset(Offset = "0x30")]
		public float OpenOutwardsAngle;

		// Token: 0x04002272 RID: 8818
		[Token(Token = "0x4002272")]
		[FieldOffset(Offset = "0x34")]
		public float SwingSpeed;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x38")]
		private bool isUpdatingDoor;

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x3C")]
		private float targetDoorAngle;
	}
}
