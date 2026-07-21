using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using Steamworks;

namespace ScheduleOne.Networking
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x1700050F")]
		public bool IsHost
		{
			[Token(Token = "0x6001B76")]
			[Address(RVA = "0x6083F0", Offset = "0x6075F0", VA = "0x1806083F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000510")]
		public ulong LobbyID
		{
			[Token(Token = "0x6001B77")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001B78")]
			[Address(RVA = "0x6085D0", Offset = "0x6077D0", VA = "0x1806085D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x17000511")]
		public CSteamID LobbySteamID
		{
			[Token(Token = "0x6001B79")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x17000512")]
		public bool IsInLobby
		{
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x608490", Offset = "0x607690", VA = "0x180608490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x17000513")]
		public int PlayerCount
		{
			[Token(Token = "0x6001B7B")]
			[Address(RVA = "0x6084A0", Offset = "0x6076A0", VA = "0x1806084A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0000A3F8 File Offset: 0x000085F8
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000514")]
		public CSteamID LocalPlayerID
		{
			[Token(Token = "0x6001B7C")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return default(CSteamID);
			}
			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0x6085E0", Offset = "0x6077E0", VA = "0x1806085E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x606B60", Offset = "0x605D60", VA = "0x180606B60", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x607E40", Offset = "0x607040", VA = "0x180607E40", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x606DA0", Offset = "0x605FA0", VA = "0x180606DA0")]
		private void InitializeCallbacks()
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x608150", Offset = "0x607350", VA = "0x180608150")]
		public void TryOpenInviteInterface()
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x607060", Offset = "0x606260", VA = "0x180607060")]
		public void LeaveLobby()
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x606C90", Offset = "0x605E90", VA = "0x180606C90")]
		private void CreateLobby()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x606CB0", Offset = "0x605EB0", VA = "0x180606CB0")]
		private string GetLaunchLobby()
		{
			return null;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x608220", Offset = "0x607420", VA = "0x180608220")]
		private void UpdateLobbyMembers()
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x606FD0", Offset = "0x6061D0", VA = "0x180606FD0")]
		public void JoinAsClient(string steamId64)
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x607CE0", Offset = "0x606EE0", VA = "0x180607CE0")]
		public void SendLobbyMessage(string message)
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x607DA0", Offset = "0x606FA0", VA = "0x180607DA0")]
		public void SetLobbyData(string key, string value)
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x607500", Offset = "0x606700", VA = "0x180607500")]
		private void OnLobbyCreated(LobbyCreated_t result)
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x607770", Offset = "0x606970", VA = "0x180607770")]
		private void OnLobbyEntered(LobbyEnter_t result)
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x607BD0", Offset = "0x606DD0", VA = "0x180607BD0")]
		private void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x607140", Offset = "0x606340", VA = "0x180607140")]
		private void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x607220", Offset = "0x606420", VA = "0x180607220")]
		private void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x608350", Offset = "0x607550", VA = "0x180608350")]
		public Lobby()
		{
		}

		// Token: 0x040017AA RID: 6058
		[Token(Token = "0x40017AA")]
		public const bool ENABLED = true;

		// Token: 0x040017AB RID: 6059
		[Token(Token = "0x40017AB")]
		public const int PLAYER_LIMIT = 4;

		// Token: 0x040017AC RID: 6060
		[Token(Token = "0x40017AC")]
		public const string JOIN_READY = "ready";

		// Token: 0x040017AD RID: 6061
		[Token(Token = "0x40017AD")]
		public const string LOAD_TUTORIAL = "load_tutorial";

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		public const string HOST_LOADING = "host_loading";

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x38")]
		public CSteamID[] Players;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x40")]
		public Action onLobbyChange;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x48")]
		private Callback<LobbyCreated_t> LobbyCreatedCallback;

		// Token: 0x040017B4 RID: 6068
		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x50")]
		private Callback<LobbyEnter_t> LobbyEnteredCallback;

		// Token: 0x040017B5 RID: 6069
		[Token(Token = "0x40017B5")]
		[FieldOffset(Offset = "0x58")]
		private Callback<LobbyChatUpdate_t> ChatUpdateCallback;

		// Token: 0x040017B6 RID: 6070
		[Token(Token = "0x40017B6")]
		[FieldOffset(Offset = "0x60")]
		private Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		[FieldOffset(Offset = "0x68")]
		private Callback<LobbyChatMsg_t> LobbyChatMessageCallback;
	}
}
