using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	public class TimeManager : NetworkSingleton<TimeManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x170003AC")]
		public static float MinuteDuration
		{
			[Token(Token = "0x60011CD")]
			[Address(RVA = "0xB2FB80", Offset = "0xB2ED80", VA = "0x180B2FB80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000083A0 File Offset: 0x000065A0
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AD")]
		public int DefaultTime
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000083B8 File Offset: 0x000065B8
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AE")]
		public int CurrentTime
		{
			[Token(Token = "0x60011D0")]
			[Address(RVA = "0x51C040", Offset = "0x51B240", VA = "0x18051C040")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011D1")]
			[Address(RVA = "0x678400", Offset = "0x677600", VA = "0x180678400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x170003AF")]
		public EDay CurrentDay
		{
			[Token(Token = "0x60011D2")]
			[Address(RVA = "0xB2FB00", Offset = "0xB2ED00", VA = "0x180B2FB00")]
			get
			{
				return EDay.Monday;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000083E8 File Offset: 0x000065E8
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B0")]
		public int ElapsedDays
		{
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x630330", Offset = "0x62F530", VA = "0x180630330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x630400", Offset = "0x62F600", VA = "0x180630400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x170003B1")]
		public bool IsEndOfDay
		{
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0xB2FB40", Offset = "0xB2ED40", VA = "0x180B2FB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x170003B2")]
		public bool IsNight
		{
			[Token(Token = "0x60011D6")]
			[Address(RVA = "0xB2FB50", Offset = "0xB2ED50", VA = "0x180B2FB50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x170003B3")]
		public float NormalizedTimeOfDay
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0xB2FBE0", Offset = "0xB2EDE0", VA = "0x180B2FBE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x170003B4")]
		public int DayIndex
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0xB2FB00", Offset = "0xB2ED00", VA = "0x180B2FB00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00008460 File Offset: 0x00006660
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B5")]
		public bool IsSleepInProgress
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x58D080", Offset = "0x58C280", VA = "0x18058D080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x58D240", Offset = "0x58C440", VA = "0x18058D240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00008478 File Offset: 0x00006678
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B6")]
		public float Playtime
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x7B1220", Offset = "0x7B0420", VA = "0x1807B1220")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0xB2FDF0", Offset = "0xB2EFF0", VA = "0x180B2FDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00008490 File Offset: 0x00006690
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B7")]
		public bool HostSleepDone
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011DE")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x000084A8 File Offset: 0x000066A8
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		public float TimeSpeedMultiplier
		{
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x5112C0", Offset = "0x5104C0", VA = "0x1805112C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60011E0")]
			[Address(RVA = "0xB2FE00", Offset = "0xB2F000", VA = "0x180B2FE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x000084C0 File Offset: 0x000066C0
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B9")]
		public int DailyMinSum
		{
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x71D5A0", Offset = "0x71C7A0", VA = "0x18071D5A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x71D780", Offset = "0x71C980", VA = "0x18071D780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x170003BA")]
		private float _minuteStaggerTime
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0xB2FD20", Offset = "0xB2EF20", VA = "0x180B2FD20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x170003BB")]
		private float _tickStaggerTime
		{
			[Token(Token = "0x60011E4")]
			[Address(RVA = "0xB2FDD0", Offset = "0xB2EFD0", VA = "0x180B2FDD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003BC")]
		public string SaveFolderName
		{
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0xB2FCF0", Offset = "0xB2EEF0", VA = "0x180B2FCF0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003BD")]
		public string SaveFileName
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0xB2FCC0", Offset = "0xB2EEC0", VA = "0x180B2FCC0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003BE")]
		public Loader Loader
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x6D6C70", Offset = "0x6D5E70", VA = "0x1806D6C70", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x170003BF")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x6D6C80", Offset = "0x6D5E80", VA = "0x1806D6C80", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x6D6DD0", Offset = "0x6D5FD0", VA = "0x1806D6DD0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C1")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x7B12D0", Offset = "0x7B04D0", VA = "0x1807B12D0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60011EC")]
			[Address(RVA = "0x92AC10", Offset = "0x929E10", VA = "0x18092AC10", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00008520 File Offset: 0x00006720
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		public bool HasChanged
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0xB2FB30", Offset = "0xB2ED30", VA = "0x180B2FB30", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011EE")]
			[Address(RVA = "0xB2FDE0", Offset = "0xB2EFE0", VA = "0x180B2FDE0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x170003C3")]
		public int LoadOrder
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0xB2FB70", Offset = "0xB2ED70", VA = "0x180B2FB70", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0xB2BBE0", Offset = "0xB2ADE0", VA = "0x180B2BBE0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0xB2F490", Offset = "0xB2E690", VA = "0x180B2F490", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0xB2C3E0", Offset = "0xB2B5E0", VA = "0x180B2C3E0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0xB2C960", Offset = "0xB2BB60", VA = "0x180B2C960", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0xB2CA70", Offset = "0xB2BC70", VA = "0x180B2CA70", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0xB2C9F0", Offset = "0xB2BBF0", VA = "0x180B2C9F0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0xB2BEA0", Offset = "0xB2B0A0", VA = "0x180B2BEA0")]
		private void Clean()
		{
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0xB2EA90", Offset = "0xB2DC90", VA = "0x180B2EA90")]
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		[TargetRpc]
		private void SetTimeData_Client(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0xB2F710", Offset = "0xB2E910", VA = "0x180B2F710", Slot = "50")]
		protected virtual void Update()
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0xB2BFD0", Offset = "0xB2B1D0", VA = "0x180B2BFD0", Slot = "51")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0xB2F5A0", Offset = "0xB2E7A0", VA = "0x180B2F5A0")]
		private IEnumerator TickLoop()
		{
			return null;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0xB2F610", Offset = "0xB2E810", VA = "0x180B2F610")]
		private IEnumerator TimeLoop()
		{
			return null;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0xB2F050", Offset = "0xB2E250", VA = "0x180B2F050")]
		private bool ShouldMinutePass()
		{
			return default(bool);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0xB2CDC0", Offset = "0xB2BFC0", VA = "0x180B2CDC0")]
		private void PassMinute()
		{
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0xB2CC70", Offset = "0xB2BE70", VA = "0x180B2CC70")]
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void PassMinute_Client(int oldTime)
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0xB2E9B0", Offset = "0xB2DBB0", VA = "0x180B2E9B0")]
		public void SetTimeAndSync(int time)
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001200")]
		[Address(RVA = "0xB2EE70", Offset = "0xB2E070", VA = "0x180B2EE70")]
		private void SetTime(int time)
		{
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6001201")]
		[Address(RVA = "0xB2C590", Offset = "0xB2B790", VA = "0x180B2C590")]
		public bool IsCurrentTimeWithinRange(int min, int max)
		{
			return default(bool);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6001202")]
		[Address(RVA = "0xB2C470", Offset = "0xB2B670", VA = "0x180B2C470")]
		public bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			return default(bool);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6001203")]
		[Address(RVA = "0xB2C210", Offset = "0xB2B410", VA = "0x180B2C210")]
		public GameDateTime GetDateTime()
		{
			return default(GameDateTime);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6001204")]
		[Address(RVA = "0xB2C3C0", Offset = "0xB2B5C0", VA = "0x180B2C3C0")]
		public int GetTotalMinSum()
		{
			return 0;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001205")]
		[Address(RVA = "0xB2EDE0", Offset = "0xB2DFE0", VA = "0x180B2EDE0")]
		public void SetTimeSpeedMultiplier(float multiplier)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001206")]
		[Address(RVA = "0xB2E710", Offset = "0xB2D910", VA = "0x180B2E710")]
		public void SetCycleDuration(float time)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001207")]
		[Address(RVA = "0xB2BD20", Offset = "0xB2AF20", VA = "0x180B2BD20")]
		private void CheckSleepStart()
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001208")]
		[Address(RVA = "0xB2F370", Offset = "0xB2E570", VA = "0x180B2F370")]
		[ObserversRpc(RunLocally = true)]
		public void StartSleep()
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001209")]
		[Address(RVA = "0xB2E870", Offset = "0xB2DA70", VA = "0x180B2E870")]
		[ObserversRpc(RunLocally = true)]
		public void SetHostSleepDone(bool done)
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120A")]
		[Address(RVA = "0xB2F0D0", Offset = "0xB2E2D0", VA = "0x180B2F0D0")]
		private void SkipForwardToTime(int newTime)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120B")]
		[Address(RVA = "0xB2CAF0", Offset = "0xB2BCF0", VA = "0x180B2CAF0")]
		[ObserversRpc(RunLocally = true)]
		private void OnTimeSkip_Client(int oldTime, int newTime)
		{
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x600120C")]
		[Address(RVA = "0xB2C630", Offset = "0xB2B830", VA = "0x180B2C630")]
		public static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			return default(bool);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x600120D")]
		[Address(RVA = "0xB2C650", Offset = "0xB2B850", VA = "0x180B2C650")]
		public static bool IsValid24HourTime(string input)
		{
			return default(bool);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600120E")]
		[Address(RVA = "0xB2C000", Offset = "0xB2B200", VA = "0x180B2C000")]
		public static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			return null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x600120F")]
		[Address(RVA = "0xB2C1C0", Offset = "0xB2B3C0", VA = "0x180B2C1C0")]
		public static int Get24HourTimeFromMinSum(int minSum)
		{
			return 0;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x6001210")]
		[Address(RVA = "0xB2C230", Offset = "0xB2B430", VA = "0x180B2C230")]
		public static int GetMinSumFrom24HourTime(int _time)
		{
			return 0;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001211")]
		[Address(RVA = "0xB2C250", Offset = "0xB2B450", VA = "0x180B2C250")]
		public static string GetMinutesToDisplayTime(int minutes)
		{
			return null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x6001212")]
		[Address(RVA = "0xB2B9F0", Offset = "0xB2ABF0", VA = "0x180B2B9F0")]
		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			return 0;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001213")]
		[Address(RVA = "0xB2C300", Offset = "0xB2B500", VA = "0x180B2C300", Slot = "52")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001214")]
		[Address(RVA = "0xB2C6C0", Offset = "0xB2B8C0", VA = "0x180B2C6C0")]
		public void Load(TimeData timeData)
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001215")]
		[Address(RVA = "0xB2F940", Offset = "0xB2EB40", VA = "0x180B2F940")]
		public TimeManager()
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001218")]
		[Address(RVA = "0xB2F680", Offset = "0xB2E880", VA = "0x180B2F680")]
		[CompilerGenerated]
		private IEnumerator <StartSleep>g__WaitForSleepEnd|118_0()
		{
			return null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121A")]
		[Address(RVA = "0xB2C760", Offset = "0xB2B960", VA = "0x180B2C760", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121B")]
		[Address(RVA = "0xB2C710", Offset = "0xB2B910", VA = "0x180B2C710", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121D")]
		[Address(RVA = "0xB2E280", Offset = "0xB2D480", VA = "0x180B2E280")]
		private void RpcWriter___Observers_SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121E")]
		[Address(RVA = "0xB2D5C0", Offset = "0xB2C7C0", VA = "0x180B2D5C0")]
		private void RpcLogic___SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		[Address(RVA = "0xB2DCB0", Offset = "0xB2CEB0", VA = "0x180B2DCB0")]
		private void RpcReader___Observers_SetTimeData_Client_1794730778(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001220")]
		[Address(RVA = "0xB2E560", Offset = "0xB2D760", VA = "0x180B2E560")]
		private void RpcWriter___Target_SetTimeData_Client_1794730778(NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001221")]
		[Address(RVA = "0xB2DDB0", Offset = "0xB2CFB0", VA = "0x180B2DDB0")]
		private void RpcReader___Target_SetTimeData_Client_1794730778(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001222")]
		[Address(RVA = "0xB2DFF0", Offset = "0xB2D1F0", VA = "0x180B2DFF0")]
		private void RpcWriter___Observers_PassMinute_Client_3316948804(int oldTime)
		{
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001223")]
		[Address(RVA = "0xB2D280", Offset = "0xB2C480", VA = "0x180B2D280")]
		private void RpcLogic___PassMinute_Client_3316948804(int oldTime)
		{
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001224")]
		[Address(RVA = "0xB2DBC0", Offset = "0xB2CDC0", VA = "0x180B2DBC0")]
		private void RpcReader___Observers_PassMinute_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0xB2E440", Offset = "0xB2D640", VA = "0x180B2E440")]
		private void RpcWriter___Observers_StartSleep_2166136261()
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0xB2D890", Offset = "0xB2CA90", VA = "0x180B2D890")]
		public void RpcLogic___StartSleep_2166136261()
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0xB2DD70", Offset = "0xB2CF70", VA = "0x180B2DD70")]
		private void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0xB2E140", Offset = "0xB2D340", VA = "0x180B2E140")]
		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001229")]
		[Address(RVA = "0xB2D500", Offset = "0xB2C700", VA = "0x180B2D500")]
		public void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122A")]
		[Address(RVA = "0xB2DC30", Offset = "0xB2CE30", VA = "0x180B2DC30")]
		private void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122B")]
		[Address(RVA = "0xB2DE70", Offset = "0xB2D070", VA = "0x180B2DE70")]
		private void RpcWriter___Observers_OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122C")]
		[Address(RVA = "0xB2CF10", Offset = "0xB2C110", VA = "0x180B2CF10")]
		private void RpcLogic___OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122D")]
		[Address(RVA = "0xB2DB20", Offset = "0xB2CD20", VA = "0x180B2DB20")]
		private void RpcReader___Observers_OnTimeSkip_Client_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122E")]
		[Address(RVA = "0xB2BAD0", Offset = "0xB2ACD0", VA = "0x180B2BAD0", Slot = "53")]
		protected virtual void Awake_UserLogic_ScheduleOne.GameTime.TimeManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		private const float DefaultCycleDuration = 24f;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		public const float TickDuration = 0.5f;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		public const int EndOfDay = 400;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		public const int WakeTime = 700;

		// Token: 0x0400107D RID: 4221
		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x0")]
		private static float CycleDuration;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private EDay _defaultDay;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x144")]
		private float _lastMinWaitExcess;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x148")]
		private bool _stopMinPassWait;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x14C")]
		private float _secondsOnCurrentMinute;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x150")]
		public ActionList onMinutePass;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x158")]
		public ActionList onUncappedMinutePass;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x160")]
		public ActionList onTick;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0x168")]
		public Action onTimeChanged;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0x170")]
		public Action<int> onTimeSkip;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0x178")]
		public Action onTimeSet;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0x180")]
		public Action onHourPass;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x188")]
		public Action onDayPass;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x190")]
		public Action onWeekPass;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x198")]
		public Action onUpdate;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x1A0")]
		public Action onFixedUpdate;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x1A8")]
		public Action onSleepStart;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x1B0")]
		public Action onSleepEnd;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x1B8")]
		private TimeLoader loader;

		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x1D8")]
		private bool NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x1D9")]
		private bool NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted;
	}
}
