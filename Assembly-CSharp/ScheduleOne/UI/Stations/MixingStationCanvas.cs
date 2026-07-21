using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Effects;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Product;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x2000CE4")]
	public class MixingStationCanvas : Singleton<MixingStationCanvas>
	{
		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06006025 RID: 24613 RVA: 0x00018078 File Offset: 0x00016278
		// (set) Token: 0x06006026 RID: 24614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEA")]
		public bool isOpen
		{
			[Token(Token = "0x6006025")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006026")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06006027 RID: 24615 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006028 RID: 24616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEB")]
		public MixingStation MixingStation
		{
			[Token(Token = "0x6006027")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006028")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006029")]
		[Address(RVA = "0xA29950", Offset = "0xA28B50", VA = "0x180A29950", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602A")]
		[Address(RVA = "0xA2C0A0", Offset = "0xA2B2A0", VA = "0x180A2C0A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602B")]
		[Address(RVA = "0xA2A410", Offset = "0xA29610", VA = "0x180A2A410")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602C")]
		[Address(RVA = "0xA2D030", Offset = "0xA2C230", VA = "0x180A2D030", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void UpdateUI()
		{
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602E")]
		[Address(RVA = "0xA2C5C0", Offset = "0xA2B7C0", VA = "0x180A2C5C0")]
		private void UpdateInput()
		{
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600602F")]
		[Address(RVA = "0xA2AFF0", Offset = "0xA2A1F0", VA = "0x180A2AFF0")]
		public void Open(MixingStation station)
		{
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006030")]
		[Address(RVA = "0xA29E20", Offset = "0xA29020", VA = "0x180A29E20")]
		public void Close(bool enablePlayerControl = true)
		{
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006031")]
		[Address(RVA = "0xA2AB20", Offset = "0xA29D20", VA = "0x180A2AB20")]
		private void MixingDone()
		{
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006032")]
		[Address(RVA = "0xA2C220", Offset = "0xA2B420", VA = "0x180A2C220")]
		private void StationContentsChanged()
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006033")]
		[Address(RVA = "0xA2C3C0", Offset = "0xA2B5C0", VA = "0x180A2C3C0")]
		private void UpdateDisplayMode()
		{
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006034")]
		[Address(RVA = "0xA2C5E0", Offset = "0xA2B7E0", VA = "0x180A2C5E0")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006035")]
		[Address(RVA = "0xA2C730", Offset = "0xA2B930", VA = "0x180A2C730")]
		private void UpdatePreview()
		{
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006036")]
		[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
		private string GetPropertyListString(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006037")]
		[Address(RVA = "0xA2A640", Offset = "0xA29840", VA = "0x180A2A640")]
		private string GetPropertyString(Effect property)
		{
			return null;
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006038")]
		[Address(RVA = "0xA2A4C0", Offset = "0xA296C0", VA = "0x180A2A4C0")]
		private List<Effect> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			return null;
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00018090 File Offset: 0x00016290
		[Token(Token = "0x6006039")]
		[Address(RVA = "0xA2A770", Offset = "0xA29970", VA = "0x180A2A770")]
		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			return default(bool);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600603A")]
		[Address(RVA = "0xA2C2F0", Offset = "0xA2B4F0", VA = "0x180A2C2F0")]
		private void UpdateBeginButton()
		{
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600603B")]
		[Address(RVA = "0xA29A10", Offset = "0xA28C10", VA = "0x180A29A10")]
		public void BeginButtonPressed()
		{
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600603C")]
		[Address(RVA = "0xA2BF40", Offset = "0xA2B140", VA = "0x180A2BF40")]
		public void StartMixOperation(MixOperation mixOperation)
		{
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600603D")]
		[Address(RVA = "0xA2A960", Offset = "0xA29B60", VA = "0x180A2A960")]
		private void MixNamed(string mixName)
		{
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600603E")]
		[Address(RVA = "0xA2D0F0", Offset = "0xA2C2F0", VA = "0x180A2D0F0")]
		public MixingStationCanvas()
		{
		}

		// Token: 0x0400427B RID: 17019
		[Token(Token = "0x400427B")]
		[FieldOffset(Offset = "0x38")]
		[Header("Prefabs")]
		public StationRecipeEntry RecipeEntryPrefab;

		// Token: 0x0400427C RID: 17020
		[Token(Token = "0x400427C")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400427D RID: 17021
		[Token(Token = "0x400427D")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform Container;

		// Token: 0x0400427E RID: 17022
		[Token(Token = "0x400427E")]
		[FieldOffset(Offset = "0x50")]
		public UIScreen UIScreen;

		// Token: 0x0400427F RID: 17023
		[Token(Token = "0x400427F")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI ProductSlotUI;

		// Token: 0x04004280 RID: 17024
		[Token(Token = "0x4004280")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI ProductPropertiesLabel;

		// Token: 0x04004281 RID: 17025
		[Token(Token = "0x4004281")]
		[FieldOffset(Offset = "0x68")]
		public ItemSlotUI IngredientSlotUI;

		// Token: 0x04004282 RID: 17026
		[Token(Token = "0x4004282")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI IngredientProblemLabel;

		// Token: 0x04004283 RID: 17027
		[Token(Token = "0x4004283")]
		[FieldOffset(Offset = "0x78")]
		public ItemSlotUI PreviewSlotUI;

		// Token: 0x04004284 RID: 17028
		[Token(Token = "0x4004284")]
		[FieldOffset(Offset = "0x80")]
		public Image PreviewIcon;

		// Token: 0x04004285 RID: 17029
		[Token(Token = "0x4004285")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI PreviewLabel;

		// Token: 0x04004286 RID: 17030
		[Token(Token = "0x4004286")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform UnknownOutputIcon;

		// Token: 0x04004287 RID: 17031
		[Token(Token = "0x4004287")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI PreviewPropertiesLabel;

		// Token: 0x04004288 RID: 17032
		[Token(Token = "0x4004288")]
		[FieldOffset(Offset = "0xA0")]
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04004289 RID: 17033
		[Token(Token = "0x4004289")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x0400428A RID: 17034
		[Token(Token = "0x400428A")]
		[FieldOffset(Offset = "0xB0")]
		public RectTransform TitleContainer;

		// Token: 0x0400428B RID: 17035
		[Token(Token = "0x400428B")]
		[FieldOffset(Offset = "0xB8")]
		public RectTransform MainContainer;

		// Token: 0x0400428C RID: 17036
		[Token(Token = "0x400428C")]
		[FieldOffset(Offset = "0xC0")]
		public Button BeginButton;

		// Token: 0x0400428D RID: 17037
		[Token(Token = "0x400428D")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform ProductHint;

		// Token: 0x0400428E RID: 17038
		[Token(Token = "0x400428E")]
		[FieldOffset(Offset = "0xD0")]
		public RectTransform MixerHint;

		// Token: 0x0400428F RID: 17039
		[Token(Token = "0x400428F")]
		[FieldOffset(Offset = "0xD8")]
		private StationRecipe selectedRecipe;
	}
}
