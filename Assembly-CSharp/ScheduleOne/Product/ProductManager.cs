using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Effects;
using ScheduleOne.Effects.MixMaps;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.StationFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x0200091B RID: 2331
	[Token(Token = "0x200091B")]
	public class ProductManager : NetworkSingleton<ProductManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x170009C9")]
		public static bool MethDiscovered
		{
			[Token(Token = "0x6003E44")]
			[Address(RVA = "0x84CCF0", Offset = "0x84BEF0", VA = "0x18084CCF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x170009CA")]
		public static bool CocaineDiscovered
		{
			[Token(Token = "0x6003E45")]
			[Address(RVA = "0x84CB00", Offset = "0x84BD00", VA = "0x18084CB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x170009CB")]
		public static bool ShroomsDiscovered
		{
			[Token(Token = "0x6003E46")]
			[Address(RVA = "0x84CE90", Offset = "0x84C090", VA = "0x18084CE90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CC")]
		public static bool IsAcceptingOrders
		{
			[Token(Token = "0x6003E47")]
			[Address(RVA = "0x84CC60", Offset = "0x84BE60", VA = "0x18084CC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E48")]
			[Address(RVA = "0x84D010", Offset = "0x84C210", VA = "0x18084D010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003E4A RID: 15946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CD")]
		public NewMixOperation CurrentMixOperation
		{
			[Token(Token = "0x6003E49")]
			[Address(RVA = "0x84CC40", Offset = "0x84BE40", VA = "0x18084CC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E4A")]
			[Address(RVA = "0x84CFE0", Offset = "0x84C1E0", VA = "0x18084CFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x170009CE")]
		public bool IsMixingInProgress
		{
			[Token(Token = "0x6003E4B")]
			[Address(RVA = "0x84CCC0", Offset = "0x84BEC0", VA = "0x18084CCC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x00011E20 File Offset: 0x00010020
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CF")]
		public bool IsMixComplete
		{
			[Token(Token = "0x6003E4C")]
			[Address(RVA = "0x84CCB0", Offset = "0x84BEB0", VA = "0x18084CCB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E4D")]
			[Address(RVA = "0x84D070", Offset = "0x84C270", VA = "0x18084D070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x00011E38 File Offset: 0x00010038
		// (set) Token: 0x06003E4F RID: 15951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D0")]
		public float TimeSinceProductListingChanged
		{
			[Token(Token = "0x6003E4E")]
			[Address(RVA = "0x84CFD0", Offset = "0x84C1D0", VA = "0x18084CFD0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003E4F")]
			[Address(RVA = "0x84D0A0", Offset = "0x84C2A0", VA = "0x18084D0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x83FC00", Offset = "0x83EE00", VA = "0x18083FC00")]
		public bool HasSentProductDataToConnection(NetworkConnection conn)
		{
			return default(bool);
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009D1")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003E51")]
			[Address(RVA = "0x84CE60", Offset = "0x84C060", VA = "0x18084CE60", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009D2")]
		public string SaveFileName
		{
			[Token(Token = "0x6003E52")]
			[Address(RVA = "0x84CE30", Offset = "0x84C030", VA = "0x18084CE30", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009D3")]
		public Loader Loader
		{
			[Token(Token = "0x6003E53")]
			[Address(RVA = "0x66B670", Offset = "0x66A870", VA = "0x18066B670", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x170009D4")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003E54")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06003E55 RID: 15957 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003E56 RID: 15958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D5")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003E55")]
			[Address(RVA = "0x84CCE0", Offset = "0x84BEE0", VA = "0x18084CCE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E56")]
			[Address(RVA = "0x84D080", Offset = "0x84C280", VA = "0x18084D080", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003E58 RID: 15960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003E57")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E58")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x00011E80 File Offset: 0x00010080
		// (set) Token: 0x06003E5A RID: 15962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D7")]
		public bool HasChanged
		{
			[Token(Token = "0x6003E59")]
			[Address(RVA = "0x84CC50", Offset = "0x84BE50", VA = "0x18084CC50", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E5A")]
			[Address(RVA = "0x84D000", Offset = "0x84C200", VA = "0x18084D000", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06003E5B RID: 15963 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x170009D8")]
		public int LoadOrder
		{
			[Token(Token = "0x6003E5B")]
			[Address(RVA = "0x84CCD0", Offset = "0x84BED0", VA = "0x18084CCD0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x83ADA0", Offset = "0x839FA0", VA = "0x18083ADA0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x84BC10", Offset = "0x84AE10", VA = "0x18084BC10", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x841940", Offset = "0x840B40", VA = "0x180841940", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x841920", Offset = "0x840B20", VA = "0x180841920", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x84C620", Offset = "0x84B820", VA = "0x18084C620")]
		private void Update()
		{
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x83B9B0", Offset = "0x83ABB0", VA = "0x18083B9B0")]
		private void Clean()
		{
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x84AB00", Offset = "0x849D00", VA = "0x18084AB00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetMethDiscovered()
		{
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x84A960", Offset = "0x849B60", VA = "0x18084A960")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetCocaineDiscovered()
		{
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x84BB00", Offset = "0x84AD00", VA = "0x18084BB00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetShroomsDiscovered()
		{
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x841B40", Offset = "0x840D40", VA = "0x180841B40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void RecordContractReceipt(NetworkConnection conn, ContractReceipt receipt)
		{
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x83DA50", Offset = "0x83CC50", VA = "0x18083DA50")]
		public List<ContractReceipt> GetContractReceipts(EMapRegion region, List<EContractParty> dealCompleterTypes, int maxMinsAgo)
		{
			return null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x83FC60", Offset = "0x83EE60", VA = "0x18083FC60", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x83DF50", Offset = "0x83D150", VA = "0x18083DF50")]
		public MixerMap GetMixerMap(EDrugType type)
		{
			return null;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x840C30", Offset = "0x83FE30", VA = "0x180840C30", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0x840A10", Offset = "0x83FC10", VA = "0x180840A10")]
		private void OnMinPass()
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x840BE0", Offset = "0x83FDE0", VA = "0x180840BE0")]
		private void OnNewDay()
		{
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0x84B9A0", Offset = "0x84ABA0", VA = "0x18084B9A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductListed(string productID, bool listed)
		{
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6D")]
		[Address(RVA = "0x84B700", Offset = "0x84A900", VA = "0x18084B700")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetProductListed(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6E")]
		[Address(RVA = "0x84B5A0", Offset = "0x84A7A0", VA = "0x18084B5A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductFavourited(string productID, bool listed)
		{
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E6F")]
		[Address(RVA = "0x84B300", Offset = "0x84A500", VA = "0x18084B300")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductFavourited(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E70")]
		[Address(RVA = "0x83D190", Offset = "0x83C390", VA = "0x18083D190")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DiscoverProduct(string productID)
		{
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x84B060", Offset = "0x84A260", VA = "0x18084B060")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductDiscovered(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E72")]
		[Address(RVA = "0x84AA70", Offset = "0x849C70", VA = "0x18084AA70")]
		public void SetIsAcceptingOrder(bool accepting)
		{
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x83CCA0", Offset = "0x83BEA0", VA = "0x18083CCA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateWeed_Server(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x83CE60", Offset = "0x83C060", VA = "0x18083CE60")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateWeed(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x83BB00", Offset = "0x83AD00", VA = "0x18083BB00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateCocaine_Server(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x83BCC0", Offset = "0x83AEC0", VA = "0x18083BCC0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateCocaine(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x83BFF0", Offset = "0x83B1F0", VA = "0x18083BFF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateMeth_Server(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x83C1B0", Offset = "0x83B3B0", VA = "0x18083C1B0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateMeth(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x83CAE0", Offset = "0x83BCE0", VA = "0x18083CAE0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateShroom_Server(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x83C7B0", Offset = "0x83B9B0", VA = "0x18083C7B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void CreateShroom_Client(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x841DA0", Offset = "0x840FA0", VA = "0x180841DA0")]
		private void RefreshHighestValueProduct()
		{
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x84A680", Offset = "0x849880", VA = "0x18084A680")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixRecipe(string product, string mixer, string output)
		{
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x83C4E0", Offset = "0x83B6E0", VA = "0x18083C4E0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateMixRecipe(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x83E210", Offset = "0x83D410", VA = "0x18083E210")]
		public StationRecipe GetRecipe(string product, string mixer)
		{
			return null;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x83E310", Offset = "0x83D510", VA = "0x18083E310")]
		public StationRecipe GetRecipe(List<Effect> productProperties, Effect mixerProperty)
		{
			return null;
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E80")]
		[Address(RVA = "0x83DD10", Offset = "0x83CF10", VA = "0x18083DD10")]
		public ProductDefinition GetKnownProduct(EDrugType type, List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x83E070", Offset = "0x83D270", VA = "0x18083E070")]
		public float GetPrice(ProductDefinition product)
		{
			return 0f;
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x84A800", Offset = "0x849A00", VA = "0x18084A800")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPrice(string productID, float value)
		{
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x84ADB0", Offset = "0x849FB0", VA = "0x18084ADB0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetPrice(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x84A530", Offset = "0x849730", VA = "0x18084A530")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixOperation(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x84AC10", Offset = "0x849E10", VA = "0x18084AC10")]
		[ObserversRpc(RunLocally = true)]
		private void SetMixOperation(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x83D480", Offset = "0x83C680", VA = "0x18083D480")]
		public string FinishAndNameMix(string productID, string ingredientID, string mixName)
		{
			return null;
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x83FD30", Offset = "0x83EF30", VA = "0x18083FD30")]
		public static string MakeIDFileSafe(string id)
		{
			return null;
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00011EC8 File Offset: 0x000100C8
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x83FCF0", Offset = "0x83EEF0", VA = "0x18083FCF0")]
		public static bool IsMixNameValid(string mixName)
		{
			return default(bool);
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x83D2D0", Offset = "0x83C4D0", VA = "0x18083D2D0")]
		[ObserversRpc(RunLocally = true)]
		private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x848AE0", Offset = "0x847CE0", VA = "0x180848AE0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x6003E8B")]
		[Address(RVA = "0x83AE20", Offset = "0x83A020", VA = "0x18083AE20")]
		public static float CalculateProductValue(ProductDefinition product, float baseValue)
		{
			return 0f;
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x6003E8C")]
		[Address(RVA = "0x83AFE0", Offset = "0x83A1E0", VA = "0x18083AFE0")]
		public static float CalculateProductValue(float baseValue, List<Effect> properties)
		{
			return 0f;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x83B160", Offset = "0x83A360", VA = "0x18083B160")]
		public static void CheckDiscovery(ItemInstance item)
		{
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x83E790", Offset = "0x83D990", VA = "0x18083E790", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x84C790", Offset = "0x84B990", VA = "0x18084C790")]
		public ProductManager()
		{
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E91")]
		[Address(RVA = "0x840030", Offset = "0x83F230", VA = "0x180840030", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x83FFE0", Offset = "0x83F1E0", VA = "0x18083FFE0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x849180", Offset = "0x848380", VA = "0x180849180")]
		private void RpcWriter___Server_SetMethDiscovered_2166136261()
		{
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x8449A0", Offset = "0x843BA0", VA = "0x1808449A0")]
		public void RpcLogic___SetMethDiscovered_2166136261()
		{
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x846900", Offset = "0x845B00", VA = "0x180846900")]
		private void RpcReader___Server_SetMethDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E97")]
		[Address(RVA = "0x849070", Offset = "0x848270", VA = "0x180849070")]
		private void RpcWriter___Server_SetCocaineDiscovered_2166136261()
		{
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E98")]
		[Address(RVA = "0x844910", Offset = "0x843B10", VA = "0x180844910")]
		public void RpcLogic___SetCocaineDiscovered_2166136261()
		{
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E99")]
		[Address(RVA = "0x8468B0", Offset = "0x845AB0", VA = "0x1808468B0")]
		private void RpcReader___Server_SetCocaineDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x849550", Offset = "0x848750", VA = "0x180849550")]
		private void RpcWriter___Server_SetShroomsDiscovered_2166136261()
		{
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0x845900", Offset = "0x844B00", VA = "0x180845900")]
		public void RpcLogic___SetShroomsDiscovered_2166136261()
		{
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9C")]
		[Address(RVA = "0x846AD0", Offset = "0x845CD0", VA = "0x180846AD0")]
		private void RpcReader___Server_SetShroomsDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9D")]
		[Address(RVA = "0x847B40", Offset = "0x846D40", VA = "0x180847B40")]
		private void RpcWriter___Observers_RecordContractReceipt_691682765(NetworkConnection conn, ContractReceipt receipt)
		{
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9E")]
		[Address(RVA = "0x8446C0", Offset = "0x8438C0", VA = "0x1808446C0")]
		public void RpcLogic___RecordContractReceipt_691682765(NetworkConnection conn, ContractReceipt receipt)
		{
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E9F")]
		[Address(RVA = "0x845E30", Offset = "0x845030", VA = "0x180845E30")]
		private void RpcReader___Observers_RecordContractReceipt_691682765(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA0")]
		[Address(RVA = "0x849E50", Offset = "0x849050", VA = "0x180849E50")]
		private void RpcWriter___Target_RecordContractReceipt_691682765(NetworkConnection conn, ContractReceipt receipt)
		{
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA1")]
		[Address(RVA = "0x846F00", Offset = "0x846100", VA = "0x180846F00")]
		private void RpcReader___Target_RecordContractReceipt_691682765(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA2")]
		[Address(RVA = "0x8493F0", Offset = "0x8485F0", VA = "0x1808493F0")]
		private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA3")]
		[Address(RVA = "0x8452C0", Offset = "0x8444C0", VA = "0x1808452C0")]
		public void RpcLogic___SetProductListed_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x846A10", Offset = "0x845C10", VA = "0x180846A10")]
		private void RpcReader___Server_SetProductListed_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x848240", Offset = "0x847440", VA = "0x180848240")]
		private void RpcWriter___Observers_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x8452E0", Offset = "0x8444E0", VA = "0x1808452E0")]
		public void RpcLogic___SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x846120", Offset = "0x845320", VA = "0x180846120")]
		private void RpcReader___Observers_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA8")]
		[Address(RVA = "0x84A3D0", Offset = "0x8495D0", VA = "0x18084A3D0")]
		private void RpcWriter___Target_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x847120", Offset = "0x846320", VA = "0x180847120")]
		private void RpcReader___Target_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0x849290", Offset = "0x848490", VA = "0x180849290")]
		private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0x844EF0", Offset = "0x8440F0", VA = "0x180844EF0")]
		public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x846950", Offset = "0x845B50", VA = "0x180846950")]
		private void RpcReader___Server_SetProductFavourited_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAD")]
		[Address(RVA = "0x8480D0", Offset = "0x8472D0", VA = "0x1808480D0")]
		private void RpcWriter___Observers_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAE")]
		[Address(RVA = "0x844F10", Offset = "0x844110", VA = "0x180844F10")]
		public void RpcLogic___SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x846070", Offset = "0x845270", VA = "0x180846070")]
		private void RpcReader___Observers_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x84A270", Offset = "0x849470", VA = "0x18084A270")]
		private void RpcWriter___Target_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x847080", Offset = "0x846280", VA = "0x180847080")]
		private void RpcReader___Target_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x8489B0", Offset = "0x847BB0", VA = "0x1808489B0")]
		private void RpcWriter___Server_DiscoverProduct_3615296227(string productID)
		{
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x844010", Offset = "0x843210", VA = "0x180844010")]
		public void RpcLogic___DiscoverProduct_3615296227(string productID)
		{
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x846550", Offset = "0x845750", VA = "0x180846550")]
		private void RpcReader___Server_DiscoverProduct_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x847F60", Offset = "0x847160", VA = "0x180847F60")]
		private void RpcWriter___Observers_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x844C30", Offset = "0x843E30", VA = "0x180844C30")]
		public void RpcLogic___SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB7")]
		[Address(RVA = "0x845FC0", Offset = "0x8451C0", VA = "0x180845FC0")]
		private void RpcReader___Observers_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB8")]
		[Address(RVA = "0x84A110", Offset = "0x849310", VA = "0x18084A110")]
		private void RpcWriter___Target_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x846FE0", Offset = "0x8461E0", VA = "0x180846FE0")]
		private void RpcReader___Target_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBA")]
		[Address(RVA = "0x848830", Offset = "0x847A30", VA = "0x180848830")]
		private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBB")]
		[Address(RVA = "0x843FD0", Offset = "0x8431D0", VA = "0x180843FD0")]
		public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBC")]
		[Address(RVA = "0x846470", Offset = "0x845670", VA = "0x180846470")]
		private void RpcReader___Server_CreateWeed_Server_2331775230(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBD")]
		[Address(RVA = "0x849CB0", Offset = "0x848EB0", VA = "0x180849CB0")]
		private void RpcWriter___Target_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBE")]
		[Address(RVA = "0x843B70", Offset = "0x842D70", VA = "0x180843B70")]
		private void RpcLogic___CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x846E30", Offset = "0x846030", VA = "0x180846E30")]
		private void RpcReader___Target_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC0")]
		[Address(RVA = "0x847820", Offset = "0x846A20", VA = "0x180847820")]
		private void RpcWriter___Observers_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC1")]
		[Address(RVA = "0x845CA0", Offset = "0x844EA0", VA = "0x180845CA0")]
		private void RpcReader___Observers_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC2")]
		[Address(RVA = "0x8483B0", Offset = "0x8475B0", VA = "0x1808483B0")]
		private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC3")]
		[Address(RVA = "0x8425D0", Offset = "0x8417D0", VA = "0x1808425D0")]
		public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x8461D0", Offset = "0x8453D0", VA = "0x1808461D0")]
		private void RpcReader___Server_CreateCocaine_Server_891166717(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x849660", Offset = "0x848860", VA = "0x180849660")]
		private void RpcWriter___Target_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x842030", Offset = "0x841230", VA = "0x180842030")]
		private void RpcLogic___CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x846B20", Offset = "0x845D20", VA = "0x180846B20")]
		private void RpcReader___Target_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x8471C0", Offset = "0x8463C0", VA = "0x1808471C0")]
		private void RpcWriter___Observers_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x845990", Offset = "0x844B90", VA = "0x180845990")]
		private void RpcReader___Observers_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x848530", Offset = "0x847730", VA = "0x180848530")]
		private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x842BB0", Offset = "0x841DB0", VA = "0x180842BB0")]
		public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECC")]
		[Address(RVA = "0x8462B0", Offset = "0x8454B0", VA = "0x1808462B0")]
		private void RpcReader___Server_CreateMeth_Server_4251728555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECD")]
		[Address(RVA = "0x849800", Offset = "0x848A00", VA = "0x180849800")]
		private void RpcWriter___Target_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECE")]
		[Address(RVA = "0x842610", Offset = "0x841810", VA = "0x180842610")]
		private void RpcLogic___CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECF")]
		[Address(RVA = "0x846BF0", Offset = "0x845DF0", VA = "0x180846BF0")]
		private void RpcReader___Target_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED0")]
		[Address(RVA = "0x847360", Offset = "0x846560", VA = "0x180847360")]
		private void RpcWriter___Observers_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x845A60", Offset = "0x844C60", VA = "0x180845A60")]
		private void RpcReader___Observers_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED2")]
		[Address(RVA = "0x8486B0", Offset = "0x8478B0", VA = "0x1808486B0")]
		private void RpcWriter___Server_CreateShroom_Server_2261384965(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x843B30", Offset = "0x842D30", VA = "0x180843B30")]
		public void RpcLogic___CreateShroom_Server_2261384965(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED4")]
		[Address(RVA = "0x846390", Offset = "0x845590", VA = "0x180846390")]
		private void RpcReader___Server_CreateShroom_Server_2261384965(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED5")]
		[Address(RVA = "0x849B10", Offset = "0x848D10", VA = "0x180849B10")]
		private void RpcWriter___Target_CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x843670", Offset = "0x842870", VA = "0x180843670")]
		private void RpcLogic___CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x846D60", Offset = "0x845F60", VA = "0x180846D60")]
		private void RpcReader___Target_CreateShroom_Client_812995776(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x847680", Offset = "0x846880", VA = "0x180847680")]
		private void RpcWriter___Observers_CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance)
		{
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x845BD0", Offset = "0x844DD0", VA = "0x180845BD0")]
		private void RpcReader___Observers_CreateShroom_Client_812995776(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x848DB0", Offset = "0x847FB0", VA = "0x180848DB0")]
		private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x8448C0", Offset = "0x843AC0", VA = "0x1808448C0")]
		public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x846750", Offset = "0x845950", VA = "0x180846750")]
		private void RpcReader___Server_SendMixRecipe_852232071(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x8499A0", Offset = "0x848BA0", VA = "0x1808499A0")]
		private void RpcWriter___Target_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x842BF0", Offset = "0x841DF0", VA = "0x180842BF0")]
		public void RpcLogic___CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x846CC0", Offset = "0x845EC0", VA = "0x180846CC0")]
		private void RpcReader___Target_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x847500", Offset = "0x846700", VA = "0x180847500")]
		private void RpcWriter___Observers_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x845B30", Offset = "0x844D30", VA = "0x180845B30")]
		private void RpcReader___Observers_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x848F10", Offset = "0x848110", VA = "0x180848F10")]
		private void RpcWriter___Server_SendPrice_606697822(string productID, float value)
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x8448F0", Offset = "0x843AF0", VA = "0x1808448F0")]
		public void RpcLogic___SendPrice_606697822(string productID, float value)
		{
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x846810", Offset = "0x845A10", VA = "0x180846810")]
		private void RpcReader___Server_SendPrice_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x847DF0", Offset = "0x846FF0", VA = "0x180847DF0")]
		private void RpcWriter___Observers_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		public void RpcLogic___SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x845F30", Offset = "0x845130", VA = "0x180845F30")]
		private void RpcReader___Observers_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x849FB0", Offset = "0x8491B0", VA = "0x180849FB0")]
		private void RpcWriter___Target_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x846F60", Offset = "0x846160", VA = "0x180846F60")]
		private void RpcReader___Target_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x848C50", Offset = "0x847E50", VA = "0x180848C50")]
		private void RpcWriter___Server_SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x8448B0", Offset = "0x843AB0", VA = "0x1808448B0")]
		public void RpcLogic___SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x8466A0", Offset = "0x8458A0", VA = "0x1808466A0")]
		private void RpcReader___Server_SendMixOperation_3670976965(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x847C80", Offset = "0x846E80", VA = "0x180847C80")]
		private void RpcWriter___Observers_SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x844A30", Offset = "0x843C30", VA = "0x180844A30")]
		private void RpcLogic___SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x845E90", Offset = "0x845090", VA = "0x180845E90")]
		private void RpcReader___Observers_SetMixOperation_3670976965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x8479C0", Offset = "0x846BC0", VA = "0x1808479C0")]
		private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x844030", Offset = "0x843230", VA = "0x180844030")]
		private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x845D70", Offset = "0x844F70", VA = "0x180845D70")]
		private void RpcReader___Observers_FinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x848AE0", Offset = "0x847CE0", VA = "0x180848AE0")]
		private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x844840", Offset = "0x843A40", VA = "0x180844840")]
		private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x8465D0", Offset = "0x8457D0", VA = "0x1808465D0")]
		private void RpcReader___Server_SendFinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x83AD50", Offset = "0x839F50", VA = "0x18083AD50", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Product.ProductManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		public const int MIN_PRICE = 1;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		public const int MAX_PRICE = 999;

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		public const int CONTRACT_RECEIPT_MAX_COUNT = 500;

		// Token: 0x04002DA2 RID: 11682
		[Token(Token = "0x4002DA2")]
		public const int STAGGERED_REPLICATIONS_PER_SECOND = 80;

		// Token: 0x04002DA3 RID: 11683
		[Token(Token = "0x4002DA3")]
		[FieldOffset(Offset = "0x120")]
		public Action<ProductDefinition> onProductDiscovered;

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x0")]
		public static List<ProductDefinition> DiscoveredProducts;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x8")]
		public static List<ProductDefinition> ListedProducts;

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x10")]
		public static List<ProductDefinition> FavouritedProducts;

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x128")]
		public List<ProductDefinition> AllProducts;

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0x130")]
		public List<ProductDefinition> DefaultKnownProducts;

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x138")]
		public List<PropertyItemDefinition> ValidMixIngredients;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x140")]
		public List<ContractReceipt> ContractReceipts;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x148")]
		public AnimationCurve SampleSuccessCurve;

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x150")]
		public ProductDefinition[] ListForSaleOnStart;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[FieldOffset(Offset = "0x158")]
		[Header("Default Products")]
		public WeedDefinition DefaultWeed;

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0x160")]
		public CocaineDefinition DefaultCocaine;

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0x168")]
		public MethDefinition DefaultMeth;

		// Token: 0x04002DB1 RID: 11697
		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x170")]
		public ShroomDefinition DefaultShroom;

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x178")]
		[Header("Mix Maps")]
		public MixerMap WeedMixMap;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x180")]
		public MixerMap MethMixMap;

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x188")]
		public MixerMap CokeMixMap;

		// Token: 0x04002DB5 RID: 11701
		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x190")]
		public MixerMap ShroomMixMap;

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x198")]
		private List<ProductDefinition> createdProducts;

		// Token: 0x04002DBA RID: 11706
		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x1B0")]
		public Action<NewMixOperation> onMixCompleted;

		// Token: 0x04002DBB RID: 11707
		[Token(Token = "0x4002DBB")]
		[FieldOffset(Offset = "0x1B8")]
		public Action<ProductDefinition> onNewProductCreated;

		// Token: 0x04002DBC RID: 11708
		[Token(Token = "0x4002DBC")]
		[FieldOffset(Offset = "0x1C0")]
		public Action<ProductDefinition> onProductListed;

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		[FieldOffset(Offset = "0x1C8")]
		public Action<ProductDefinition> onProductDelisted;

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x1D0")]
		public Action<ProductDefinition> onProductFavourited;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x1D8")]
		public Action<ProductDefinition> onProductUnfavourited;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x1E0")]
		public Action<ContractReceipt> onContractReceiptRecorded;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x1E8")]
		public UnityEvent onFirstSampleRejection;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x1F0")]
		public UnityEvent onSecondUniqueProductCreated;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x1F8")]
		public List<string> ProductNames;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x200")]
		private List<StationRecipe> mixRecipes;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x208")]
		public Action<StationRecipe> onMixRecipeAdded;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x210")]
		private Dictionary<ProductDefinition, float> ProductPrices;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x218")]
		private ProductDefinition highestValueProduct;

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x220")]
		private List<NetworkConnection> productDataSentTo;

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x228")]
		public Action<NetworkConnection> onProductDataSentToConnection;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x230")]
		private ProductManagerLoader loader;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x250")]
		private bool NetworkInitialize___EarlyScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002DD0 RID: 11728
		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x251")]
		private bool NetworkInitialize__LateScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted;
	}
}
