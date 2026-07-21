using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x06003176 RID: 12662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003176")]
		[Address(RVA = "0x758880", Offset = "0x757A80", VA = "0x180758880")]
		private void Awake()
		{
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003177")]
		[Address(RVA = "0x758970", Offset = "0x757B70", VA = "0x180758970")]
		private void Hovered()
		{
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003178")]
		[Address(RVA = "0x758A50", Offset = "0x757C50", VA = "0x180758A50")]
		private void Interacted()
		{
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003179")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CasinoGameInteraction()
		{
		}

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0x20")]
		public string GameName;

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject IntObj;

		// Token: 0x04002471 RID: 9329
		[Token(Token = "0x4002471")]
		[FieldOffset(Offset = "0x38")]
		public Action<Player> onLocalPlayerRequestJoin;
	}
}
