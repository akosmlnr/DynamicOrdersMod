using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000840 RID: 2112
	[Token(Token = "0x2000840")]
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x00010A58 File Offset: 0x0000EC58
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F5")]
		public bool IsOpen
		{
			[Token(Token = "0x6003894")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003895")]
			[Address(RVA = "0x5D63A0", Offset = "0x5D55A0", VA = "0x1805D63A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00010A70 File Offset: 0x0000EC70
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F6")]
		public bool StatePreserved
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x806D70", Offset = "0x805F70", VA = "0x180806D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x806D80", Offset = "0x805F80", VA = "0x180806D80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x804A80", Offset = "0x803C80", VA = "0x180804A80", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x806B70", Offset = "0x805D70", VA = "0x180806B70")]
		private void Update()
		{
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x8063C0", Offset = "0x8055C0", VA = "0x1808063C0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x8065C0", Offset = "0x8057C0", VA = "0x1808065C0")]
		public void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x804BE0", Offset = "0x803DE0", VA = "0x180804BE0")]
		public void Close(bool preserveState = false)
		{
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x806410", Offset = "0x805610", VA = "0x180806410")]
		private void LerpToVerticalPosition(bool open, Action callback)
		{
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x806CD0", Offset = "0x805ED0", VA = "0x180806CD0")]
		public ManagementClipboard()
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x806AB0", Offset = "0x805CB0", VA = "0x180806AB0")]
		[CompilerGenerated]
		private void <Close>g__Done|25_1()
		{
		}

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x28")]
		public bool IsEquipped;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		public const float OpenTime = 0.06f;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform ClipboardTransform;

		// Token: 0x040029A3 RID: 10659
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0x38")]
		public Camera OverlayCamera;

		// Token: 0x040029A4 RID: 10660
		[Token(Token = "0x40029A4")]
		[FieldOffset(Offset = "0x40")]
		public Light OverlayLight;

		// Token: 0x040029A5 RID: 10661
		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0x48")]
		public SelectionInfoUI SelectionInfo;

		// Token: 0x040029A6 RID: 10662
		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float ClosedOffset;

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onClipboardEquipped;

		// Token: 0x040029A8 RID: 10664
		[Token(Token = "0x40029A8")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onClipboardUnequipped;

		// Token: 0x040029A9 RID: 10665
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onOpened;

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onClosed;

		// Token: 0x040029AB RID: 10667
		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine lerpRoutine;

		// Token: 0x040029AC RID: 10668
		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0x80")]
		private List<IConfigurable> CurrentConfigurables;
	}
}
