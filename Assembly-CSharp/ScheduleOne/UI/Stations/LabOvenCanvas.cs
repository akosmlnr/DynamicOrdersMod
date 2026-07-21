using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CE3 RID: 3299
	[Token(Token = "0x2000CE3")]
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00018030 File Offset: 0x00016230
		// (set) Token: 0x06006019 RID: 24601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE8")]
		public bool isOpen
		{
			[Token(Token = "0x6006018")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006019")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600601B RID: 24603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE9")]
		public LabOven Oven
		{
			[Token(Token = "0x600601A")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600601B")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600601C")]
		[Address(RVA = "0xA286F0", Offset = "0xA278F0", VA = "0x180A286F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600601D")]
		[Address(RVA = "0xA29350", Offset = "0xA28550", VA = "0x180A29350", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600601E")]
		[Address(RVA = "0xA29440", Offset = "0xA28640", VA = "0x180A29440", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600601F")]
		[Address(RVA = "0xA28BF0", Offset = "0xA27DF0", VA = "0x180A28BF0")]
		public void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006020")]
		[Address(RVA = "0xA287B0", Offset = "0xA279B0", VA = "0x180A287B0")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00018048 File Offset: 0x00016248
		[Token(Token = "0x6006021")]
		[Address(RVA = "0xA289C0", Offset = "0xA27BC0", VA = "0x180A289C0")]
		public bool CanBegin()
		{
			return default(bool);
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00018060 File Offset: 0x00016260
		[Token(Token = "0x6006022")]
		[Address(RVA = "0xA28A90", Offset = "0xA27C90", VA = "0x180A28A90")]
		private bool DoesOvenOutputHaveSpace()
		{
			return default(bool);
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006023")]
		[Address(RVA = "0xA28B50", Offset = "0xA27D50", VA = "0x180A28B50")]
		private void RefreshActiveOperation()
		{
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006024")]
		[Address(RVA = "0xA29910", Offset = "0xA28B10", VA = "0x180A29910")]
		public LabOvenCanvas()
		{
		}

		// Token: 0x0400426C RID: 17004
		[Token(Token = "0x400426C")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400426D RID: 17005
		[Token(Token = "0x400426D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Container;

		// Token: 0x0400426E RID: 17006
		[Token(Token = "0x400426E")]
		[FieldOffset(Offset = "0x48")]
		public UIScreen UIScreen;

		// Token: 0x0400426F RID: 17007
		[Token(Token = "0x400426F")]
		[FieldOffset(Offset = "0x50")]
		public ItemSlotUI IngredientSlotUI;

		// Token: 0x04004270 RID: 17008
		[Token(Token = "0x4004270")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04004271 RID: 17009
		[Token(Token = "0x4004271")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04004272 RID: 17010
		[Token(Token = "0x4004272")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04004273 RID: 17011
		[Token(Token = "0x4004273")]
		[FieldOffset(Offset = "0x70")]
		public Button BeginButton;

		// Token: 0x04004274 RID: 17012
		[Token(Token = "0x4004274")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI BeginButtonLabel;

		// Token: 0x04004275 RID: 17013
		[Token(Token = "0x4004275")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform ProgressContainer;

		// Token: 0x04004276 RID: 17014
		[Token(Token = "0x4004276")]
		[FieldOffset(Offset = "0x88")]
		public Image IngredientIcon;

		// Token: 0x04004277 RID: 17015
		[Token(Token = "0x4004277")]
		[FieldOffset(Offset = "0x90")]
		public Image ProgressImg;

		// Token: 0x04004278 RID: 17016
		[Token(Token = "0x4004278")]
		[FieldOffset(Offset = "0x98")]
		public Image ProductIcon;
	}
}
