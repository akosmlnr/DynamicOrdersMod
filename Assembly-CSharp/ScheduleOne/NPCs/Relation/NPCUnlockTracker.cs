using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x06004D53 RID: 19795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x940C80", Offset = "0x93FE80", VA = "0x180940C80")]
		private void Awake()
		{
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		private void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NPCUnlockTracker()
		{
		}

		// Token: 0x04003631 RID: 13873
		[Token(Token = "0x4003631")]
		[FieldOffset(Offset = "0x20")]
		public NPC Npc;

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onUnlocked;
	}
}
