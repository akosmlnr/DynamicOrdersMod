using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x1700080F")]
		public int CurrentPlayerCount
		{
			[Token(Token = "0x6003181")]
			[Address(RVA = "0x75D560", Offset = "0x75C760", VA = "0x18075D560")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x758F10", Offset = "0x758110", VA = "0x180758F10", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003183")]
		[Address(RVA = "0x759830", Offset = "0x758A30", VA = "0x180759830", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x758D70", Offset = "0x757F70", VA = "0x180758D70")]
		public void AddPlayer(Player player)
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x75A070", Offset = "0x759270", VA = "0x18075A070")]
		public void RemovePlayer(Player player)
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x75D320", Offset = "0x75C520", VA = "0x18075D320")]
		public void SetPlayerScore(Player player, int score)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x759360", Offset = "0x758560", VA = "0x180759360")]
		public int GetPlayerScore(Player player)
		{
			return 0;
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x759430", Offset = "0x758630", VA = "0x180759430")]
		public Player GetPlayer(int index)
		{
			return null;
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x7591B0", Offset = "0x7583B0", VA = "0x1807591B0")]
		public int GetPlayerIndex(Player player)
		{
			return 0;
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x75A1C0", Offset = "0x7593C0", VA = "0x18075A1C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestAddPlayer(NetworkObject playerObject)
		{
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x758C50", Offset = "0x757E50", VA = "0x180758C50")]
		private void AddPlayerToArray(Player player)
		{
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x75A2F0", Offset = "0x7594F0", VA = "0x18075A2F0")]
		[ServerRpc(RequireOwnership = false)]
		private void RequestRemovePlayer(NetworkObject playerObject)
		{
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x759F70", Offset = "0x759170", VA = "0x180759F70")]
		private void RemovePlayerFromArray(Player player)
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x75A420", Offset = "0x759620", VA = "0x18075A420")]
		[ServerRpc(RequireOwnership = false)]
		private void RequestSetScore(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x75D060", Offset = "0x75C260", VA = "0x18075D060")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x75CE00", Offset = "0x75C000", VA = "0x18075CE00")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetPlayerList(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x759150", Offset = "0x758350", VA = "0x180759150")]
		public CasinoGamePlayerData GetPlayerData()
		{
			return null;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x758F90", Offset = "0x758190", VA = "0x180758F90")]
		public CasinoGamePlayerData GetPlayerData(Player player)
		{
			return null;
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x759090", Offset = "0x758290", VA = "0x180759090")]
		public CasinoGamePlayerData GetPlayerData(int index)
		{
			return null;
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003194")]
		[Address(RVA = "0x75CAF0", Offset = "0x75BCF0", VA = "0x18075CAF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x7599C0", Offset = "0x758BC0", VA = "0x1807599C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x75CC70", Offset = "0x75BE70", VA = "0x18075CC70")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x759C90", Offset = "0x758E90", VA = "0x180759C90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x759200", Offset = "0x758400", VA = "0x180759200")]
		private NetworkObject[] GetPlayerObjects()
		{
			return null;
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x75D480", Offset = "0x75C680", VA = "0x18075D480")]
		public CasinoGamePlayers()
		{
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319A")]
		[Address(RVA = "0x759470", Offset = "0x758670", VA = "0x180759470", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x6C9300", Offset = "0x6C8500", VA = "0x1806C9300", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x75C150", Offset = "0x75B350", VA = "0x18075C150")]
		private void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319E")]
		[Address(RVA = "0x75A8D0", Offset = "0x759AD0", VA = "0x18075A8D0")]
		private void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x75B490", Offset = "0x75A690", VA = "0x18075B490")]
		private void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A0")]
		[Address(RVA = "0x75A2F0", Offset = "0x7594F0", VA = "0x18075A2F0")]
		private void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0x75AB90", Offset = "0x759D90", VA = "0x18075AB90")]
		private void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A2")]
		[Address(RVA = "0x75B510", Offset = "0x75A710", VA = "0x18075B510")]
		private void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A3")]
		[Address(RVA = "0x75A420", Offset = "0x759620", VA = "0x18075A420")]
		private void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0x75AD40", Offset = "0x759F40", VA = "0x18075AD40")]
		private void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0x75B6E0", Offset = "0x75A8E0", VA = "0x18075B6E0")]
		private void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x75BFD0", Offset = "0x75B1D0", VA = "0x18075BFD0")]
		private void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x75B0D0", Offset = "0x75A2D0", VA = "0x18075B0D0")]
		private void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x75B3E0", Offset = "0x75A5E0", VA = "0x18075B3E0")]
		private void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A9")]
		[Address(RVA = "0x75C980", Offset = "0x75BB80", VA = "0x18075C980")]
		private void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AA")]
		[Address(RVA = "0x75BAF0", Offset = "0x75ACF0", VA = "0x18075BAF0")]
		private void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AB")]
		[Address(RVA = "0x75BE90", Offset = "0x75B090", VA = "0x18075BE90")]
		private void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x75ADC0", Offset = "0x759FC0", VA = "0x18075ADC0")]
		private void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x75B380", Offset = "0x75A580", VA = "0x18075B380")]
		private void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x75C820", Offset = "0x75BA20", VA = "0x18075C820")]
		private void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x75BA90", Offset = "0x75AC90", VA = "0x18075BA90")]
		private void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B0")]
		[Address(RVA = "0x75C280", Offset = "0x75B480", VA = "0x18075C280")]
		private void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B1")]
		[Address(RVA = "0x75AD60", Offset = "0x759F60", VA = "0x18075AD60")]
		public void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B2")]
		[Address(RVA = "0x75B770", Offset = "0x75A970", VA = "0x18075B770")]
		private void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B3")]
		[Address(RVA = "0x75BB90", Offset = "0x75AD90", VA = "0x18075BB90")]
		private void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B4")]
		[Address(RVA = "0x75A590", Offset = "0x759790", VA = "0x18075A590")]
		private void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B5")]
		[Address(RVA = "0x75B1F0", Offset = "0x75A3F0", VA = "0x18075B1F0")]
		private void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B6")]
		[Address(RVA = "0x75C540", Offset = "0x75B740", VA = "0x18075C540")]
		private void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B7")]
		[Address(RVA = "0x75B910", Offset = "0x75AB10", VA = "0x18075B910")]
		private void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B8")]
		[Address(RVA = "0x75C3E0", Offset = "0x75B5E0", VA = "0x18075C3E0")]
		private void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031B9")]
		[Address(RVA = "0x75AD90", Offset = "0x759F90", VA = "0x18075AD90")]
		public void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BA")]
		[Address(RVA = "0x75B850", Offset = "0x75AA50", VA = "0x18075B850")]
		private void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BB")]
		[Address(RVA = "0x75BD10", Offset = "0x75AF10", VA = "0x18075BD10")]
		private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BC")]
		[Address(RVA = "0x75A730", Offset = "0x759930", VA = "0x18075A730")]
		private void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x75B2C0", Offset = "0x75A4C0", VA = "0x18075B2C0")]
		private void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x75C6B0", Offset = "0x75B8B0", VA = "0x18075C6B0")]
		private void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x75B9E0", Offset = "0x75ABE0", VA = "0x18075B9E0")]
		private void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x758EB0", Offset = "0x7580B0", VA = "0x180758EB0")]
		private void Awake_UserLogic_ScheduleOne.Casino.CasinoGamePlayers_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x118")]
		public int PlayerLimit;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x120")]
		private Player[] Players;

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		[FieldOffset(Offset = "0x128")]
		public UnityEvent onPlayerListChanged;

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent onPlayerScoresChanged;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<Player, int> playerScores;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<Player, CasinoGamePlayerData> playerDatas;

		// Token: 0x0400247C RID: 9340
		[Token(Token = "0x400247C")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted;

		// Token: 0x0400247D RID: 9341
		[Token(Token = "0x400247D")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted;
	}
}
