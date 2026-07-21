using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CDA RID: 3290
	[Token(Token = "0x2000CDA")]
	public class CauldronCanvas : Singleton<CauldronCanvas>
	{
		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x00017F40 File Offset: 0x00016140
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE0")]
		public bool isOpen
		{
			[Token(Token = "0x6005FDA")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FDB")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06005FDC RID: 24540 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005FDD RID: 24541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE1")]
		public Cauldron Cauldron
		{
			[Token(Token = "0x6005FDC")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FDD")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0xA21870", Offset = "0xA20A70", VA = "0x180A21870", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0xA22420", Offset = "0xA21620", VA = "0x180A22420", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0xA22510", Offset = "0xA21710", VA = "0x180A22510", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0xA21A00", Offset = "0xA20C00", VA = "0x180A21A00")]
		public void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)
		{
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0xA21930", Offset = "0xA20B30", VA = "0x180A21930")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0xA227C0", Offset = "0xA219C0", VA = "0x180A227C0")]
		public CauldronCanvas()
		{
		}

		// Token: 0x0400422E RID: 16942
		[Token(Token = "0x400422E")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400422F RID: 16943
		[Token(Token = "0x400422F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Container;

		// Token: 0x04004230 RID: 16944
		[Token(Token = "0x4004230")]
		[FieldOffset(Offset = "0x48")]
		public UIScreen UIScreen;

		// Token: 0x04004231 RID: 16945
		[Token(Token = "0x4004231")]
		[FieldOffset(Offset = "0x50")]
		public List<ItemSlotUI> IngredientSlotUIs;

		// Token: 0x04004232 RID: 16946
		[Token(Token = "0x4004232")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI LiquidSlotUI;

		// Token: 0x04004233 RID: 16947
		[Token(Token = "0x4004233")]
		[FieldOffset(Offset = "0x60")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04004234 RID: 16948
		[Token(Token = "0x4004234")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04004235 RID: 16949
		[Token(Token = "0x4004235")]
		[FieldOffset(Offset = "0x70")]
		public Button BeginButton;
	}
}
