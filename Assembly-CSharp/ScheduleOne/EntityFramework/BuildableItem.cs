using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EPOOutline;
using FishNet.Component.Ownership;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	[RequireComponent(typeof(PredictedSpawn))]
	public abstract class BuildableItem : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000707")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x600288E")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600288F")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000708")]
		public Property ParentProperty
		{
			[Token(Token = "0x6002890")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002891")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0000D170 File Offset: 0x0000B370
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000709")]
		public bool IsDestroyed
		{
			[Token(Token = "0x6002892")]
			[Address(RVA = "0x6302F0", Offset = "0x62F4F0", VA = "0x1806302F0", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002893")]
			[Address(RVA = "0x6303B0", Offset = "0x62F5B0", VA = "0x1806303B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0000D188 File Offset: 0x0000B388
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070A")]
		public bool Initialized
		{
			[Token(Token = "0x6002894")]
			[Address(RVA = "0x6D6C50", Offset = "0x6D5E50", VA = "0x1806D6C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002895")]
			[Address(RVA = "0x6D6D90", Offset = "0x6D5F90", VA = "0x1806D6D90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070B")]
		public Guid GUID
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x6D6C30", Offset = "0x6D5E30", VA = "0x1806D6C30", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x6D6D70", Offset = "0x6D5F70", VA = "0x1806D6D70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070C")]
		public bool IsCulled
		{
			[Token(Token = "0x6002898")]
			[Address(RVA = "0x6D6C60", Offset = "0x6D5E60", VA = "0x1806D6C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002899")]
			[Address(RVA = "0x6D6DA0", Offset = "0x6D5FA0", VA = "0x1806D6DA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700070D")]
		public GameObject BuildHandler
		{
			[Token(Token = "0x600289A")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070E")]
		protected bool _locallyBuilt
		{
			[Token(Token = "0x600289B")]
			[Address(RVA = "0x6D6D60", Offset = "0x6D5F60", VA = "0x1806D6D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600289C")]
			[Address(RVA = "0x6D6DF0", Offset = "0x6D5FF0", VA = "0x1806D6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x6D6270", Offset = "0x6D5470", VA = "0x1806D6270")]
		public void SetLocallyBuilt()
		{
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700070F")]
		public string SaveFolderName
		{
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x6D6CC0", Offset = "0x6D5EC0", VA = "0x1806D6CC0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000710")]
		public string SaveFileName
		{
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x6D6C90", Offset = "0x6D5E90", VA = "0x1806D6C90", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000711")]
		public Loader Loader
		{
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x17000712")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000713")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60028A2")]
			[Address(RVA = "0x6D6C70", Offset = "0x6D5E70", VA = "0x1806D6C70", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028A3")]
			[Address(RVA = "0x6D6DB0", Offset = "0x6D5FB0", VA = "0x1806D6DB0", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000714")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x6D6C80", Offset = "0x6D5E80", VA = "0x1806D6C80", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028A5")]
			[Address(RVA = "0x6D6DD0", Offset = "0x6D5FD0", VA = "0x1806D6DD0", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0000D200 File Offset: 0x0000B400
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000715")]
		public bool HasChanged
		{
			[Token(Token = "0x60028A6")]
			[Address(RVA = "0x6D6C40", Offset = "0x6D5E40", VA = "0x1806D6C40", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A7")]
			[Address(RVA = "0x6D6D80", Offset = "0x6D5F80", VA = "0x1806D6D80", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x6D2A70", Offset = "0x6D1C70", VA = "0x1806D2A70", Slot = "47")]
		public virtual void Awake()
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x6D68D0", Offset = "0x6D5AD0", VA = "0x1806D68D0", Slot = "48")]
		protected virtual void Start()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x6D4A50", Offset = "0x6D3C50", VA = "0x1806D4A50", Slot = "49")]
		protected virtual Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x6D30D0", Offset = "0x6D22D0", VA = "0x1806D30D0", Slot = "50")]
		public virtual string GetManagementName()
		{
			return null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x6D3070", Offset = "0x6D2270", VA = "0x1806D3070", Slot = "51")]
		public virtual string GetDefaultManagementName()
		{
			return null;
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x6D55D0", Offset = "0x6D47D0", VA = "0x1806D55D0", Slot = "52")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x6D57A0", Offset = "0x6D49A0", VA = "0x1806D57A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x6D5800", Offset = "0x6D4A00", VA = "0x1806D5800", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060028B0 RID: 10416
		[Token(Token = "0x60028B0")]
		protected abstract void SendInitializationToClient(NetworkConnection conn);

		// Token: 0x060028B1 RID: 10417
		[Token(Token = "0x60028B1")]
		protected abstract void SendInitializationToServer();

		// Token: 0x060028B2 RID: 10418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x6D50D0", Offset = "0x6D42D0", VA = "0x1806D50D0")]
		protected void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x6D2B70", Offset = "0x6D1D70", VA = "0x1806D2B70")]
		public bool CanBePickedUp(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x6D2B20", Offset = "0x6D1D20", VA = "0x1806D2B20", Slot = "55")]
		public virtual bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x6D5890", Offset = "0x6D4A90", VA = "0x1806D5890")]
		public void PickupItem()
		{
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x6D2EA0", Offset = "0x6D20A0", VA = "0x1806D2EA0", Slot = "56")]
		protected virtual void Destroy()
		{
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x6D2D90", Offset = "0x6D1F90", VA = "0x1806D2D90")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void Destroy_Server()
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x6D2C60", Offset = "0x6D1E60", VA = "0x1806D2C60")]
		[ObserversRpc(RunLocally = true)]
		private void Destroy_Client()
		{
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x6D6200", Offset = "0x6D5400", VA = "0x1806D6200", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x6D3010", Offset = "0x6D2210", VA = "0x1806D3010")]
		private static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			return default(Color32);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x6D6360", Offset = "0x6D5560", VA = "0x1806D6360", Slot = "57")]
		public virtual void ShowOutline(Color color)
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x6D6280", Offset = "0x6D5480", VA = "0x1806D6280")]
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x6D5010", Offset = "0x6D4210", VA = "0x1806D5010", Slot = "58")]
		public virtual void HideOutline()
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0000D260 File Offset: 0x0000B460
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x6D30F0", Offset = "0x6D22F0", VA = "0x1806D30F0")]
		public bool GetPenetration(out float x, out float z, out float y)
		{
			return default(bool);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x6D4BF0", Offset = "0x6D3DF0", VA = "0x1806D4BF0")]
		private bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x6D5FF0", Offset = "0x6D51F0", VA = "0x1806D5FF0", Slot = "59")]
		public virtual void SetCulled(bool culled)
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x6D4B40", Offset = "0x6D3D40", VA = "0x1806D4B40", Slot = "60")]
		public virtual DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x6D2F90", Offset = "0x6D2190", VA = "0x1806D2F90", Slot = "61")]
		public virtual BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x6D4BB0", Offset = "0x6D3DB0", VA = "0x1806D4BB0", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x6D6AC0", Offset = "0x6D5CC0", VA = "0x1806D6AC0", Slot = "62")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x6D6B20", Offset = "0x6D5D20", VA = "0x1806D6B20")]
		protected BuildableItem()
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x6D6A50", Offset = "0x6D5C50", VA = "0x1806D6A50")]
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|74_0()
		{
			return null;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x6D56C0", Offset = "0x6D48C0", VA = "0x1806D56C0", Slot = "63")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x6D56A0", Offset = "0x6D48A0", VA = "0x1806D56A0", Slot = "64")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x6D5EE0", Offset = "0x6D50E0", VA = "0x1806D5EE0")]
		private void RpcWriter___Server_Destroy_Server_2166136261()
		{
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x6D5BA0", Offset = "0x6D4DA0", VA = "0x1806D5BA0")]
		private void RpcLogic___Destroy_Server_2166136261()
		{
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x6D5D70", Offset = "0x6D4F70", VA = "0x1806D5D70")]
		private void RpcReader___Server_Destroy_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x6D5DC0", Offset = "0x6D4FC0", VA = "0x1806D5DC0")]
		private void RpcWriter___Observers_Destroy_Client_2166136261()
		{
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x6D5B80", Offset = "0x6D4D80", VA = "0x1806D5B80")]
		private void RpcLogic___Destroy_Client_2166136261()
		{
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x6D5D20", Offset = "0x6D4F20", VA = "0x1806D5D20")]
		private void RpcReader___Observers_Destroy_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x6D29F0", Offset = "0x6D1BF0", VA = "0x1806D29F0", Slot = "65")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.BuildableItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		[HideInInspector]
		public bool isGhost;

		// Token: 0x04001F37 RID: 7991
		[Token(Token = "0x4001F37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Header("Build Settings")]
		[SerializeField]
		protected GameObject buildHandler;

		// Token: 0x04001F38 RID: 7992
		[Token(Token = "0x4001F38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float HoldDistance;

		// Token: 0x04001F39 RID: 7993
		[Token(Token = "0x4001F39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Transform BuildPoint;

		// Token: 0x04001F3A RID: 7994
		[Token(Token = "0x4001F3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Transform MidAirCenterPoint;

		// Token: 0x04001F3B RID: 7995
		[Token(Token = "0x4001F3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public BoxCollider BoundingCollider;

		// Token: 0x04001F3C RID: 7996
		[Token(Token = "0x4001F3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Header("Outline settings")]
		protected List<GameObject> OutlineRenderers;

		// Token: 0x04001F3D RID: 7997
		[Token(Token = "0x4001F3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected bool IncludeOutlineRendererChildren;

		// Token: 0x04001F3E RID: 7998
		[Token(Token = "0x4001F3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		protected Outlinable OutlineEffect;

		// Token: 0x04001F3F RID: 7999
		[Token(Token = "0x4001F3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Header("Culling Settings")]
		public GameObject[] GameObjectsToCull;

		// Token: 0x04001F40 RID: 8000
		[Token(Token = "0x4001F40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public List<MeshRenderer> MeshesToCull;

		// Token: 0x04001F41 RID: 8001
		[Token(Token = "0x4001F41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Header("Buildable Events")]
		public UnityEvent onGhostModel;

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UnityEvent onInitialized;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UnityEvent onDestroyed;

		// Token: 0x04001F44 RID: 8004
		[Token(Token = "0x4001F44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Action<BuildableItem> onDestroyedWithParameter;

		// Token: 0x04001F49 RID: 8009
		[Token(Token = "0x4001F49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F4A RID: 8010
		[Token(Token = "0x4001F4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted;

		// Token: 0x02000658 RID: 1624
		[Token(Token = "0x2000658")]
		public enum EOutlineColor
		{
			// Token: 0x04001F4C RID: 8012
			[Token(Token = "0x4001F4C")]
			White,
			// Token: 0x04001F4D RID: 8013
			[Token(Token = "0x4001F4D")]
			Blue,
			// Token: 0x04001F4E RID: 8014
			[Token(Token = "0x4001F4E")]
			LightBlue
		}
	}
}
