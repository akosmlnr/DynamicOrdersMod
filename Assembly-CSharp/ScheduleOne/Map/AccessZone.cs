using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054C")]
		public bool IsOpen
		{
			[Token(Token = "0x6001D08")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x61FCD0", Offset = "0x61EED0", VA = "0x18061FCD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x61FCF0", Offset = "0x61EEF0", VA = "0x18061FCF0", Slot = "5")]
		public virtual void SetIsOpen(bool open)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x61FF30", Offset = "0x61F130", VA = "0x18061FF30")]
		public AccessZone()
		{
		}

		// Token: 0x0400187C RID: 6268
		[Token(Token = "0x400187C")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings")]
		public bool AllowExitWhenClosed;

		// Token: 0x0400187D RID: 6269
		[Token(Token = "0x400187D")]
		[FieldOffset(Offset = "0x22")]
		public bool AutoCloseDoor;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public DoorController[] Doors;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		[FieldOffset(Offset = "0x30")]
		public ToggleableLight[] Lights;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onOpen;

		// Token: 0x04001881 RID: 6273
		[Token(Token = "0x4001881")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onClose;
	}
}
