using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Law
{
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0000B7F0 File Offset: 0x000099F0
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FA")]
		public bool IsEnabled
		{
			[Token(Token = "0x60021B9")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021BA")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0000B808 File Offset: 0x00009A08
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FB")]
		public bool IsCurrentlyActive
		{
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x621930", Offset = "0x620B30", VA = "0x180621930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021BC")]
			[Address(RVA = "0x621940", Offset = "0x620B40", VA = "0x180621940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0000B820 File Offset: 0x00009A20
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FC")]
		public bool IsHardCurfewActive
		{
			[Token(Token = "0x60021BD")]
			[Address(RVA = "0x66F790", Offset = "0x66E990", VA = "0x18066F790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x66F7A0", Offset = "0x66E9A0", VA = "0x18066F7A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x66E420", Offset = "0x66D620", VA = "0x18066E420", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x66F5A0", Offset = "0x66E7A0", VA = "0x18066F5A0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x66E990", Offset = "0x66DB90", VA = "0x18066E990", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x66E620", Offset = "0x66D820", VA = "0x18066E620")]
		[ObserversRpc]
		[TargetRpc]
		public void Enable(NetworkConnection conn)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x66E500", Offset = "0x66D700", VA = "0x18066E500")]
		[ObserversRpc]
		public void Disable()
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x66E9F0", Offset = "0x66DBF0", VA = "0x18066E9F0")]
		private void OnUncappedMinPass()
		{
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x66F750", Offset = "0x66E950", VA = "0x18066F750")]
		public CurfewManager()
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x66E860", Offset = "0x66DA60", VA = "0x18066E860", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x66E810", Offset = "0x66DA10", VA = "0x18066E810", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x66F360", Offset = "0x66E560", VA = "0x18066F360")]
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x66F160", Offset = "0x66E360", VA = "0x18066F160")]
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x66F2F0", Offset = "0x66E4F0", VA = "0x18066F2F0")]
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x66F470", Offset = "0x66E670", VA = "0x18066F470")]
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x66F320", Offset = "0x66E520", VA = "0x18066F320")]
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x66E500", Offset = "0x66D700", VA = "0x18066E500")]
		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x66F0C0", Offset = "0x66E2C0", VA = "0x18066F0C0")]
		public void RpcLogic___Disable_2166136261()
		{
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x66F240", Offset = "0x66E440", VA = "0x18066F240")]
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x66E370", Offset = "0x66D570", VA = "0x18066E370", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Law.CurfewManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		private const string NORMAL_MESSAGE = "CURFEW TONIGHT\n9PM - 5AM";

		// Token: 0x04001B48 RID: 6984
		[Token(Token = "0x4001B48")]
		private const string CURFEW_MESSAGE = "CURFEW ACTIVE\n UNTIL 5AM";

		// Token: 0x04001B49 RID: 6985
		[Token(Token = "0x4001B49")]
		private const string WARNING_MESSAGE = "CURFEW SOON\n{0} MINS";

		// Token: 0x04001B4A RID: 6986
		[Token(Token = "0x4001B4A")]
		public const int HOUR_BEFORE_CURFEW = 2000;

		// Token: 0x04001B4B RID: 6987
		[Token(Token = "0x4001B4B")]
		public const int WARNING_TIME = 2030;

		// Token: 0x04001B4C RID: 6988
		[Token(Token = "0x4001B4C")]
		public const int CURFEW_START_TIME = 2100;

		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		public const int HARD_CURFEW_START_TIME = 2115;

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		public const int CURFEW_END_TIME = 500;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public VMSBoard[] VMSBoards;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[FieldOffset(Offset = "0x130")]
		public AudioSourceController CurfewWarningSound;

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x138")]
		public AudioSourceController CurfewAlarmSound;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onCurfewEnabled;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onCurfewDisabled;

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onCurfewHint;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onCurfewWarning;

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onCurfewStart;

		// Token: 0x04001B5A RID: 7002
		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x168")]
		public UnityEvent onCurfewHardStart;

		// Token: 0x04001B5B RID: 7003
		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onCurfewEnd;

		// Token: 0x04001B5C RID: 7004
		[Token(Token = "0x4001B5C")]
		[FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B5D RID: 7005
		[Token(Token = "0x4001B5D")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted;
	}
}
