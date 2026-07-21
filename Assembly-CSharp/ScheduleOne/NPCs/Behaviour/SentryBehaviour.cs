using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Law;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B28 RID: 2856
	[Token(Token = "0x2000B28")]
	public class SentryBehaviour : Behaviour
	{
		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060054A2 RID: 21666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C81")]
		public SentryLocation AssignedLocation
		{
			[Token(Token = "0x60054A1")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054A2")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C82")]
		private SentryLocation.SentryRoute _currentRoute
		{
			[Token(Token = "0x60054A3")]
			[Address(RVA = "0x987E70", Offset = "0x987070", VA = "0x180987E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C83")]
		private Transform _standPoint
		{
			[Token(Token = "0x60054A4")]
			[Address(RVA = "0x987F40", Offset = "0x987140", VA = "0x180987F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x987350", Offset = "0x986550", VA = "0x180987350", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x987460", Offset = "0x986660", VA = "0x180987460", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x987BE0", Offset = "0x986DE0", VA = "0x180987BE0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x9870A0", Offset = "0x9862A0", VA = "0x1809870A0")]
		public void AssignLocation(SentryLocation loc)
		{
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x987DB0", Offset = "0x986FB0", VA = "0x180987DB0")]
		public void UnassignLocation()
		{
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x9876E0", Offset = "0x9868E0", VA = "0x1809876E0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x9879D0", Offset = "0x986BD0", VA = "0x1809879D0", Slot = "29")]
		public override void OnActiveUncappedMinutePass()
		{
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00015EA0 File Offset: 0x000140A0
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x987500", Offset = "0x986700", VA = "0x180987500")]
		private bool IsAtStandPoint()
		{
			return default(bool);
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x987D10", Offset = "0x986F10", VA = "0x180987D10")]
		private void SetFlashlightEquipped(bool equipped)
		{
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x986FB0", Offset = "0x9861B0", VA = "0x180986FB0")]
		private void ApplyMovementModifiers()
		{
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x987C70", Offset = "0x986E70", VA = "0x180987C70")]
		private void RemoveMovementModifiers()
		{
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x963950", Offset = "0x962B50", VA = "0x180963950")]
		public SentryBehaviour()
		{
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x9876C0", Offset = "0x9868C0", VA = "0x1809876C0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x9876A0", Offset = "0x9868A0", VA = "0x1809876A0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x987260", Offset = "0x986460", VA = "0x180987260", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.SentryBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		private const float BodySearchChance = 0.75f;

		// Token: 0x0400391C RID: 14620
		[Token(Token = "0x400391C")]
		private const int FlashlightMinTime = 1930;

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x168")]
		private int FlashlightMaxTime;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		private const string FlashlightAssetPath = "Tools/Flashlight/Flashlight_AvatarEquippable";

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		private const float AngularSpeedMultiplier = 0.2f;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		private const float WalkSpeed = 0.035f;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x16C")]
		public bool UseFlashlight;

		// Token: 0x04003922 RID: 14626
		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x16D")]
		private bool flashlightEquipped;

		// Token: 0x04003924 RID: 14628
		[Token(Token = "0x4003924")]
		[FieldOffset(Offset = "0x178")]
		private PoliceOfficer officer;

		// Token: 0x04003925 RID: 14629
		[Token(Token = "0x4003925")]
		[FieldOffset(Offset = "0x180")]
		private int _currentRoutePointIndex;

		// Token: 0x04003926 RID: 14630
		[Token(Token = "0x4003926")]
		[FieldOffset(Offset = "0x184")]
		private int _minutesAtCurrentPoint;

		// Token: 0x04003927 RID: 14631
		[Token(Token = "0x4003927")]
		[FieldOffset(Offset = "0x188")]
		private bool _movementModifiersApplied;

		// Token: 0x04003928 RID: 14632
		[Token(Token = "0x4003928")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003929 RID: 14633
		[Token(Token = "0x4003929")]
		[FieldOffset(Offset = "0x18A")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted;
	}
}
