using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts.Cash;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000C62")]
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06005CCC RID: 23756 RVA: 0x00017610 File Offset: 0x00015810
		[Token(Token = "0x17000D6D")]
		protected int maxLaunderAmount
		{
			[Token(Token = "0x6005CCC")]
			[Address(RVA = "0x9E25B0", Offset = "0x9E17B0", VA = "0x1809E25B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06005CCD RID: 23757 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005CCE RID: 23758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6E")]
		public Business business
		{
			[Token(Token = "0x6005CCD")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CCE")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x00017628 File Offset: 0x00015828
		[Token(Token = "0x17000D6F")]
		public bool isOpen
		{
			[Token(Token = "0x6005CCF")]
			[Address(RVA = "0x9E2510", Offset = "0x9E1710", VA = "0x1809E2510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x9DFCA0", Offset = "0x9DEEA0", VA = "0x1809DFCA0")]
		public void Initialize(Business bus)
		{
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0x9E06A0", Offset = "0x9DF8A0", VA = "0x1809E06A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0x9E0610", Offset = "0x9DF810", VA = "0x1809E0610", Slot = "4")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0x9DFB30", Offset = "0x9DED30", VA = "0x1809DFB30")]
		protected void Exit(ExitAction exit)
		{
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0x9E1CC0", Offset = "0x9E0EC0", VA = "0x1809E1CC0")]
		protected void UpdateTimeline()
		{
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0x9E1800", Offset = "0x9E0A00", VA = "0x1809E1800")]
		protected void UpdateCurrentTotal()
		{
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x9DF8A0", Offset = "0x9DEAA0", VA = "0x1809DF8A0")]
		private void CreateEntry(LaunderingOperation op)
		{
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x9E13F0", Offset = "0x9E05F0", VA = "0x1809E13F0")]
		private void RemoveEntry(LaunderingOperation op)
		{
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD8")]
		[Address(RVA = "0x9E1860", Offset = "0x9E0A60", VA = "0x1809E1860")]
		private void UpdateEntryTimes()
		{
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0x9E1700", Offset = "0x9E0900", VA = "0x1809E1700")]
		private void UpdateCashStacks(LaunderingOperation op)
		{
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x9E11A0", Offset = "0x9E03A0", VA = "0x1809E11A0")]
		private void RefreshLaunderButton()
		{
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x9E0AA0", Offset = "0x9DFCA0", VA = "0x1809E0AA0")]
		public void OpenAmountSelector()
		{
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x9DF210", Offset = "0x9DE410", VA = "0x1809DF210")]
		public void CloseAmountSelector()
		{
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0x9DF640", Offset = "0x9DE840", VA = "0x1809DF640")]
		public void ConfirmAmount()
		{
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDE")]
		[Address(RVA = "0x9E1570", Offset = "0x9E0770", VA = "0x1809E1570")]
		public void SliderValueChanged()
		{
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x9E0510", Offset = "0x9DF710", VA = "0x1809E0510")]
		public void InputValueChanged()
		{
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x9DF150", Offset = "0x9DE350", VA = "0x1809DF150")]
		public void ChangeSelectorValue(int amount)
		{
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x9DFBE0", Offset = "0x9DEDE0", VA = "0x1809DFBE0")]
		public void Hovered()
		{
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x9E05C0", Offset = "0x9DF7C0", VA = "0x1809E05C0")]
		public void Interacted()
		{
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x9E0CB0", Offset = "0x9DFEB0", VA = "0x1809E0CB0", Slot = "5")]
		public virtual void Open()
		{
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x9DF2C0", Offset = "0x9DE4C0", VA = "0x1809DF2C0", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x9E2400", Offset = "0x9E1600", VA = "0x1809E2400")]
		public LaunderingInterface()
		{
		}

		// Token: 0x04003F2C RID: 16172
		[Token(Token = "0x4003F2C")]
		protected const float fovOverride = 65f;

		// Token: 0x04003F2D RID: 16173
		[Token(Token = "0x4003F2D")]
		protected const float lerpTime = 0.15f;

		// Token: 0x04003F2E RID: 16174
		[Token(Token = "0x4003F2E")]
		protected const int minLaunderAmount = 10;

		// Token: 0x04003F30 RID: 16176
		[Token(Token = "0x4003F30")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected Transform cameraPosition;

		// Token: 0x04003F31 RID: 16177
		[Token(Token = "0x4003F31")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003F32 RID: 16178
		[Token(Token = "0x4003F32")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Button launderButton;

		// Token: 0x04003F33 RID: 16179
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject amountSelectorScreen;

		// Token: 0x04003F34 RID: 16180
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Slider amountSlider;

		// Token: 0x04003F35 RID: 16181
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected TMP_InputField amountInputField;

		// Token: 0x04003F36 RID: 16182
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected RectTransform notchContainer;

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TextMeshProUGUI currentTotalAmountLabel;

		// Token: 0x04003F38 RID: 16184
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected TextMeshProUGUI launderCapacityLabel;

		// Token: 0x04003F39 RID: 16185
		[Token(Token = "0x4003F39")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected TextMeshProUGUI insufficientCashLabel;

		// Token: 0x04003F3A RID: 16186
		[Token(Token = "0x4003F3A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected RectTransform entryContainer;

		// Token: 0x04003F3B RID: 16187
		[Token(Token = "0x4003F3B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected RectTransform noEntries;

		// Token: 0x04003F3C RID: 16188
		[Token(Token = "0x4003F3C")]
		[FieldOffset(Offset = "0x88")]
		public CashStackVisuals[] CashStacks;

		// Token: 0x04003F3D RID: 16189
		[Token(Token = "0x4003F3D")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject timelineNotchPrefab;

		// Token: 0x04003F3E RID: 16190
		[Token(Token = "0x4003F3E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected GameObject entryPrefab;

		// Token: 0x04003F3F RID: 16191
		[Token(Token = "0x4003F3F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Header("UI references")]
		protected Canvas canvas;

		// Token: 0x04003F40 RID: 16192
		[Token(Token = "0x4003F40")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected ScrollRect scrollRect;

		// Token: 0x04003F41 RID: 16193
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected UIScreen UIScreen;

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected UIPanel mainPanel;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected UIScreen selectorScreen;

		// Token: 0x04003F44 RID: 16196
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected UIPanel selectorPanel;

		// Token: 0x04003F45 RID: 16197
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0xD0")]
		private int selectedAmountToLaunder;

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<LaunderingOperation, RectTransform> operationToNotch;

		// Token: 0x04003F47 RID: 16199
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0xE0")]
		private List<RectTransform> notches;

		// Token: 0x04003F48 RID: 16200
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0xE8")]
		private bool ignoreSliderChange;

		// Token: 0x04003F49 RID: 16201
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<LaunderingOperation, RectTransform> operationToEntry;
	}
}
