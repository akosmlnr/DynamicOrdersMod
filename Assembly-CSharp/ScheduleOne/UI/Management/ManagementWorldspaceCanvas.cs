using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.Property;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D91 RID: 3473
	[Token(Token = "0x2000D91")]
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x00018AC8 File Offset: 0x00016CC8
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E51")]
		public bool IsOpen
		{
			[Token(Token = "0x600642F")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006430")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E52")]
		public Property CurrentProperty
		{
			[Token(Token = "0x6006431")]
			[Address(RVA = "0xA62C30", Offset = "0xA61E30", VA = "0x180A62C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006432")]
		[Address(RVA = "0xA61240", Offset = "0xA60440", VA = "0x180A61240")]
		public void Open()
		{
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006433")]
		[Address(RVA = "0xA60650", Offset = "0xA5F850", VA = "0x180A60650")]
		public void Close(bool preserveSelection = false)
		{
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006434")]
		[Address(RVA = "0xA62890", Offset = "0xA61A90", VA = "0x180A62890")]
		private void Update()
		{
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006435")]
		[Address(RVA = "0xA617A0", Offset = "0xA609A0", VA = "0x180A617A0")]
		private void UpdateInputPrompt()
		{
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006436")]
		[Address(RVA = "0xA62210", Offset = "0xA61410", VA = "0x180A62210")]
		private void UpdateUIs()
		{
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006437")]
		[Address(RVA = "0xA60D80", Offset = "0xA5FF80", VA = "0x180A60D80")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006438")]
		[Address(RVA = "0xA61A40", Offset = "0xA60C40", VA = "0x180A61A40")]
		private void UpdateSelection()
		{
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006439")]
		[Address(RVA = "0xA60460", Offset = "0xA5F660", VA = "0x180A60460")]
		private void AddToSelection(IConfigurable config)
		{
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643A")]
		[Address(RVA = "0xA61470", Offset = "0xA60670", VA = "0x180A61470")]
		private void RemoveFromSelection(IConfigurable config)
		{
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643B")]
		[Address(RVA = "0xA605A0", Offset = "0xA5F7A0", VA = "0x180A605A0")]
		private void ClearSelection()
		{
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643C")]
		[Address(RVA = "0xA615D0", Offset = "0xA607D0", VA = "0x180A615D0")]
		private void RemoveNullConfigurables()
		{
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600643D")]
		[Address(RVA = "0xA60C80", Offset = "0xA5FE80", VA = "0x180A60C80")]
		private IConfigurable GetHoveredConfigurable()
		{
			return null;
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600643E")]
		[Address(RVA = "0xA60790", Offset = "0xA5F990", VA = "0x180A60790")]
		private List<IConfigurable> GetConfigurablesToShow()
		{
			return null;
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643F")]
		[Address(RVA = "0xA61730", Offset = "0xA60930", VA = "0x180A61730")]
		public void ShowCrosshairPrompt(string message)
		{
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006440")]
		[Address(RVA = "0x9D9D00", Offset = "0x9D8F00", VA = "0x1809D9D00")]
		public void HideCrosshairPrompt()
		{
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006441")]
		[Address(RVA = "0xA62B60", Offset = "0xA61D60", VA = "0x180A62B60")]
		public ManagementWorldspaceCanvas()
		{
		}

		// Token: 0x04004640 RID: 17984
		[Token(Token = "0x4004640")]
		public const float VISIBILITY_RANGE = 6f;

		// Token: 0x04004641 RID: 17985
		[Token(Token = "0x4004641")]
		public const float PROPERTY_CANVAS_RANGE = 50f;

		// Token: 0x04004643 RID: 17987
		[Token(Token = "0x4004643")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004644 RID: 17988
		[Token(Token = "0x4004644")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve ScaleCurve;

		// Token: 0x04004645 RID: 17989
		[Token(Token = "0x4004645")]
		[FieldOffset(Offset = "0x40")]
		public TransitLineVisuals TransitRouteVisualsPrefab;

		// Token: 0x04004646 RID: 17990
		[Token(Token = "0x4004646")]
		[FieldOffset(Offset = "0x48")]
		public InputPrompt CrosshairPrompt;

		// Token: 0x04004647 RID: 17991
		[Token(Token = "0x4004647")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public LayerMask ObjectSelectionLayerMask;

		// Token: 0x04004648 RID: 17992
		[Token(Token = "0x4004648")]
		[FieldOffset(Offset = "0x54")]
		public Color HoveredOutlineColor;

		// Token: 0x04004649 RID: 17993
		[Token(Token = "0x4004649")]
		[FieldOffset(Offset = "0x64")]
		public Color SelectedOutlineColor;

		// Token: 0x0400464A RID: 17994
		[Token(Token = "0x400464A")]
		[FieldOffset(Offset = "0x78")]
		private List<IConfigurable> ShownConfigurables;

		// Token: 0x0400464B RID: 17995
		[Token(Token = "0x400464B")]
		[FieldOffset(Offset = "0x80")]
		public IConfigurable HoveredConfigurable;

		// Token: 0x0400464C RID: 17996
		[Token(Token = "0x400464C")]
		[FieldOffset(Offset = "0x88")]
		private IConfigurable OutlinedConfigurable;

		// Token: 0x0400464D RID: 17997
		[Token(Token = "0x400464D")]
		[FieldOffset(Offset = "0x90")]
		public List<IConfigurable> SelectedConfigurables;
	}
}
