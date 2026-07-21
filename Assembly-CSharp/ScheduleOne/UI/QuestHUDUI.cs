using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public class QuestHUDUI : MonoBehaviour
	{
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB3")]
		public Quest Quest
		{
			[Token(Token = "0x6005E99")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E9A")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0xA0E160", Offset = "0xA0D360", VA = "0x180A0E160")]
		public void Initialize(Quest quest)
		{
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0xA0DC40", Offset = "0xA0CE40", VA = "0x180A0DC40")]
		public void Destroy()
		{
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0xA0E710", Offset = "0xA0D910", VA = "0x180A0E710")]
		public void UpdateUI()
		{
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0xA0E610", Offset = "0xA0D810", VA = "0x180A0E610")]
		public void UpdateMainLabel()
		{
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0xA0E6B0", Offset = "0xA0D8B0", VA = "0x180A0E6B0")]
		public void UpdateShade()
		{
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0xA0DAB0", Offset = "0xA0CCB0", VA = "0x180A0DAB0")]
		public void BopIcon()
		{
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0xA0DFD0", Offset = "0xA0D1D0", VA = "0x180A0DFD0")]
		private void FadeIn()
		{
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0xA0DEB0", Offset = "0xA0D0B0", VA = "0x180A0DEB0")]
		private void EntryEnded(EQuestState endState)
		{
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0xA0E050", Offset = "0xA0D250", VA = "0x180A0E050")]
		private void FadeOut()
		{
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0xA0DB30", Offset = "0xA0CD30", VA = "0x180A0DB30")]
		private void Complete()
		{
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0xA0E9D0", Offset = "0xA0DBD0", VA = "0x180A0E9D0")]
		public QuestHUDUI()
		{
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0xA0E5A0", Offset = "0xA0D7A0", VA = "0x180A0E5A0")]
		[CompilerGenerated]
		private IEnumerator <UpdateUI>g__DelayFix|13_0()
		{
			return null;
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0xA0E530", Offset = "0xA0D730", VA = "0x180A0E530")]
		[CompilerGenerated]
		private IEnumerator <FadeOut>g__Routine|19_0()
		{
			return null;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0xA0E4C0", Offset = "0xA0D6C0", VA = "0x180A0E4C0")]
		[CompilerGenerated]
		private IEnumerator <Complete>g__Routine|20_0()
		{
			return null;
		}

		// Token: 0x040040F7 RID: 16631
		[Token(Token = "0x40040F7")]
		[FieldOffset(Offset = "0x20")]
		public string CriticalTimeColor;

		// Token: 0x040040F9 RID: 16633
		[Token(Token = "0x40040F9")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x040040FA RID: 16634
		[Token(Token = "0x40040FA")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x040040FB RID: 16635
		[Token(Token = "0x40040FB")]
		[FieldOffset(Offset = "0x40")]
		public VerticalLayoutGroup hudUILayout;

		// Token: 0x040040FC RID: 16636
		[Token(Token = "0x40040FC")]
		[FieldOffset(Offset = "0x48")]
		public Animation Animation;

		// Token: 0x040040FD RID: 16637
		[Token(Token = "0x40040FD")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform Shade;

		// Token: 0x040040FE RID: 16638
		[Token(Token = "0x40040FE")]
		[FieldOffset(Offset = "0x58")]
		public Action onUpdateUI;
	}
}
