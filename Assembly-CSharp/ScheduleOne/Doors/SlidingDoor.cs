using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x0000E760 File Offset: 0x0000C960
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C5")]
		public bool IsOpen
		{
			[Token(Token = "0x6002E9F")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EA0")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA1")]
		[Address(RVA = "0x74D010", Offset = "0x74C210", VA = "0x18074D010", Slot = "4")]
		public virtual void Opened(EDoorSide openSide)
		{
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x74CF60", Offset = "0x74C160", VA = "0x18074CF60", Slot = "5")]
		public virtual void Closed()
		{
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x74CF70", Offset = "0x74C170", VA = "0x18074CF70")]
		private void Move()
		{
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA4")]
		[Address(RVA = "0x74D090", Offset = "0x74C290", VA = "0x18074D090")]
		public SlidingDoor()
		{
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x74D020", Offset = "0x74C220", VA = "0x18074D020")]
		[CompilerGenerated]
		private IEnumerator <Move>g__Move|12_0()
		{
			return null;
		}

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Transform DoorTransform;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x30")]
		public Transform ClosedPosition;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x38")]
		public Transform OpenPosition;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x40")]
		public float SlideDuration;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve SlideCurve;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine MoveRoutine;
	}
}
