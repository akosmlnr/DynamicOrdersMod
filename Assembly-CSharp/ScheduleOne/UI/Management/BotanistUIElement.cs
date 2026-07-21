using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D9E RID: 3486
	[Token(Token = "0x2000D9E")]
	public class BotanistUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06006492 RID: 25746 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006493 RID: 25747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E56")]
		public Botanist AssignedBotanist
		{
			[Token(Token = "0x6006492")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006493")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006494")]
		[Address(RVA = "0xA6FFA0", Offset = "0xA6F1A0", VA = "0x180A6FFA0")]
		public void Initialize(Botanist bot)
		{
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006495")]
		[Address(RVA = "0xA700D0", Offset = "0xA6F2D0", VA = "0x180A700D0", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006496")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BotanistUIElement()
		{
		}

		// Token: 0x04004695 RID: 18069
		[Token(Token = "0x4004695")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Image SupplyIcon;

		// Token: 0x04004696 RID: 18070
		[Token(Token = "0x4004696")]
		[FieldOffset(Offset = "0x58")]
		public GameObject NoSupply;

		// Token: 0x04004697 RID: 18071
		[Token(Token = "0x4004697")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI SupplyLabel;

		// Token: 0x04004698 RID: 18072
		[Token(Token = "0x4004698")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform[] PotRects;
	}
}
