using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	public abstract class GrowContainer : GridItem, IUsable, ITransitEntity
	{
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x00011058 File Offset: 0x0000F258
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000921")]
		public float SoilCapacity
		{
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x803780", Offset = "0x802980", VA = "0x180803780")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x803920", Offset = "0x802B20", VA = "0x180803920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00011070 File Offset: 0x0000F270
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000922")]
		public float MoistureCapacity
		{
			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x8036D0", Offset = "0x8028D0", VA = "0x1808036D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A73")]
			[Address(RVA = "0x803850", Offset = "0x802A50", VA = "0x180803850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00011088 File Offset: 0x0000F288
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000923")]
		public bool HidePlantDuringPourTasks
		{
			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x803610", Offset = "0x802810", VA = "0x180803610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x803810", Offset = "0x802A10", VA = "0x180803810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000924")]
		public Transform SoilContainer
		{
			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000925")]
		public Transform PourableStartPoint
		{
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x803900", Offset = "0x802B00", VA = "0x180803900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000926")]
		public GrowContainerSurfaceCover SurfaceCover
		{
			[Token(Token = "0x6003A7A")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A7B")]
			[Address(RVA = "0x66BD40", Offset = "0x66AF40", VA = "0x18066BD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000927")]
		public GrowContainerCameraHandler CameraHandler
		{
			[Token(Token = "0x6003A7C")]
			[Address(RVA = "0x8035F0", Offset = "0x8027F0", VA = "0x1808035F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A7D")]
			[Address(RVA = "0x8037D0", Offset = "0x8029D0", VA = "0x1808037D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000928")]
		public TemperatureDisplay TemperatureDisplay
		{
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A7F")]
			[Address(RVA = "0x803950", Offset = "0x802B50", VA = "0x180803950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Token(Token = "0x17000929")]
		public float NormalizedSoilAmount
		{
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x803740", Offset = "0x802940", VA = "0x180803740")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x000110B8 File Offset: 0x0000F2B8
		[Token(Token = "0x1700092A")]
		public bool IsFullyFilledWithSoil
		{
			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x803640", Offset = "0x802840", VA = "0x180803640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Token(Token = "0x1700092B")]
		public float NormalizedMoistureAmount
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x803720", Offset = "0x802920", VA = "0x180803720")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092C")]
		public SoilDefinition CurrentSoil
		{
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x8037F0", Offset = "0x8029F0", VA = "0x1808037F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092D")]
		public List<AdditiveDefinition> AppliedAdditives
		{
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x8037B0", Offset = "0x8029B0", VA = "0x1808037B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A88 RID: 14984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092E")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6003A87")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A88")]
			[Address(RVA = "0x8010E0", Offset = "0x8002E0", VA = "0x1808010E0", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700092F")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A8A")]
			[Address(RVA = "0x803860", Offset = "0x802A60", VA = "0x180803860", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003A8B RID: 14987 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000930")]
		public string Name
		{
			[Token(Token = "0x6003A8B")]
			[Address(RVA = "0x8036F0", Offset = "0x8028F0", VA = "0x1808036F0", Slot = "81")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000931")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6003A8C")]
			[Address(RVA = "0x803620", Offset = "0x802820", VA = "0x180803620", Slot = "82")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A8D")]
			[Address(RVA = "0x803820", Offset = "0x802A20", VA = "0x180803820", Slot = "83")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003A8F RID: 14991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000932")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6003A8E")]
			[Address(RVA = "0x66B560", Offset = "0x66A760", VA = "0x18066B560", Slot = "84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x66BDB0", Offset = "0x66AFB0", VA = "0x18066BDB0", Slot = "85")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06003A90 RID: 14992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000933")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6003A90")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "86")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000934")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6003A91")]
			[Address(RVA = "0x66B650", Offset = "0x66A850", VA = "0x18066B650", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x17000935")]
		public bool Selectable
		{
			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x803770", Offset = "0x802970", VA = "0x180803770", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00011100 File Offset: 0x0000F300
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000936")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6003A93")]
			[Address(RVA = "0x803630", Offset = "0x802830", VA = "0x180803630", Slot = "89")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x803840", Offset = "0x802A40", VA = "0x180803840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A95")]
		[Address(RVA = "0x7FF2F0", Offset = "0x7FE4F0", VA = "0x1807FF2F0")]
		public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState)
		{
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A96")]
		[Address(RVA = "0x7FF340", Offset = "0x7FE540", VA = "0x1807FF340")]
		public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, Vector3 labelPosition)
		{
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A97")]
		[Address(RVA = "0x7FED80", Offset = "0x7FDF80", VA = "0x1807FED80", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x7FFA80", Offset = "0x7FEC80", VA = "0x1807FFA80", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x7FF9D0", Offset = "0x7FEBD0", VA = "0x1807FF9D0")]
		private void HeatmapVisibilityChanged(Property property, bool visible)
		{
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x7FF390", Offset = "0x7FE590", VA = "0x1807FF390", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x8008E0", Offset = "0x7FFAE0", VA = "0x1808008E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x800800", Offset = "0x7FFA00", VA = "0x180800800", Slot = "103")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x800AF0", Offset = "0x7FFCF0", VA = "0x180800AF0", Slot = "104")]
		protected virtual void OnTimeSkipped(int minsSkipped)
		{
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x7FF6C0", Offset = "0x7FE8C0", VA = "0x1807FF6C0")]
		private void DrainMoisture(int minutes)
		{
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x00011118 File Offset: 0x0000F318
		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x7FF700", Offset = "0x7FE900", VA = "0x1807FF700")]
		public float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			return 0f;
		}

		// Token: 0x06003AA0 RID: 15008
		[Token(Token = "0x6003AA0")]
		public abstract bool IsPointAboveGrowSurface(Vector3 point);

		// Token: 0x06003AA1 RID: 15009
		[Token(Token = "0x6003AA1")]
		public abstract void SetGrowableVisible(bool visible);

		// Token: 0x06003AA2 RID: 15010
		[Token(Token = "0x6003AA2")]
		public abstract float GetGrowSurfaceSideLength();

		// Token: 0x06003AA3 RID: 15011
		[Token(Token = "0x6003AA3")]
		public abstract bool ContainsGrowable();

		// Token: 0x06003AA4 RID: 15012
		[Token(Token = "0x6003AA4")]
		public abstract float GetGrowthProgressNormalized();

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x8030E0", Offset = "0x8022E0", VA = "0x1808030E0", Slot = "110")]
		public virtual void SetSoil(SoilDefinition soil)
		{
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x7FEFB0", Offset = "0x7FE1B0", VA = "0x1807FEFB0")]
		public void ChangeSoilAmount(float amount)
		{
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA7")]
		[Address(RVA = "0x802E20", Offset = "0x802020", VA = "0x180802E20")]
		public void SetSoilAmount(float amount)
		{
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x802E10", Offset = "0x802010", VA = "0x180802E10")]
		public void SetRemainingSoilUses(int uses)
		{
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x803260", Offset = "0x802460", VA = "0x180803260")]
		public void SyncSoilData()
		{
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAA")]
		[Address(RVA = "0x802380", Offset = "0x801580", VA = "0x180802380")]
		[ServerRpc(RequireOwnership = false)]
		private void SetSoilData_Server(string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x802E60", Offset = "0x802060", VA = "0x180802E60")]
		[ObserversRpc]
		[TargetRpc]
		private void SetSoilData_Client(NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x800E60", Offset = "0x800060", VA = "0x180800E60", Slot = "111")]
		protected virtual void RefreshSoilVisuals()
		{
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x7FF1E0", Offset = "0x7FE3E0", VA = "0x1807FF1E0", Slot = "112")]
		protected virtual void ClearSoil()
		{
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00011130 File Offset: 0x0000F330
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x800070", Offset = "0x7FF270", VA = "0x180800070")]
		public bool IsSoilAllowed(SoilDefinition soil)
		{
			return default(bool);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x7FF900", Offset = "0x7FEB00", VA = "0x1807FF900", Slot = "113")]
		protected virtual Material GetSoilMaterial()
		{
			return null;
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x7FEF90", Offset = "0x7FE190", VA = "0x1807FEF90")]
		public void ChangeMoistureAmount(float amount)
		{
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x802930", Offset = "0x801B30", VA = "0x180802930", Slot = "114")]
		public virtual void SetMoistureAmount(float amount)
		{
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB2")]
		[Address(RVA = "0x803120", Offset = "0x802320", VA = "0x180803120")]
		public void SyncMoistureData()
		{
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x801FE0", Offset = "0x8011E0", VA = "0x180801FE0")]
		[ServerRpc(RequireOwnership = false)]
		private void SetMoistureData_Server(float amount)
		{
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB4")]
		[Address(RVA = "0x802970", Offset = "0x801B70", VA = "0x180802970")]
		[TargetRpc]
		[ObserversRpc]
		private void SetMoistureData_Client(NetworkConnection conn, float amount)
		{
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x7FE8A0", Offset = "0x7FDAA0", VA = "0x1807FE8A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ApplyAdditive_Server(string additiveID)
		{
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x7FE600", Offset = "0x7FD800", VA = "0x1807FE600")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ApplyAdditive_Client(NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003AB7")]
		[Address(RVA = "0x7FE9E0", Offset = "0x7FDBE0", VA = "0x1807FE9E0", Slot = "115")]
		protected virtual AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x00011148 File Offset: 0x0000F348
		[Token(Token = "0x6003AB8")]
		[Address(RVA = "0x7FF9C0", Offset = "0x7FEBC0", VA = "0x1807FF9C0", Slot = "116")]
		public virtual float GetTemperatureGrowthMultiplier()
		{
			return 0f;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00011160 File Offset: 0x0000F360
		[Token(Token = "0x6003AB9")]
		[Address(RVA = "0x7FFF60", Offset = "0x7FF160", VA = "0x1807FFF60")]
		public bool IsAdditiveApplied(string additiveID)
		{
			return default(bool);
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ABA")]
		[Address(RVA = "0x7FF000", Offset = "0x7FE200", VA = "0x1807FF000")]
		protected void ClearAdditives()
		{
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x00011178 File Offset: 0x0000F378
		[Token(Token = "0x6003ABB")]
		[Address(RVA = "0x7FEE30", Offset = "0x7FE030", VA = "0x1807FEE30", Slot = "117")]
		public virtual bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x802DD0", Offset = "0x801FD0", VA = "0x180802DD0")]
		public void SetPourTargetActive(bool active)
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x800B80", Offset = "0x7FFD80", VA = "0x180800B80")]
		public void RandomizePourTargetPosition()
		{
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00011190 File Offset: 0x0000F390
		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x7FF8C0", Offset = "0x7FEAC0", VA = "0x1807FF8C0")]
		public Vector3 GetCurrentTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003ABF RID: 15039
		[Token(Token = "0x6003ABF")]
		protected abstract Vector3 GetRandomPourTargetPosition();

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x802CA0", Offset = "0x801EA0", VA = "0x180802CA0", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x802B70", Offset = "0x801D70", VA = "0x180802B70", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x800140", Offset = "0x7FF340", VA = "0x180800140")]
		protected void Load(GrowContainerData data)
		{
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC3")]
		[Address(RVA = "0x803460", Offset = "0x802660", VA = "0x180803460")]
		protected GrowContainer()
		{
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x800300", Offset = "0x7FF500", VA = "0x180800300", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x800290", Offset = "0x7FF490", VA = "0x180800290", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x802380", Offset = "0x801580", VA = "0x180802380")]
		private void RpcWriter___Server_SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x801420", Offset = "0x800620", VA = "0x180801420")]
		private void RpcLogic___SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x8017F0", Offset = "0x8009F0", VA = "0x1808017F0")]
		private void RpcReader___Server_SetSoilData_Server_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x801D20", Offset = "0x800F20", VA = "0x180801D20")]
		private void RpcWriter___Observers_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x801360", Offset = "0x800560", VA = "0x180801360")]
		private void RpcLogic___SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x801560", Offset = "0x800760", VA = "0x180801560")]
		private void RpcReader___Observers_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x8027B0", Offset = "0x8019B0", VA = "0x1808027B0")]
		private void RpcWriter___Target_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x8019B0", Offset = "0x800BB0", VA = "0x1808019B0")]
		private void RpcReader___Target_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x801FE0", Offset = "0x8011E0", VA = "0x180801FE0")]
		private void RpcWriter___Server_SetMoistureData_Server_431000436(float amount)
		{
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x8010D0", Offset = "0x8002D0", VA = "0x1808010D0")]
		private void RpcLogic___SetMoistureData_Server_431000436(float amount)
		{
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x801690", Offset = "0x800890", VA = "0x180801690")]
		private void RpcReader___Server_SetMoistureData_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x801BD0", Offset = "0x800DD0", VA = "0x180801BD0")]
		private void RpcWriter___Observers_SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x8010B0", Offset = "0x8002B0", VA = "0x1808010B0")]
		private void RpcLogic___SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x801500", Offset = "0x800700", VA = "0x180801500")]
		private void RpcReader___Observers_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x802650", Offset = "0x801850", VA = "0x180802650")]
		private void RpcWriter___Target_SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x801940", Offset = "0x800B40", VA = "0x180801940")]
		private void RpcReader___Target_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x801EB0", Offset = "0x8010B0", VA = "0x180801EB0")]
		private void RpcWriter___Server_ApplyAdditive_Server_3615296227(string additiveID)
		{
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x801090", Offset = "0x800290", VA = "0x180801090")]
		public void RpcLogic___ApplyAdditive_Server_3615296227(string additiveID)
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x801610", Offset = "0x800810", VA = "0x180801610")]
		private void RpcReader___Server_ApplyAdditive_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x801A60", Offset = "0x800C60", VA = "0x180801A60")]
		private void RpcWriter___Observers_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x801070", Offset = "0x800270", VA = "0x180801070")]
		private void RpcLogic___ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x801450", Offset = "0x800650", VA = "0x180801450")]
		private void RpcReader___Observers_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x8024F0", Offset = "0x8016F0", VA = "0x1808024F0")]
		private void RpcWriter___Target_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x8018A0", Offset = "0x800AA0", VA = "0x1808018A0")]
		private void RpcReader___Target_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x802250", Offset = "0x801450", VA = "0x180802250")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x801180", Offset = "0x800380", VA = "0x180801180", Slot = "119")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x801770", Offset = "0x800970", VA = "0x180801770")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x802120", Offset = "0x801320", VA = "0x180802120")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE4")]
		[Address(RVA = "0x8010E0", Offset = "0x8002E0", VA = "0x1808010E0", Slot = "120")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x8016F0", Offset = "0x8008F0", VA = "0x1808016F0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000937")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6003AE6")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AE7")]
			[Address(RVA = "0x803970", Offset = "0x802B70", VA = "0x180803970")]
			set
			{
			}
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x000111C0 File Offset: 0x0000F3C0
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x800D30", Offset = "0x7FFF30", VA = "0x180800D30", Slot = "121")]
		public virtual bool ReadSyncVar___ScheduleOne.Growing.GrowContainer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000938")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6003AE9")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x803A30", Offset = "0x802C30", VA = "0x180803A30")]
			set
			{
			}
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x7FED00", Offset = "0x7FDF00", VA = "0x1807FED00", Slot = "122")]
		protected virtual void Awake_UserLogic_ScheduleOne.Growing.GrowContainer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		public const float DryThreshold = 0f;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x21C")]
		[SerializeField]
		private float _moistureDrainPerHour;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		public SoilDefinition[] AllowedSoils;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		public AdditiveDefinition[] AllowedAdditives;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		[Header("Grow Container References")]
		private GrowContainerInteraction _interactionHandler;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		protected MeshRenderer[] _soilMeshRenderers;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		protected Transform _soilMinTransform;

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		protected Transform _soilMaxTransform;

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private MeshRenderer _additiveDisplayTemplate;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		protected Transform _pourTarget;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		protected Transform _uiPoint;

		// Token: 0x04002B5E RID: 11102
		[Token(Token = "0x4002B5E")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		protected Transform[] _accessPoints;

		// Token: 0x04002B5F RID: 11103
		[Token(Token = "0x4002B5F")]
		[FieldOffset(Offset = "0x298")]
		[SerializeField]
		private ParticleSystem[] _soilClearedParticles;

		// Token: 0x04002B60 RID: 11104
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		private AudioSourceController _soilClearedSound;

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		[Header("Optional References")]
		private UsableLightSource _lightSourceOverride;

		// Token: 0x04002B6A RID: 11114
		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0x2E8")]
		public Action onMinPass;

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x2F0")]
		public Action<int> onTimeSkip;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x2F8")]
		protected float _currentSoilAmount;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x2FC")]
		protected float _currentMoistureAmount;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x4002B6E")]
		[FieldOffset(Offset = "0x300")]
		protected int _remainingSoilUses;

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0x308")]
		private List<MeshRenderer> _activeAdditiveDisplays;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x310")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x318")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x320")]
		private bool NetworkInitialize___EarlyScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x321")]
		private bool NetworkInitialize__LateScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted;
	}
}
