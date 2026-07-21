using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;

namespace ScheduleOne.Law
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x674DD0", Offset = "0x673FD0", VA = "0x180674DD0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x6747F0", Offset = "0x6739F0", VA = "0x1806747F0")]
		public void PoliceCalled(Player target, Crime crime)
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x674990", Offset = "0x673B90", VA = "0x180674990")]
		public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			return null;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x674C10", Offset = "0x673E10", VA = "0x180674C10")]
		public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			return null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x674F90", Offset = "0x674190", VA = "0x180674F90")]
		public LawManager()
		{
		}

		// Token: 0x04001B76 RID: 7030
		[Token(Token = "0x4001B76")]
		public const int DISPATCH_OFFICER_COUNT = 2;

		// Token: 0x04001B77 RID: 7031
		[Token(Token = "0x4001B77")]
		[FieldOffset(Offset = "0x0")]
		public static float DISPATCH_VEHICLE_USE_THRESHOLD;
	}
}
