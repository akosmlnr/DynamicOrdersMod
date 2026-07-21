using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x0000E718 File Offset: 0x0000C918
		// (set) Token: 0x06002E8F RID: 11919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C4")]
		public bool IsOpen
		{
			[Token(Token = "0x6002E8E")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E8F")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x74C280", Offset = "0x74B480", VA = "0x18074C280")]
		private void Awake()
		{
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x74C320", Offset = "0x74B520", VA = "0x18074C320")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x74C4D0", Offset = "0x74B6D0", VA = "0x18074C4D0")]
		public void Open()
		{
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x74C2D0", Offset = "0x74B4D0", VA = "0x18074C2D0")]
		public void Close()
		{
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "4")]
		protected virtual bool CanOpen()
		{
			return default(bool);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x74C540", Offset = "0x74B740", VA = "0x18074C540")]
		public RollerDoor()
		{
		}

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Transform Door;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 LocalPos_Open;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 LocalPos_Closed;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x48")]
		public float LerpTime;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Blocker;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 startPos;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x64")]
		private float timeSinceValueChange;
	}
}
