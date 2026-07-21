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
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class BrickPressCanvas : Singleton<BrickPressCanvas>
	{
		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06005FD0 RID: 24528 RVA: 0x00017F28 File Offset: 0x00016128
		// (set) Token: 0x06005FD1 RID: 24529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DDE")]
		public bool isOpen
		{
			[Token(Token = "0x6005FD0")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FD1")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005FD3 RID: 24531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DDF")]
		public BrickPress Press
		{
			[Token(Token = "0x6005FD2")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FD3")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0xA20880", Offset = "0xA1FA80", VA = "0x180A20880", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0xA21320", Offset = "0xA20520", VA = "0x180A21320", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0xA21410", Offset = "0xA20610", VA = "0x180A21410", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0xA20A70", Offset = "0xA1FC70", VA = "0x180A20A70")]
		public void SetIsOpen(BrickPress press, bool open, bool removeUI = true)
		{
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0xA20940", Offset = "0xA1FB40", VA = "0x180A20940")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0xA216B0", Offset = "0xA208B0", VA = "0x180A216B0")]
		public BrickPressCanvas()
		{
		}

		// Token: 0x04004225 RID: 16933
		[Token(Token = "0x4004225")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004226 RID: 16934
		[Token(Token = "0x4004226")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Container;

		// Token: 0x04004227 RID: 16935
		[Token(Token = "0x4004227")]
		[FieldOffset(Offset = "0x48")]
		public UIScreen UIScreen;

		// Token: 0x04004228 RID: 16936
		[Token(Token = "0x4004228")]
		[FieldOffset(Offset = "0x50")]
		public ItemSlotUI[] ProductSlotUIs;

		// Token: 0x04004229 RID: 16937
		[Token(Token = "0x4004229")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x0400422A RID: 16938
		[Token(Token = "0x400422A")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x0400422B RID: 16939
		[Token(Token = "0x400422B")]
		[FieldOffset(Offset = "0x68")]
		public Button BeginButton;
	}
}
