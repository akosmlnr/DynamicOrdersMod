using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	[RequireComponent(typeof(NetworkTransform))]
	public class ShroomColony : NetworkBehaviour
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x000113A0 File Offset: 0x0000F5A0
		// (set) Token: 0x06003B58 RID: 15192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000949")]
		public int BaseShroomYield
		{
			[Token(Token = "0x6003B57")]
			[Address(RVA = "0x5219B0", Offset = "0x520BB0", VA = "0x1805219B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003B58")]
			[Address(RVA = "0x77EBC0", Offset = "0x77DDC0", VA = "0x18077EBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x000113B8 File Offset: 0x0000F5B8
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094A")]
		public float GrowthProgress
		{
			[Token(Token = "0x6003B59")]
			[Address(RVA = "0x511800", Offset = "0x510A00", VA = "0x180511800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0x7C9870", Offset = "0x7C8A70", VA = "0x1807C9870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x000113D0 File Offset: 0x0000F5D0
		[Token(Token = "0x1700094B")]
		public bool IsFullyGrown
		{
			[Token(Token = "0x6003B5B")]
			[Address(RVA = "0x81D950", Offset = "0x81CB50", VA = "0x18081D950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[Token(Token = "0x1700094C")]
		public bool IsTooHotToGrow
		{
			[Token(Token = "0x6003B5C")]
			[Address(RVA = "0x81D970", Offset = "0x81CB70", VA = "0x18081D970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x00011400 File Offset: 0x0000F600
		[Token(Token = "0x1700094D")]
		public int GrownMushroomCount
		{
			[Token(Token = "0x6003B5D")]
			[Address(RVA = "0x81D910", Offset = "0x81CB10", VA = "0x18081D910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700094E")]
		public AudioSourceController SnipSound
		{
			[Token(Token = "0x6003B5E")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x00011418 File Offset: 0x0000F618
		// (set) Token: 0x06003B60 RID: 15200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700094F")]
		public float NormalizedQuality
		{
			[Token(Token = "0x6003B5F")]
			[Address(RVA = "0x81DA00", Offset = "0x81CC00", VA = "0x18081DA00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003B60")]
			[Address(RVA = "0x81DA10", Offset = "0x81CC10", VA = "0x18081DA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x81B640", Offset = "0x81A840", VA = "0x18081B640", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x81B920", Offset = "0x81AB20", VA = "0x18081B920", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x81B320", Offset = "0x81A520", VA = "0x18081B320")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x81B550", Offset = "0x81A750", VA = "0x18081B550")]
		private void OnMinPass()
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x81BBE0", Offset = "0x81ADE0", VA = "0x18081BBE0")]
		private void OnTimeSkipped(int mins)
		{
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x81D290", Offset = "0x81C490", VA = "0x18081D290")]
		public void SetColonyVisible(bool visible)
		{
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00011430 File Offset: 0x0000F630
		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x81ABE0", Offset = "0x819DE0", VA = "0x18081ABE0")]
		private float GetCurrentGrowthRate()
		{
			return 0f;
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x81ABA0", Offset = "0x819DA0", VA = "0x18081ABA0")]
		private void ChangeGrowthPercentage(float change)
		{
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x81CEA0", Offset = "0x81C0A0", VA = "0x18081CEA0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetFullyGrown()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x81D2E0", Offset = "0x81C4E0", VA = "0x18081D2E0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetGrowthPercentage_Local(NetworkConnection conn, float percent)
		{
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x81D550", Offset = "0x81C750", VA = "0x18081D550")]
		private void SetGrowthPercentage(float percent)
		{
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x81ABB0", Offset = "0x819DB0", VA = "0x18081ABB0")]
		private void ChangeQuality(float change)
		{
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6D")]
		[Address(RVA = "0x81A460", Offset = "0x819660", VA = "0x18081A460")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddShroomAtPosition_Server(int alignmentIndex)
		{
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6E")]
		[Address(RVA = "0x81A310", Offset = "0x819510", VA = "0x18081A310")]
		[ObserversRpc(RunLocally = true)]
		private void AddShroomAtPosition_Local(int alignmentIndex)
		{
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B6F")]
		[Address(RVA = "0x81A5A0", Offset = "0x8197A0", VA = "0x18081A5A0")]
		private void AddShroomAtPosition(int alignmentIndex)
		{
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x81BEA0", Offset = "0x81B0A0", VA = "0x18081BEA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void RemoveShroom_Server(int alignmentIndex)
		{
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x81BCA0", Offset = "0x81AEA0", VA = "0x18081BCA0")]
		public void RemoveRandomShroom()
		{
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x81BD50", Offset = "0x81AF50", VA = "0x18081BD50")]
		[ObserversRpc(RunLocally = true)]
		private void RemoveShoom_Client(int alignmentIndex)
		{
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x81C1A0", Offset = "0x81B3A0", VA = "0x18081C1A0")]
		private void RemoveShroom(int alignmentIndex)
		{
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x81BFE0", Offset = "0x81B1E0", VA = "0x18081BFE0")]
		private void RemoveShroom(GrowingMushroom shroom)
		{
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x81D2C0", Offset = "0x81C4C0", VA = "0x18081D2C0")]
		public void SetFullyHarvested()
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x81AD50", Offset = "0x819F50", VA = "0x18081AD50")]
		private int GetRandomAvailableAlignmentIndex()
		{
			return 0;
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x81AC40", Offset = "0x819E40", VA = "0x18081AC40")]
		public ShroomInstance GetHarvestedShroom(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x81AA80", Offset = "0x819C80", VA = "0x18081AA80")]
		public void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication)
		{
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x81CFB0", Offset = "0x81C1B0", VA = "0x18081CFB0")]
		[TargetRpc]
		public void SetColonyState(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x81AED0", Offset = "0x81A0D0", VA = "0x18081AED0")]
		public ShroomColonyData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x81AFF0", Offset = "0x81A1F0", VA = "0x18081AFF0")]
		public void Load(ShroomColonyData data)
		{
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x81D7D0", Offset = "0x81C9D0", VA = "0x18081D7D0")]
		public ShroomColony()
		{
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7D")]
		[Address(RVA = "0x81B0B0", Offset = "0x81A2B0", VA = "0x18081B0B0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x81B090", Offset = "0x81A290", VA = "0x18081B090", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x81CEA0", Offset = "0x81C0A0", VA = "0x18081CEA0")]
		private void RpcWriter___Server_SetFullyGrown_2166136261()
		{
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x81C430", Offset = "0x81B630", VA = "0x18081C430")]
		public void RpcLogic___SetFullyGrown_2166136261()
		{
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x81C6B0", Offset = "0x81B8B0", VA = "0x18081C6B0")]
		private void RpcReader___Server_SetFullyGrown_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x81CAD0", Offset = "0x81BCD0", VA = "0x18081CAD0")]
		private void RpcWriter___Observers_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x81C450", Offset = "0x81B650", VA = "0x18081C450")]
		private void RpcLogic___SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x81C540", Offset = "0x81B740", VA = "0x18081C540")]
		private void RpcReader___Observers_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x81D130", Offset = "0x81C330", VA = "0x18081D130")]
		private void RpcWriter___Target_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x81C7D0", Offset = "0x81B9D0", VA = "0x18081C7D0")]
		private void RpcReader___Target_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x81CC20", Offset = "0x81BE20", VA = "0x18081CC20")]
		private void RpcWriter___Server_AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x81C370", Offset = "0x81B570", VA = "0x18081C370")]
		public void RpcLogic___AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x81C5B0", Offset = "0x81B7B0", VA = "0x18081C5B0")]
		private void RpcReader___Server_AddShroomAtPosition_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x81C830", Offset = "0x81BA30", VA = "0x18081C830")]
		private void RpcWriter___Observers_AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x81C360", Offset = "0x81B560", VA = "0x18081C360")]
		private void RpcLogic___AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x81C460", Offset = "0x81B660", VA = "0x18081C460")]
		private void RpcReader___Observers_AddShroomAtPosition_Local_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x81CD60", Offset = "0x81BF60", VA = "0x18081CD60")]
		private void RpcWriter___Server_RemoveShroom_Server_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x81BD50", Offset = "0x81AF50", VA = "0x18081BD50")]
		public void RpcLogic___RemoveShroom_Server_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x81C630", Offset = "0x81B830", VA = "0x18081C630")]
		private void RpcReader___Server_RemoveShroom_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x81C980", Offset = "0x81BB80", VA = "0x18081C980")]
		private void RpcWriter___Observers_RemoveShoom_Client_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x81C380", Offset = "0x81B580", VA = "0x18081C380")]
		private void RpcLogic___RemoveShoom_Client_3316948804(int alignmentIndex)
		{
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x81C4D0", Offset = "0x81B6D0", VA = "0x18081C4D0")]
		private void RpcReader___Observers_RemoveShoom_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x81CFB0", Offset = "0x81C1B0", VA = "0x18081CFB0")]
		private void RpcWriter___Target_SetColonyState_4288818029(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x81C390", Offset = "0x81B590", VA = "0x18081C390")]
		public void RpcLogic___SetColonyState_4288818029(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality)
		{
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x81C6F0", Offset = "0x81B8F0", VA = "0x18081C6F0")]
		private void RpcReader___Target_SetColonyState_4288818029(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		public const float MaxTemperatureForGrowth = 15f;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		private const float MinSoilMoistureForGrowth = 0.0001f;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		private const float RandomRotationRange = 15f;

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		private const float RandomVerticalShift = 0.02f;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ShroomSpawnDefinition _spawnDefinition;

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private int _growTime;

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Transform[] _shroomAlignments;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GrowingMushroom[] _growingShroomPrefabs;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private AudioSourceController _snipSound;

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private ParticleSystem _fullyGrownParticles;

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0x158")]
		public Action onFullyHarvested;

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		[FieldOffset(Offset = "0x160")]
		private List<GrowingMushroom> _growingShrooms;

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<GrowingMushroom, int> _growingShroomPositions;

		// Token: 0x04002BF0 RID: 11248
		[Token(Token = "0x4002BF0")]
		[FieldOffset(Offset = "0x170")]
		private List<int> _takenAlignmentIndices;

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		[FieldOffset(Offset = "0x178")]
		private MushroomBed _parentBed;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x180")]
		private bool _shroomsInitiallySpawned;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize___EarlyScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x182")]
		private bool NetworkInitialize__LateScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted;
	}
}
