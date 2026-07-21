using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC9 RID: 3273
	[Token(Token = "0x2000CC9")]
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x00017DD8 File Offset: 0x00015FD8
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD2")]
		public bool IsOpen
		{
			[Token(Token = "0x6005F6E")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005F6F")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0xA1DF50", Offset = "0xA1D150", VA = "0x180A1DF50", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0xA1E5F0", Offset = "0xA1D7F0", VA = "0x180A1E5F0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0xA1E2E0", Offset = "0xA1D4E0", VA = "0x180A1E2E0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0xA1EDB0", Offset = "0xA1DFB0", VA = "0x180A1EDB0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0xA1E340", Offset = "0xA1D540", VA = "0x180A1E340")]
		public void Open(LandVehicle vehicle)
		{
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0xA1E000", Offset = "0xA1D200", VA = "0x180A1E000")]
		public void Close()
		{
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0xA1E0F0", Offset = "0xA1D2F0", VA = "0x180A1E0F0")]
		public void ColorClicked(EVehicleColor col)
		{
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0xA1ECB0", Offset = "0xA1DEB0", VA = "0x180A1ECB0")]
		private void UpdateConfirmButton()
		{
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D6E0", VA = "0x180A1E4E0")]
		private void RefreshSelectionIndicator()
		{
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0xA1E140", Offset = "0xA1D340", VA = "0x180A1E140")]
		public void ConfirmButtonClicked()
		{
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0xA1EE00", Offset = "0xA1E000", VA = "0x180A1EE00")]
		public VehicleModMenu()
		{
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0xA1EC40", Offset = "0xA1DE40", VA = "0x180A1EC40")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Close|24_0()
		{
			return null;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0xA1EBD0", Offset = "0xA1DDD0", VA = "0x180A1EBD0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|25_0()
		{
			return null;
		}

		// Token: 0x040041BF RID: 16831
		[Token(Token = "0x40041BF")]
		[FieldOffset(Offset = "0x0")]
		public static float repaintCost;

		// Token: 0x040041C1 RID: 16833
		[Token(Token = "0x40041C1")]
		[FieldOffset(Offset = "0x30")]
		[Header("UI References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x040041C2 RID: 16834
		[Token(Token = "0x40041C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x040041C3 RID: 16835
		[Token(Token = "0x40041C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected RectTransform tempIndicator;

		// Token: 0x040041C4 RID: 16836
		[Token(Token = "0x40041C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RectTransform permIndicator;

		// Token: 0x040041C5 RID: 16837
		[Token(Token = "0x40041C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Button confirmButton_Online;

		// Token: 0x040041C6 RID: 16838
		[Token(Token = "0x40041C6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected TextMeshProUGUI confirmText_Online;

		// Token: 0x040041C7 RID: 16839
		[Token(Token = "0x40041C7")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x040041C8 RID: 16840
		[Token(Token = "0x40041C8")]
		[FieldOffset(Offset = "0x68")]
		public Transform VehiclePosition;

		// Token: 0x040041C9 RID: 16841
		[Token(Token = "0x40041C9")]
		[FieldOffset(Offset = "0x70")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x040041CA RID: 16842
		[Token(Token = "0x40041CA")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onPaintPurchased;

		// Token: 0x040041CB RID: 16843
		[Token(Token = "0x40041CB")]
		[FieldOffset(Offset = "0x80")]
		protected LandVehicle currentVehicle;

		// Token: 0x040041CC RID: 16844
		[Token(Token = "0x40041CC")]
		[FieldOffset(Offset = "0x88")]
		protected List<RectTransform> colorButtons;

		// Token: 0x040041CD RID: 16845
		[Token(Token = "0x40041CD")]
		[FieldOffset(Offset = "0x90")]
		protected Dictionary<EVehicleColor, RectTransform> colorToButton;

		// Token: 0x040041CE RID: 16846
		[Token(Token = "0x40041CE")]
		[FieldOffset(Offset = "0x98")]
		protected EVehicleColor selectedColor;

		// Token: 0x040041CF RID: 16847
		[Token(Token = "0x40041CF")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine openCloseRoutine;
	}
}
