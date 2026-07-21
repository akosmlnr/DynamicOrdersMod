using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	public class CartelRegionActivities : NetworkBehaviour
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000852")]
		public CartelActivity CurrentActivity
		{
			[Token(Token = "0x6003454")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003455")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000853")]
		public int HoursUntilNextActivity
		{
			[Token(Token = "0x6003456")]
			[Address(RVA = "0x51C040", Offset = "0x51B240", VA = "0x18051C040")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003457")]
			[Address(RVA = "0x678400", Offset = "0x677600", VA = "0x180678400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x7990E0", Offset = "0x7982E0", VA = "0x1807990E0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x799B50", Offset = "0x798D50", VA = "0x180799B50")]
		private void Start()
		{
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x799000", Offset = "0x798200", VA = "0x180799000", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x798D60", Offset = "0x797F60", VA = "0x180798D60")]
		public void HourPass()
		{
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x799E70", Offset = "0x799070", VA = "0x180799E70")]
		private void TryStartActivity()
		{
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x7998B0", Offset = "0x798AB0", VA = "0x1807998B0")]
		[Button]
		public void StartActivity()
		{
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345E")]
		[Address(RVA = "0x7998A0", Offset = "0x798AA0", VA = "0x1807998A0")]
		private void StartAcivity(int activityIndex)
		{
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x7985C0", Offset = "0x7977C0", VA = "0x1807985C0")]
		[Button]
		public void ActivateDeal()
		{
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x7998D0", Offset = "0x798AD0", VA = "0x1807998D0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void StartActivity(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x7985D0", Offset = "0x7977D0", VA = "0x1807985D0")]
		private void ActivityEnded()
		{
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x798750", Offset = "0x797950", VA = "0x180798750")]
		public CartelRegionalActivityData GetData()
		{
			return null;
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x798E70", Offset = "0x798070", VA = "0x180798E70")]
		public void Load(CartelRegionalActivityData data)
		{
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x798840", Offset = "0x797A40", VA = "0x180798840")]
		public static int GetNewCooldown(EMapRegion region)
		{
			return 0;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x798720", Offset = "0x797920", VA = "0x180798720")]
		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x79A220", Offset = "0x799420", VA = "0x18079A220")]
		public CartelRegionActivities()
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x798F30", Offset = "0x798130", VA = "0x180798F30", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x798F10", Offset = "0x798110", VA = "0x180798F10", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003469")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346A")]
		[Address(RVA = "0x7995E0", Offset = "0x7987E0", VA = "0x1807995E0")]
		private void RpcWriter___Observers_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346B")]
		[Address(RVA = "0x799180", Offset = "0x798380", VA = "0x180799180")]
		private void RpcLogic___StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346C")]
		[Address(RVA = "0x799500", Offset = "0x798700", VA = "0x180799500")]
		private void RpcReader___Observers_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346D")]
		[Address(RVA = "0x799730", Offset = "0x798930", VA = "0x180799730")]
		private void RpcWriter___Target_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346E")]
		[Address(RVA = "0x799570", Offset = "0x798770", VA = "0x180799570")]
		private void RpcReader___Target_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		public const int MIN_COOLDOWN = 12;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		public const int MAX_COOLDOWN = 48;

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x118")]
		public bool TEST_MODE;

		// Token: 0x04002633 RID: 9779
		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0x12C")]
		[Header("Settings")]
		public bool Active;

		// Token: 0x04002634 RID: 9780
		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0x130")]
		public EMapRegion Region;

		// Token: 0x04002635 RID: 9781
		[Token(Token = "0x4002635")]
		[FieldOffset(Offset = "0x138")]
		public List<CartelActivity> Activities;

		// Token: 0x04002636 RID: 9782
		[Token(Token = "0x4002636")]
		[FieldOffset(Offset = "0x140")]
		[Header("References")]
		public CartelAmbushLocation[] AmbushLocations;

		// Token: 0x04002637 RID: 9783
		[Token(Token = "0x4002637")]
		[FieldOffset(Offset = "0x148")]
		public CartelDealer CartelDealer;

		// Token: 0x04002638 RID: 9784
		[Token(Token = "0x4002638")]
		[FieldOffset(Offset = "0x150")]
		[Header("Development & Debugging")]
		public int _debugActivityIndex;

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		[FieldOffset(Offset = "0x154")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x155")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted;
	}
}
