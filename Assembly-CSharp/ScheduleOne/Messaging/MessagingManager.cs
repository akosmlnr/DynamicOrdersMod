using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone.Messages;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		// Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x60EB90", Offset = "0x60DD90", VA = "0x18060EB90", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x60F260", Offset = "0x60E460", VA = "0x18060F260", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x60ED30", Offset = "0x60DF30", VA = "0x18060ED30")]
		public MSGConversation GetConversation(NPC npc)
		{
			return null;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x610040", Offset = "0x60F240", VA = "0x180610040")]
		public void Register(NPC npc, MSGConversation convs)
		{
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x612830", Offset = "0x611A30", VA = "0x180612830")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessage(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x60FA00", Offset = "0x60EC00", VA = "0x18060FA00")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessage(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x612690", Offset = "0x611890", VA = "0x180612690")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x60F840", Offset = "0x60EA40", VA = "0x18060F840")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x612B60", Offset = "0x611D60", VA = "0x180612B60")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendResponse(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x60FD40", Offset = "0x60EF40", VA = "0x18060FD40")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveResponse(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x6129C0", Offset = "0x611BC0", VA = "0x1806129C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x60FB90", Offset = "0x60ED90", VA = "0x18060FB90")]
		[ObserversRpc(RunLocally = true)]
		private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x60F6E0", Offset = "0x60E8E0", VA = "0x18060F6E0")]
		[TargetRpc]
		private void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x60EC00", Offset = "0x60DE00", VA = "0x18060EC00")]
		[ServerRpc(RequireOwnership = false)]
		public void ClearResponses(string npcID)
		{
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x60F5A0", Offset = "0x60E7A0", VA = "0x18060F5A0")]
		[ObserversRpc]
		private void ReceiveClearResponses(string npcID)
		{
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x612CD0", Offset = "0x611ED0", VA = "0x180612CD0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ShowResponses(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x60FEB0", Offset = "0x60F0B0", VA = "0x18060FEB0")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x612F70", Offset = "0x612170", VA = "0x180612F70")]
		public MessagingManager()
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x612E70", Offset = "0x612070", VA = "0x180612E70")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__Replicate|2_0(NPC npc, NetworkConnection conn)
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x60EE80", Offset = "0x60E080", VA = "0x18060EE80", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x60EE30", Offset = "0x60E030", VA = "0x18060EE30", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x6120E0", Offset = "0x6112E0", VA = "0x1806120E0")]
		private void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x60FA00", Offset = "0x60EC00", VA = "0x18060FA00")]
		public void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x611380", Offset = "0x610580", VA = "0x180611380")]
		private void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x611980", Offset = "0x610B80", VA = "0x180611980")]
		private void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x610590", Offset = "0x60F790", VA = "0x180610590")]
		private void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x610E80", Offset = "0x610080", VA = "0x180610E80")]
		private void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x611F70", Offset = "0x611170", VA = "0x180611F70")]
		private void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x60F840", Offset = "0x60EA40", VA = "0x18060F840")]
		public void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEA")]
		[Address(RVA = "0x611290", Offset = "0x610490", VA = "0x180611290")]
		private void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x611800", Offset = "0x610A00", VA = "0x180611800")]
		private void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x610430", Offset = "0x60F630", VA = "0x180610430")]
		private void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x610DA0", Offset = "0x60FFA0", VA = "0x180610DA0")]
		private void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x6123C0", Offset = "0x6115C0", VA = "0x1806123C0")]
		private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x60FD40", Offset = "0x60EF40", VA = "0x18060FD40")]
		public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x611520", Offset = "0x610720", VA = "0x180611520")]
		private void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x611C80", Offset = "0x610E80", VA = "0x180611C80")]
		private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x6108A0", Offset = "0x60FAA0", VA = "0x1806108A0")]
		private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x610FF0", Offset = "0x6101F0", VA = "0x180610FF0")]
		private void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x612240", Offset = "0x611440", VA = "0x180612240")]
		private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x60FB90", Offset = "0x60ED90", VA = "0x18060FB90")]
		public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x611450", Offset = "0x610650", VA = "0x180611450")]
		private void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x611AF0", Offset = "0x610CF0", VA = "0x180611AF0")]
		private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x6106F0", Offset = "0x60F8F0", VA = "0x1806106F0")]
		private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x610F30", Offset = "0x610130", VA = "0x180610F30")]
		private void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x60F6E0", Offset = "0x60E8E0", VA = "0x18060F6E0")]
		private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x6102F0", Offset = "0x60F4F0", VA = "0x1806102F0")]
		private void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x611680", Offset = "0x610880", VA = "0x180611680")]
		private void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x60EC00", Offset = "0x60DE00", VA = "0x18060EC00")]
		private void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x60F5A0", Offset = "0x60E7A0", VA = "0x18060F5A0")]
		public void RpcLogic___ClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x611120", Offset = "0x610320", VA = "0x180611120")]
		private void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x60F5A0", Offset = "0x60E7A0", VA = "0x18060F5A0")]
		private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x610150", Offset = "0x60F350", VA = "0x180610150")]
		private void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x610BD0", Offset = "0x60FDD0", VA = "0x180610BD0")]
		private void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x612530", Offset = "0x611730", VA = "0x180612530")]
		private void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x60FEB0", Offset = "0x60F0B0", VA = "0x18060FEB0")]
		public void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x6115C0", Offset = "0x6107C0", VA = "0x1806115C0")]
		private void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x611E00", Offset = "0x611000", VA = "0x180611E00")]
		private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x610A80", Offset = "0x60FC80", VA = "0x180610A80")]
		private void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x611080", Offset = "0x610280", VA = "0x180611080")]
		private void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x60EB50", Offset = "0x60DD50", VA = "0x18060EB50", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Messaging.MessagingManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x120")]
		protected Dictionary<NPC, MSGConversation> ConversationMap;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted;
	}
}
