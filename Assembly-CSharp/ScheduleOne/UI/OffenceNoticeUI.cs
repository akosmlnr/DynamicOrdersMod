using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Police;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C8D RID: 3213
	[Token(Token = "0x2000C8D")]
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x06005E0E RID: 24078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0xA0A1C0", Offset = "0xA093C0", VA = "0x180A0A1C0")]
		public void ShowOffenceNotice(Offense offence)
		{
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0xA0A5A0", Offset = "0xA097A0", VA = "0x180A0A5A0")]
		protected void Update()
		{
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E10")]
		[Address(RVA = "0xA0A750", Offset = "0xA09950", VA = "0x180A0A750")]
		public OffenceNoticeUI()
		{
		}

		// Token: 0x04004087 RID: 16519
		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected GameObject container;

		// Token: 0x04004088 RID: 16520
		[Token(Token = "0x4004088")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected List<Text> charges;

		// Token: 0x04004089 RID: 16521
		[Token(Token = "0x4004089")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<Text> penalties;
	}
}
