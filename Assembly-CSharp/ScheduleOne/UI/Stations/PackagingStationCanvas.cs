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
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x2000CE6")]
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06006050 RID: 24656 RVA: 0x000180D8 File Offset: 0x000162D8
		// (set) Token: 0x06006051 RID: 24657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEE")]
		public bool isOpen
		{
			[Token(Token = "0x6006050")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006051")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06006052 RID: 24658 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006053 RID: 24659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEF")]
		public PackagingStation PackagingStation
		{
			[Token(Token = "0x6006052")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006053")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006054")]
		[Address(RVA = "0xA2EB10", Offset = "0xA2DD10", VA = "0x180A2EB10", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006055")]
		[Address(RVA = "0xA2F880", Offset = "0xA2EA80", VA = "0x180A2F880", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006056")]
		[Address(RVA = "0xA2FCA0", Offset = "0xA2EEA0", VA = "0x180A2FCA0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006057")]
		[Address(RVA = "0xA2EDC0", Offset = "0xA2DFC0", VA = "0x180A2EDC0")]
		public void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
		{
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006058")]
		[Address(RVA = "0xA2EBD0", Offset = "0xA2DDD0", VA = "0x180A2EBD0")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006059")]
		[Address(RVA = "0xA2F990", Offset = "0xA2EB90", VA = "0x180A2F990")]
		private void UpdateSlotPositions()
		{
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600605A")]
		[Address(RVA = "0xA2F970", Offset = "0xA2EB70", VA = "0x180A2F970")]
		public void ToggleMode()
		{
		}

		// Token: 0x0600605B RID: 24667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600605B")]
		[Address(RVA = "0xA2F560", Offset = "0xA2E760", VA = "0x180A2F560")]
		public void SetMode(PackagingStation.EMode mode)
		{
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600605C")]
		[Address(RVA = "0xA300B0", Offset = "0xA2F2B0", VA = "0x180A300B0")]
		public PackagingStationCanvas()
		{
		}

		// Token: 0x0400429D RID: 17053
		[Token(Token = "0x400429D")]
		[FieldOffset(Offset = "0x38")]
		public bool ShowHintOnOpen;

		// Token: 0x0400429E RID: 17054
		[Token(Token = "0x400429E")]
		[FieldOffset(Offset = "0x39")]
		public bool ShowShiftClickHint;

		// Token: 0x0400429F RID: 17055
		[Token(Token = "0x400429F")]
		[FieldOffset(Offset = "0x3C")]
		public PackagingStation.EMode CurrentMode;

		// Token: 0x040042A0 RID: 17056
		[Token(Token = "0x40042A0")]
		[FieldOffset(Offset = "0x40")]
		public Color InstructionWarningColor;

		// Token: 0x040042A1 RID: 17057
		[Token(Token = "0x40042A1")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040042A2 RID: 17058
		[Token(Token = "0x40042A2")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Container;

		// Token: 0x040042A3 RID: 17059
		[Token(Token = "0x40042A3")]
		[FieldOffset(Offset = "0x60")]
		public UIScreen UIScreen;

		// Token: 0x040042A4 RID: 17060
		[Token(Token = "0x40042A4")]
		[FieldOffset(Offset = "0x68")]
		public ItemSlotUI PackagingSlotUI;

		// Token: 0x040042A5 RID: 17061
		[Token(Token = "0x40042A5")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI ProductSlotUI;

		// Token: 0x040042A6 RID: 17062
		[Token(Token = "0x40042A6")]
		[FieldOffset(Offset = "0x78")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x040042A7 RID: 17063
		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x040042A8 RID: 17064
		[Token(Token = "0x40042A8")]
		[FieldOffset(Offset = "0x88")]
		public Image InstructionShadow;

		// Token: 0x040042A9 RID: 17065
		[Token(Token = "0x40042A9")]
		[FieldOffset(Offset = "0x90")]
		public Button BeginButton;

		// Token: 0x040042AA RID: 17066
		[Token(Token = "0x40042AA")]
		[FieldOffset(Offset = "0x98")]
		public Animation ModeAnimation;

		// Token: 0x040042AB RID: 17067
		[Token(Token = "0x40042AB")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI ButtonLabel;
	}
}
