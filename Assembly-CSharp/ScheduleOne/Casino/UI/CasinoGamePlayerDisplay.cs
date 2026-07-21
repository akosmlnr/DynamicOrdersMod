using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x06003290 RID: 12944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x76DF70", Offset = "0x76D170", VA = "0x18076DF70")]
		public void RefreshPlayers()
		{
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x76E430", Offset = "0x76D630", VA = "0x18076E430")]
		public void RefreshScores()
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x76DE60", Offset = "0x76D060", VA = "0x18076DE60")]
		public void Bind(CasinoGamePlayers players)
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x76E5C0", Offset = "0x76D7C0", VA = "0x18076E5C0")]
		public void Unbind()
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CasinoGamePlayerDisplay()
		{
		}

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0x20")]
		public CasinoGamePlayers BindedPlayers;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform[] PlayerEntries;
	}
}
