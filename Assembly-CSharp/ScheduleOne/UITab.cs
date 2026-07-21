using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public class UITab : UIPanel, INonNavigablePanel
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0xAE0610", Offset = "0xADF810", VA = "0x180AE0610", Slot = "10")]
		protected override void EarlyUpdate()
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0xAE07C0", Offset = "0xADF9C0", VA = "0x180AE07C0")]
		private float GetCycleTabInputValue()
		{
			return 0f;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0xAE04A0", Offset = "0xADF6A0", VA = "0x180AE04A0")]
		private void CycleTab(float navDir, float delay, float speed)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0xAE0F30", Offset = "0xAE0130", VA = "0x180AE0F30")]
		private bool Navigate(float navDir)
		{
			return default(bool);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0xAE0A10", Offset = "0xADFC10", VA = "0x180AE0A10")]
		private bool Navigate2(float navDir)
		{
			return default(bool);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0xAE08D0", Offset = "0xADFAD0", VA = "0x180AE08D0", Slot = "11")]
		protected override void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0xAE1680", Offset = "0xAE0880", VA = "0x180AE1680")]
		public UITab()
		{
		}

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Tooltip("Set to true to looping of cycling behavior between the first and last selectables index.")]
		private bool allowLooping;

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Tooltip("The InputActions for cycling behavior.")]
		private UITab.CycleInputActionType cycleInputActionType;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Tooltip("The InputActions for cycling behavior.")]
		private UITab.CycleDirection cycleDirection;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Tooltip("UI display for cycle left")]
		private TextMeshProUGUI cycleLeftVisual;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("UI display for cycle right")]
		[SerializeField]
		private TextMeshProUGUI cycleRightVisual;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0xC8")]
		private float cycleTabTimer;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0xCC")]
		private bool wasCycleTabPressedLastFrame;

		// Token: 0x0200023B RID: 571
		[Token(Token = "0x200023B")]
		public enum CycleInputActionType
		{
			// Token: 0x04000CD5 RID: 3285
			[Token(Token = "0x4000CD5")]
			Primary,
			// Token: 0x04000CD6 RID: 3286
			[Token(Token = "0x4000CD6")]
			Secondary
		}

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		public enum CycleDirection
		{
			// Token: 0x04000CD8 RID: 3288
			[Token(Token = "0x4000CD8")]
			Horizontal,
			// Token: 0x04000CD9 RID: 3289
			[Token(Token = "0x4000CD9")]
			Vertical
		}
	}
}
