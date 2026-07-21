using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	public class DealerAttendDealBehaviour : Behaviour
	{
		// Token: 0x06005073 RID: 20595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005073")]
		[Address(RVA = "0x94BEE0", Offset = "0x94B0E0", VA = "0x18094BEE0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005074")]
		[Address(RVA = "0x94BD60", Offset = "0x94AF60", VA = "0x18094BD60")]
		public void AssignContract(Contract contract)
		{
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005075")]
		[Address(RVA = "0x94BCF0", Offset = "0x94AEF0", VA = "0x18094BCF0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x94CA20", Offset = "0x94BC20", VA = "0x18094CA20", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x94C970", Offset = "0x94BB70", VA = "0x18094C970", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x94C090", Offset = "0x94B290", VA = "0x18094C090", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x94C5C0", Offset = "0x94B7C0", VA = "0x18094C5C0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x94BFF0", Offset = "0x94B1F0", VA = "0x18094BFF0")]
		private void BeginHandover()
		{
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x94CA90", Offset = "0x94BC90", VA = "0x18094CA90")]
		private void StopHandover()
		{
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x600507C")]
		[Address(RVA = "0x94C430", Offset = "0x94B630", VA = "0x18094C430")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x94C570", Offset = "0x94B770", VA = "0x18094C570")]
		private bool IsCustomerReadyForHandover()
		{
			return default(bool);
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x600507E")]
		[Address(RVA = "0x94C2A0", Offset = "0x94B4A0", VA = "0x18094C2A0")]
		private Vector3 GetStandPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00015150 File Offset: 0x00013350
		[Token(Token = "0x600507F")]
		[Address(RVA = "0x94C170", Offset = "0x94B370", VA = "0x18094C170")]
		private Vector3 GetDirectionToFace()
		{
			return default(Vector3);
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005080")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public DealerAttendDealBehaviour()
		{
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x94CAE0", Offset = "0x94BCE0", VA = "0x18094CAE0")]
		[CompilerGenerated]
		private IEnumerator <BeginHandover>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x94C5A0", Offset = "0x94B7A0", VA = "0x18094C5A0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x9477E0", Offset = "0x9469E0", VA = "0x1809477E0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x94BDF0", Offset = "0x94AFF0", VA = "0x18094BDF0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x168")]
		private Dealer _dealer;

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x170")]
		private Contract _contract;

		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x178")]
		private Customer _customer;

		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine _handoverRoutine;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviourAssembly-CSharp.dll_Excuted;
	}
}
