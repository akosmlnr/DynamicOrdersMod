using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public class WorldSpraySurface : SpraySurface, IGUIDRegisterable
	{
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000702")]
		public Guid GUID
		{
			[Token(Token = "0x6002862")]
			[Address(RVA = "0x6ECFC0", Offset = "0x6EC1C0", VA = "0x1806ECFC0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002863")]
			[Address(RVA = "0x6ED010", Offset = "0x6EC210", VA = "0x1806ED010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000703")]
		public EMapRegion Region
		{
			[Token(Token = "0x6002864")]
			[Address(RVA = "0x6ECFF0", Offset = "0x6EC1F0", VA = "0x1806ECFF0")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x6002865")]
			[Address(RVA = "0x6ED050", Offset = "0x6EC250", VA = "0x1806ED050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x0000D110 File Offset: 0x0000B310
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000704")]
		public bool HasEverBeenMarkedByPlayer
		{
			[Token(Token = "0x6002866")]
			[Address(RVA = "0x6ECFD0", Offset = "0x6EC1D0", VA = "0x1806ECFD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002867")]
			[Address(RVA = "0x6ED020", Offset = "0x6EC220", VA = "0x1806ED020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000705")]
		public Transform NPCStandPoint
		{
			[Token(Token = "0x6002868")]
			[Address(RVA = "0x6ECFE0", Offset = "0x6EC1E0", VA = "0x1806ECFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002869")]
			[Address(RVA = "0x6ED030", Offset = "0x6EC230", VA = "0x1806ED030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x0000D128 File Offset: 0x0000B328
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000706")]
		public bool CanBeSprayedByNPCs
		{
			[Token(Token = "0x600286A")]
			[Address(RVA = "0x6ECFB0", Offset = "0x6EC1B0", VA = "0x1806ECFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x6ED000", Offset = "0x6EC200", VA = "0x1806ED000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x6EADF0", Offset = "0x6E9FF0", VA = "0x1806EADF0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x6ECCB0", Offset = "0x6EBEB0", VA = "0x1806ECCB0")]
		private void Start()
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x6EB7D0", Offset = "0x6EA9D0", VA = "0x1806EB7D0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x6EB990", Offset = "0x6EAB90", VA = "0x1806EB990", Slot = "21")]
		public override void OnEditingFinished()
		{
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x6EB000", Offset = "0x6EA200", VA = "0x1806EB000", Slot = "22")]
		public override void CleanGraffiti()
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x6EBE80", Offset = "0x6EB080", VA = "0x1806EBE80")]
		private void Reward()
		{
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x6EBDF0", Offset = "0x6EAFF0", VA = "0x1806EBDF0", Slot = "20")]
		public override void ReplicateTo(NetworkConnection conn)
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x6EC990", Offset = "0x6EBB90", VA = "0x1806EC990")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Set(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x6EB520", Offset = "0x6EA720", VA = "0x1806EB520")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkDrawingFinalized()
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x6EBFC0", Offset = "0x6EB1C0", VA = "0x1806EBFC0")]
		[ObserversRpc(RunLocally = true)]
		private void SetFinalized()
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x6ECC60", Offset = "0x6EBE60", VA = "0x1806ECC60", Slot = "23")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x6EC920", Offset = "0x6EBB20", VA = "0x1806EC920", Slot = "30")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x6EBDA0", Offset = "0x6EAFA0", VA = "0x1806EBDA0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x6EB230", Offset = "0x6EA430", VA = "0x1806EB230")]
		[Button]
		private void GroundNPCStandPoint()
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x6EB120", Offset = "0x6EA320", VA = "0x1806EB120")]
		public new WorldSpraySurfaceData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x6ECEC0", Offset = "0x6EC0C0", VA = "0x1806ECEC0")]
		public WorldSpraySurface()
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x6EB660", Offset = "0x6EA860", VA = "0x1806EB660", Slot = "25")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x6EB630", Offset = "0x6EA830", VA = "0x1806EB630", Slot = "26")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x6E33D0", Offset = "0x6E25D0", VA = "0x1806E33D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x6EC520", Offset = "0x6EB720", VA = "0x1806EC520")]
		private void RpcWriter___Observers_Set_3759704962(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x6EC110", Offset = "0x6EB310", VA = "0x1806EC110")]
		public void RpcLogic___Set_3759704962(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x6EC1E0", Offset = "0x6EB3E0", VA = "0x1806EC1E0")]
		private void RpcReader___Observers_Set_3759704962(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x6EC7B0", Offset = "0x6EB9B0", VA = "0x1806EC7B0")]
		private void RpcWriter___Target_Set_3759704962(NetworkConnection conn, SprayStroke[] strokes, bool hasBeenFinalized, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x6EC320", Offset = "0x6EB520", VA = "0x1806EC320")]
		private void RpcReader___Target_Set_3759704962(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x6EC6A0", Offset = "0x6EB8A0", VA = "0x1806EC6A0")]
		private void RpcWriter___Server_MarkDrawingFinalized_2166136261()
		{
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x6EBFC0", Offset = "0x6EB1C0", VA = "0x1806EBFC0")]
		public void RpcLogic___MarkDrawingFinalized_2166136261()
		{
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x6EC2D0", Offset = "0x6EB4D0", VA = "0x1806EC2D0")]
		private void RpcReader___Server_MarkDrawingFinalized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x6EC400", Offset = "0x6EB600", VA = "0x1806EC400")]
		private void RpcWriter___Observers_SetFinalized_2166136261()
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x6EC100", Offset = "0x6EB300", VA = "0x1806EC100")]
		private void RpcLogic___SetFinalized_2166136261()
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x6EC1B0", Offset = "0x6EB3B0", VA = "0x1806EC1B0")]
		private void RpcReader___Observers_SetFinalized_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x6EAC10", Offset = "0x6E9E10", VA = "0x1806EAC10", Slot = "31")]
		protected virtual void Awake_UserLogic_ScheduleOne.Graffiti.WorldSpraySurface_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F22 RID: 7970
		[Token(Token = "0x4001F22")]
		public const int RemoveCartelGraffitiXP = 25;

		// Token: 0x04001F23 RID: 7971
		[Token(Token = "0x4001F23")]
		private const float RemoveCartelGraffitiInfluenceChange = -0.05f;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		private const float CartelInfluenceChange = -0.05f;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		[FieldOffset(Offset = "0x198")]
		[Header("Settings")]
		public string BakedGUID;

		// Token: 0x04001F2B RID: 7979
		[Token(Token = "0x4001F2B")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private float StandPointWallOffset;

		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		[FieldOffset(Offset = "0x1A8")]
		private bool NetworkInitialize___EarlyScheduleOne.Graffiti.WorldSpraySurfaceAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		[FieldOffset(Offset = "0x1A9")]
		private bool NetworkInitialize__LateScheduleOne.Graffiti.WorldSpraySurfaceAssembly-CSharp.dll_Excuted;
	}
}
