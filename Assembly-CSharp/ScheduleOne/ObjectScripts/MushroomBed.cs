using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	public class MushroomBed : GrowContainer, IConfigurable
	{
		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004683 RID: 18051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B07")]
		public ShroomColony CurrentColony
		{
			[Token(Token = "0x6004682")]
			[Address(RVA = "0x87F2B0", Offset = "0x87E4B0", VA = "0x18087F2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004683")]
			[Address(RVA = "0x8BD090", Offset = "0x8BC290", VA = "0x1808BD090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B08")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6004684")]
			[Address(RVA = "0x8BD080", Offset = "0x8BC280", VA = "0x1808BD080", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B09")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6004685")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x17000B0A")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6004686")]
			[Address(RVA = "0x56C890", Offset = "0x56BA90", VA = "0x18056C890", Slot = "125")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004688 RID: 18056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0B")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6004687")]
			[Address(RVA = "0x89E4E0", Offset = "0x89D6E0", VA = "0x18089E4E0", Slot = "126")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004688")]
			[Address(RVA = "0x8BD0B0", Offset = "0x8BC2B0", VA = "0x1808BD0B0", Slot = "127")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600468A RID: 18058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0C")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6004689")]
			[Address(RVA = "0x89E500", Offset = "0x89D700", VA = "0x18089E500", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600468A")]
			[Address(RVA = "0x8BC890", Offset = "0x8BBA90", VA = "0x1808BC890", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B0D")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600468B")]
			[Address(RVA = "0x72EFC0", Offset = "0x72E1C0", VA = "0x18072EFC0", Slot = "131")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B0E")]
		public Transform Transform
		{
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "132")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B0F")]
		public Transform UIPoint
		{
			[Token(Token = "0x600468D")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x17000B10")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600468E")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "135")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B11")]
		protected MushroomBedConfiguration _configuration
		{
			[Token(Token = "0x600468F")]
			[Address(RVA = "0x8BD080", Offset = "0x8BC280", VA = "0x1808BD080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x8BD0D0", Offset = "0x8BC2D0", VA = "0x1808BD0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004691")]
		[Address(RVA = "0x8BC3D0", Offset = "0x8BB5D0", VA = "0x1808BC3D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004692")]
		[Address(RVA = "0x8BCB60", Offset = "0x8BBD60", VA = "0x1808BCB60", Slot = "144")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004693")]
		[Address(RVA = "0x8BBAC0", Offset = "0x8BACC0", VA = "0x1808BBAC0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x8BB870", Offset = "0x8BAA70", VA = "0x1808BB870", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004695")]
		[Address(RVA = "0x8BB390", Offset = "0x8BA590", VA = "0x1808BB390", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x8BA890", Offset = "0x8B9A90", VA = "0x1808BA890", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x6004697")]
		[Address(RVA = "0x8BBBC0", Offset = "0x8BADC0", VA = "0x1808BBBC0", Slot = "105")]
		public override bool IsPointAboveGrowSurface(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004698")]
		[Address(RVA = "0x8BCDF0", Offset = "0x8BBFF0", VA = "0x1808BCDF0", Slot = "106")]
		public override void SetGrowableVisible(bool visible)
		{
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x6004699")]
		[Address(RVA = "0x8BA790", Offset = "0x8B9990", VA = "0x1808BA790", Slot = "117")]
		public override bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x600469A")]
		[Address(RVA = "0x8BB8A0", Offset = "0x8BAAA0", VA = "0x1808BB8A0", Slot = "118")]
		protected override Vector3 GetRandomPourTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x600469B")]
		[Address(RVA = "0x8BB7D0", Offset = "0x8BA9D0", VA = "0x1808BB7D0", Slot = "107")]
		public override float GetGrowSurfaceSideLength()
		{
			return 0f;
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600469C")]
		[Address(RVA = "0x8BBAB0", Offset = "0x8BACB0", VA = "0x1808BBAB0", Slot = "113")]
		protected override Material GetSoilMaterial()
		{
			return null;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600469D")]
		[Address(RVA = "0x8BCF40", Offset = "0x8BC140", VA = "0x1808BCF40", Slot = "110")]
		public override void SetSoil(SoilDefinition soil)
		{
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600469E")]
		[Address(RVA = "0x8BCE80", Offset = "0x8BC080", VA = "0x1808BCE80", Slot = "114")]
		public override void SetMoistureAmount(float amount)
		{
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x8BAC20", Offset = "0x8B9E20", VA = "0x1808BAC20")]
		public void ConfigureSoilAppearance(MushroomBed.EMushroomBedSoilAppearance appearance, [Optional] Texture2D sporeMask)
		{
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x8BBC60", Offset = "0x8BAE60", VA = "0x1808BBC60")]
		public bool IsReadyForHarvest(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x8BCCC0", Offset = "0x8BBEC0", VA = "0x1808BCCC0", Slot = "143")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x8BA240", Offset = "0x8B9440", VA = "0x1808BA240", Slot = "115")]
		protected override AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x8BC6A0", Offset = "0x8BB8A0", VA = "0x1808BC6A0")]
		public void PlayMixFXAtPoint(Vector3 point)
		{
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x8BC530", Offset = "0x8BB730", VA = "0x1808BC530", Slot = "67")]
		protected override void OnTileTemperatureChanged(Tile tile, float newTemp)
		{
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x8BAD70", Offset = "0x8B9F70", VA = "0x1808BAD70", Slot = "108")]
		public override bool ContainsGrowable()
		{
			return default(bool);
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x8BB7E0", Offset = "0x8BA9E0", VA = "0x1808BB7E0", Slot = "109")]
		public override float GetGrowthProgressNormalized()
		{
			return 0f;
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x8BADD0", Offset = "0x8B9FD0", VA = "0x1808BADD0")]
		[ServerRpc(RequireOwnership = false)]
		public void CreateAndAssignColony_Server(string shroomSpawnID)
		{
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x8BAF00", Offset = "0x8BA100", VA = "0x1808BAF00")]
		private void CreateAndAssignColony(ShroomSpawnDefinition shroomSpawn)
		{
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x8BA390", Offset = "0x8B9590", VA = "0x1808BA390")]
		public void AssignColony(ShroomColony colony)
		{
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AA")]
		[Address(RVA = "0x8BC1C0", Offset = "0x8BB3C0", VA = "0x1808BC1C0")]
		private void OnColonyFullyHarvested()
		{
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x8BAB70", Offset = "0x8B9D70", VA = "0x1808BAB70", Slot = "112")]
		protected override void ClearSoil()
		{
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x8BA990", Offset = "0x8B9B90", VA = "0x1808BA990")]
		public void CheckShowTemperatureHint()
		{
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x8BB0D0", Offset = "0x8BA2D0", VA = "0x1808BB0D0", Slot = "137")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x8BB300", Offset = "0x8BA500", VA = "0x1808BB300", Slot = "138")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x8BB460", Offset = "0x8BA660", VA = "0x1808BB460", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x8BBA00", Offset = "0x8BAC00", VA = "0x1808BBA00", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x8BBE10", Offset = "0x8BB010", VA = "0x1808BBE10", Slot = "145")]
		public virtual void Load(MushroomBedData mushroomBedData)
		{
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x8BD060", Offset = "0x8BC260", VA = "0x1808BD060")]
		public MushroomBed()
		{
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x8BBFD0", Offset = "0x8BB1D0", VA = "0x1808BBFD0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x8BBF70", Offset = "0x8BB170", VA = "0x1808BBF70", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x8BCA30", Offset = "0x8BBC30", VA = "0x1808BCA30")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x8BC890", Offset = "0x8BBA90", VA = "0x1808BC890", Slot = "146")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x8BC9B0", Offset = "0x8BBBB0", VA = "0x1808BC9B0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x8BADD0", Offset = "0x8B9FD0", VA = "0x1808BADD0")]
		private void RpcWriter___Server_CreateAndAssignColony_Server_3615296227(string shroomSpawnID)
		{
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x8BC830", Offset = "0x8BBA30", VA = "0x1808BC830")]
		public void RpcLogic___CreateAndAssignColony_Server_3615296227(string shroomSpawnID)
		{
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x8BC930", Offset = "0x8BBB30", VA = "0x1808BC930")]
		private void RpcReader___Server_CreateAndAssignColony_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B12")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x89E500", Offset = "0x89D700", VA = "0x18089E500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046BD")]
			[Address(RVA = "0x8BD0F0", Offset = "0x8BC2F0", VA = "0x1808BD0F0")]
			set
			{
			}
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x8BC770", Offset = "0x8BB970", VA = "0x1808BC770", Slot = "147")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.MushroomBed(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x8BA740", Offset = "0x8B9940", VA = "0x1808BA740", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		[Header("Mushroom Bed")]
		[SerializeField]
		private float _internalSideLength;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		[SerializeField]
		private ConfigurationReplicator _configurationReplicator;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		[SerializeField]
		private Sprite _typeIcon;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		[SerializeField]
		private MushroomBedUIElement _worldspaceUIPrefab;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		[SerializeField]
		private ParticleSystem _poofParticles;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		[SerializeField]
		private AudioSourceController _poofSound;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		[SerializeField]
		private Transform _colonyAlignment;

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		[SerializeField]
		private Transform _mixFXContainer;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		[SerializeField]
		private ParticleSystem[] _mixParticles;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		[SerializeField]
		private AudioSourceController _mixSound;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private Material _soilMaterialInstance;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private MushroomBed.EMushroomBedSoilAppearance _currentSoilAppearance;

		// Token: 0x04003238 RID: 12856
		[Token(Token = "0x4003238")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		private bool _mushroomBedColdAtLeastOnce;

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MushroomBedAssembly-CSharp.dll_Excuted;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MushroomBedAssembly-CSharp.dll_Excuted;

		// Token: 0x020009BE RID: 2494
		[Token(Token = "0x20009BE")]
		public enum EMushroomBedSoilAppearance
		{
			// Token: 0x0400323D RID: 12861
			[Token(Token = "0x400323D")]
			NoSpores,
			// Token: 0x0400323E RID: 12862
			[Token(Token = "0x400323E")]
			MaskedSpores,
			// Token: 0x0400323F RID: 12863
			[Token(Token = "0x400323F")]
			FullSpores
		}
	}
}
