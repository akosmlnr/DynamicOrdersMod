using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000601 RID: 1537
	[Token(Token = "0x2000601")]
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x170006A7")]
		protected float calculatedJumpJoltHeight
		{
			[Token(Token = "0x60025DA")]
			[Address(RVA = "0x6D1A00", Offset = "0x6D0C00", VA = "0x1806D1A00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x6D0650", Offset = "0x6CF850", VA = "0x1806D0650", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x6CFB10", Offset = "0x6CED10", VA = "0x1806CFB10", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x6CFCA0", Offset = "0x6CEEA0", VA = "0x1806CFCA0", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x6D0FF0", Offset = "0x6D01F0", VA = "0x1806D0FF0")]
		protected void Update()
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x6CFBE0", Offset = "0x6CEDE0", VA = "0x1806CFBE0")]
		private void InventoryStateChanged(bool active)
		{
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x6CFC90", Offset = "0x6CEE90", VA = "0x1806CFC90")]
		private void OnEquippedSlotChanged(int slotIndex)
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x6D0150", Offset = "0x6CF350", VA = "0x1806D0150")]
		public void RefreshViewmodel()
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x6CFB80", Offset = "0x6CED80", VA = "0x1806CFB80")]
		protected void BreatheBob()
		{
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x6D0690", Offset = "0x6CF890", VA = "0x1806D0690")]
		protected void Sway()
		{
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x6D1310", Offset = "0x6D0510", VA = "0x1806D1310")]
		protected void WalkBob()
		{
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x6D0640", Offset = "0x6CF840", VA = "0x1806D0640")]
		protected void StartJump()
		{
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x6D0AD0", Offset = "0x6CFCD0", VA = "0x1806D0AD0")]
		protected void UpdateJump()
		{
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x6CFBF0", Offset = "0x6CEDF0", VA = "0x1806CFBF0")]
		protected void Land()
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x6D17D0", Offset = "0x6D09D0", VA = "0x1806D17D0")]
		public ViewmodelSway()
		{
		}

		// Token: 0x04001D81 RID: 7553
		[Token(Token = "0x4001D81")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04001D82 RID: 7554
		[Token(Token = "0x4001D82")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings - Breathing")]
		public bool breatheBobbingEnabled;

		// Token: 0x04001D83 RID: 7555
		[Token(Token = "0x4001D83")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 0.0004f)]
		protected float breathingHeightMultiplier;

		// Token: 0x04001D84 RID: 7556
		[Token(Token = "0x4001D84")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 10f)]
		[SerializeField]
		protected float breathingSpeedMultiplier;

		// Token: 0x04001D85 RID: 7557
		[Token(Token = "0x4001D85")]
		[FieldOffset(Offset = "0x2C")]
		private float lastHeight;

		// Token: 0x04001D86 RID: 7558
		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 breatheBobPos;

		// Token: 0x04001D87 RID: 7559
		[Token(Token = "0x4001D87")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Settings - Sway - Movement")]
		public bool swayingEnabled;

		// Token: 0x04001D88 RID: 7560
		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float horizontalSwayMultiplier;

		// Token: 0x04001D89 RID: 7561
		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float verticalSwayMultiplier;

		// Token: 0x04001D8A RID: 7562
		[Token(Token = "0x4001D8A")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxHorizontal;

		// Token: 0x04001D8B RID: 7563
		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxVertical;

		// Token: 0x04001D8C RID: 7564
		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected float swaySmooth;

		// Token: 0x04001D8D RID: 7565
		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected float returnMultiplier;

		// Token: 0x04001D8E RID: 7566
		[Token(Token = "0x4001D8E")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 initialPos;

		// Token: 0x04001D8F RID: 7567
		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 swayPos;

		// Token: 0x04001D90 RID: 7568
		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x70")]
		[Header("Settings - Walk Bob")]
		public bool walkBobbingEnabled;

		// Token: 0x04001D91 RID: 7569
		[Token(Token = "0x4001D91")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected AnimationCurve verticalMovement;

		// Token: 0x04001D92 RID: 7570
		[Token(Token = "0x4001D92")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected AnimationCurve horizontalMovement;

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float verticalBobHeight;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[FieldOffset(Offset = "0x8C")]
		[Range(0f, 5f)]
		[SerializeField]
		protected float verticalBobSpeed;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float horizontalBobWidth;

		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4001D96")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 5f)]
		[SerializeField]
		protected float horizontalBobSpeed;

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float walkBobSmooth;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected float sprintSpeedMultiplier;

		// Token: 0x04001D99 RID: 7577
		[Token(Token = "0x4001D99")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public float walkBobMultiplier;

		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 walkBobPos;

		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4001D9B")]
		[FieldOffset(Offset = "0xB0")]
		private float timeSinceWalkStart_vert;

		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0xB4")]
		private float timeSinceWalkStart_horiz;

		// Token: 0x04001D9D RID: 7581
		[Token(Token = "0x4001D9D")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Settings - Jump Jolt")]
		public bool jumpJoltEnabled;

		// Token: 0x04001D9E RID: 7582
		[Token(Token = "0x4001D9E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected AnimationCurve jumpCurve;

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected float jumpJoltTime;

		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		protected float jumpJoltHeight;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected float jumpJoltSmooth;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Header("Settings - Equip Bop")]
		protected float equipBopVerticalOffset;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected float equipBopTime;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 equipBopPos;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0xE8")]
		private float timeSinceJumpStart;

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 jumpPos;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Settings - Falling")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float fallOffsetRate;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[FieldOffset(Offset = "0xFC")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float maxFallOffsetAmount;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 fallOffsetPos;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Header("Settings - Land Jolt")]
		protected AnimationCurve landCurve;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected float landJoltTime;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		protected float landJoltSmooth;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 landPos;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x12C")]
		private float timeSinceLanded;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0x130")]
		private float landJoltMultiplier;
	}
}
