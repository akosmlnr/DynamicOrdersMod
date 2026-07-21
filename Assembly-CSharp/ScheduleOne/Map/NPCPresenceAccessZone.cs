using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	public class NPCPresenceAccessZone : AccessZone
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x61FCD0", Offset = "0x61EED0", VA = "0x18061FCD0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x629B70", Offset = "0x628D70", VA = "0x180629B70", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x629A60", Offset = "0x628C60", VA = "0x180629A60", Slot = "7")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x629C70", Offset = "0x628E70", VA = "0x180629C70")]
		public NPCPresenceAccessZone()
		{
		}

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		public const float CooldownTime = 0.5f;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0x48")]
		public Collider DetectionZone;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x50")]
		public NPC TargetNPC;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x58")]
		private float timeSinceNPCSensed;
	}
}
