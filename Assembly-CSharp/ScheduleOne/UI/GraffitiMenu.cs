using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Graffiti;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C4F RID: 3151
	[Token(Token = "0x2000C4F")]
	public class GraffitiMenu : Singleton<GraffitiMenu>
	{
		// Token: 0x06005C46 RID: 23622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x9D9770", Offset = "0x9D8970", VA = "0x1809D9770", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C47")]
		[Address(RVA = "0x9D9EB0", Offset = "0x9D90B0", VA = "0x1809D9EB0")]
		public void Open()
		{
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x9CE8F0", Offset = "0x9CDAF0", VA = "0x1809CE8F0")]
		public void Close()
		{
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x9DA680", Offset = "0x9D9880", VA = "0x1809DA680")]
		private void Update()
		{
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x9DA2B0", Offset = "0x9D94B0", VA = "0x1809DA2B0")]
		public void ShowConfirmPanel()
		{
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x9D9FB0", Offset = "0x9D91B0", VA = "0x1809D9FB0")]
		private void SelectColor(ESprayColor color)
		{
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0x9DA740", Offset = "0x9D9940", VA = "0x1809DA740")]
		private void WeightButtonClicked(int buttonIndex)
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0x9DA310", Offset = "0x9D9510", VA = "0x1809DA310")]
		public void UpdateRemainingPaintIndicator(float remainingPaint)
		{
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0x9D9E50", Offset = "0x9D9050", VA = "0x1809D9E50")]
		private void ClearClicked()
		{
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0x9DA2E0", Offset = "0x9D94E0", VA = "0x1809DA2E0")]
		private void UndoClicked()
		{
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C50")]
		[Address(RVA = "0x9D9E80", Offset = "0x9D9080", VA = "0x1809D9E80")]
		private void Done()
		{
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x9D9D00", Offset = "0x9D8F00", VA = "0x1809D9D00")]
		private void CancelClicked()
		{
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x9DA190", Offset = "0x9D9390", VA = "0x1809DA190")]
		public void SetActiveSurface(SpraySurface surface)
		{
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x9D9D30", Offset = "0x9D8F30", VA = "0x1809D9D30")]
		public void ClearActiveSurface()
		{
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C54")]
		[Address(RVA = "0x9DA5E0", Offset = "0x9D97E0", VA = "0x1809DA5E0")]
		private void UpdateUndoInteraction()
		{
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x9DA850", Offset = "0x9D9A50", VA = "0x1809DA850")]
		public GraffitiMenu()
		{
		}

		// Token: 0x04003E8E RID: 16014
		[Token(Token = "0x4003E8E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003E8F RID: 16015
		[Token(Token = "0x4003E8F")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform ColorButtonContainer;

		// Token: 0x04003E90 RID: 16016
		[Token(Token = "0x4003E90")]
		[FieldOffset(Offset = "0x38")]
		public Button ClearButton;

		// Token: 0x04003E91 RID: 16017
		[Token(Token = "0x4003E91")]
		[FieldOffset(Offset = "0x40")]
		public Button DoneButton;

		// Token: 0x04003E92 RID: 16018
		[Token(Token = "0x4003E92")]
		[FieldOffset(Offset = "0x48")]
		public Transform ConfirmPanel;

		// Token: 0x04003E93 RID: 16019
		[Token(Token = "0x4003E93")]
		[FieldOffset(Offset = "0x50")]
		public Button ConfirmButton;

		// Token: 0x04003E94 RID: 16020
		[Token(Token = "0x4003E94")]
		[FieldOffset(Offset = "0x58")]
		public Button CancelButton;

		// Token: 0x04003E95 RID: 16021
		[Token(Token = "0x4003E95")]
		[FieldOffset(Offset = "0x60")]
		public Button UndoButton;

		// Token: 0x04003E96 RID: 16022
		[Token(Token = "0x4003E96")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform RemainigPaintContainer;

		// Token: 0x04003E97 RID: 16023
		[Token(Token = "0x4003E97")]
		[FieldOffset(Offset = "0x70")]
		public Slider RemainingPaintSlider;

		// Token: 0x04003E98 RID: 16024
		[Token(Token = "0x4003E98")]
		[FieldOffset(Offset = "0x78")]
		public Image[] RemainingPaintImages;

		// Token: 0x04003E99 RID: 16025
		[Token(Token = "0x4003E99")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI RemainingPaintLabel;

		// Token: 0x04003E9A RID: 16026
		[Token(Token = "0x4003E9A")]
		[FieldOffset(Offset = "0x88")]
		public Button[] WeightButtons;

		// Token: 0x04003E9B RID: 16027
		[Token(Token = "0x4003E9B")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefabs")]
		public GameObject ColorButtonPrefab;

		// Token: 0x04003E9C RID: 16028
		[Token(Token = "0x4003E9C")]
		[FieldOffset(Offset = "0x98")]
		public Action<ESprayColor> onColorSelected;

		// Token: 0x04003E9D RID: 16029
		[Token(Token = "0x4003E9D")]
		[FieldOffset(Offset = "0xA0")]
		public Action<byte> onWeightSelected;

		// Token: 0x04003E9E RID: 16030
		[Token(Token = "0x4003E9E")]
		[FieldOffset(Offset = "0xA8")]
		public Action onClearClicked;

		// Token: 0x04003E9F RID: 16031
		[Token(Token = "0x4003E9F")]
		[FieldOffset(Offset = "0xB0")]
		public Action onDone;

		// Token: 0x04003EA0 RID: 16032
		[Token(Token = "0x4003EA0")]
		[FieldOffset(Offset = "0xB8")]
		public Action onUndoClicked;

		// Token: 0x04003EA1 RID: 16033
		[Token(Token = "0x4003EA1")]
		[FieldOffset(Offset = "0xC0")]
		private List<Button> colorButtons;

		// Token: 0x04003EA2 RID: 16034
		[Token(Token = "0x4003EA2")]
		[FieldOffset(Offset = "0xC8")]
		private SpraySurface activeSurface;
	}
}
