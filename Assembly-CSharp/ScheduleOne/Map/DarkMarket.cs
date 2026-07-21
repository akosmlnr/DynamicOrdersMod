using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Map
{
	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054D")]
		public bool IsOpen
		{
			[Token(Token = "0x6001D10")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0000A908 File Offset: 0x00008B08
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054E")]
		public bool Unlocked
		{
			[Token(Token = "0x6001D12")]
			[Address(RVA = "0x621930", Offset = "0x620B30", VA = "0x180621930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D13")]
			[Address(RVA = "0x621940", Offset = "0x620B40", VA = "0x180621940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x621660", Offset = "0x620860", VA = "0x180621660", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x620B20", Offset = "0x61FD20", VA = "0x180620B20", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x621760", Offset = "0x620960", VA = "0x180621760")]
		private void Update()
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x6214F0", Offset = "0x6206F0", VA = "0x1806214F0")]
		private bool ShouldBeOpen()
		{
			return default(bool);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x620960", Offset = "0x61FB60", VA = "0x180620960")]
		private void OnLoad()
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x621190", Offset = "0x620390", VA = "0x180621190")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendUnlocked()
		{
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x6212A0", Offset = "0x6204A0", VA = "0x1806212A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetUnlocked(NetworkConnection conn)
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x6218F0", Offset = "0x620AF0", VA = "0x1806218F0")]
		public DarkMarket()
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x620820", Offset = "0x61FA20", VA = "0x180620820", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x6207D0", Offset = "0x61F9D0", VA = "0x1806207D0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x620F50", Offset = "0x620150", VA = "0x180620F50")]
		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x620B60", Offset = "0x61FD60", VA = "0x180620B60")]
		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x620DA0", Offset = "0x61FFA0", VA = "0x180620DA0")]
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x620E30", Offset = "0x620030", VA = "0x180620E30")]
		private void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x620B70", Offset = "0x61FD70", VA = "0x180620B70")]
		private void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x620D60", Offset = "0x61FF60", VA = "0x180620D60")]
		private void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x621060", Offset = "0x620260", VA = "0x180621060")]
		private void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x620DF0", Offset = "0x61FFF0", VA = "0x180620DF0")]
		private void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x620760", Offset = "0x61F960", VA = "0x180620760", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0x128")]
		public DarkMarketAccessZone AccessZone;

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x130")]
		public DarkMarketMainDoor MainDoor;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x138")]
		public Oscar Oscar;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x140")]
		public FullRank UnlockRank;

		// Token: 0x0400188B RID: 6283
		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted;

		// Token: 0x0400188C RID: 6284
		[Token(Token = "0x400188C")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted;
	}
}
