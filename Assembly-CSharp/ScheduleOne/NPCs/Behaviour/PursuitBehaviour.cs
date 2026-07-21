using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Combat;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B21 RID: 2849
	[Token(Token = "0x2000B21")]
	public class PursuitBehaviour : CombatBehaviour
	{
		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7B")]
		public Player TargetPlayer
		{
			[Token(Token = "0x600543D")]
			[Address(RVA = "0x66B670", Offset = "0x66A870", VA = "0x18066B670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600543E")]
			[Address(RVA = "0x66BE00", Offset = "0x66B000", VA = "0x18066BE00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543F")]
		[Address(RVA = "0x96E620", Offset = "0x96D820", VA = "0x18096E620", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005440")]
		[Address(RVA = "0x96EFD0", Offset = "0x96E1D0", VA = "0x18096EFD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005441")]
		[Address(RVA = "0x96F1F0", Offset = "0x96E3F0", VA = "0x18096F1F0", Slot = "35")]
		protected override void SetTarget(NetworkObject target)
		{
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005442")]
		[Address(RVA = "0x96E3D0", Offset = "0x96D5D0", VA = "0x18096E3D0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005443")]
		[Address(RVA = "0x96F130", Offset = "0x96E330", VA = "0x18096F130", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005444")]
		[Address(RVA = "0x96EAB0", Offset = "0x96DCB0", VA = "0x18096EAB0", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005445")]
		[Address(RVA = "0x96E670", Offset = "0x96D870", VA = "0x18096E670", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005446")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x6005447")]
		[Address(RVA = "0x96EC40", Offset = "0x96DE40", VA = "0x18096EC40", Slot = "46")]
		protected override bool IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005448")]
		[Address(RVA = "0x96FF00", Offset = "0x96F100", VA = "0x18096FF00", Slot = "50")]
		protected virtual void UpdateInvestigatingBehaviour()
		{
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005449")]
		[Address(RVA = "0x96F500", Offset = "0x96E700", VA = "0x18096F500", Slot = "51")]
		protected virtual void UpdateArrestBehaviour()
		{
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544A")]
		[Address(RVA = "0x970250", Offset = "0x96F450", VA = "0x180970250", Slot = "52")]
		protected virtual void UpdateNonLethalBehaviour()
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544B")]
		[Address(RVA = "0x96FFF0", Offset = "0x96F1F0", VA = "0x18096FFF0", Slot = "53")]
		protected virtual void UpdateLethalBehaviour()
		{
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544C")]
		[Address(RVA = "0x96EE00", Offset = "0x96E000", VA = "0x18096EE00", Slot = "40")]
		protected override void OnCurrentWeaponChanged(AvatarWeapon weapon)
		{
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x600544D")]
		[Address(RVA = "0x96EC30", Offset = "0x96DE30", VA = "0x18096EC30", Slot = "43")]
		protected override float GetIdealRangedWeaponDistance()
		{
			return 0f;
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544E")]
		[Address(RVA = "0x96FC60", Offset = "0x96EE60", VA = "0x18096FC60")]
		private void UpdateArrest(float tick)
		{
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544F")]
		[Address(RVA = "0x96E840", Offset = "0x96DA40", VA = "0x18096E840")]
		private void ClearSpeedControls()
		{
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005450")]
		[Address(RVA = "0x96EAE0", Offset = "0x96DCE0", VA = "0x18096EAE0", Slot = "37")]
		protected override void EndCombat()
		{
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005451")]
		[Address(RVA = "0x96F8C0", Offset = "0x96EAC0", VA = "0x18096F8C0", Slot = "54")]
		protected virtual void UpdateArrestCircle()
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005452")]
		[Address(RVA = "0x96F120", Offset = "0x96E320", VA = "0x18096F120")]
		public void ResetArrestProgress()
		{
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005453")]
		[Address(RVA = "0x96F180", Offset = "0x96E380", VA = "0x18096F180")]
		private void SetArrestCircleAlpha(float alpha)
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005454")]
		[Address(RVA = "0x96F1B0", Offset = "0x96E3B0", VA = "0x18096F1B0")]
		private void SetArrestCircleColor(Color col)
		{
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005455")]
		[Address(RVA = "0x96F110", Offset = "0x96E310", VA = "0x18096F110")]
		private void OnThirdPartyVisionEvent(VisionEventReceipt receipt)
		{
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005456")]
		[Address(RVA = "0x96F490", Offset = "0x96E690", VA = "0x18096F490", Slot = "44")]
		protected override void TargetSpotted()
		{
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005457")]
		[Address(RVA = "0x9704B0", Offset = "0x96F6B0", VA = "0x1809704B0")]
		public PursuitBehaviour()
		{
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005458")]
		[Address(RVA = "0x96EDE0", Offset = "0x96DFE0", VA = "0x18096EDE0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005459")]
		[Address(RVA = "0x96EDC0", Offset = "0x96DFC0", VA = "0x18096EDC0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545A")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545B")]
		[Address(RVA = "0x96E420", Offset = "0x96D620", VA = "0x18096E420", Slot = "55")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.PursuitBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040038E4 RID: 14564
		[Token(Token = "0x40038E4")]
		public const float ARREST_RANGE = 2.75f;

		// Token: 0x040038E5 RID: 14565
		[Token(Token = "0x40038E5")]
		public const float ARREST_TIME = 1.75f;

		// Token: 0x040038E6 RID: 14566
		[Token(Token = "0x40038E6")]
		public const float EXTRA_VISIBILITY_TIME = 2f;

		// Token: 0x040038E7 RID: 14567
		[Token(Token = "0x40038E7")]
		public const float MOVE_SPEED_INVESTIGATING = 0.35f;

		// Token: 0x040038E8 RID: 14568
		[Token(Token = "0x40038E8")]
		public const float MOVE_SPEED_ARRESTING = 0.7f;

		// Token: 0x040038E9 RID: 14569
		[Token(Token = "0x40038E9")]
		public const float MOVE_SPEED_CHASE = 0.9f;

		// Token: 0x040038EA RID: 14570
		[Token(Token = "0x40038EA")]
		public const float CHASE_SPEED_DISTANCE_THRESHOLD = 6f;

		// Token: 0x040038EB RID: 14571
		[Token(Token = "0x40038EB")]
		public const float ARREST_MAX_DISTANCE = 15f;

		// Token: 0x040038EC RID: 14572
		[Token(Token = "0x40038EC")]
		public const int LEAVE_ARREST_CIRCLE_LIMIT = 3;

		// Token: 0x040038EE RID: 14574
		[Token(Token = "0x40038EE")]
		[FieldOffset(Offset = "0x238")]
		[Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		// Token: 0x040038EF RID: 14575
		[Token(Token = "0x40038EF")]
		[FieldOffset(Offset = "0x23C")]
		public float ArrestCircle_MaxOpacity;

		// Token: 0x040038F0 RID: 14576
		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x240")]
		[Header("Weapons")]
		public AvatarWeapon Weapon_Baton;

		// Token: 0x040038F1 RID: 14577
		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x248")]
		public AvatarWeapon Weapon_Taser;

		// Token: 0x040038F2 RID: 14578
		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x250")]
		public AvatarWeapon Weapon_Gun;

		// Token: 0x040038F3 RID: 14579
		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x258")]
		protected bool arrestingEnabled;

		// Token: 0x040038F4 RID: 14580
		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x25C")]
		protected float currentPursuitLevelDuration;

		// Token: 0x040038F5 RID: 14581
		[Token(Token = "0x40038F5")]
		[FieldOffset(Offset = "0x260")]
		protected float timeWithinArrestRange;

		// Token: 0x040038F6 RID: 14582
		[Token(Token = "0x40038F6")]
		[FieldOffset(Offset = "0x264")]
		protected float distanceOnPursuitStart;

		// Token: 0x040038F7 RID: 14583
		[Token(Token = "0x40038F7")]
		[FieldOffset(Offset = "0x268")]
		private PoliceOfficer officer;

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x270")]
		private bool targetWasDrivingOnPursuitStart;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x271")]
		private bool wasInArrestCircleLastFrame;

		// Token: 0x040038FA RID: 14586
		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x274")]
		private int leaveArrestCircleCount;

		// Token: 0x040038FB RID: 14587
		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x278")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038FC RID: 14588
		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0x279")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000B22 RID: 2850
		[Token(Token = "0x2000B22")]
		private enum EPursuitAction
		{
			// Token: 0x040038FE RID: 14590
			[Token(Token = "0x40038FE")]
			None,
			// Token: 0x040038FF RID: 14591
			[Token(Token = "0x40038FF")]
			Move,
			// Token: 0x04003900 RID: 14592
			[Token(Token = "0x4003900")]
			Shoot,
			// Token: 0x04003901 RID: 14593
			[Token(Token = "0x4003901")]
			MoveAndShoot
		}
	}
}
