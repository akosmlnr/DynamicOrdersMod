using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	[RequireComponent(typeof(Selectable))]
	public class UITrigger : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerExitHandler
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000071B8 File Offset: 0x000053B8
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		public bool Interactable
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x508DE0", Offset = "0x507FE0", VA = "0x180508DE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0xAE2080", Offset = "0xAE1280", VA = "0x180AE2080")]
			set
			{
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027F")]
		public Image HoldImage
		{
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			set
			{
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
		internal UITrigger.TriggerType GetTriggerType()
		{
			return UITrigger.TriggerType.Press;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0xAE19B0", Offset = "0xAE0BB0", VA = "0x180AE19B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0xAE1C30", Offset = "0xAE0E30", VA = "0x180AE1C30")]
		private bool IsInteractable()
		{
			return default(bool);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0xAE1F80", Offset = "0xAE1180", VA = "0x180AE1F80")]
		private void Update()
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0xAE1ED0", Offset = "0xAE10D0", VA = "0x180AE1ED0", Slot = "9")]
		internal virtual void OnReset()
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0xAE1A30", Offset = "0xAE0C30", VA = "0x180AE1A30", Slot = "10")]
		internal virtual void DetectTriggerInput(InputActionReference inputAction)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0xAE1CE0", Offset = "0xAE0EE0", VA = "0x180AE1CE0")]
		internal void OnInputDown()
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0xAE1B80", Offset = "0xAE0D80", VA = "0x180AE1B80")]
		internal void OnInputUp()
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0xAE1EC0", Offset = "0xAE10C0", VA = "0x180AE1EC0", Slot = "11")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0xAE1B80", Offset = "0xAE0D80", VA = "0x180AE1B80", Slot = "12")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0xAE1B80", Offset = "0xAE0D80", VA = "0x180AE1B80", Slot = "13")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0xAE1E40", Offset = "0xAE1040", VA = "0x180AE1E40", Slot = "14")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0xAE1BB0", Offset = "0xAE0DB0", VA = "0x180AE1BB0")]
		private void HandleHoldStart()
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0xAE1B80", Offset = "0xAE0D80", VA = "0x180AE1B80")]
		private void HandleHoldEnd()
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0xAE1EF0", Offset = "0xAE10F0", VA = "0x180AE1EF0")]
		private void UpdateHoldImage(float amount)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0xAE2060", Offset = "0xAE1260", VA = "0x180AE2060")]
		public UITrigger()
		{
		}

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UITrigger.TriggerType triggerType;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Set to true if you want Mouse to be always Press")]
		[SerializeField]
		private bool mouseAlwaysPress;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Duration in seconds to hold for Hold trigger")]
		private float holdDuration;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Optional UI image to show hold progress (should be Image Type: Filled)")]
		private Image holdImage;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Optional UGUI Selectable. If assigned, the uiTrigger interactable will also check for the UGUI Selectable interactable property.")]
		private Selectable uGUISelectable;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Event triggered when the action is performed")]
		public UnityEvent OnTrigger;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x48")]
		private bool isHolding;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x4C")]
		private float holdTime;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x50")]
		private bool isHoldStarted;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x51")]
		private bool interactable;

		// Token: 0x0200023F RID: 575
		[Token(Token = "0x200023F")]
		public enum TriggerType
		{
			// Token: 0x04000CEB RID: 3307
			[Token(Token = "0x4000CEB")]
			Press,
			// Token: 0x04000CEC RID: 3308
			[Token(Token = "0x4000CEC")]
			Hold
		}
	}
}
