using System;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	public class VehiclePatrolBehaviour : Behaviour
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x17000C87")]
		private bool isDriving
		{
			[Token(Token = "0x60054F4")]
			[Address(RVA = "0x98C3E0", Offset = "0x98B5E0", VA = "0x18098C3E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C88")]
		private VehicleAgent Agent
		{
			[Token(Token = "0x60054F5")]
			[Address(RVA = "0x98C3B0", Offset = "0x98B5B0", VA = "0x18098C3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x98B8F0", Offset = "0x98AAF0", VA = "0x18098B8F0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F8")]
		[Address(RVA = "0x98C1A0", Offset = "0x98B3A0", VA = "0x18098C1A0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x98C040", Offset = "0x98B240", VA = "0x18098C040", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x98B910", Offset = "0x98AB10", VA = "0x18098B910", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
		public void SetRoute(VehiclePatrolRoute route)
		{
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x98C1C0", Offset = "0x98B3C0", VA = "0x18098C1C0")]
		private void StartPatrol()
		{
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x98BD50", Offset = "0x98AF50", VA = "0x18098BD50", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x98BA70", Offset = "0x98AC70", VA = "0x18098BA70")]
		private void DriveTo(Vector3 location)
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x98BCF0", Offset = "0x98AEF0", VA = "0x18098BCF0")]
		private void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x98BB90", Offset = "0x98AD90", VA = "0x18098BB90")]
		private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			return default(bool);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x98C3A0", Offset = "0x98B5A0", VA = "0x18098C3A0")]
		public VehiclePatrolBehaviour()
		{
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x94C5A0", Offset = "0x94B7A0", VA = "0x18094C5A0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x9477E0", Offset = "0x9469E0", VA = "0x1809477E0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x986F10", Offset = "0x986110", VA = "0x180986F10", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400394D RID: 14669
		[Token(Token = "0x400394D")]
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		// Token: 0x0400394E RID: 14670
		[Token(Token = "0x400394E")]
		public const float PROGRESSION_THRESHOLD = 10f;

		// Token: 0x0400394F RID: 14671
		[Token(Token = "0x400394F")]
		[FieldOffset(Offset = "0x168")]
		public int CurrentWaypoint;

		// Token: 0x04003950 RID: 14672
		[Token(Token = "0x4003950")]
		[FieldOffset(Offset = "0x170")]
		[Header("Settings")]
		public VehiclePatrolRoute Route;

		// Token: 0x04003951 RID: 14673
		[Token(Token = "0x4003951")]
		[FieldOffset(Offset = "0x178")]
		public LandVehicle Vehicle;

		// Token: 0x04003952 RID: 14674
		[Token(Token = "0x4003952")]
		[FieldOffset(Offset = "0x180")]
		private bool aggressiveDrivingEnabled;

		// Token: 0x04003953 RID: 14675
		[Token(Token = "0x4003953")]
		[FieldOffset(Offset = "0x184")]
		private new int consecutivePathingFailures;

		// Token: 0x04003954 RID: 14676
		[Token(Token = "0x4003954")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003955 RID: 14677
		[Token(Token = "0x4003955")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted;
	}
}
