using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	public class CartelInfluence : NetworkBehaviour
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x796F10", Offset = "0x796110", VA = "0x180796F10")]
		public CartelInfluence.RegionInfluenceData[] GetAllRegionInfluence()
		{
			return null;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x796AF0", Offset = "0x795CF0", VA = "0x180796AF0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x7971E0", Offset = "0x7963E0", VA = "0x1807971E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x797350", Offset = "0x796550", VA = "0x180797350", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x796DB0", Offset = "0x795FB0", VA = "0x180796DB0")]
		[ServerRpc(RequireOwnership = false)]
		public void ChangeInfluence(EMapRegion region, float amount)
		{
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x798290", Offset = "0x797490", VA = "0x180798290")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetInfluence(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x796F60", Offset = "0x796160", VA = "0x180796F60")]
		public float GetInfluence(EMapRegion region)
		{
			return 0f;
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343E")]
		[Address(RVA = "0x796C10", Offset = "0x795E10", VA = "0x180796C10")]
		[ObserversRpc(RunLocally = true)]
		private void ChangeInfluence(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600343F")]
		[Address(RVA = "0x796F90", Offset = "0x796190", VA = "0x180796F90")]
		private CartelInfluence.RegionInfluenceData GetRegionData(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x798540", Offset = "0x797740", VA = "0x180798540")]
		public CartelInfluence()
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x797080", Offset = "0x796280", VA = "0x180797080", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003442")]
		[Address(RVA = "0x797060", Offset = "0x796260", VA = "0x180797060", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003443")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003444")]
		[Address(RVA = "0x796DB0", Offset = "0x795FB0", VA = "0x180796DB0")]
		private void RpcWriter___Server_ChangeInfluence_2792544924(EMapRegion region, float amount)
		{
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x797950", Offset = "0x796B50", VA = "0x180797950")]
		public void RpcLogic___ChangeInfluence_2792544924(EMapRegion region, float amount)
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x797D50", Offset = "0x796F50", VA = "0x180797D50")]
		private void RpcReader___Server_ChangeInfluence_2792544924(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x797FC0", Offset = "0x7971C0", VA = "0x180797FC0")]
		private void RpcWriter___Observers_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x797B20", Offset = "0x796D20", VA = "0x180797B20")]
		public void RpcLogic___SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x797CC0", Offset = "0x796EC0", VA = "0x180797CC0")]
		private void RpcReader___Observers_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344A")]
		[Address(RVA = "0x798130", Offset = "0x797330", VA = "0x180798130")]
		private void RpcWriter___Target_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x797DC0", Offset = "0x796FC0", VA = "0x180797DC0")]
		private void RpcReader___Target_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x797E40", Offset = "0x797040", VA = "0x180797E40")]
		private void RpcWriter___Observers_ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x797730", Offset = "0x796930", VA = "0x180797730")]
		private void RpcLogic___ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x797C20", Offset = "0x796E20", VA = "0x180797C20")]
		private void RpcReader___Observers_ChangeInfluence_1267088319(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x796A00", Offset = "0x795C00", VA = "0x180796A00")]
		private void Awake_UserLogic_ScheduleOne.Cartel.CartelInfluence_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002622 RID: 9762
		[Token(Token = "0x4002622")]
		public const float INFLUENCE_TO_UNLOCK_NEXT_REGION = 0.3f;

		// Token: 0x04002623 RID: 9763
		[Token(Token = "0x4002623")]
		public const float WESTVILLE_MAX_INFLUENCE = 0.5f;

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x118")]
		[Header("Settings")]
		public CartelInfluence.RegionInfluenceData[] DefaultRegionInfluence;

		// Token: 0x04002625 RID: 9765
		[Token(Token = "0x4002625")]
		[FieldOffset(Offset = "0x120")]
		private List<CartelInfluence.RegionInfluenceData> regionInfluence;

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x128")]
		public Action<EMapRegion, float, float> OnInfluenceChanged;

		// Token: 0x04002627 RID: 9767
		[Token(Token = "0x4002627")]
		[FieldOffset(Offset = "0x130")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted;

		// Token: 0x04002628 RID: 9768
		[Token(Token = "0x4002628")]
		[FieldOffset(Offset = "0x131")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted;

		// Token: 0x020007A2 RID: 1954
		[Token(Token = "0x20007A2")]
		[Serializable]
		public class RegionInfluenceData
		{
			// Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003450")]
			[Address(RVA = "0x79D580", Offset = "0x79C780", VA = "0x18079D580")]
			public RegionInfluenceData(EMapRegion region, float influence = 0f)
			{
			}

			// Token: 0x04002629 RID: 9769
			[Token(Token = "0x4002629")]
			[FieldOffset(Offset = "0x10")]
			private string name;

			// Token: 0x0400262A RID: 9770
			[Token(Token = "0x400262A")]
			[FieldOffset(Offset = "0x18")]
			public EMapRegion Region;

			// Token: 0x0400262B RID: 9771
			[Token(Token = "0x400262B")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			public float Influence;
		}
	}
}
