using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B32 RID: 2866
	[Token(Token = "0x2000B32")]
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06005535 RID: 21813 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x17000C8E")]
		public bool NPCsReady
		{
			[Token(Token = "0x6005535")]
			[Address(RVA = "0x978790", Offset = "0x977990", VA = "0x180978790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005536")]
		[Address(RVA = "0x9781D0", Offset = "0x9773D0", VA = "0x1809781D0")]
		public void Awake()
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005537")]
		[Address(RVA = "0x9784E0", Offset = "0x9776E0", VA = "0x1809784E0")]
		public Transform GetStandPoint(NPC npc)
		{
			return null;
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005538")]
		[Address(RVA = "0x9785F0", Offset = "0x9777F0", VA = "0x1809785F0")]
		public void SetNPCReady(NPC npc, bool ready)
		{
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005539")]
		[Address(RVA = "0x978370", Offset = "0x977570", VA = "0x180978370")]
		public NPC GetOtherNPC(NPC npc)
		{
			return null;
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600553A")]
		[Address(RVA = "0x9786D0", Offset = "0x9778D0", VA = "0x1809786D0")]
		public ConversationLocation()
		{
		}

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] StandPoints;

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<NPC> NPCs;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<NPC, bool> npcReady;
	}
}
