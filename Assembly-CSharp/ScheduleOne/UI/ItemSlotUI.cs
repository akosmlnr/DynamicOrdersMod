using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06005CAD RID: 23725 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005CAE RID: 23726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6B")]
		public ItemSlot assignedSlot
		{
			[Token(Token = "0x6005CAD")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CAE")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6C")]
		public ItemUI ItemUI
		{
			[Token(Token = "0x6005CAF")]
			[Address(RVA = "0x9B5D90", Offset = "0x9B4F90", VA = "0x1809B5D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CB0")]
			[Address(RVA = "0x9DF130", Offset = "0x9DE330", VA = "0x1809DF130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x9DD9F0", Offset = "0x9DCBF0", VA = "0x1809DD9F0")]
		private void Awake()
		{
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x9DD490", Offset = "0x9DC690", VA = "0x1809DD490", Slot = "4")]
		public virtual void AssignSlot(ItemSlot s)
		{
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x9DDAF0", Offset = "0x9DCCF0", VA = "0x1809DDAF0", Slot = "5")]
		public virtual void ClearSlot()
		{
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x9DE130", Offset = "0x9DD330", VA = "0x1809DE130", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x9DE2E0", Offset = "0x9DD4E0", VA = "0x1809DE2E0")]
		public void OnDestroy()
		{
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0x9DEC00", Offset = "0x9DDE00", VA = "0x1809DEC00", Slot = "7")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0x9DE580", Offset = "0x9DD780", VA = "0x1809DE580")]
		public void SetHighlighted(bool h)
		{
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0x9DE670", Offset = "0x9DD870", VA = "0x1809DE670")]
		public void SetNormalColor(Color color)
		{
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x9DE4B0", Offset = "0x9DD6B0", VA = "0x1809DE4B0")]
		public void SetHighlightColor(Color color)
		{
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0x9DE230", Offset = "0x9DD430", VA = "0x1809DE230")]
		private void Lock()
		{
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x9DEB50", Offset = "0x9DDD50", VA = "0x1809DEB50")]
		private void Unlock()
		{
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x9DE630", Offset = "0x9DD830", VA = "0x1809DE630")]
		public void SetLockVisible(bool vis)
		{
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x9DDFF0", Offset = "0x9DD1F0", VA = "0x1809DDFF0")]
		public RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0x9DE740", Offset = "0x9DD940", VA = "0x1809DE740")]
		public void SetVisible(bool shown)
		{
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x9DE410", Offset = "0x9DD610", VA = "0x1809DE410")]
		public void OverrideDisplayedQuantity(int quantity)
		{
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x9DD120", Offset = "0x9DC320", VA = "0x1809DD120")]
		private void AssignControllerCommands()
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x9DE7E0", Offset = "0x9DD9E0", VA = "0x1809DE7E0")]
		private void UnassignControllerCommands()
		{
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x9DF030", Offset = "0x9DE230", VA = "0x1809DF030")]
		private void WrapCmdQuickMove()
		{
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0x9DEEB0", Offset = "0x9DE0B0", VA = "0x1809DEEB0")]
		private void WrapCmdGrabAll()
		{
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0x9DEF30", Offset = "0x9DE130", VA = "0x1809DEF30")]
		private void WrapCmdQtyAdd()
		{
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0x9DEFB0", Offset = "0x9DE1B0", VA = "0x1809DEFB0")]
		private void WrapCmdQtySubtract()
		{
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0x9DF0B0", Offset = "0x9DE2B0", VA = "0x1809DF0B0")]
		private void WrapCmdToggleTooltip()
		{
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0x9DEE30", Offset = "0x9DE030", VA = "0x1809DEE30")]
		private void WrapCmdDiscardItem()
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x9DDF40", Offset = "0x9DD140", VA = "0x1809DDF40")]
		public void ControllerSelect(bool isSelected)
		{
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x9DE3E0", Offset = "0x9DD5E0", VA = "0x1809DE3E0")]
		private void OnItemSlotDataChanged()
		{
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x9DDA00", Offset = "0x9DCC00", VA = "0x1809DDA00")]
		private void CheckSlotBop()
		{
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x9D9100", Offset = "0x9D8300", VA = "0x1809D9100")]
		public ItemSlotUI()
		{
		}

		// Token: 0x04003F18 RID: 16152
		[Token(Token = "0x4003F18")]
		[FieldOffset(Offset = "0x20")]
		public Color32 normalColor;

		// Token: 0x04003F19 RID: 16153
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x24")]
		public Color32 highlightColor;

		// Token: 0x04003F1B RID: 16155
		[Token(Token = "0x4003F1B")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool IsBeingDragged;

		// Token: 0x04003F1C RID: 16156
		[Token(Token = "0x4003F1C")]
		[FieldOffset(Offset = "0x31")]
		[Header("Settings")]
		[SerializeField]
		private bool _playBopAnimation;

		// Token: 0x04003F1D RID: 16157
		[Token(Token = "0x4003F1D")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04003F1E RID: 16158
		[Token(Token = "0x4003F1E")]
		[FieldOffset(Offset = "0x40")]
		public Image Background;

		// Token: 0x04003F1F RID: 16159
		[Token(Token = "0x4003F1F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LockContainer;

		// Token: 0x04003F20 RID: 16160
		[Token(Token = "0x4003F20")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform ItemContainer;

		// Token: 0x04003F21 RID: 16161
		[Token(Token = "0x4003F21")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotFilterButton FilterButton;

		// Token: 0x04003F22 RID: 16162
		[Token(Token = "0x4003F22")]
		[FieldOffset(Offset = "0x60")]
		public Animation BopAnimation;

		// Token: 0x04003F23 RID: 16163
		[Token(Token = "0x4003F23")]
		[FieldOffset(Offset = "0x68")]
		[Header("Controller Support")]
		public UITrigger CmdQuickMove;

		// Token: 0x04003F24 RID: 16164
		[Token(Token = "0x4003F24")]
		[FieldOffset(Offset = "0x70")]
		public UITrigger CmdGrabAll;

		// Token: 0x04003F25 RID: 16165
		[Token(Token = "0x4003F25")]
		[FieldOffset(Offset = "0x78")]
		public UITrigger CmdQtyAdd;

		// Token: 0x04003F26 RID: 16166
		[Token(Token = "0x4003F26")]
		[FieldOffset(Offset = "0x80")]
		public UITrigger CmdQtySubtract;

		// Token: 0x04003F27 RID: 16167
		[Token(Token = "0x4003F27")]
		[FieldOffset(Offset = "0x88")]
		public UITrigger CmdToggleTooltip;

		// Token: 0x04003F28 RID: 16168
		[Token(Token = "0x4003F28")]
		[FieldOffset(Offset = "0x90")]
		public UITrigger CmdDiscardItem;

		// Token: 0x04003F2A RID: 16170
		[Token(Token = "0x4003F2A")]
		[FieldOffset(Offset = "0xA0")]
		private int _lastQuantity;

		// Token: 0x04003F2B RID: 16171
		[Token(Token = "0x4003F2B")]
		[FieldOffset(Offset = "0xA4")]
		private bool _slotBopQueued;
	}
}
