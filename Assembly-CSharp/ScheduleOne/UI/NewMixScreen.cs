using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Effects;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C6E RID: 3182
	[Token(Token = "0x2000C6E")]
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x00017718 File Offset: 0x00015918
		[Token(Token = "0x17000D7B")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D21")]
			[Address(RVA = "0x9E5500", Offset = "0x9E4700", VA = "0x1809E5500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D22")]
		[Address(RVA = "0x9E42E0", Offset = "0x9E34E0", VA = "0x1809E42E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D23")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D24")]
		[Address(RVA = "0x9E53A0", Offset = "0x9E45A0", VA = "0x1809E53A0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x9E4CF0", Offset = "0x9E3EF0", VA = "0x1809E4CF0")]
		public void Open(List<Effect> properties, EDrugType drugType, float productMarketValue)
		{
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x9E4450", Offset = "0x9E3650", VA = "0x1809E4450")]
		public void Close()
		{
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D27")]
		[Address(RVA = "0x9E5230", Offset = "0x9E4430", VA = "0x1809E5230")]
		public void RandomizeButtonClicked()
		{
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D28")]
		[Address(RVA = "0x9E4530", Offset = "0x9E3730", VA = "0x1809E4530")]
		public void ConfirmButtonClicked()
		{
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x9E4690", Offset = "0x9E3890", VA = "0x1809E4690")]
		public string GenerateUniqueName([Optional] Effect[] properties, EDrugType drugType = EDrugType.Marijuana)
		{
			return null;
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0x9E5270", Offset = "0x9E4470", VA = "0x1809E5270")]
		protected void RefreshNameButtons()
		{
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D2B")]
		[Address(RVA = "0x9E4A30", Offset = "0x9E3C30", VA = "0x1809E4A30")]
		public void OnNameValueChanged(string newVal)
		{
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0x9E5430", Offset = "0x9E4630", VA = "0x1809E5430")]
		public NewMixScreen()
		{
		}

		// Token: 0x04003F8E RID: 16270
		[Token(Token = "0x4003F8E")]
		public const int MAX_PROPERTIES_DISPLAYED = 5;

		// Token: 0x04003F8F RID: 16271
		[Token(Token = "0x4003F8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x04003F90 RID: 16272
		[Token(Token = "0x4003F90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RectTransform Container;

		// Token: 0x04003F91 RID: 16273
		[Token(Token = "0x4003F91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected TMP_InputField nameInputField;

		// Token: 0x04003F92 RID: 16274
		[Token(Token = "0x4003F92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject mixAlreadyExistsText;

		// Token: 0x04003F93 RID: 16275
		[Token(Token = "0x4003F93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected RectTransform editIcon;

		// Token: 0x04003F94 RID: 16276
		[Token(Token = "0x4003F94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Button randomizeNameButton;

		// Token: 0x04003F95 RID: 16277
		[Token(Token = "0x4003F95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Button confirmButton;

		// Token: 0x04003F96 RID: 16278
		[Token(Token = "0x4003F96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected TextMeshProUGUI PropertiesLabel;

		// Token: 0x04003F97 RID: 16279
		[Token(Token = "0x4003F97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected TextMeshProUGUI MarketValueLabel;

		// Token: 0x04003F98 RID: 16280
		[Token(Token = "0x4003F98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioSourceController Sound;

		// Token: 0x04003F99 RID: 16281
		[Token(Token = "0x4003F99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject attributeEntryPrefab;

		// Token: 0x04003F9A RID: 16282
		[Token(Token = "0x4003F9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("Name Library")]
		protected List<string> name1Library;

		// Token: 0x04003F9B RID: 16283
		[Token(Token = "0x4003F9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected List<string> name2Library;

		// Token: 0x04003F9C RID: 16284
		[Token(Token = "0x4003F9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Action<string> onMixNamed;
	}
}
