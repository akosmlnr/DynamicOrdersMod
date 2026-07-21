using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Cartel;
using ScheduleOne.Casino;
using ScheduleOne.Combat;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.Economy;
using ScheduleOne.Employees;
using ScheduleOne.Equipping;
using ScheduleOne.GameTime;
using ScheduleOne.Graffiti;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.Temperature;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using ScheduleOne.Weather;
using UnityEngine;

namespace FishNet.Serializing.Generated
{
	// Token: 0x02000E40 RID: 3648
	[Token(Token = "0x2000E40")]
	[StructLayout(3, CharSet = CharSet.Auto)]
	public static class GeneratedReaders___Internal
	{
		// Token: 0x06006901 RID: 26881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006901")]
		[Address(RVA = "0xABE850", Offset = "0xABDA50", VA = "0x180ABE850")]
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00019800 File Offset: 0x00017A00
		[Token(Token = "0x6006902")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EVehicleColor Read___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generateds(Reader reader)
		{
			return EVehicleColor.Black;
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006903")]
		[Address(RVA = "0xAC5460", Offset = "0xAC4660", VA = "0x180AC5460")]
		public static ParkData Read___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x6006904")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EParkingAlignment Read___ScheduleOne.Vehicles.EParkingAlignmentFishNet.Serializing.Generateds(Reader reader)
		{
			return EParkingAlignment.FrontToKerb;
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x6006905")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static AirConditioner.EMode Read___ScheduleOne.Temperature.AirConditioner/EModeFishNet.Serializing.Generateds(Reader reader)
		{
			return AirConditioner.EMode.Off;
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006906")]
		[Address(RVA = "0xAC4C90", Offset = "0xAC3E90", VA = "0x180AC4C90")]
		public static ContractInfo Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006907")]
		[Address(RVA = "0xAC48B0", Offset = "0xAC3AB0", VA = "0x180AC48B0")]
		public static ProductList Read___ScheduleOne.Product.ProductListFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006908")]
		[Address(RVA = "0xAC4990", Offset = "0xAC3B90", VA = "0x180AC4990")]
		public static ProductList.Entry Read___ScheduleOne.Product.ProductList/EntryFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x00019848 File Offset: 0x00017A48
		[Token(Token = "0x6006909")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EQuality Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(Reader reader)
		{
			return EQuality.Trash;
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600690A")]
		[Address(RVA = "0xAC5A20", Offset = "0xAC4C20", VA = "0x180AC5A20")]
		public static List<ProductList.Entry> Read___System.Collections.Generic.List`1<ScheduleOne.Product.ProductList/Entry>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600690B")]
		[Address(RVA = "0xAC4F90", Offset = "0xAC4190", VA = "0x180AC4F90")]
		public static QuestWindowConfig Read___ScheduleOne.Quests.QuestWindowConfigFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x600690C")]
		[Address(RVA = "0xAC2920", Offset = "0xAC1B20", VA = "0x180AC2920")]
		public static GameDateTime Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(Reader reader)
		{
			return default(GameDateTime);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x600690D")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static QuestManager.EQuestAction Read___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generateds(Reader reader)
		{
			return QuestManager.EQuestAction.Begin;
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x600690E")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EQuestState Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds(Reader reader)
		{
			return EQuestState.Inactive;
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x600690F")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static Manor.EManorState Read___ScheduleOne.Property.Manor/EManorStateFishNet.Serializing.Generateds(Reader reader)
		{
			return Manor.EManorState.Original;
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x6006910")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EVisualState Read___ScheduleOne.Vision.EVisualStateFishNet.Serializing.Generateds(Reader reader)
		{
			return EVisualState.Visible;
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006911")]
		[Address(RVA = "0xAC5600", Offset = "0xAC4800", VA = "0x180AC5600")]
		public static VisionEventReceipt Read___ScheduleOne.Vision.VisionEventReceiptFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x000198D8 File Offset: 0x00017AD8
		[Token(Token = "0x6006912")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static VisionCone.EEventLevel Read___ScheduleOne.Vision.VisionCone/EEventLevelFishNet.Serializing.Generateds(Reader reader)
		{
			return VisionCone.EEventLevel.Start;
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006913")]
		[Address(RVA = "0xAC2D30", Offset = "0xAC1F30", VA = "0x180AC2D30")]
		public static Message Read___ScheduleOne.Messaging.MessageFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x000198F0 File Offset: 0x00017AF0
		[Token(Token = "0x6006914")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static Message.ESenderType Read___ScheduleOne.Messaging.Message/ESenderTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return Message.ESenderType.Player;
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006915")]
		[Address(RVA = "0xAC52B0", Offset = "0xAC44B0", VA = "0x180AC52B0")]
		public static MessageChain Read___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006916")]
		[Address(RVA = "0xAC5AC0", Offset = "0xAC4CC0", VA = "0x180AC5AC0")]
		public static List<string> Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006917")]
		[Address(RVA = "0xAC3C60", Offset = "0xAC2E60", VA = "0x180AC3C60")]
		public static MSGConversationData Read___ScheduleOne.Persistence.Datas.MSGConversationDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006918")]
		[Address(RVA = "0xAC4040", Offset = "0xAC3240", VA = "0x180AC4040")]
		public static TextMessageData Read___ScheduleOne.Persistence.Datas.TextMessageDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006919")]
		[Address(RVA = "0xAC4160", Offset = "0xAC3360", VA = "0x180AC4160")]
		public static TextMessageData[] Read___ScheduleOne.Persistence.Datas.TextMessageData[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691A")]
		[Address(RVA = "0xAC41E0", Offset = "0xAC33E0", VA = "0x180AC41E0")]
		public static TextResponseData Read___ScheduleOne.Persistence.Datas.TextResponseDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691B")]
		[Address(RVA = "0xAC42C0", Offset = "0xAC34C0", VA = "0x180AC42C0")]
		public static TextResponseData[] Read___ScheduleOne.Persistence.Datas.TextResponseData[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691C")]
		[Address(RVA = "0xAC2E50", Offset = "0xAC2050", VA = "0x180AC2E50")]
		public static Response Read___ScheduleOne.Messaging.ResponseFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691D")]
		[Address(RVA = "0xAC59D0", Offset = "0xAC4BD0", VA = "0x180AC59D0")]
		public static List<Response> Read___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691E")]
		[Address(RVA = "0xAC57A0", Offset = "0xAC49A0", VA = "0x180AC57A0")]
		public static List<NetworkObject> Read___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600691F")]
		[Address(RVA = "0xAC35C0", Offset = "0xAC27C0", VA = "0x180AC35C0")]
		public static AdvancedTransitRouteData Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x6006920")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static ManagementItemFilter.EMode Read___ScheduleOne.Management.ManagementItemFilter/EModeFishNet.Serializing.Generateds(Reader reader)
		{
			return ManagementItemFilter.EMode.Whitelist;
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006921")]
		[Address(RVA = "0xAC3700", Offset = "0xAC2900", VA = "0x180AC3700")]
		public static AdvancedTransitRouteData[] Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x6006922")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static ERank Read___ScheduleOne.Levelling.ERankFishNet.Serializing.Generateds(Reader reader)
		{
			return ERank.Street_Rat;
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x6006923")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EMapRegion Read___ScheduleOne.Map.EMapRegionFishNet.Serializing.Generateds(Reader reader)
		{
			return EMapRegion.Northtown;
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006924")]
		[Address(RVA = "0xAC5980", Offset = "0xAC4B80", VA = "0x180AC5980")]
		public static List<EMapRegion> Read___System.Collections.Generic.List`1<ScheduleOne.Map.EMapRegion>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x6006925")]
		[Address(RVA = "0xAC2920", Offset = "0xAC1B20", VA = "0x180AC2920")]
		public static FullRank Read___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generateds(Reader reader)
		{
			return default(FullRank);
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006926")]
		[Address(RVA = "0xAC3EA0", Offset = "0xAC30A0", VA = "0x180AC3EA0")]
		public static PlayerData Read___ScheduleOne.Persistence.Datas.PlayerDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006927")]
		[Address(RVA = "0xAC4340", Offset = "0xAC3540", VA = "0x180AC4340")]
		public static VariableData Read___ScheduleOne.Persistence.Datas.VariableDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006928")]
		[Address(RVA = "0xAC4470", Offset = "0xAC3670", VA = "0x180AC4470")]
		public static VariableData[] Read___ScheduleOne.Persistence.Datas.VariableData[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006929")]
		[Address(RVA = "0xAC1310", Offset = "0xAC0510", VA = "0x180AC1310")]
		public static AvatarSettings Read___ScheduleOne.AvatarFramework.AvatarSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x600692A")]
		[Address(RVA = "0xAC1B10", Offset = "0xAC0D10", VA = "0x180AC1B10")]
		public static Eye.EyeLidConfiguration Read___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generateds(Reader reader)
		{
			return default(Eye.EyeLidConfiguration);
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00019980 File Offset: 0x00017B80
		[Token(Token = "0x600692B")]
		[Address(RVA = "0xAC1700", Offset = "0xAC0900", VA = "0x180AC1700")]
		public static AvatarSettings.LayerSetting Read___ScheduleOne.AvatarFramework.AvatarSettings/LayerSettingFishNet.Serializing.Generateds(Reader reader)
		{
			return default(AvatarSettings.LayerSetting);
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600692C")]
		[Address(RVA = "0xAC5840", Offset = "0xAC4A40", VA = "0x180AC5840")]
		public static List<AvatarSettings.LayerSetting> Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600692D")]
		[Address(RVA = "0xAC1620", Offset = "0xAC0820", VA = "0x180AC1620")]
		public static AvatarSettings.AccessorySetting Read___ScheduleOne.AvatarFramework.AvatarSettings/AccessorySettingFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600692E")]
		[Address(RVA = "0xAC57F0", Offset = "0xAC49F0", VA = "0x180AC57F0")]
		public static List<AvatarSettings.AccessorySetting> Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/AccessorySetting>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600692F")]
		[Address(RVA = "0xAC1770", Offset = "0xAC0970", VA = "0x180AC1770")]
		public static BasicAvatarSettings Read___ScheduleOne.AvatarFramework.Customization.BasicAvatarSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006930")]
		[Address(RVA = "0xAC1F50", Offset = "0xAC1150", VA = "0x180AC1F50")]
		public static Impact Read___ScheduleOne.Combat.ImpactFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x00019998 File Offset: 0x00017B98
		[Token(Token = "0x6006931")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EImpactType Read___ScheduleOne.Combat.EImpactTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return EImpactType.Punch;
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x000199B0 File Offset: 0x00017BB0
		[Token(Token = "0x6006932")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EExplosionType Read___ScheduleOne.Combat.EExplosionTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return EExplosionType.Default;
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006933")]
		[Address(RVA = "0xAC2BF0", Offset = "0xAC1DF0", VA = "0x180AC2BF0")]
		public static SlotFilter Read___ScheduleOne.ItemFramework.SlotFilterFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x000199C8 File Offset: 0x00017BC8
		[Token(Token = "0x6006934")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static SlotFilter.EType Read___ScheduleOne.ItemFramework.SlotFilter/ETypeFishNet.Serializing.Generateds(Reader reader)
		{
			return SlotFilter.EType.None;
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006935")]
		[Address(RVA = "0xAC58E0", Offset = "0xAC4AE0", VA = "0x180AC58E0")]
		public static List<EQuality> Read___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.EQuality>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Token(Token = "0x6006936")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static PlayerCrimeData.EPursuitLevel Read___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generateds(Reader reader)
		{
			return PlayerCrimeData.EPursuitLevel.None;
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006937")]
		[Address(RVA = "0xAC29C0", Offset = "0xAC1BC0", VA = "0x180AC29C0")]
		public static SprayStroke Read___ScheduleOne.Graffiti.SprayStrokeFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x6006938")]
		[Address(RVA = "0xAC2B40", Offset = "0xAC1D40", VA = "0x180AC2B40")]
		public static UShort2 Read___ScheduleOne.Graffiti.UShort2FishNet.Serializing.Generateds(Reader reader)
		{
			return default(UShort2);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00019A10 File Offset: 0x00017C10
		[Token(Token = "0x6006939")]
		[Address(RVA = "0xAC2980", Offset = "0xAC1B80", VA = "0x180AC2980")]
		public static ESprayColor Read___ScheduleOne.Graffiti.ESprayColorFishNet.Serializing.Generateds(Reader reader)
		{
			return ESprayColor.None;
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600693A")]
		[Address(RVA = "0xAC5890", Offset = "0xAC4A90", VA = "0x180AC5890")]
		public static List<SprayStroke> Read___System.Collections.Generic.List`1<ScheduleOne.Graffiti.SprayStroke>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600693B")]
		[Address(RVA = "0xAC2AC0", Offset = "0xAC1CC0", VA = "0x180AC2AC0")]
		public static SprayStroke[] Read___ScheduleOne.Graffiti.SprayStroke[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600693C")]
		[Address(RVA = "0xAC53B0", Offset = "0xAC45B0", VA = "0x180AC53B0")]
		public static LandVehicle Read___ScheduleOne.Vehicles.LandVehicleFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00019A28 File Offset: 0x00017C28
		[Token(Token = "0x600693D")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EVOLineType Read___ScheduleOne.VoiceOver.EVOLineTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return EVOLineType.None;
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600693E")]
		[Address(RVA = "0xAC4BE0", Offset = "0xAC3DE0", VA = "0x180AC4BE0")]
		public static Property Read___ScheduleOne.Property.PropertyFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x600693F")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EEmployeeType Read___ScheduleOne.Employees.EEmployeeTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return EEmployeeType.Botanist;
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00019A58 File Offset: 0x00017C58
		[Token(Token = "0x6006940")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EDealWindow Read___ScheduleOne.Economy.EDealWindowFishNet.Serializing.Generateds(Reader reader)
		{
			return EDealWindow.Morning;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x6006941")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static HandoverScreen.EHandoverOutcome Read___ScheduleOne.UI.Handover.HandoverScreen/EHandoverOutcomeFishNet.Serializing.Generateds(Reader reader)
		{
			return HandoverScreen.EHandoverOutcome.Cancelled;
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006942")]
		[Address(RVA = "0xAC5930", Offset = "0xAC4B30", VA = "0x180AC5930")]
		public static List<ItemInstance> Read___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006943")]
		[Address(RVA = "0xAC3780", Offset = "0xAC2980", VA = "0x180AC3780")]
		public static ScheduleOne.Persistence.Datas.CustomerData Read___ScheduleOne.Persistence.Datas.CustomerDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006944")]
		[Address(RVA = "0xAC5B90", Offset = "0xAC4D90", VA = "0x180AC5B90")]
		public static float[] Read___System.Single[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x6006945")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EDrugType Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds(Reader reader)
		{
			return EDrugType.Marijuana;
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[Token(Token = "0x6006946")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EDoorSide Read___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generateds(Reader reader)
		{
			return EDoorSide.Interior;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006947")]
		[Address(RVA = "0xAC2120", Offset = "0xAC1320", VA = "0x180AC2120")]
		public static DeliveryInstance Read___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006948")]
		[Address(RVA = "0xAC2550", Offset = "0xAC1750", VA = "0x180AC2550")]
		public static StringIntPair Read___ScheduleOne.DevUtilities.StringIntPairFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006949")]
		[Address(RVA = "0xAC2630", Offset = "0xAC1830", VA = "0x180AC2630")]
		public static StringIntPair[] Read___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[Token(Token = "0x600694A")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EDeliveryStatus Read___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generateds(Reader reader)
		{
			return EDeliveryStatus.InTransit;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600694B")]
		[Address(RVA = "0xAC22E0", Offset = "0xAC14E0", VA = "0x180AC22E0")]
		public static DeliveryReceipt Read___ScheduleOne.Delivery.DeliveryReceiptFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Token(Token = "0x600694C")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static PlayingCard.ECardSuit Read___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generateds(Reader reader)
		{
			return PlayingCard.ECardSuit.Spades;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00019AE8 File Offset: 0x00017CE8
		[Token(Token = "0x600694D")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static PlayingCard.ECardValue Read___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generateds(Reader reader)
		{
			return PlayingCard.ECardValue.Blank;
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600694E")]
		[Address(RVA = "0xAC1290", Offset = "0xAC0490", VA = "0x180AC1290")]
		public static NetworkObject[] Read___FishNet.Object.NetworkObject[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00019B00 File Offset: 0x00017D00
		[Token(Token = "0x600694F")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static RTBGameController.EStage Read___ScheduleOne.Casino.RTBGameController/EStageFishNet.Serializing.Generateds(Reader reader)
		{
			return RTBGameController.EStage.WaitingForPlayers;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x6006950")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static SlotMachine.ESymbol Read___ScheduleOne.Casino.SlotMachine/ESymbolFishNet.Serializing.Generateds(Reader reader)
		{
			return SlotMachine.ESymbol.Cherry;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006951")]
		[Address(RVA = "0xAC1E10", Offset = "0xAC1010", VA = "0x180AC1E10")]
		public static SlotMachine.ESymbol[] Read___ScheduleOne.Casino.SlotMachine/ESymbol[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x6006952")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static CheckpointManager.ECheckpointLocation Read___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generateds(Reader reader)
		{
			return CheckpointManager.ECheckpointLocation.Western;
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x6006953")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static ECartelStatus Read___ECartelStatusFishNet.Serializing.Generateds(Reader reader)
		{
			return ECartelStatus.Unknown;
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006954")]
		[Address(RVA = "0xAC1CB0", Offset = "0xAC0EB0", VA = "0x180AC1CB0")]
		public static CartelGoonAppearance Read___ScheduleOne.Cartel.CartelGoonAppearanceFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006955")]
		[Address(RVA = "0xAC1B50", Offset = "0xAC0D50", VA = "0x180AC1B50")]
		public static CartelDealInfo Read___ScheduleOne.Cartel.CartelDealInfoFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x6006956")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static CartelDealInfo.EStatus Read___ScheduleOne.Cartel.CartelDealInfo/EStatusFishNet.Serializing.Generateds(Reader reader)
		{
			return CartelDealInfo.EStatus.Pending;
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006957")]
		[Address(RVA = "0xAC44F0", Offset = "0xAC36F0", VA = "0x180AC44F0")]
		public static TrashContentData Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006958")]
		[Address(RVA = "0xAC5C10", Offset = "0xAC4E10", VA = "0x180AC5C10")]
		public static string[] Read___System.String[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006959")]
		[Address(RVA = "0xAC5B10", Offset = "0xAC4D10", VA = "0x180AC5B10")]
		public static int[] Read___System.Int32[]FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600695A")]
		[Address(RVA = "0xAC26B0", Offset = "0xAC18B0", VA = "0x180AC26B0")]
		public static ContractReceipt Read___ScheduleOne.Economy.ContractReceiptFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00019B78 File Offset: 0x00017D78
		[Token(Token = "0x600695B")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static EContractParty Read___ScheduleOne.Economy.EContractPartyFishNet.Serializing.Generateds(Reader reader)
		{
			return EContractParty.Player;
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600695C")]
		[Address(RVA = "0xAC4B00", Offset = "0xAC3D00", VA = "0x180AC4B00")]
		public static WeedAppearanceSettings Read___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600695D")]
		[Address(RVA = "0xAC4670", Offset = "0xAC3870", VA = "0x180AC4670")]
		public static CocaineAppearanceSettings Read___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600695E")]
		[Address(RVA = "0xAC4720", Offset = "0xAC3920", VA = "0x180AC4720")]
		public static MethAppearanceSettings Read___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600695F")]
		[Address(RVA = "0xAC4A80", Offset = "0xAC3C80", VA = "0x180AC4A80")]
		public static ShroomAppearanceSettings Read___ScheduleOne.Product.ShroomAppearanceSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006960")]
		[Address(RVA = "0xAC47D0", Offset = "0xAC39D0", VA = "0x180AC47D0")]
		public static NewMixOperation Read___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006961")]
		[Address(RVA = "0xAC2870", Offset = "0xAC1A70", VA = "0x180AC2870")]
		public static EquippedItemHandler Read___ScheduleOne.Equipping.EquippedItemHandlerFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006962")]
		[Address(RVA = "0xAC3190", Offset = "0xAC2390", VA = "0x180AC3190")]
		public static Jukebox.JukeboxState Read___ScheduleOne.ObjectScripts.Jukebox/JukeboxStateFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00019B90 File Offset: 0x00017D90
		[Token(Token = "0x6006963")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static Jukebox.ERepeatMode Read___ScheduleOne.ObjectScripts.Jukebox/ERepeatModeFishNet.Serializing.Generateds(Reader reader)
		{
			return Jukebox.ERepeatMode.None;
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006964")]
		[Address(RVA = "0xAC2F50", Offset = "0xAC2150", VA = "0x180AC2F50")]
		public static ChemistryCookOperation Read___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006965")]
		[Address(RVA = "0xAC3080", Offset = "0xAC2280", VA = "0x180AC3080")]
		public static DryingOperation Read___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006966")]
		[Address(RVA = "0xAC3490", Offset = "0xAC2690", VA = "0x180AC3490")]
		public static OvenCookOperation Read___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006967")]
		[Address(RVA = "0xAC3380", Offset = "0xAC2580", VA = "0x180AC3380")]
		public static MixOperation Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x6006968")]
		[Address(RVA = "0xAC5170", Offset = "0xAC4370", VA = "0x180AC5170")]
		public static CoordinateProceduralTilePair Read___ScheduleOne.Tiles.CoordinateProceduralTilePairFishNet.Serializing.Generateds(Reader reader)
		{
			return default(CoordinateProceduralTilePair);
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006969")]
		[Address(RVA = "0xAC5090", Offset = "0xAC4290", VA = "0x180AC5090")]
		public static Coordinate Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600696A")]
		[Address(RVA = "0xAC5A70", Offset = "0xAC4C70", VA = "0x180AC5A70")]
		public static List<CoordinateProceduralTilePair> Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x600696B")]
		[Address(RVA = "0xAC1260", Offset = "0xAC0460", VA = "0x180AC1260")]
		public static Recycler.EState Read___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generateds(Reader reader)
		{
			return Recycler.EState.HatchClosed;
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600696C")]
		[Address(RVA = "0xAC3A50", Offset = "0xAC2C50", VA = "0x180AC3A50")]
		public static GameData Read___ScheduleOne.Persistence.Datas.GameDataFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600696D")]
		[Address(RVA = "0xAC2460", Offset = "0xAC1660", VA = "0x180AC2460")]
		public static GameSettings Read___ScheduleOne.DevUtilities.GameSettingsFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600696E")]
		[Address(RVA = "0xAC56F0", Offset = "0xAC48F0", VA = "0x180AC56F0")]
		public static WeatherVolume Read___ScheduleOne.Weather.WeatherVolumeFishNet.Serializing.Generateds(Reader reader)
		{
			return null;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x600696F")]
		[Address(RVA = "0xAC1E90", Offset = "0xAC1090", VA = "0x180AC1E90")]
		public static ExplosionData Read___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generateds(Reader reader)
		{
			return default(ExplosionData);
		}
	}
}
