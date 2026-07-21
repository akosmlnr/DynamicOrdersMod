using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Misc;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	public class ManagementClipboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x060038A9 RID: 14505 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x805B40", Offset = "0x804D40", VA = "0x180805B40")]
		public static bool ResetHeatmapToggle()
		{
			return default(bool);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x170008F9")]
		private static bool _canToggleHeatmap
		{
			[Token(Token = "0x60038AA")]
			[Address(RVA = "0x8063B0", Offset = "0x8055B0", VA = "0x1808063B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x8053E0", Offset = "0x8045E0", VA = "0x1808053E0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x805B80", Offset = "0x804D80", VA = "0x180805B80")]
		private void ShowInputPrompts()
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x805960", Offset = "0x804B60", VA = "0x180805960")]
		private void HideInputPrompts()
		{
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x805C30", Offset = "0x804E30", VA = "0x180805C30", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x806150", Offset = "0x805350", VA = "0x180806150", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x8050E0", Offset = "0x8042E0", VA = "0x1808050E0")]
		private bool CanToggleClipboard()
		{
			return default(bool);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x805E80", Offset = "0x805080", VA = "0x180805E80")]
		private void UpdateHeatmap()
		{
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x8052B0", Offset = "0x8044B0", VA = "0x1808052B0")]
		private void ClearPropertyWithHeatmapShown()
		{
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x805780", Offset = "0x804980", VA = "0x180805780")]
		private void FullscreenEnter()
		{
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x805830", Offset = "0x804A30", VA = "0x180805830")]
		private void FullscreenExit()
		{
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x805AC0", Offset = "0x804CC0", VA = "0x180805AC0")]
		public void OverrideClipboardText(string overriddenText)
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x805380", Offset = "0x804580", VA = "0x180805380")]
		public void EndOverride()
		{
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x5944E0", Offset = "0x5936E0", VA = "0x1805944E0")]
		public ManagementClipboard_Equippable()
		{
		}

		// Token: 0x040029B5 RID: 10677
		[Token(Token = "0x40029B5")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Transform Clipboard;

		// Token: 0x040029B6 RID: 10678
		[Token(Token = "0x40029B6")]
		[FieldOffset(Offset = "0x68")]
		public Transform LoweredPosition;

		// Token: 0x040029B7 RID: 10679
		[Token(Token = "0x40029B7")]
		[FieldOffset(Offset = "0x70")]
		public Transform RaisedPosition;

		// Token: 0x040029B8 RID: 10680
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0x78")]
		public ToggleableLight Light;

		// Token: 0x040029B9 RID: 10681
		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0x80")]
		public SelectionInfoUI SelectionInfo;

		// Token: 0x040029BA RID: 10682
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI OverrideText;

		// Token: 0x040029BB RID: 10683
		[Token(Token = "0x40029BB")]
		[FieldOffset(Offset = "0x0")]
		private static bool _heatmapToggledOn;

		// Token: 0x040029BC RID: 10684
		[Token(Token = "0x40029BC")]
		[FieldOffset(Offset = "0x90")]
		private Property _propertyWithHeatmapShown;
	}
}
