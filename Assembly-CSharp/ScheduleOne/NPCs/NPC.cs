using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EPOOutline;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Combat;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Equipping.Framework;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using ScheduleOne.Weather;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	[RequireComponent(typeof(NPCHealth))]
	public class NPC : NetworkBehaviour, IGUIDRegisterable, ISaveable, ICombatTargetable, IDamageable, ISightable, INetworkedEquippableUser, IEquippableUser, IWeatherEntity
	{
		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x17000B96")]
		public bool IsLocalPlayer
		{
			[Token(Token = "0x6004A6B")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06004A6C RID: 19052 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B97")]
		public NetworkBehaviour NetworkBehaviour
		{
			[Token(Token = "0x6004A6C")]
			[Address(RVA = "0x66B930", Offset = "0x66AB30", VA = "0x18066B930", Slot = "65")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B98")]
		public IThirdPersonReferencesProvider ThirdPersonReferences
		{
			[Token(Token = "0x6004A6D")]
			[Address(RVA = "0x630310", Offset = "0x62F510", VA = "0x180630310", Slot = "73")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06004A6E RID: 19054 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B99")]
		public string fullName
		{
			[Token(Token = "0x6004A6E")]
			[Address(RVA = "0x8FB710", Offset = "0x8FA910", VA = "0x1808FB710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x000142F8 File Offset: 0x000124F8
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9A")]
		public float Scale
		{
			[Token(Token = "0x6004A6F")]
			[Address(RVA = "0x6288E0", Offset = "0x627AE0", VA = "0x1806288E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A70")]
			[Address(RVA = "0x628A20", Offset = "0x627C20", VA = "0x180628A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x17000B9B")]
		public bool IsConscious
		{
			[Token(Token = "0x6004A71")]
			[Address(RVA = "0x9075A0", Offset = "0x9067A0", VA = "0x1809075A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A73 RID: 19059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9C")]
		public LandVehicle CurrentVehicle
		{
			[Token(Token = "0x6004A72")]
			[Address(RVA = "0x6D6C80", Offset = "0x6D5E80", VA = "0x1806D6C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A73")]
			[Address(RVA = "0x6D6DD0", Offset = "0x6D5FD0", VA = "0x1806D6DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06004A74 RID: 19060 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x17000B9D")]
		public bool IsInVehicle
		{
			[Token(Token = "0x6004A74")]
			[Address(RVA = "0x907650", Offset = "0x906850", VA = "0x180907650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x17000B9E")]
		public bool isInBuilding
		{
			[Token(Token = "0x6004A75")]
			[Address(RVA = "0x9077E0", Offset = "0x9069E0", VA = "0x1809077E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A77 RID: 19063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9F")]
		public NPCEnterableBuilding CurrentBuilding
		{
			[Token(Token = "0x6004A76")]
			[Address(RVA = "0x6DA280", Offset = "0x6D9480", VA = "0x1806DA280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A77")]
			[Address(RVA = "0x6DA290", Offset = "0x6D9490", VA = "0x1806DA290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A79 RID: 19065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA0")]
		public StaticDoor LastEnteredDoor
		{
			[Token(Token = "0x6004A78")]
			[Address(RVA = "0x6DDB10", Offset = "0x6DCD10", VA = "0x1806DDB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A79")]
			[Address(RVA = "0x71D7A0", Offset = "0x71C9A0", VA = "0x18071D7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A7B RID: 19067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA1")]
		public MSGConversation MSGConversation
		{
			[Token(Token = "0x6004A7A")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A7B")]
			[Address(RVA = "0x89E640", Offset = "0x89D840", VA = "0x18089E640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x17000BA2")]
		public float WalkInRainMaxSpeedMultiplier
		{
			[Token(Token = "0x6004A7C")]
			[Address(RVA = "0x9077D0", Offset = "0x9069D0", VA = "0x1809077D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BA3")]
		public string SaveFolderName
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x8FB710", Offset = "0x8FA910", VA = "0x1808FB710", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BA4")]
		public string SaveFileName
		{
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x907730", Offset = "0x906930", VA = "0x180907730", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BA5")]
		public Loader Loader
		{
			[Token(Token = "0x6004A7F")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x17000BA6")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6004A80")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A82 RID: 19074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA7")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6004A81")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A82")]
			[Address(RVA = "0x803900", Offset = "0x802B00", VA = "0x180803900", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA8")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6004A83")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A84")]
			[Address(RVA = "0x66BD40", Offset = "0x66AF40", VA = "0x18066BD40", Slot = "29")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00014388 File Offset: 0x00012588
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA9")]
		public bool HasChanged
		{
			[Token(Token = "0x6004A85")]
			[Address(RVA = "0x5AC190", Offset = "0x5AB390", VA = "0x1805AC190", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A86")]
			[Address(RVA = "0x5AC1A0", Offset = "0x5AB3A0", VA = "0x1805AC1A0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x17000BAA")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x6004A87")]
			[Address(RVA = "0x907530", Offset = "0x906730", VA = "0x180907530", Slot = "46")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06004A88 RID: 19080 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BAB")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x6004A88")]
			[Address(RVA = "0x904170", Offset = "0x903370", VA = "0x180904170", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x17000BAC")]
		public Vector3 LookAtPoint
		{
			[Token(Token = "0x6004A89")]
			[Address(RVA = "0x9076D0", Offset = "0x9068D0", VA = "0x1809076D0", Slot = "48")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x17000BAD")]
		public bool IsCurrentlyTargetable
		{
			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x907610", Offset = "0x906810", VA = "0x180907610", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06004A8B RID: 19083 RVA: 0x000143E8 File Offset: 0x000125E8
		[Token(Token = "0x17000BAE")]
		public float RangedHitChanceMultiplier
		{
			[Token(Token = "0x6004A8B")]
			[Address(RVA = "0x7FF9C0", Offset = "0x7FEBC0", VA = "0x1807FF9C0", Slot = "50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06004A8C RID: 19084 RVA: 0x00014400 File Offset: 0x00012600
		[Token(Token = "0x17000BAF")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6004A8C")]
			[Address(RVA = "0x907770", Offset = "0x906970", VA = "0x180907770", Slot = "51")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "52")]
		public void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x8FBBD0", Offset = "0x8FADD0", VA = "0x1808FBBD0", Slot = "53")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004A90 RID: 19088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB0")]
		public VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x6004A8F")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A90")]
			[Address(RVA = "0x803950", Offset = "0x802B50", VA = "0x180803950", Slot = "62")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BB1")]
		public EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x6004A91")]
			[Address(RVA = "0x6D6C70", Offset = "0x6D5E70", VA = "0x1806D6C70", Slot = "63")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x8FBDF0", Offset = "0x8FAFF0", VA = "0x1808FBDF0", Slot = "64")]
		public bool IsCurrentlySightable()
		{
			return default(bool);
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06004A93 RID: 19091 RVA: 0x00014448 File Offset: 0x00012648
		// (set) Token: 0x06004A94 RID: 19092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB2")]
		public Guid GUID
		{
			[Token(Token = "0x6004A93")]
			[Address(RVA = "0x907580", Offset = "0x906780", VA = "0x180907580", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6004A94")]
			[Address(RVA = "0x907850", Offset = "0x906A50", VA = "0x180907850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06004A95 RID: 19093 RVA: 0x00014460 File Offset: 0x00012660
		// (set) Token: 0x06004A96 RID: 19094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB3")]
		public bool isVisible
		{
			[Token(Token = "0x6004A95")]
			[Address(RVA = "0x907840", Offset = "0x906A40", VA = "0x180907840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x907930", Offset = "0x906B30", VA = "0x180907930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x00014478 File Offset: 0x00012678
		// (set) Token: 0x06004A98 RID: 19096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB4")]
		public bool isUnsettled
		{
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x895730", Offset = "0x894930", VA = "0x180895730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x907920", Offset = "0x906B20", VA = "0x180907920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00014490 File Offset: 0x00012690
		// (set) Token: 0x06004A9A RID: 19098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB5")]
		public bool IsPanicked
		{
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x9076B0", Offset = "0x9068B0", VA = "0x1809076B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0x9078F0", Offset = "0x906AF0", VA = "0x1809078F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x000144A8 File Offset: 0x000126A8
		// (set) Token: 0x06004A9C RID: 19100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB6")]
		public float TimeSincePanicked
		{
			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0x907760", Offset = "0x906960", VA = "0x180907760")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x907910", Offset = "0x906B10", VA = "0x180907910")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06004A9D RID: 19101 RVA: 0x000144C0 File Offset: 0x000126C0
		// (set) Token: 0x06004A9E RID: 19102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB7")]
		public bool HasUmbrella
		{
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x907590", Offset = "0x906790", VA = "0x180907590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0x907860", Offset = "0x906A60", VA = "0x180907860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06004A9F RID: 19103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BB8")]
		private Transform ScheduleOne.Weather.IWeatherEntity.Transform
		{
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x904170", Offset = "0x903370", VA = "0x180904170", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BB9")]
		private string ScheduleOne.Weather.IWeatherEntity.WeatherVolume
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x835030", Offset = "0x834230", VA = "0x180835030", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x000144D8 File Offset: 0x000126D8
		// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBA")]
		public bool IsUnderCover
		{
			[Token(Token = "0x6004AA2")]
			[Address(RVA = "0x9076C0", Offset = "0x9068C0", VA = "0x1809076C0", Slot = "80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AA3")]
			[Address(RVA = "0x907900", Offset = "0x906B00", VA = "0x180907900", Slot = "81")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x8F9E50", Offset = "0x8F9050", VA = "0x1808F9E50", Slot = "82")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x8F9EA0", Offset = "0x8F90A0", VA = "0x1808F9EA0", Slot = "83")]
		protected virtual void CheckAndGetReferences()
		{
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x8FBD40", Offset = "0x8FAF40", VA = "0x1808FBD40", Slot = "84")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x905590", Offset = "0x904790", VA = "0x180905590", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x8FDA30", Offset = "0x8FCC30", VA = "0x1808FDA30")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x8FA310", Offset = "0x8F9510", VA = "0x1808FA310", Slot = "85")]
		protected virtual void CreateMessageConversation()
		{
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x8FB710", Offset = "0x8FA910", VA = "0x1808FB710", Slot = "86")]
		protected virtual string GetMessagingName()
		{
			return null;
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "87")]
		public virtual Sprite GetMessagingIcon()
		{
			return null;
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x9048B0", Offset = "0x903AB0", VA = "0x1809048B0")]
		public void SendTextMessage(string message)
		{
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x906780", Offset = "0x905980", VA = "0x180906780", Slot = "88")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x8FCA20", Offset = "0x8FBC20", VA = "0x1808FCA20", Slot = "89")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x8FCCB0", Offset = "0x8FBEB0", VA = "0x1808FCCB0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x8FD090", Offset = "0x8FC290", VA = "0x1808FD090", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x9058C0", Offset = "0x904AC0", VA = "0x1809058C0")]
		[ObserversRpc]
		private void SetTransform(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "90")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x8FD270", Offset = "0x8FC470", VA = "0x1808FD270", Slot = "91")]
		protected virtual void OnUncappedMinPass()
		{
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "92")]
		protected virtual void OnTick()
		{
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x905CE0", Offset = "0x904EE0", VA = "0x180905CE0", Slot = "93")]
		public virtual void SetVisible(bool visible, bool networked = false)
		{
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x905B90", Offset = "0x904D90", VA = "0x180905B90")]
		[ObserversRpc(RunLocally = true)]
		private void SetVisible_Networked(bool visible)
		{
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x905710", Offset = "0x904910", VA = "0x180905710")]
		public void SetScale(float scale)
		{
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x905730", Offset = "0x904930", VA = "0x180905730")]
		public void SetScale(float scale, float lerpTime)
		{
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x8F91D0", Offset = "0x8F83D0", VA = "0x1808F91D0", Slot = "94")]
		protected virtual void ApplyScale()
		{
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x8F90A0", Offset = "0x8F82A0", VA = "0x1808F90A0", Slot = "95")]
		[ServerRpc(RequireOwnership = false)]
		public virtual void AimedAtByPlayer(NetworkObject player)
		{
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x7C9870", Offset = "0x7C8A70", VA = "0x1807C9870")]
		public void OverrideAggression(float aggression)
		{
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x8FE210", Offset = "0x8FD410", VA = "0x1808FE210")]
		public void ResetAggression()
		{
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x8FCBF0", Offset = "0x8FBDF0", VA = "0x1808FCBF0", Slot = "96")]
		protected virtual void OnDie()
		{
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x8FCC30", Offset = "0x8FBE30", VA = "0x1808FCC30", Slot = "97")]
		protected virtual void OnKnockedOut()
		{
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x904770", Offset = "0x903970", VA = "0x180904770", Slot = "98")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x8FDE40", Offset = "0x8FD040", VA = "0x1808FDE40", Slot = "99")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC1")]
		[Address(RVA = "0x8FBC60", Offset = "0x8FAE60", VA = "0x1808FBC60", Slot = "100")]
		protected virtual void HitByLightning()
		{
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC2")]
		[Address(RVA = "0x8FDA50", Offset = "0x8FCC50", VA = "0x1808FDA50", Slot = "101")]
		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x8FAD90", Offset = "0x8F9F90", VA = "0x1808FAD90", Slot = "102")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void EnterVehicle(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x8FB5F0", Offset = "0x8FA7F0", VA = "0x1808FB5F0", Slot = "103")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ExitVehicle()
		{
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x904970", Offset = "0x903B70", VA = "0x180904970")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendWorldspaceDialogueReaction(string key, float duration)
		{
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x8FD8B0", Offset = "0x8FCAB0", VA = "0x1808FD8B0")]
		[ObserversRpc(RunLocally = true)]
		private void PlayWorldspaceDialogueReaction(string key, float duration)
		{
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x903120", Offset = "0x902320", VA = "0x180903120")]
		[ServerRpc(RequireOwnership = false)]
		public void SendWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x906610", Offset = "0x905810", VA = "0x180906610")]
		[ObserversRpc(RunLocally = true)]
		public void ShowWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
		private void Hovered_Internal()
		{
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x8FBDD0", Offset = "0x8FAFD0", VA = "0x1808FBDD0")]
		private void Interacted_Internal()
		{
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "104")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "105")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x8FA4C0", Offset = "0x8F96C0", VA = "0x1808FA4C0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void EnterBuilding(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x8FA780", Offset = "0x8F9980", VA = "0x1808FA780", Slot = "106")]
		protected virtual void EnterBuilding(string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x8FB4B0", Offset = "0x8FA6B0", VA = "0x1808FB4B0")]
		[ObserversRpc(RunLocally = true)]
		public void ExitBuilding(string buildingID = "")
		{
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x8FB0B0", Offset = "0x8FA2B0", VA = "0x1808FB0B0", Slot = "107")]
		protected virtual void ExitBuilding(NPCEnterableBuilding building)
		{
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x905180", Offset = "0x904380", VA = "0x180905180")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetEquippable_Client(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x9053F0", Offset = "0x9045F0", VA = "0x1809053F0")]
		public AvatarEquippable SetEquippable_Networked_Return(NetworkConnection conn, string assetPath)
		{
			return null;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x905560", Offset = "0x904760", VA = "0x180905560")]
		public AvatarEquippable SetEquippable_Return(string assetPath)
		{
			return null;
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x902590", Offset = "0x901790", VA = "0x180902590")]
		[ObserversRpc(RunLocally = false, ExcludeServer = true)]
		private void SetEquippable_Networked_ExcludeServer(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x904500", Offset = "0x903700", VA = "0x180904500")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x9041A0", Offset = "0x9033A0", VA = "0x1809041A0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked_Vector(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x8FB050", Offset = "0x8FA250", VA = "0x1808FB050", Slot = "69")]
		public IEquippedItemHandler Equip(EquippableData equippable)
		{
			return null;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x8FB080", Offset = "0x8FA280", VA = "0x1808FB080", Slot = "70")]
		public IEquippedItemHandler Equip(BaseItemInstance item)
		{
			return null;
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x8FB020", Offset = "0x8FA220", VA = "0x1808FB020", Slot = "66")]
		public IEquippedItemHandler EquipLocal(EquippableData equippable)
		{
			return null;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x8FAFF0", Offset = "0x8FA1F0", VA = "0x1808FAFF0", Slot = "67")]
		public IEquippedItemHandler EquipLocal(BaseItemInstance item)
		{
			return null;
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x906F60", Offset = "0x906160", VA = "0x180906F60", Slot = "71")]
		public void Unequip(IEquippedItemHandler equippedItem)
		{
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x906F30", Offset = "0x906130", VA = "0x180906F30", Slot = "72")]
		public void UnequipAll()
		{
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x902D80", Offset = "0x901F80", VA = "0x180902D80")]
		[ServerRpc(RequireOwnership = false)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x904D90", Offset = "0x903F90", VA = "0x180904D90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x905000", Offset = "0x904200", VA = "0x180905000")]
		public void SetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x8FE220", Offset = "0x8FD420", VA = "0x1808FE220")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x8FE490", Offset = "0x8FD690", VA = "0x1808FE490")]
		public void ResetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x905030", Offset = "0x904230", VA = "0x180905030")]
		[ObserversRpc(RunLocally = true)]
		public void SetCrouched_Networked(bool crouched)
		{
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x904AC0", Offset = "0x903CC0", VA = "0x180904AC0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationBool_Networked(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x904D60", Offset = "0x903F60", VA = "0x180904D60")]
		public void SetAnimationBool(string trigger, bool val)
		{
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x905900", Offset = "0x904B00", VA = "0x180905900", Slot = "108")]
		protected virtual void SetUnsettled_30s(Player player)
		{
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x905A40", Offset = "0x904C40", VA = "0x180905A40")]
		protected void SetUnsettled(float duration)
		{
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x905600", Offset = "0x904800", VA = "0x180905600")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPanicked_Server()
		{
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x8FF7E0", Offset = "0x8FE9E0", VA = "0x1808FF7E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetPanicked_Client()
		{
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE9")]
		[Address(RVA = "0x8FE0F0", Offset = "0x8FD2F0", VA = "0x1808FE0F0")]
		[ObserversRpc(RunLocally = true)]
		private void RemovePanicked()
		{
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080", Slot = "109")]
		public virtual string GetNameAddress()
		{
			return null;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x8FD740", Offset = "0x8FC940", VA = "0x1808FD740")]
		public void PlayVO(EVOLineType lineType, bool network = false)
		{
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x8FD610", Offset = "0x8FC810", VA = "0x1808FD610")]
		[ServerRpc(RequireOwnership = false)]
		private void PlayVO_Server(EVOLineType lineType)
		{
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x8FD4C0", Offset = "0x8FC6C0", VA = "0x1808FD4C0")]
		[ObserversRpc(RunLocally = true)]
		private void PlayVO_Client(EVOLineType lineType)
		{
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x8FDF80", Offset = "0x8FD180", VA = "0x1808FDF80")]
		[TargetRpc]
		public void ReceiveRelationshipData(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEF")]
		[Address(RVA = "0x9033E0", Offset = "0x9025E0", VA = "0x1809033E0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetIsBeingPickPocketed(bool pickpocketed)
		{
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x902FE0", Offset = "0x9021E0", VA = "0x180902FE0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendRelationship(float relationship)
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x8FF340", Offset = "0x8FE540", VA = "0x1808FF340")]
		[ObserversRpc]
		private void SetRelationship(float relationship)
		{
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x8FDC50", Offset = "0x8FCE50", VA = "0x1808FDC50")]
		private void RandomizeUseUmbrella()
		{
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x906150", Offset = "0x905350", VA = "0x180906150", Slot = "110")]
		public void ShowOutline(Color color)
		{
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x8FBBE0", Offset = "0x8FADE0", VA = "0x1808FBBE0", Slot = "111")]
		public void HideOutline()
		{
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x8760C0", Offset = "0x8752C0", VA = "0x1808760C0", Slot = "78")]
		public void OnWeatherChange(WeatherConditions newConditions)
		{
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x834F70", Offset = "0x834170", VA = "0x180834F70")]
		public WeatherConditions GetWeatherTolerence()
		{
			return null;
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x66B8A0", Offset = "0x66AAA0", VA = "0x18066B8A0")]
		public WeatherConditions GetCurrentWeatherConditionsForEnitty()
		{
			return null;
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x8FD4B0", Offset = "0x8FC6B0", VA = "0x1808FD4B0", Slot = "79")]
		public void OnUpdateWeatherEntity()
		{
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x906F90", Offset = "0x906190", VA = "0x180906F90")]
		public void UpdateWetness()
		{
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x000144F0 File Offset: 0x000126F0
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x9060A0", Offset = "0x9052A0", VA = "0x1809060A0", Slot = "112")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00014508 File Offset: 0x00012708
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x906060", Offset = "0x905260", VA = "0x180906060", Slot = "113")]
		protected virtual bool ShouldSaveRelationshipData()
		{
			return default(bool);
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00014520 File Offset: 0x00012720
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x906000", Offset = "0x905200", VA = "0x180906000")]
		protected bool ShouldSaveMessages()
		{
			return default(bool);
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00014538 File Offset: 0x00012738
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x905F40", Offset = "0x905140", VA = "0x180905F40", Slot = "114")]
		protected virtual bool ShouldSaveInventory()
		{
			return default(bool);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x905EE0", Offset = "0x9050E0", VA = "0x180905EE0", Slot = "115")]
		protected virtual bool ShouldSaveHealth()
		{
			return default(bool);
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x8FBB90", Offset = "0x8FAD90", VA = "0x1808FBB90", Slot = "33")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x8FB770", Offset = "0x8FA970", VA = "0x1808FB770", Slot = "116")]
		public virtual NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B01")]
		[Address(RVA = "0x8FB7D0", Offset = "0x8FA9D0", VA = "0x1808FB7D0", Slot = "117")]
		public virtual DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x907140", Offset = "0x906340", VA = "0x180907140", Slot = "118")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "119")]
		public virtual void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "120")]
		public virtual void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x9071A0", Offset = "0x9063A0", VA = "0x1809071A0")]
		public NPC()
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "45")]
		private NetworkObject ScheduleOne.Combat.ICombatTargetable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x668390", Offset = "0x667590", VA = "0x180668390", Slot = "57")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B08")]
		[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "60")]
		private NetworkObject ScheduleOne.Vision.ISightable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x906DB0", Offset = "0x905FB0", VA = "0x180906DB0")]
		[CompilerGenerated]
		private void <Awake>g__Unlocked|166_0(NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x906EC0", Offset = "0x9060C0", VA = "0x180906EC0")]
		[CompilerGenerated]
		private IEnumerator <HitByLightning>g__Reset|196_0()
		{
			return null;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x8FBE80", Offset = "0x8FB080", VA = "0x1808FBE80", Slot = "121")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x8FBE30", Offset = "0x8FB030", VA = "0x1808FBE30", Slot = "122")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0E")]
		[Address(RVA = "0x902820", Offset = "0x901A20", VA = "0x180902820")]
		private void RpcWriter___Observers_SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0F")]
		[Address(RVA = "0x8FF940", Offset = "0x8FEB40", VA = "0x1808FF940")]
		private void RpcLogic___SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B10")]
		[Address(RVA = "0x9002F0", Offset = "0x8FF4F0", VA = "0x1809002F0")]
		private void RpcReader___Observers_SetTransform_4260003484(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B11")]
		[Address(RVA = "0x902AD0", Offset = "0x901CD0", VA = "0x180902AD0")]
		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool visible)
		{
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x8FF9D0", Offset = "0x8FEBD0", VA = "0x1808FF9D0")]
		private void RpcLogic___SetVisible_Networked_1140765316(bool visible)
		{
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x900410", Offset = "0x8FF610", VA = "0x180900410")]
		private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x8F90A0", Offset = "0x8F82A0", VA = "0x1808F90A0")]
		private void RpcWriter___Server_AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x8FE4C0", Offset = "0x8FD6C0", VA = "0x1808FE4C0", Slot = "123")]
		public virtual void RpcLogic___AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x900520", Offset = "0x8FF720", VA = "0x180900520")]
		private void RpcReader___Server_AimedAtByPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x902EB0", Offset = "0x9020B0", VA = "0x180902EB0")]
		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x8FF320", Offset = "0x8FE520", VA = "0x1808FF320", Slot = "124")]
		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x9007A0", Offset = "0x8FF9A0", VA = "0x1809007A0")]
		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x9019D0", Offset = "0x900BD0", VA = "0x1809019D0")]
		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x8FED60", Offset = "0x8FDF60", VA = "0x1808FED60", Slot = "125")]
		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x8FFCC0", Offset = "0x8FEEC0", VA = "0x1808FFCC0")]
		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x901380", Offset = "0x900580", VA = "0x180901380")]
		private void RpcWriter___Observers_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x8FE560", Offset = "0x8FD760", VA = "0x1808FE560", Slot = "126")]
		public virtual void RpcLogic___EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x8FFAB0", Offset = "0x8FECB0", VA = "0x1808FFAB0")]
		private void RpcReader___Observers_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x903790", Offset = "0x902990", VA = "0x180903790")]
		private void RpcWriter___Target_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x900C00", Offset = "0x8FFE00", VA = "0x180900C00")]
		private void RpcReader___Target_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x901600", Offset = "0x900800", VA = "0x180901600")]
		private void RpcWriter___Observers_ExitVehicle_2166136261()
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x8FE960", Offset = "0x8FDB60", VA = "0x1808FE960", Slot = "127")]
		public virtual void RpcLogic___ExitVehicle_2166136261()
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x8FFB70", Offset = "0x8FED70", VA = "0x1808FFB70")]
		private void RpcReader___Observers_ExitVehicle_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x903280", Offset = "0x902480", VA = "0x180903280")]
		private void RpcWriter___Server_SendWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x8FD8B0", Offset = "0x8FCAB0", VA = "0x1808FD8B0")]
		public void RpcLogic___SendWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x900A00", Offset = "0x8FFC00", VA = "0x180900A00")]
		private void RpcReader___Server_SendWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x901860", Offset = "0x900A60", VA = "0x180901860")]
		private void RpcWriter___Observers_PlayWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x8FED20", Offset = "0x8FDF20", VA = "0x1808FED20")]
		private void RpcLogic___PlayWorldspaceDialogueReaction_606697822(string key, float duration)
		{
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x8FFC20", Offset = "0x8FEE20", VA = "0x1808FFC20")]
		private void RpcReader___Observers_PlayWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x903120", Offset = "0x902320", VA = "0x180903120")]
		private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x8FF490", Offset = "0x8FE690", VA = "0x1808FF490")]
		public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x900990", Offset = "0x8FFB90", VA = "0x180900990")]
		private void RpcReader___Server_SendWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x902C10", Offset = "0x901E10", VA = "0x180902C10")]
		private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x8FF9F0", Offset = "0x8FEBF0", VA = "0x1808FF9F0")]
		public void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x900490", Offset = "0x8FF690", VA = "0x180900490")]
		private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x901200", Offset = "0x900400", VA = "0x180901200")]
		private void RpcWriter___Observers_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x8FE540", Offset = "0x8FD740", VA = "0x1808FE540")]
		public void RpcLogic___EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x8FFA20", Offset = "0x8FEC20", VA = "0x1808FFA20")]
		private void RpcReader___Observers_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x903620", Offset = "0x902820", VA = "0x180903620")]
		private void RpcWriter___Target_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x900B70", Offset = "0x8FFD70", VA = "0x180900B70")]
		private void RpcReader___Target_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x9014C0", Offset = "0x9006C0", VA = "0x1809014C0")]
		private void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "")
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x8FE800", Offset = "0x8FDA00", VA = "0x1808FE800")]
		public void RpcLogic___ExitBuilding_3615296227(string buildingID = "")
		{
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x8FFB10", Offset = "0x8FED10", VA = "0x1808FFB10")]
		private void RpcReader___Observers_ExitBuilding_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x902450", Offset = "0x901650", VA = "0x180902450")]
		private void RpcWriter___Observers_SetEquippable_Client_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x8FF550", Offset = "0x8FE750", VA = "0x1808FF550")]
		public void RpcLogic___SetEquippable_Client_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x900150", Offset = "0x8FF350", VA = "0x180900150")]
		private void RpcReader___Observers_SetEquippable_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x904010", Offset = "0x903210", VA = "0x180904010")]
		private void RpcWriter___Target_SetEquippable_Client_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x901190", Offset = "0x900390", VA = "0x180901190")]
		private void RpcReader___Target_SetEquippable_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x902590", Offset = "0x901790", VA = "0x180902590")]
		private void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x8FF550", Offset = "0x8FE750", VA = "0x1808FF550")]
		private void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x9001D0", Offset = "0x8FF3D0", VA = "0x1809001D0")]
		private void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x901D70", Offset = "0x900F70", VA = "0x180901D70")]
		private void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B42")]
		[Address(RVA = "0x8FF240", Offset = "0x8FE440", VA = "0x1808FF240")]
		public void RpcLogic___SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x8FFDD0", Offset = "0x8FEFD0", VA = "0x1808FFDD0")]
		private void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B44")]
		[Address(RVA = "0x903A50", Offset = "0x902C50", VA = "0x180903A50")]
		private void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B45")]
		[Address(RVA = "0x900EC0", Offset = "0x9000C0", VA = "0x180900EC0")]
		private void RpcReader___Target_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B46")]
		[Address(RVA = "0x901EB0", Offset = "0x9010B0", VA = "0x180901EB0")]
		private void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x8FF280", Offset = "0x8FE480", VA = "0x1808FF280")]
		public void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B48")]
		[Address(RVA = "0x8FFE50", Offset = "0x8FF050", VA = "0x1808FFE50")]
		private void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x903BB0", Offset = "0x902DB0", VA = "0x180903BB0")]
		private void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x900F30", Offset = "0x900130", VA = "0x180900F30")]
		private void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x902D80", Offset = "0x901F80", VA = "0x180902D80")]
		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x8FF230", Offset = "0x8FE430", VA = "0x1808FF230")]
		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x900740", Offset = "0x8FF940", VA = "0x180900740")]
		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x9021D0", Offset = "0x9013D0", VA = "0x1809021D0")]
		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x8FF4E0", Offset = "0x8FE6E0", VA = "0x1808FF4E0")]
		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x900050", Offset = "0x8FF250", VA = "0x180900050")]
		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x903EB0", Offset = "0x9030B0", VA = "0x180903EB0")]
		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x901120", Offset = "0x900320", VA = "0x180901120")]
		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x901C30", Offset = "0x900E30", VA = "0x180901C30")]
		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x8FF1F0", Offset = "0x8FE3F0", VA = "0x1808FF1F0")]
		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x8FFD60", Offset = "0x8FEF60", VA = "0x1808FFD60")]
		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x9038F0", Offset = "0x902AF0", VA = "0x1809038F0")]
		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x900E50", Offset = "0x900050", VA = "0x180900E50")]
		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x902310", Offset = "0x901510", VA = "0x180902310")]
		private void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x8FF520", Offset = "0x8FE720", VA = "0x1808FF520")]
		public void RpcLogic___SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x9000C0", Offset = "0x8FF2C0", VA = "0x1809000C0")]
		private void RpcReader___Observers_SetCrouched_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x902060", Offset = "0x901260", VA = "0x180902060")]
		private void RpcWriter___Observers_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x8FF4A0", Offset = "0x8FE6A0", VA = "0x1808FF4A0")]
		public void RpcLogic___SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x8FFFA0", Offset = "0x8FF1A0", VA = "0x1808FFFA0")]
		private void RpcReader___Observers_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x903D50", Offset = "0x902F50", VA = "0x180903D50")]
		private void RpcWriter___Target_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x901070", Offset = "0x900270", VA = "0x180901070")]
		private void RpcReader___Target_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x903510", Offset = "0x902710", VA = "0x180903510")]
		private void RpcWriter___Server_SetPanicked_Server_2166136261()
		{
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x8FF7E0", Offset = "0x8FE9E0", VA = "0x1808FF7E0")]
		public void RpcLogic___SetPanicked_Server_2166136261()
		{
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x900B20", Offset = "0x8FFD20", VA = "0x180900B20")]
		private void RpcReader___Server_SetPanicked_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x902700", Offset = "0x901900", VA = "0x180902700")]
		private void RpcWriter___Observers_SetPanicked_Client_2166136261()
		{
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x8FF5E0", Offset = "0x8FE7E0", VA = "0x1808FF5E0")]
		private void RpcLogic___SetPanicked_Client_2166136261()
		{
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x900240", Offset = "0x8FF440", VA = "0x180900240")]
		private void RpcReader___Observers_SetPanicked_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x901B10", Offset = "0x900D10", VA = "0x180901B10")]
		private void RpcWriter___Observers_RemovePanicked_2166136261()
		{
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x8FF0F0", Offset = "0x8FE2F0", VA = "0x1808FF0F0")]
		private void RpcLogic___RemovePanicked_2166136261()
		{
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x8FFD20", Offset = "0x8FEF20", VA = "0x1808FFD20")]
		private void RpcReader___Observers_RemovePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B69")]
		[Address(RVA = "0x8FD610", Offset = "0x8FC810", VA = "0x1808FD610")]
		private void RpcWriter___Server_PlayVO_Server_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6A")]
		[Address(RVA = "0x8FD4C0", Offset = "0x8FC6C0", VA = "0x1808FD4C0")]
		private void RpcLogic___PlayVO_Server_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6B")]
		[Address(RVA = "0x9005D0", Offset = "0x8FF7D0", VA = "0x1809005D0")]
		private void RpcReader___Server_PlayVO_Server_1710085680(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6C")]
		[Address(RVA = "0x901720", Offset = "0x900920", VA = "0x180901720")]
		private void RpcWriter___Observers_PlayVO_Client_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6D")]
		[Address(RVA = "0x8FECF0", Offset = "0x8FDEF0", VA = "0x1808FECF0")]
		private void RpcLogic___PlayVO_Client_1710085680(EVOLineType lineType)
		{
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6E")]
		[Address(RVA = "0x8FFBB0", Offset = "0x8FEDB0", VA = "0x1808FFBB0")]
		private void RpcReader___Observers_PlayVO_Client_1710085680(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x8FDF80", Offset = "0x8FD180", VA = "0x1808FDF80")]
		private void RpcWriter___Target_ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x8FEF70", Offset = "0x8FE170", VA = "0x1808FEF70")]
		public void RpcLogic___ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x900C60", Offset = "0x8FFE60", VA = "0x180900C60")]
		private void RpcReader___Target_ReceiveRelationshipData_4052192084(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B72")]
		[Address(RVA = "0x9033E0", Offset = "0x9025E0", VA = "0x1809033E0")]
		private void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x8FF590", Offset = "0x8FE790", VA = "0x1808FF590")]
		public void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x900A90", Offset = "0x8FFC90", VA = "0x180900A90")]
		private void RpcReader___Server_SetIsBeingPickPocketed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x902FE0", Offset = "0x9021E0", VA = "0x180902FE0")]
		private void RpcWriter___Server_SendRelationship_431000436(float relationship)
		{
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x8FF340", Offset = "0x8FE540", VA = "0x1808FF340")]
		public void RpcLogic___SendRelationship_431000436(float relationship)
		{
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x900820", Offset = "0x8FFA20", VA = "0x180900820")]
		private void RpcReader___Server_SendRelationship_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B78")]
		[Address(RVA = "0x8FF340", Offset = "0x8FE540", VA = "0x1808FF340")]
		private void RpcWriter___Observers_SetRelationship_431000436(float relationship)
		{
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x8FF900", Offset = "0x8FEB00", VA = "0x1808FF900")]
		private void RpcLogic___SetRelationship_431000436(float relationship)
		{
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x900280", Offset = "0x8FF480", VA = "0x180900280")]
		private void RpcReader___Observers_SetRelationship_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x00014568 File Offset: 0x00012768
		// (set) Token: 0x06004B7C RID: 19324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBB")]
		public bool SyncAccessor_<HasUmbrella>k__BackingField
		{
			[Token(Token = "0x6004B7B")]
			[Address(RVA = "0x907590", Offset = "0x906790", VA = "0x180907590")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B7C")]
			[Address(RVA = "0x907940", Offset = "0x906B40", VA = "0x180907940")]
			set
			{
			}
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x8FDD00", Offset = "0x8FCF00", VA = "0x1808FDD00", Slot = "128")]
		public virtual bool ReadSyncVar___ScheduleOne.NPCs.NPC(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0x8F9220", Offset = "0x8F8420", VA = "0x1808F9220", Slot = "129")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPC_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		private const int PanicDuration = 15;

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		public const bool RequiresRegionUnlocked = true;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		[FieldOffset(Offset = "0x118")]
		[Header("Info Settings")]
		public string FirstName;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		[FieldOffset(Offset = "0x120")]
		public bool hasLastName;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		[FieldOffset(Offset = "0x128")]
		public string LastName;

		// Token: 0x040034B8 RID: 13496
		[Token(Token = "0x40034B8")]
		[FieldOffset(Offset = "0x138")]
		public string ID;

		// Token: 0x040034B9 RID: 13497
		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x140")]
		public Sprite MugshotSprite;

		// Token: 0x040034BA RID: 13498
		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x148")]
		public EMapRegion Region;

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x14C")]
		[Header("If true, NPC will respawn next day instead of waiting 3 days.")]
		public bool IsImportant;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x150")]
		[Range(0f, 1f)]
		[Header("Personality")]
		public float Aggression;

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x158")]
		[Header("References")]
		[SerializeField]
		protected Transform modelContainer;

		// Token: 0x040034BE RID: 13502
		[Token(Token = "0x40034BE")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040034BF RID: 13503
		[Token(Token = "0x40034BF")]
		[FieldOffset(Offset = "0x168")]
		public NPCMovement Movement;

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		[FieldOffset(Offset = "0x170")]
		public DialogueHandler DialogueHandler;

		// Token: 0x040034C1 RID: 13505
		[Token(Token = "0x40034C1")]
		[FieldOffset(Offset = "0x178")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x040034C2 RID: 13506
		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x180")]
		public NPCAwareness Awareness;

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x188")]
		public NPCResponses Responses;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x190")]
		public NPCActions Actions;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x198")]
		public NPCBehaviour Behaviour;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x1A0")]
		public NPCInventory Inventory;

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x1A8")]
		public VOEmitter VoiceOverEmitter;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x1B0")]
		public NPCHealth Health;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x1B8")]
		public EntityVisibility Visibility;

		// Token: 0x040034CB RID: 13515
		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x1C8")]
		public Action<LandVehicle> onEnterVehicle;

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x1D0")]
		public Action<LandVehicle> onExitVehicle;

		// Token: 0x040034CF RID: 13519
		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x1E8")]
		[Header("Summoning")]
		public bool CanBeSummoned;

		// Token: 0x040034D0 RID: 13520
		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Relationship")]
		public NPCRelationData RelationData;

		// Token: 0x040034D1 RID: 13521
		[Token(Token = "0x40034D1")]
		[FieldOffset(Offset = "0x1F8")]
		public string NPCUnlockedVariable;

		// Token: 0x040034D2 RID: 13522
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x200")]
		public bool ShowRelationshipInfo;

		// Token: 0x040034D3 RID: 13523
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x208")]
		[Header("Messaging")]
		public List<EConversationCategory> ConversationCategories;

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x210")]
		public bool MessagingKnownByDefault;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x220")]
		public bool ConversationCanBeHidden;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x228")]
		public Action onConversationCreated;

		// Token: 0x040034D8 RID: 13528
		[Token(Token = "0x40034D8")]
		[FieldOffset(Offset = "0x230")]
		[Header("Other Settings")]
		public bool CanOpenDoors;

		// Token: 0x040034D9 RID: 13529
		[Token(Token = "0x40034D9")]
		[FieldOffset(Offset = "0x231")]
		public bool OverrideParent;

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x238")]
		public Transform OverriddenParent;

		// Token: 0x040034DB RID: 13531
		[Token(Token = "0x40034DB")]
		[FieldOffset(Offset = "0x240")]
		public bool IgnoreImpacts;

		// Token: 0x040034DC RID: 13532
		[Token(Token = "0x40034DC")]
		[FieldOffset(Offset = "0x244")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _useUmbrellaChance;

		// Token: 0x040034DD RID: 13533
		[Token(Token = "0x40034DD")]
		[FieldOffset(Offset = "0x248")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _rainTolerance;

		// Token: 0x040034DE RID: 13534
		[Token(Token = "0x40034DE")]
		[FieldOffset(Offset = "0x24C")]
		[SerializeField]
		[Range(1f, 10f)]
		private float _walkInRainMaxSpeedMultiplier;

		// Token: 0x040034DF RID: 13535
		[Token(Token = "0x40034DF")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		protected List<GameObject> OutlineRenderers;

		// Token: 0x040034E0 RID: 13536
		[Token(Token = "0x40034E0")]
		[FieldOffset(Offset = "0x258")]
		protected Outlinable OutlineEffect;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x280")]
		[Header("GUID")]
		public string BakedGUID;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x2A0")]
		public Action<bool> onVisibilityChanged;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x2B0")]
		private Coroutine resetUnsettledCoroutine;

		// Token: 0x040034F0 RID: 13552
		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x2D8")]
		private List<int> impactHistory;

		// Token: 0x040034F1 RID: 13553
		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x2E0")]
		private int headlightStartTime;

		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0x2E4")]
		private int heaedLightsEndTime;

		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0x2E8")]
		protected float defaultAggression;

		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0x2F0")]
		private WeatherConditions _weatherTolerence;

		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0x2F8")]
		protected WeatherConditions _currentWeatherConditionsForEntity;

		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0x300")]
		private float _wetness;

		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		private const float NPC_WET_RATE = 0.1f;

		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		private const float NPC_DRY_RATE = 0.05f;

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x308")]
		protected NetworkedEquipper _networkedEquipper;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x310")]
		private Coroutine lerpScaleRoutine;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x318")]
		public SyncVar<bool> syncVar___<HasUmbrella>k__BackingField;

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x320")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x321")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted;
	}
}
