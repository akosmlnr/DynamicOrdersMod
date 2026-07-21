using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	public class ItemInfoPanel : MonoBehaviour
	{
		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06006684 RID: 26244 RVA: 0x00018F90 File Offset: 0x00017190
		// (set) Token: 0x06006685 RID: 26245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8B")]
		public bool IsOpen
		{
			[Token(Token = "0x6006684")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006685")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006687 RID: 26247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8C")]
		public ItemInstance CurrentItem
		{
			[Token(Token = "0x6006686")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006687")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006688")]
		[Address(RVA = "0xA94E20", Offset = "0xA94020", VA = "0x180A94E20")]
		private void Awake()
		{
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006689")]
		[Address(RVA = "0xA94F00", Offset = "0xA94100", VA = "0x180A94F00")]
		public void Open(ItemInstance item, RectTransform rect)
		{
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668A")]
		[Address(RVA = "0xA952B0", Offset = "0xA944B0", VA = "0x180A952B0")]
		public void Open(ItemDefinition def, RectTransform rect)
		{
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668B")]
		[Address(RVA = "0xA94E30", Offset = "0xA94030", VA = "0x180A94E30")]
		public void Close()
		{
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668C")]
		[Address(RVA = "0xA955E0", Offset = "0xA947E0", VA = "0x180A955E0")]
		public ItemInfoPanel()
		{
		}

		// Token: 0x04004852 RID: 18514
		[Token(Token = "0x4004852")]
		public const float VERTICAL_THRESHOLD = 200f;

		// Token: 0x04004855 RID: 18517
		[Token(Token = "0x4004855")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04004856 RID: 18518
		[Token(Token = "0x4004856")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform ContentContainer;

		// Token: 0x04004857 RID: 18519
		[Token(Token = "0x4004857")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TopArrow;

		// Token: 0x04004858 RID: 18520
		[Token(Token = "0x4004858")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BottomArrow;

		// Token: 0x04004859 RID: 18521
		[Token(Token = "0x4004859")]
		[FieldOffset(Offset = "0x50")]
		public Canvas Canvas;

		// Token: 0x0400485A RID: 18522
		[Token(Token = "0x400485A")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public Vector2 Offset;

		// Token: 0x0400485B RID: 18523
		[Token(Token = "0x400485B")]
		[FieldOffset(Offset = "0x60")]
		[Header("Prefabs")]
		public ItemInfoContent DefaultContentPrefab;

		// Token: 0x0400485C RID: 18524
		[Token(Token = "0x400485C")]
		[FieldOffset(Offset = "0x68")]
		private ItemInfoContent content;
	}
}
