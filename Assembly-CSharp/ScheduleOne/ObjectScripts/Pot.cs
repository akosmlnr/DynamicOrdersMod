using System;
using System.Runtime.CompilerServices;
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
	// Token: 0x020009C2 RID: 2498
	[Token(Token = "0x20009C2")]
	public class Pot : GrowContainer, IConfigurable
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B15")]
		public Plant Plant
		{
			[Token(Token = "0x60046CC")]
			[Address(RVA = "0x8C4040", Offset = "0x8C3240", VA = "0x1808C4040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046CD")]
			[Address(RVA = "0x8C4050", Offset = "0x8C3250", VA = "0x1808C4050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B16")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x89E4C0", Offset = "0x89D6C0", VA = "0x18089E4C0", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B17")]
		protected PotConfiguration potConfiguration
		{
			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x89E4C0", Offset = "0x89D6C0", VA = "0x18089E4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046D0")]
			[Address(RVA = "0x89E6A0", Offset = "0x89D8A0", VA = "0x18089E6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B18")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60046D1")]
			[Address(RVA = "0x87F2E0", Offset = "0x87E4E0", VA = "0x18087F2E0", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x17000B19")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60046D2")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "125")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1A")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x6F2D10", Offset = "0x6F1F10", VA = "0x1806F2D10", Slot = "126")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x89E680", Offset = "0x89D880", VA = "0x18089E680", Slot = "127")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1B")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x8C2100", Offset = "0x8C1300", VA = "0x1808C2100", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x8C3770", Offset = "0x8C2970", VA = "0x1808C3770", Slot = "143")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B1C")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60046D8")]
			[Address(RVA = "0x8BBAB0", Offset = "0x8BACB0", VA = "0x1808BBAB0", Slot = "131")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B1D")]
		public Transform Transform
		{
			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "132")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B1E")]
		public Transform UIPoint
		{
			[Token(Token = "0x60046DA")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x17000B1F")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60046DB")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "135")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x8BF780", Offset = "0x8BE980", VA = "0x1808BF780", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x8C3F80", Offset = "0x8C3180", VA = "0x1808C3F80", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x8C12A0", Offset = "0x8C04A0", VA = "0x1808C12A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x8C3610", Offset = "0x8C2810", VA = "0x1808C3610", Slot = "144")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x8C0470", Offset = "0x8BF670", VA = "0x1808C0470", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x8977E0", Offset = "0x8969E0", VA = "0x1808977E0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x8C0220", Offset = "0x8BF420", VA = "0x1808C0220", Slot = "51")]
		public override string GetDefaultManagementName()
		{
			return null;
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x8BFDE0", Offset = "0x8BEFE0", VA = "0x1808BFDE0", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x8C0800", Offset = "0x8BFA00", VA = "0x1808C0800", Slot = "145")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E5")]
		[Address(RVA = "0x8C0800", Offset = "0x8BFA00", VA = "0x1808C0800")]
		private void UpdateRotation()
		{
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x8C1010", Offset = "0x8C0210", VA = "0x1808C1010", Slot = "103")]
		protected override void OnMinPass()
		{
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x8C1550", Offset = "0x8C0750", VA = "0x1808C1550", Slot = "104")]
		protected override void OnTimeSkipped(int minsSkipped)
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x8BF7D0", Offset = "0x8BE9D0", VA = "0x1808BF7D0")]
		public bool CanAcceptSeed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x8C0650", Offset = "0x8BF850", VA = "0x1808C0650")]
		public bool IsReadyForHarvest(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x8BF9C0", Offset = "0x8BEBC0", VA = "0x1808BF9C0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x8C1620", Offset = "0x8C0820", VA = "0x1808C1620")]
		public void OverrideRotation(float angle)
		{
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x8BF610", Offset = "0x8BE810", VA = "0x1808BF610", Slot = "115")]
		protected override AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x8BF8C0", Offset = "0x8BEAC0", VA = "0x1808BF8C0", Slot = "117")]
		public override bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x8C0570", Offset = "0x8BF770", VA = "0x1808C0570", Slot = "105")]
		public override bool IsPointAboveGrowSurface(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x8C38A0", Offset = "0x8C2AA0", VA = "0x1808C38A0", Slot = "106")]
		public override void SetGrowableVisible(bool visible)
		{
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x8C02D0", Offset = "0x8BF4D0", VA = "0x1808C02D0", Slot = "118")]
		protected override Vector3 GetRandomPourTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x60046F1")]
		[Address(RVA = "0x8C0230", Offset = "0x8BF430", VA = "0x1808C0230", Slot = "107")]
		public override float GetGrowSurfaceSideLength()
		{
			return 0f;
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x88D210", Offset = "0x88C410", VA = "0x18088D210", Slot = "116")]
		public override float GetTemperatureGrowthMultiplier()
		{
			return 0f;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x8BFAC0", Offset = "0x8BECC0", VA = "0x1808BFAC0", Slot = "108")]
		public override bool ContainsGrowable()
		{
			return default(bool);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x8C0240", Offset = "0x8BF440", VA = "0x1808C0240", Slot = "109")]
		public override float GetGrowthProgressNormalized()
		{
			return 0f;
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F5")]
		[Address(RVA = "0x8C3D60", Offset = "0x8C2F60", VA = "0x1808C3D60")]
		public void SetSoilState(Pot.ESoilState state)
		{
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x8C18E0", Offset = "0x8C0AE0", VA = "0x1808C18E0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void PlantSeed_Server(string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x8C1630", Offset = "0x8C0830", VA = "0x1808C1630")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void PlantSeed_Client(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x8C3090", Offset = "0x8C2290", VA = "0x1808C3090")]
		[ServerRpc(RequireOwnership = false)]
		public void SetGrowthProgress_Server(float progress)
		{
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x8C2B30", Offset = "0x8C1D30", VA = "0x1808C2B30")]
		[ObserversRpc]
		private void SetGrowthProgress_Client(float progress)
		{
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x8C3BF0", Offset = "0x8C2DF0", VA = "0x1808C3BF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetHarvestableActive_Server(int harvestableIndex, bool active)
		{
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x8C3930", Offset = "0x8C2B30", VA = "0x1808C3930")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetHarvestableActive_Client(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x8C10B0", Offset = "0x8C02B0", VA = "0x1808C10B0")]
		private void OnPlantFullyHarvested()
		{
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x8BFB20", Offset = "0x8BED20", VA = "0x1808BFB20", Slot = "137")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x8BFD50", Offset = "0x8BEF50", VA = "0x1808BFD50", Slot = "138")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x8BFEB0", Offset = "0x8BF0B0", VA = "0x1808BFEB0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004700")]
		[Address(RVA = "0x8C03C0", Offset = "0x8BF5C0", VA = "0x1808C03C0", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004701")]
		[Address(RVA = "0x8C0AB0", Offset = "0x8BFCB0", VA = "0x1808C0AB0", Slot = "146")]
		public virtual void Load(PotData potData)
		{
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004702")]
		[Address(RVA = "0x8C09B0", Offset = "0x8BFBB0", VA = "0x1808C09B0")]
		private void LoadPlant(PlantData data)
		{
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004703")]
		[Address(RVA = "0x8C4010", Offset = "0x8C3210", VA = "0x1808C4010")]
		public Pot()
		{
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004704")]
		[Address(RVA = "0x8C0C30", Offset = "0x8BFE30", VA = "0x1808C0C30", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x8C0BD0", Offset = "0x8BFDD0", VA = "0x1808C0BD0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004706")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004707")]
		[Address(RVA = "0x8C2F60", Offset = "0x8C2160", VA = "0x1808C2F60")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004708")]
		[Address(RVA = "0x8C2100", Offset = "0x8C1300", VA = "0x1808C2100", Slot = "147")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x8C26E0", Offset = "0x8C18E0", VA = "0x1808C26E0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x8C2E00", Offset = "0x8C2000", VA = "0x1808C2E00")]
		private void RpcWriter___Server_PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470B")]
		[Address(RVA = "0x8C20E0", Offset = "0x8C12E0", VA = "0x1808C20E0")]
		public void RpcLogic___PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x8C2640", Offset = "0x8C1840", VA = "0x1808C2640")]
		private void RpcReader___Server_PlantSeed_Server_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x8C29C0", Offset = "0x8C1BC0", VA = "0x1808C29C0")]
		private void RpcWriter___Observers_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x8C1B00", Offset = "0x8C0D00", VA = "0x1808C1B00")]
		private void RpcLogic___PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x8C23E0", Offset = "0x8C15E0", VA = "0x1808C23E0")]
		private void RpcReader___Observers_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004710")]
		[Address(RVA = "0x8C3340", Offset = "0x8C2540", VA = "0x1808C3340")]
		private void RpcWriter___Target_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x8C2890", Offset = "0x8C1A90", VA = "0x1808C2890")]
		private void RpcReader___Target_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x8C3090", Offset = "0x8C2290", VA = "0x1808C3090")]
		private void RpcWriter___Server_SetGrowthProgress_Server_431000436(float progress)
		{
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x8C2290", Offset = "0x8C1490", VA = "0x1808C2290")]
		public void RpcLogic___SetGrowthProgress_Server_431000436(float progress)
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x8C2760", Offset = "0x8C1960", VA = "0x1808C2760")]
		private void RpcReader___Server_SetGrowthProgress_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x8C2B30", Offset = "0x8C1D30", VA = "0x1808C2B30")]
		private void RpcWriter___Observers_SetGrowthProgress_Client_431000436(float progress)
		{
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x8C21A0", Offset = "0x8C13A0", VA = "0x1808C21A0")]
		private void RpcLogic___SetGrowthProgress_Client_431000436(float progress)
		{
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x8C2470", Offset = "0x8C1670", VA = "0x1808C2470")]
		private void RpcReader___Observers_SetGrowthProgress_Client_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x8C31D0", Offset = "0x8C23D0", VA = "0x1808C31D0")]
		private void RpcWriter___Server_SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x8C23C0", Offset = "0x8C15C0", VA = "0x1808C23C0")]
		public void RpcLogic___SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x8C27C0", Offset = "0x8C19C0", VA = "0x1808C27C0")]
		private void RpcReader___Server_SetHarvestableActive_Server_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x8C2C80", Offset = "0x8C1E80", VA = "0x1808C2C80")]
		private void RpcWriter___Observers_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x8C22A0", Offset = "0x8C14A0", VA = "0x1808C22A0")]
		private void RpcLogic___SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471D")]
		[Address(RVA = "0x8C2580", Offset = "0x8C1780", VA = "0x1808C2580")]
		private void RpcReader___Observers_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471E")]
		[Address(RVA = "0x8C34A0", Offset = "0x8C26A0", VA = "0x1808C34A0")]
		private void RpcWriter___Target_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471F")]
		[Address(RVA = "0x8C2910", Offset = "0x8C1B10", VA = "0x1808C2910")]
		private void RpcReader___Target_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B20")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6004720")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004721")]
			[Address(RVA = "0x8C4070", Offset = "0x8C3270", VA = "0x1808C4070")]
			set
			{
			}
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x6004722")]
		[Address(RVA = "0x8C1A40", Offset = "0x8C0C40", VA = "0x1808C1A40", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004723")]
		[Address(RVA = "0x8BF750", Offset = "0x8BE950", VA = "0x1808BF750", Slot = "149")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Pot_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		public const float MaxWarmthGrowthMultiplier = 1.5f;

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		public const float WarmthMinThreshold = 20f;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		public const float WarmthMaxThreshold = 40f;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		public const float RotationSpeed = 10f;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x328")]
		[Header("References")]
		public Transform ModelTransform;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x330")]
		public Transform SeedStartPoint;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x338")]
		public Transform SeedRestingPoint;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x340")]
		public Transform LookAtPoint;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x348")]
		public Transform PlantContainer;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[FieldOffset(Offset = "0x350")]
		public Transform TaskBounds;

		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		[FieldOffset(Offset = "0x358")]
		public Transform LeafDropPoint;

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x360")]
		public ParticleSystem PoofParticles;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0x368")]
		public AudioSourceController PoofSound;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x370")]
		public ConfigurationReplicator ConfigurationReplicator;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		[FieldOffset(Offset = "0x378")]
		public Transform Dirt_Flat;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		[FieldOffset(Offset = "0x380")]
		public Transform Dirt_Parted;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		[FieldOffset(Offset = "0x388")]
		public SoilChunk[] SoilChunks;

		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		[FieldOffset(Offset = "0x390")]
		[Header("UI")]
		public PotUIElement WorldspaceUIPrefab;

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		[FieldOffset(Offset = "0x398")]
		public Sprite typeIcon;

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[FieldOffset(Offset = "0x3A0")]
		[Header("Pot Settings")]
		public float PotRadius;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		[FieldOffset(Offset = "0x3A4")]
		[Range(0.2f, 2f)]
		public float YieldMultiplier;

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[FieldOffset(Offset = "0x3A8")]
		[Range(0.2f, 2f)]
		public float GrowSpeedMultiplier;

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[FieldOffset(Offset = "0x3D0")]
		private float rotation;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[FieldOffset(Offset = "0x3D4")]
		private bool rotationOverridden;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[FieldOffset(Offset = "0x3D8")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[FieldOffset(Offset = "0x3E0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[FieldOffset(Offset = "0x3E1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted;

		// Token: 0x020009C3 RID: 2499
		[Token(Token = "0x20009C3")]
		public enum ESoilState
		{
			// Token: 0x04003267 RID: 12903
			[Token(Token = "0x4003267")]
			Flat,
			// Token: 0x04003268 RID: 12904
			[Token(Token = "0x4003268")]
			Parted,
			// Token: 0x04003269 RID: 12905
			[Token(Token = "0x4003269")]
			Packed
		}
	}
}
