using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B4D RID: 2893
	[Token(Token = "0x2000B4D")]
	public class SmokeCigarette : MonoBehaviour
	{
		// Token: 0x060056CF RID: 22223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x9A3FE0", Offset = "0x9A31E0", VA = "0x1809A3FE0")]
		private void Awake()
		{
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x9A4030", Offset = "0x9A3230", VA = "0x1809A4030")]
		public void Begin()
		{
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0x9A40B0", Offset = "0x9A32B0", VA = "0x1809A40B0")]
		public void End()
		{
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SmokeCigarette()
		{
		}

		// Token: 0x040039FB RID: 14843
		[Token(Token = "0x40039FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EquippableData _cigarette;

		// Token: 0x040039FC RID: 14844
		[Token(Token = "0x40039FC")]
		[FieldOffset(Offset = "0x28")]
		private NPC _npc;

		// Token: 0x040039FD RID: 14845
		[Token(Token = "0x40039FD")]
		[FieldOffset(Offset = "0x30")]
		private IEquippedItemHandler _equippedItem;
	}
}
