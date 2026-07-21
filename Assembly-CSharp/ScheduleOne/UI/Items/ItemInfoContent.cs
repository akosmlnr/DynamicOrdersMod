using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public class ItemInfoContent : MonoBehaviour
	{
		// Token: 0x06006681 RID: 26241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006681")]
		[Address(RVA = "0xA94CF0", Offset = "0xA93EF0", VA = "0x180A94CF0", Slot = "4")]
		public virtual void Initialize(ItemInstance instance)
		{
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006682")]
		[Address(RVA = "0xA94DA0", Offset = "0xA93FA0", VA = "0x180A94DA0", Slot = "5")]
		public virtual void Initialize(ItemDefinition definition)
		{
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006683")]
		[Address(RVA = "0xA94E10", Offset = "0xA94010", VA = "0x180A94E10")]
		public ItemInfoContent()
		{
		}

		// Token: 0x0400484F RID: 18511
		[Token(Token = "0x400484F")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float Height;

		// Token: 0x04004850 RID: 18512
		[Token(Token = "0x4004850")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		// Token: 0x04004851 RID: 18513
		[Token(Token = "0x4004851")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI DescriptionLabel;
	}
}
