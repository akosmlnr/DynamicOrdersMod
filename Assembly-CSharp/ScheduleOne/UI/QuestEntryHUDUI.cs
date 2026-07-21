using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class QuestEntryHUDUI : MonoBehaviour
	{
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAE")]
		public QuestEntry QuestEntry
		{
			[Token(Token = "0x6005E81")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E82")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E83")]
		[Address(RVA = "0xA0D5E0", Offset = "0xA0C7E0", VA = "0x180A0D5E0")]
		public void Initialize(QuestEntry entry)
		{
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0xA0CF90", Offset = "0xA0C190", VA = "0x180A0CF90")]
		public void Destroy()
		{
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0xA0D8E0", Offset = "0xA0CAE0", VA = "0x180A0D8E0", Slot = "4")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0xA0D370", Offset = "0xA0C570", VA = "0x180A0D370")]
		private void FadeIn()
		{
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E87")]
		[Address(RVA = "0xA0D1E0", Offset = "0xA0C3E0", VA = "0x180A0D1E0")]
		private void EntryEnded()
		{
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E88")]
		[Address(RVA = "0xA0D4D0", Offset = "0xA0C6D0", VA = "0x180A0D4D0")]
		private void FadeOut()
		{
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0xA0CE30", Offset = "0xA0C030", VA = "0x180A0CE30")]
		private void Complete()
		{
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public QuestEntryHUDUI()
		{
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0xA0D870", Offset = "0xA0CA70", VA = "0x180A0D870")]
		[CompilerGenerated]
		private IEnumerator <FadeOut>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0xA0D800", Offset = "0xA0CA00", VA = "0x180A0D800")]
		[CompilerGenerated]
		private IEnumerator <Complete>g__Routine|12_0()
		{
			return null;
		}

		// Token: 0x040040EF RID: 16623
		[Token(Token = "0x40040EF")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x040040F0 RID: 16624
		[Token(Token = "0x40040F0")]
		[FieldOffset(Offset = "0x30")]
		public Animation Animation;
	}
}
