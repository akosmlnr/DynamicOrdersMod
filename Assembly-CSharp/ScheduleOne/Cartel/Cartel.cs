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
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x2000794")]
	public class Cartel : NetworkSingleton<Cartel>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		// (set) Token: 0x06003388 RID: 13192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083E")]
		public ECartelStatus Status
		{
			[Token(Token = "0x6003387")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return ECartelStatus.Unknown;
			}
			[Token(Token = "0x6003388")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083F")]
		public int HoursSinceStatusChange
		{
			[Token(Token = "0x6003389")]
			[Address(RVA = "0x5D6EC0", Offset = "0x5D60C0", VA = "0x1805D6EC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600338A")]
			[Address(RVA = "0x5D6EE0", Offset = "0x5D60E0", VA = "0x1805D6EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000840")]
		public string SaveFolderName
		{
			[Token(Token = "0x600338B")]
			[Address(RVA = "0x79BB30", Offset = "0x79AD30", VA = "0x18079BB30", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000841")]
		public string SaveFileName
		{
			[Token(Token = "0x600338C")]
			[Address(RVA = "0x79BB00", Offset = "0x79AD00", VA = "0x18079BB00", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000842")]
		public Loader Loader
		{
			[Token(Token = "0x600338D")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x17000843")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600338E")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003390 RID: 13200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000844")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600338F")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003390")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003391 RID: 13201 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000845")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003391")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003392")]
			[Address(RVA = "0x588860", Offset = "0x587A60", VA = "0x180588860", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x0000FB28 File Offset: 0x0000DD28
		// (set) Token: 0x06003394 RID: 13204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000846")]
		public bool HasChanged
		{
			[Token(Token = "0x6003393")]
			[Address(RVA = "0x6782D0", Offset = "0x6774D0", VA = "0x1806782D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003394")]
			[Address(RVA = "0x6783C0", Offset = "0x6775C0", VA = "0x1806783C0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x0000FB40 File Offset: 0x0000DD40
		[Token(Token = "0x17000847")]
		public int LoadOrder
		{
			[Token(Token = "0x6003395")]
			[Address(RVA = "0x6782E0", Offset = "0x6774E0", VA = "0x1806782E0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x79B860", Offset = "0x79AA60", VA = "0x18079B860", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x79AE10", Offset = "0x79A010", VA = "0x18079AE10", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x79A6B0", Offset = "0x7998B0", VA = "0x18079A6B0")]
		private void HourPass()
		{
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x79A6C0", Offset = "0x7998C0", VA = "0x18079A6C0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x79A320", Offset = "0x799520", VA = "0x18079A320", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x79A750", Offset = "0x799950", VA = "0x18079A750")]
		public void Load(CartelData data)
		{
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x79B300", Offset = "0x79A500", VA = "0x18079B300")]
		[ServerRpc(RequireOwnership = false)]
		public void SetStatus_Server(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339D")]
		[Address(RVA = "0x79B5C0", Offset = "0x79A7C0", VA = "0x18079B5C0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetStatus(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x79B9E0", Offset = "0x79ABE0", VA = "0x18079B9E0")]
		public Cartel()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x79ACD0", Offset = "0x799ED0", VA = "0x18079ACD0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x79AC80", Offset = "0x799E80", VA = "0x18079AC80", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x79B300", Offset = "0x79A500", VA = "0x18079B300")]
		private void RpcWriter___Server_SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x79AF90", Offset = "0x79A190", VA = "0x18079AF90")]
		public void RpcLogic___SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x79B050", Offset = "0x79A250", VA = "0x18079B050")]
		private void RpcReader___Server_SetStatus_Server_2366206100(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x79B190", Offset = "0x79A390", VA = "0x18079B190")]
		private void RpcWriter___Observers_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x79AE70", Offset = "0x79A070", VA = "0x18079AE70")]
		public void RpcLogic___SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x79AFB0", Offset = "0x79A1B0", VA = "0x18079AFB0")]
		private void RpcReader___Observers_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x79B460", Offset = "0x79A660", VA = "0x18079B460")]
		private void RpcWriter___Target_SetStatus_3666943613(NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x79B0F0", Offset = "0x79A2F0", VA = "0x18079B0F0")]
		private void RpcReader___Target_SetStatus_3666943613(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x79A2B0", Offset = "0x7994B0", VA = "0x18079A2B0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public CartelActivities Activities;

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x130")]
		public CartelInfluence Influence;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x138")]
		public GoonPool GoonPool;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x140")]
		public CartelDealManager DealManager;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x148")]
		public Action<ECartelStatus, ECartelStatus> OnStatusChange;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x150")]
		private CartelLoader loader;

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted;

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelAssembly-CSharp.dll_Excuted;
	}
}
