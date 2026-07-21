using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Handover;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	public class RequestProductBehaviour : Behaviour
	{
		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7C")]
		public Player TargetPlayer
		{
			[Token(Token = "0x6005463")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005464")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x00015DF8 File Offset: 0x00013FF8
		// (set) Token: 0x06005466 RID: 21606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7D")]
		public RequestProductBehaviour.EState State
		{
			[Token(Token = "0x6005465")]
			[Address(RVA = "0x745880", Offset = "0x744A80", VA = "0x180745880")]
			[CompilerGenerated]
			get
			{
				return RequestProductBehaviour.EState.InitialApproach;
			}
			[Token(Token = "0x6005466")]
			[Address(RVA = "0x7458E0", Offset = "0x744AE0", VA = "0x1807458E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C7E")]
		private Customer customer
		{
			[Token(Token = "0x6005467")]
			[Address(RVA = "0x986E90", Offset = "0x986090", VA = "0x180986E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005468")]
		[Address(RVA = "0x983C00", Offset = "0x982E00", VA = "0x180983C00")]
		[ObserversRpc(RunLocally = true)]
		public void AssignTarget(NetworkObject plr)
		{
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005469")]
		[Address(RVA = "0x986E10", Offset = "0x986010", VA = "0x180986E10", Slot = "35")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546A")]
		[Address(RVA = "0x9838B0", Offset = "0x982AB0", VA = "0x1809838B0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546B")]
		[Address(RVA = "0x984010", Offset = "0x983210", VA = "0x180984010", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546C")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546D")]
		[Address(RVA = "0x985030", Offset = "0x984230", VA = "0x180985030", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x600546E")]
		[Address(RVA = "0x984BD0", Offset = "0x983DD0", VA = "0x180984BD0")]
		private bool IsTargetDestinationValid()
		{
			return default(bool);
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00015E28 File Offset: 0x00014028
		[Token(Token = "0x600546F")]
		[Address(RVA = "0x9842F0", Offset = "0x9834F0", VA = "0x1809842F0")]
		private bool GetNewDestination(out Vector3 dest)
		{
			return default(bool);
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00015E40 File Offset: 0x00014040
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x984DC0", Offset = "0x983FC0", VA = "0x180984DC0")]
		public static bool IsTargetValid(Player player)
		{
			return default(bool);
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00015E58 File Offset: 0x00014058
		[Token(Token = "0x6005471")]
		[Address(RVA = "0x983DC0", Offset = "0x982FC0", VA = "0x180983DC0")]
		public bool CanStartDialogue()
		{
			return default(bool);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005472")]
		[Address(RVA = "0x9865C0", Offset = "0x9857C0", VA = "0x1809865C0")]
		private void SetUpDialogue()
		{
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005473")]
		[Address(RVA = "0x9864B0", Offset = "0x9856B0", VA = "0x1809864B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartInitialDialogue()
		{
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005474")]
		[Address(RVA = "0x986CF0", Offset = "0x985EF0", VA = "0x180986CF0")]
		[ObserversRpc(RunLocally = true)]
		private void StartInitialDialogue()
		{
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005475")]
		[Address(RVA = "0x9863A0", Offset = "0x9855A0", VA = "0x1809863A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartFollowUpDialogue()
		{
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005476")]
		[Address(RVA = "0x985820", Offset = "0x984A20", VA = "0x180985820")]
		[ObserversRpc(RunLocally = true)]
		private void StartFollowUpDialogue()
		{
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00015E70 File Offset: 0x00014070
		[Token(Token = "0x6005477")]
		[Address(RVA = "0x9840D0", Offset = "0x9832D0", VA = "0x1809840D0")]
		private bool DialogueActive(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005478")]
		[Address(RVA = "0x985510", Offset = "0x984710", VA = "0x180985510")]
		private void RequestAccepted()
		{
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005479")]
		[Address(RVA = "0x9844F0", Offset = "0x9836F0", VA = "0x1809844F0")]
		private void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547A")]
		[Address(RVA = "0x984170", Offset = "0x983370", VA = "0x180984170")]
		private void Follow()
		{
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547B")]
		[Address(RVA = "0x9856F0", Offset = "0x9848F0", VA = "0x1809856F0")]
		private void RequestRejected()
		{
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547C")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public RequestProductBehaviour()
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600547D")]
		[Address(RVA = "0x986E20", Offset = "0x986020", VA = "0x180986E20")]
		[CompilerGenerated]
		private IEnumerator <HandoverClosed>g__Wait|36_0()
		{
			return null;
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547E")]
		[Address(RVA = "0x984E80", Offset = "0x984080", VA = "0x180984E80", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547F")]
		[Address(RVA = "0x950B60", Offset = "0x94FD60", VA = "0x180950B60", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005480")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005481")]
		[Address(RVA = "0x985E00", Offset = "0x985000", VA = "0x180985E00")]
		private void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
		{
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005482")]
		[Address(RVA = "0x985770", Offset = "0x984970", VA = "0x180985770")]
		public void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005483")]
		[Address(RVA = "0x985BF0", Offset = "0x984DF0", VA = "0x180985BF0")]
		private void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005484")]
		[Address(RVA = "0x986290", Offset = "0x985490", VA = "0x180986290")]
		private void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005485")]
		[Address(RVA = "0x985940", Offset = "0x984B40", VA = "0x180985940")]
		private void RpcLogic___SendStartInitialDialogue_2166136261()
		{
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005486")]
		[Address(RVA = "0x985DB0", Offset = "0x984FB0", VA = "0x180985DB0")]
		private void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005487")]
		[Address(RVA = "0x986060", Offset = "0x985260", VA = "0x180986060")]
		private void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005488")]
		[Address(RVA = "0x985AA0", Offset = "0x984CA0", VA = "0x180985AA0")]
		private void RpcLogic___StartInitialDialogue_2166136261()
		{
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005489")]
		[Address(RVA = "0x985D20", Offset = "0x984F20", VA = "0x180985D20")]
		private void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548A")]
		[Address(RVA = "0x986180", Offset = "0x985380", VA = "0x180986180")]
		private void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548B")]
		[Address(RVA = "0x985820", Offset = "0x984A20", VA = "0x180985820")]
		private void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548C")]
		[Address(RVA = "0x985D60", Offset = "0x984F60", VA = "0x180985D60")]
		private void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548D")]
		[Address(RVA = "0x985F40", Offset = "0x985140", VA = "0x180985F40")]
		private void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548E")]
		[Address(RVA = "0x985950", Offset = "0x984B50", VA = "0x180985950")]
		private void RpcLogic___StartFollowUpDialogue_2166136261()
		{
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x985CE0", Offset = "0x984EE0", VA = "0x180985CE0")]
		private void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005490")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003906 RID: 14598
		[Token(Token = "0x4003906")]
		public const float CONVERSATION_RANGE = 2.5f;

		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		public const float FOLLOW_MAX_RANGE = 5f;

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		public const int TicksBeforeAskAgain = 180;

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x174")]
		private int ticksSinceLastRequest;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x178")]
		private DialogueController.GreetingOverride requestGreeting;

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x180")]
		private DialogueController.DialogueChoice acceptRequestChoice;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x188")]
		private DialogueController.DialogueChoice followChoice;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x190")]
		private DialogueController.DialogueChoice rejectChoice;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000B25 RID: 2853
		[Token(Token = "0x2000B25")]
		public enum EState
		{
			// Token: 0x04003913 RID: 14611
			[Token(Token = "0x4003913")]
			InitialApproach,
			// Token: 0x04003914 RID: 14612
			[Token(Token = "0x4003914")]
			FollowPlayer
		}
	}
}
