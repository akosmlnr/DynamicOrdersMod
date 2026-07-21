using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009BB RID: 2491
	[Token(Token = "0x20009BB")]
	public class SurfaceStorageEntity : SurfaceItem, IUsable
	{
		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004660 RID: 18016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B01")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x600465F")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004660")]
			[Address(RVA = "0x8CA270", Offset = "0x8C9470", VA = "0x1808CA270", Slot = "71")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06004661 RID: 18017 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004662 RID: 18018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B02")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6004661")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004662")]
			[Address(RVA = "0x8CA310", Offset = "0x8C9510", VA = "0x1808CA310", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x17000B03")]
		public bool Selectable
		{
			[Token(Token = "0x6004663")]
			[Address(RVA = "0x66BBD0", Offset = "0x66ADD0", VA = "0x18066BBD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x00013458 File Offset: 0x00011658
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B04")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6004664")]
			[Address(RVA = "0x8CA980", Offset = "0x8C9B80", VA = "0x1808CA980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004665")]
			[Address(RVA = "0x8CA990", Offset = "0x8C9B90", VA = "0x1808CA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004666")]
		[Address(RVA = "0x8CA840", Offset = "0x8C9A40", VA = "0x1808CA840", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x8CA710", Offset = "0x8C9910", VA = "0x1808CA710", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x6004668")]
		[Address(RVA = "0x8C9B90", Offset = "0x8C8D90", VA = "0x1808C9B90", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004669")]
		[Address(RVA = "0x8C9C90", Offset = "0x8C8E90", VA = "0x1808C9C90", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466A")]
		[Address(RVA = "0x8CA970", Offset = "0x8C9B70", VA = "0x1808CA970")]
		public SurfaceStorageEntity()
		{
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466B")]
		[Address(RVA = "0x8C9EB0", Offset = "0x8C90B0", VA = "0x1808C9EB0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466C")]
		[Address(RVA = "0x8C9E40", Offset = "0x8C9040", VA = "0x1808C9E40", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466E")]
		[Address(RVA = "0x8CA5E0", Offset = "0x8C97E0", VA = "0x1808CA5E0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466F")]
		[Address(RVA = "0x8CA310", Offset = "0x8C9510", VA = "0x1808CA310", Slot = "78")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004670")]
		[Address(RVA = "0x8CA430", Offset = "0x8C9630", VA = "0x1808CA430")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004671")]
		[Address(RVA = "0x8CA4B0", Offset = "0x8C96B0", VA = "0x1808CA4B0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x8CA270", Offset = "0x8C9470", VA = "0x1808CA270", Slot = "79")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x8CA3B0", Offset = "0x8C95B0", VA = "0x1808CA3B0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004675 RID: 18037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B05")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6004674")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004675")]
			[Address(RVA = "0x8CA9A0", Offset = "0x8C9BA0", VA = "0x1808CA9A0")]
			set
			{
			}
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x6004676")]
		[Address(RVA = "0x8CA140", Offset = "0x8C9340", VA = "0x1808CA140", Slot = "80")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.SurfaceStorageEntity(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B06")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6004677")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x8CAA60", Offset = "0x8C9C60", VA = "0x1808CAA60")]
			set
			{
			}
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004679")]
		[Address(RVA = "0x8C9B40", Offset = "0x8C8D40", VA = "0x1808C9B40", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		[FieldOffset(Offset = "0x208")]
		[Header("Reference")]
		public StorageEntity StorageEntity;

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x228")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x230")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x238")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x239")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SurfaceStorageEntityAssembly-CSharp.dll_Excuted;
	}
}
