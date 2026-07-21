using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		[Token(Token = "0x170006AF")]
		public LayerMask Interaction_SearchMask
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B0")]
		public bool CanDestroy
		{
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x6B6E40", Offset = "0x6B6040", VA = "0x1806B6E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600262F")]
			[Address(RVA = "0x6B6F10", Offset = "0x6B6110", VA = "0x1806B6F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B1")]
		public InteractableObject HoveredInteractableObject
		{
			[Token(Token = "0x6002630")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002631")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B2")]
		public InteractableObject HoveredValidInteractableObject
		{
			[Token(Token = "0x6002632")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002633")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B3")]
		public InteractableObject InteractedObject
		{
			[Token(Token = "0x6002634")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002635")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B4")]
		public string InteractKeyStr
		{
			[Token(Token = "0x6002636")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002637")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x6C3640", Offset = "0x6C2840", VA = "0x1806C3640", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x6C34B0", Offset = "0x6C26B0", VA = "0x1806C34B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x6C33D0", Offset = "0x6C25D0", VA = "0x1806C33D0")]
		private void LoadInteractKey()
		{
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263B")]
		[Address(RVA = "0x6C3960", Offset = "0x6C2B60", VA = "0x1806C3960", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263C")]
		[Address(RVA = "0x6C32F0", Offset = "0x6C24F0", VA = "0x1806C32F0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x6C1A90", Offset = "0x6C0C90", VA = "0x1806C1A90", Slot = "9")]
		protected virtual void CheckHover()
		{
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x6C2FE0", Offset = "0x6C21E0", VA = "0x1806C2FE0")]
		public bool IsAnythingBlockingInteraction()
		{
			return default(bool);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x6C26F0", Offset = "0x6C18F0", VA = "0x1806C26F0", Slot = "10")]
		protected virtual void CheckInteraction()
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x6C2A40", Offset = "0x6C1C40", VA = "0x1806C2A40", Slot = "11")]
		protected virtual void CheckRightClick()
		{
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x6C2E90", Offset = "0x6C2090", VA = "0x1806C2E90", Slot = "12")]
		protected virtual BuildableItem GetHoveredBuildableItem()
		{
			return null;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002642")]
		[Address(RVA = "0x6B6F10", Offset = "0x6B6110", VA = "0x1806B6F10")]
		public void SetCanDestroy(bool canDestroy)
		{
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002643")]
		[Address(RVA = "0x6C3A30", Offset = "0x6C2C30", VA = "0x1806C3A30")]
		public InteractionManager()
		{
		}

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		public const float RayRadius = 0.075f;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		public const float MaxInteractionRange = 5f;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask interaction_SearchMask;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected float rightClickRange;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[FieldOffset(Offset = "0x30")]
		public EInteractionSearchType interactionSearchType;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[FieldOffset(Offset = "0x34")]
		public bool DEBUG;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public InputActionReference InteractInput;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[FieldOffset(Offset = "0x60")]
		[Header("Visuals Settings")]
		public Color messageColor_Default;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x70")]
		public Color iconColor_Default;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x80")]
		public Color iconColor_Default_Key;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x90")]
		public Color messageColor_Invalid;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0xA0")]
		public Color iconColor_Invalid;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite icon_Key;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite icon_LeftMouse;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0xC0")]
		public Sprite icon_Cross;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[FieldOffset(Offset = "0x0")]
		public static float interactCooldown;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0xC8")]
		private float timeSinceLastInteractStart;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		[FieldOffset(Offset = "0xD0")]
		private BuildableItem itemBeingDestroyed;

		// Token: 0x04001DF6 RID: 7670
		[Token(Token = "0x4001DF6")]
		[FieldOffset(Offset = "0xD8")]
		private float destroyTime;

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0x4")]
		private static float timeToDestroy;
	}
}
