using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.UI.Shop
{
	// Token: 0x02000E05 RID: 3589
	[Token(Token = "0x2000E05")]
	public class ShopManager : NetworkSingleton<ShopManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E93")]
		public string SaveFolderName
		{
			[Token(Token = "0x60066DA")]
			[Address(RVA = "0xA9D8A0", Offset = "0xA9CAA0", VA = "0x180A9D8A0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E94")]
		public string SaveFileName
		{
			[Token(Token = "0x60066DB")]
			[Address(RVA = "0xA9D870", Offset = "0xA9CA70", VA = "0x180A9D870", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E95")]
		public Loader Loader
		{
			[Token(Token = "0x60066DC")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x00019020 File Offset: 0x00017220
		[Token(Token = "0x17000E96")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60066DD")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060066DF RID: 26335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E97")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60066DE")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066DF")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E98")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60066E0")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066E1")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x00019038 File Offset: 0x00017238
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E99")]
		public bool HasChanged
		{
			[Token(Token = "0x60066E2")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60066E3")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x17000E9A")]
		public int LoadOrder
		{
			[Token(Token = "0x60066E4")]
			[Address(RVA = "0x71D590", Offset = "0x71C790", VA = "0x18071D590", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066E5")]
		[Address(RVA = "0xA9D710", Offset = "0xA9C910", VA = "0x180A9D710", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066E6")]
		[Address(RVA = "0xA9C970", Offset = "0xA9BB70", VA = "0x180A9C970", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0xA9C6E0", Offset = "0xA9B8E0", VA = "0x180A9C6E0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066E8")]
		[Address(RVA = "0xA9D140", Offset = "0xA9C340", VA = "0x180A9D140")]
		[ServerRpc(RequireOwnership = false)]
		public void SendStock(string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066E9")]
		[Address(RVA = "0xA9D430", Offset = "0xA9C630", VA = "0x180A9D430")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetStock(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066EA")]
		[Address(RVA = "0xA9D760", Offset = "0xA9C960", VA = "0x180A9D760")]
		public ShopManager()
		{
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066EB")]
		[Address(RVA = "0xA9CA50", Offset = "0xA9BC50", VA = "0x180A9CA50", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066EC")]
		[Address(RVA = "0xA9CA00", Offset = "0xA9BC00", VA = "0x180A9CA00", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066ED")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066EE")]
		[Address(RVA = "0xA9D140", Offset = "0xA9C340", VA = "0x180A9D140")]
		private void RpcWriter___Server_SendStock_15643032(string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066EF")]
		[Address(RVA = "0xA9CB90", Offset = "0xA9BD90", VA = "0x180A9CB90")]
		public void RpcLogic___SendStock_15643032(string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F0")]
		[Address(RVA = "0xA9CE60", Offset = "0xA9C060", VA = "0x180A9CE60")]
		private void RpcReader___Server_SendStock_15643032(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0xA9CFB0", Offset = "0xA9C1B0", VA = "0x180A9CFB0")]
		private void RpcWriter___Observers_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F2")]
		[Address(RVA = "0xA9CBC0", Offset = "0xA9BDC0", VA = "0x180A9CBC0")]
		public void RpcLogic___SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F3")]
		[Address(RVA = "0xA9CDB0", Offset = "0xA9BFB0", VA = "0x180A9CDB0")]
		private void RpcReader___Observers_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F4")]
		[Address(RVA = "0xA9D2B0", Offset = "0xA9C4B0", VA = "0x180A9D2B0")]
		private void RpcWriter___Target_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F5")]
		[Address(RVA = "0xA9CF00", Offset = "0xA9C100", VA = "0x180A9CF00")]
		private void RpcReader___Target_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F6")]
		[Address(RVA = "0xA9C670", Offset = "0xA9B870", VA = "0x180A9C670", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04004896 RID: 18582
		[Token(Token = "0x4004896")]
		[FieldOffset(Offset = "0x120")]
		private ShopManagerLoader loader;

		// Token: 0x0400489B RID: 18587
		[Token(Token = "0x400489B")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400489C RID: 18588
		[Token(Token = "0x400489C")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted;
	}
}
