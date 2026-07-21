using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public class Supplier : NPC
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A7")]
		public Supplier.ESupplierStatus Status
		{
			[Token(Token = "0x6002D94")]
			[Address(RVA = "0x735A30", Offset = "0x734C30", VA = "0x180735A30")]
			[CompilerGenerated]
			get
			{
				return Supplier.ESupplierStatus.Idle;
			}
			[Token(Token = "0x6002D95")]
			[Address(RVA = "0x735A60", Offset = "0x734C60", VA = "0x180735A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A8")]
		public bool DeliveriesEnabled
		{
			[Token(Token = "0x6002D96")]
			[Address(RVA = "0x735A20", Offset = "0x734C20", VA = "0x180735A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D97")]
			[Address(RVA = "0x735A50", Offset = "0x734C50", VA = "0x180735A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		[Token(Token = "0x170007A9")]
		public float Debt
		{
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0x735A10", Offset = "0x734C10", VA = "0x180735A10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AA")]
		public int minsUntilDeaddropReady
		{
			[Token(Token = "0x6002D99")]
			[Address(RVA = "0x735A40", Offset = "0x734C40", VA = "0x180735A40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002D9A")]
			[Address(RVA = "0x735A70", Offset = "0x734C70", VA = "0x180735A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0x72F5F0", Offset = "0x72E7F0", VA = "0x18072F5F0", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0x734A80", Offset = "0x733C80", VA = "0x180734A80", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0x732B70", Offset = "0x731D70", VA = "0x180732B70", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0x734450", Offset = "0x733650", VA = "0x180734450")]
		[ServerRpc(RequireOwnership = false)]
		public void SendUnlocked()
		{
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x733900", Offset = "0x732B00", VA = "0x180733900")]
		[ObserversRpc]
		private void SetUnlocked()
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x7324F0", Offset = "0x7316F0", VA = "0x1807324F0", Slot = "90")]
		protected override void MinPass()
		{
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x732C60", Offset = "0x731E60", VA = "0x180732C60", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x7317C0", Offset = "0x7309C0", VA = "0x1807317C0")]
		protected void HourPass()
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x732CF0", Offset = "0x731EF0", VA = "0x180732CF0")]
		private void OnTimeSkip(int minsSlept)
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x732040", Offset = "0x731240", VA = "0x180732040")]
		[ObserversRpc(RunLocally = true)]
		public void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x730FC0", Offset = "0x7301C0", VA = "0x180730FC0")]
		public void EndMeeting()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x735390", Offset = "0x734590", VA = "0x180735390", Slot = "130")]
		protected virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x733010", Offset = "0x732210", VA = "0x180733010", Slot = "131")]
		protected virtual void RelationshipChange(float change)
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x730D70", Offset = "0x72FF70", VA = "0x180730D70")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void EnableDeliveries(NetworkConnection conn)
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x734970", Offset = "0x733B70", VA = "0x180734970")]
		private void SendUnlockMessage()
		{
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x72FDE0", Offset = "0x72EFE0", VA = "0x18072FDE0", Slot = "85")]
		protected override void CreateMessageConversation()
		{
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x730B90", Offset = "0x72FD90", VA = "0x180730B90", Slot = "132")]
		protected virtual void DeaddropRequested()
		{
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x7301C0", Offset = "0x72F3C0", VA = "0x1807301C0", Slot = "133")]
		protected virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x734560", Offset = "0x733760", VA = "0x180734560")]
		[ServerRpc(RequireOwnership = false)]
		private void SetDeaddrop(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0x72F650", Offset = "0x72E850", VA = "0x18072F650")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ChangeDebt(float amount)
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x735510", Offset = "0x734710", VA = "0x180735510")]
		private void TryRecoverDebt()
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x72F780", Offset = "0x72E980", VA = "0x18072F780")]
		private void CompleteDeaddrop()
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x734800", Offset = "0x733A00", VA = "0x180734800")]
		private void SendDebtReminder()
		{
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x732360", Offset = "0x731560", VA = "0x180732360", Slot = "134")]
		protected virtual void MeetupRequested()
		{
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x732D40", Offset = "0x731F40", VA = "0x180732D40", Slot = "135")]
		protected virtual void PayDebtRequested()
		{
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x731090", Offset = "0x730290", VA = "0x180731090")]
		protected SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			return null;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0000E400 File Offset: 0x0000C600
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x7319C0", Offset = "0x730BC0", VA = "0x1807319C0")]
		private bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x731A50", Offset = "0x730C50", VA = "0x180731A50")]
		private bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x731670", Offset = "0x730870", VA = "0x180731670", Slot = "136")]
		public virtual float GetDeadDropLimit()
		{
			return 0f;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x7316E0", Offset = "0x7308E0", VA = "0x1807316E0", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x731D40", Offset = "0x730F40", VA = "0x180731D40", Slot = "119")]
		public override void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x731B30", Offset = "0x730D30", VA = "0x180731B30", Slot = "120")]
		public override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x7321F0", Offset = "0x7313F0", VA = "0x1807321F0")]
		private void MeetupOrderCompleted(float spend)
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x735950", Offset = "0x734B50", VA = "0x180735950")]
		public Supplier()
		{
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x735890", Offset = "0x734A90", VA = "0x180735890")]
		[CompilerGenerated]
		private IEnumerator <SupplierUnlocked>g__WaitForPlayer|55_0()
		{
			return null;
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x7357F0", Offset = "0x7349F0", VA = "0x1807357F0")]
		[CompilerGenerated]
		private IEnumerator <EnableDeliveries>g__Wait|57_0()
		{
			return null;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x732750", Offset = "0x731950", VA = "0x180732750", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x7326E0", Offset = "0x7318E0", VA = "0x1807326E0", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x734450", Offset = "0x733650", VA = "0x180734450")]
		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x733900", Offset = "0x732B00", VA = "0x180733900")]
		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x733D70", Offset = "0x732F70", VA = "0x180733D70")]
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x733900", Offset = "0x732B00", VA = "0x180733900")]
		private void RpcWriter___Observers_SetUnlocked_2166136261()
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x733B60", Offset = "0x732D60", VA = "0x180733B60")]
		private void RpcLogic___SetUnlocked_2166136261()
		{
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x733CA0", Offset = "0x732EA0", VA = "0x180733CA0")]
		private void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x734180", Offset = "0x733380", VA = "0x180734180")]
		private void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0x733480", Offset = "0x732680", VA = "0x180733480")]
		public void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x733BE0", Offset = "0x732DE0", VA = "0x180733BE0")]
		private void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x734060", Offset = "0x733260", VA = "0x180734060")]
		private void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x733390", Offset = "0x732590", VA = "0x180733390")]
		private void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x733BA0", Offset = "0x732DA0", VA = "0x180733BA0")]
		private void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x7346D0", Offset = "0x7338D0", VA = "0x1807346D0")]
		private void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x734020", Offset = "0x733220", VA = "0x180734020")]
		private void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x734560", Offset = "0x733760", VA = "0x180734560")]
		private void RpcWriter___Server_SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x733A20", Offset = "0x732C20", VA = "0x180733A20")]
		private void RpcLogic___SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x733EA0", Offset = "0x7330A0", VA = "0x180733EA0")]
		private void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x734310", Offset = "0x733510", VA = "0x180734310")]
		private void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x7332C0", Offset = "0x7324C0", VA = "0x1807332C0")]
		private void RpcLogic___ChangeDebt_431000436(float amount)
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x733CF0", Offset = "0x732EF0", VA = "0x180733CF0")]
		private void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x0000E448 File Offset: 0x0000C648
		// (set) Token: 0x06002DD9 RID: 11737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AB")]
		public float SyncAccessor_debt
		{
			[Token(Token = "0x6002DD8")]
			[Address(RVA = "0x735A10", Offset = "0x734C10", VA = "0x180735A10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002DD9")]
			[Address(RVA = "0x735B50", Offset = "0x734D50", VA = "0x180735B50")]
			set
			{
			}
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x732E70", Offset = "0x732070", VA = "0x180732E70", Slot = "137")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x0000E478 File Offset: 0x0000C678
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AC")]
		public bool SyncAccessor_deadDropPreparing
		{
			[Token(Token = "0x6002DDB")]
			[Address(RVA = "0x735A80", Offset = "0x734C80", VA = "0x180735A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002DDC")]
			[Address(RVA = "0x735A90", Offset = "0x734C90", VA = "0x180735A90")]
			set
			{
			}
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x72F5B0", Offset = "0x72E7B0", VA = "0x18072F5B0", Slot = "138")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Supplier_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		public const float MEETUP_RELATIONSHIP_REQUIREMENT = 4f;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		public const int MEETUP_DURATION_MINS = 360;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		public const int MEETING_COOLDOWN_MINS = 720;

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		public const int DEADDROP_WAIT_PER_ITEM = 30;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		public const int DEADDROP_MAX_WAIT = 360;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		public const int DEADDROP_ITEM_LIMIT = 10;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		public const float MeetingEndDistance = 20f;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		public const float DELIVERY_RELATIONSHIP_REQUIREMENT = 5f;

		// Token: 0x040021DC RID: 8668
		[Token(Token = "0x40021DC")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 SupplierLabelColor;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x330")]
		[Header("Supplier Settings")]
		public float MinOrderLimit;

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x334")]
		public float MaxOrderLimit;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x338")]
		public PhoneShopInterface.Listing[] OnlineShopItems;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x340")]
		[TextArea(3, 10)]
		public string SupplierRecommendMessage;

		// Token: 0x040021E3 RID: 8675
		[Token(Token = "0x40021E3")]
		[FieldOffset(Offset = "0x348")]
		[TextArea(3, 10)]
		public string SupplierUnlockHint;

		// Token: 0x040021E4 RID: 8676
		[Token(Token = "0x40021E4")]
		[FieldOffset(Offset = "0x350")]
		[Header("References")]
		public ShopInterface Shop;

		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x358")]
		public SupplierStash Stash;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x360")]
		public UnityEvent onDeaddropReady;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x368")]
		private int minsSinceMeetingStart;

		// Token: 0x040021E8 RID: 8680
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0x36C")]
		private int minsSinceLastMeetingEnd;

		// Token: 0x040021E9 RID: 8681
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x370")]
		private float playerSpendSinceMeetingStart;

		// Token: 0x040021EA RID: 8682
		[Token(Token = "0x40021EA")]
		[FieldOffset(Offset = "0x378")]
		private SupplierLocation currentLocation;

		// Token: 0x040021EB RID: 8683
		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x380")]
		private DialogueController dialogueController;

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x388")]
		private DialogueController.GreetingOverride meetingGreeting;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x390")]
		private DialogueController.DialogueChoice meetingChoice;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x398")]
		[SyncVar]
		public float debt;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x39C")]
		[SyncVar]
		public bool deadDropPreparing;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x3A8")]
		private StringIntPair[] deaddropItems;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x3B0")]
		private int minsSinceDeaddropOrder;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x3B4")]
		private bool repaymentReminderSent;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x3B8")]
		public SyncVar<float> syncVar___debt;

		// Token: 0x040021F5 RID: 8693
		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x3C0")]
		public SyncVar<bool> syncVar___deadDropPreparing;

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x3C8")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted;

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x3C9")]
		private bool NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted;

		// Token: 0x020006C5 RID: 1733
		[Token(Token = "0x20006C5")]
		public enum ESupplierStatus
		{
			// Token: 0x040021F9 RID: 8697
			[Token(Token = "0x40021F9")]
			Idle,
			// Token: 0x040021FA RID: 8698
			[Token(Token = "0x40021FA")]
			PreppingDeadDrop,
			// Token: 0x040021FB RID: 8699
			[Token(Token = "0x40021FB")]
			Meeting
		}
	}
}
