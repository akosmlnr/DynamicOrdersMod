using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Core;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.ATM;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Money
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	public class ATM : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0000A6F8 File Offset: 0x000088F8
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000532")]
		public bool IsBroken
		{
			[Token(Token = "0x6001C82")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0000A710 File Offset: 0x00008910
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000533")]
		public int DaysUntilRepair
		{
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x511A30", Offset = "0x510C30", VA = "0x180511A30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C85")]
			[Address(RVA = "0x61FC90", Offset = "0x61EE90", VA = "0x18061FC90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0000A728 File Offset: 0x00008928
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000534")]
		public bool isInUse
		{
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x5AF090", Offset = "0x5AE290", VA = "0x1805AF090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x61FCC0", Offset = "0x61EEC0", VA = "0x18061FCC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0000A740 File Offset: 0x00008940
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000535")]
		public Guid GUID
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x61FC80", Offset = "0x61EE80", VA = "0x18061FC80", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x61FCA0", Offset = "0x61EEA0", VA = "0x18061FCA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x61EDC0", Offset = "0x61DFC0", VA = "0x18061EDC0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x61DA90", Offset = "0x61CC90", VA = "0x18061DA90", Slot = "26")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x61F880", Offset = "0x61EA80", VA = "0x18061F880", Slot = "27")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x61ED80", Offset = "0x61DF80", VA = "0x18061ED80", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x61F810", Offset = "0x61EA10", VA = "0x18061F810", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x61DE90", Offset = "0x61D090", VA = "0x18061DE90")]
		public void DayPass()
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x61FB70", Offset = "0x61ED70", VA = "0x18061FB70")]
		public void WeekPass()
		{
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x61E720", Offset = "0x61D920", VA = "0x18061E720")]
		public void Hovered()
		{
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x61EAA0", Offset = "0x61DCA0", VA = "0x18061EAA0")]
		public void Interacted()
		{
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x61E0F0", Offset = "0x61D2F0", VA = "0x18061E0F0")]
		public void Enter()
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x61E400", Offset = "0x61D600", VA = "0x18061E400")]
		public void Exit()
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x61E7B0", Offset = "0x61D9B0", VA = "0x18061E7B0")]
		private void Impacted(Impact impact)
		{
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x61F6F0", Offset = "0x61E8F0", VA = "0x18061F6F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x61DC20", Offset = "0x61CE20", VA = "0x18061DC20")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Break(NetworkConnection conn)
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x61EE10", Offset = "0x61E010", VA = "0x18061EE10")]
		[ObserversRpc]
		private void Repair()
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x61DFE0", Offset = "0x61D1E0", VA = "0x18061DFE0")]
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x61EAC0", Offset = "0x61DCC0", VA = "0x18061EAC0", Slot = "24")]
		public void Load(GenericSaveData data)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x61E650", Offset = "0x61D850", VA = "0x18061E650", Slot = "25")]
		public GenericSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x61FC20", Offset = "0x61EE20", VA = "0x18061FC20")]
		public ATM()
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x61FB00", Offset = "0x61ED00", VA = "0x18061FB00")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|45_0()
		{
			return null;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x61EBD0", Offset = "0x61DDD0", VA = "0x18061EBD0", Slot = "28")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x61EBB0", Offset = "0x61DDB0", VA = "0x18061EBB0", Slot = "29")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x61EB70", Offset = "0x61DD70", VA = "0x18061EB70", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x61F4B0", Offset = "0x61E6B0", VA = "0x18061F4B0")]
		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x61F1F0", Offset = "0x61E3F0", VA = "0x18061F1F0")]
		private void RpcLogic___SendBreak_2166136261()
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x61F2E0", Offset = "0x61E4E0", VA = "0x18061F2E0")]
		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x61F390", Offset = "0x61E590", VA = "0x18061F390")]
		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x61EF30", Offset = "0x61E130", VA = "0x18061EF30")]
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x61F210", Offset = "0x61E410", VA = "0x18061F210")]
		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x61F5C0", Offset = "0x61E7C0", VA = "0x18061F5C0")]
		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x61F340", Offset = "0x61E540", VA = "0x18061F340")]
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x61EE10", Offset = "0x61E010", VA = "0x18061EE10")]
		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x61F1C0", Offset = "0x61E3C0", VA = "0x18061F1C0")]
		private void RpcLogic___Repair_2166136261()
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x61F260", Offset = "0x61E460", VA = "0x18061F260")]
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x61DFE0", Offset = "0x61D1E0", VA = "0x18061DFE0")]
		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x61EF60", Offset = "0x61E160", VA = "0x18061EF60")]
		private void RpcLogic___DropCash_2166136261()
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x61F2B0", Offset = "0x61E4B0", VA = "0x18061F2B0")]
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x61D930", Offset = "0x61CB30", VA = "0x18061D930")]
		private void Awake_UserLogic_ScheduleOne.Money.ATM_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		public const bool DepositLimitEnabled = true;

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		public const float WEEKLY_DEPOSIT_LIMIT = 10000f;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		public const float IMPACT_THRESHOLD_BREAK = 150f;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		public const int REPAIR_TIME_DAYS = 0;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		public const int MIN_CASH_DROP = 2;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		public const int MAX_CASH_DROP = 8;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x0")]
		public static float WeeklyDepositSum;

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x120")]
		public CashPickup CashPrefab;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected Transform camPos;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected ATMInterface interfaceATM;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x140")]
		public Transform AccessPoint;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x148")]
		public Transform CashSpawnPoint;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x150")]
		public PhysicsDamageable Damageable;

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x4")]
		[Header("Settings")]
		public static float viewLerpTime;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onBreak;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x180")]
		public UnityEvent onRepair;

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted;
	}
}
