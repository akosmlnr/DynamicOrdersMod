using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	public class NPCEvent_StayInBuilding : NPCEvent
	{
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060055CB RID: 21963 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C96")]
		public new string ActionName
		{
			[Token(Token = "0x60055CB")]
			[Address(RVA = "0x982290", Offset = "0x981490", VA = "0x180982290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x17000C97")]
		private bool InBuilding
		{
			[Token(Token = "0x60055CC")]
			[Address(RVA = "0x9822C0", Offset = "0x9814C0", VA = "0x1809822C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x97A0D0", Offset = "0x9792D0", VA = "0x18097A0D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x9814F0", Offset = "0x9806F0", VA = "0x1809814F0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x9820C0", Offset = "0x9812C0", VA = "0x1809820C0", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x981900", Offset = "0x980B00", VA = "0x180981900", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x981730", Offset = "0x980930", VA = "0x180981730", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x9816B0", Offset = "0x9808B0", VA = "0x1809816B0", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x980FB0", Offset = "0x9801B0", VA = "0x180980FB0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x981610", Offset = "0x980810", VA = "0x180981610", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x9820B0", Offset = "0x9812B0", VA = "0x1809820B0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x981DD0", Offset = "0x980FD0", VA = "0x180981DD0", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x982240", Offset = "0x981440", VA = "0x180982240", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x981CB0", Offset = "0x980EB0", VA = "0x180981CB0")]
		[ObserversRpc(RunLocally = true)]
		private void PlayEnterAnimation()
		{
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x980F10", Offset = "0x980110", VA = "0x180980F10")]
		private void CancelEnter()
		{
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x981050", Offset = "0x980250", VA = "0x180981050", Slot = "45")]
		protected virtual void EnterBuilding(int doorIndex)
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x981170", Offset = "0x980370", VA = "0x180981170")]
		private void ExitBuilding()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x981390", Offset = "0x980590", VA = "0x180981390")]
		private Transform GetEntryPoint()
		{
			return null;
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x9811D0", Offset = "0x9803D0", VA = "0x1809811D0")]
		private StaticDoor GetDoor(out int doorIndex)
		{
			return null;
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCEvent_StayInBuilding()
		{
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x9821D0", Offset = "0x9813D0", VA = "0x1809821D0")]
		[CompilerGenerated]
		private IEnumerator <PlayEnterAnimation>g__Enter|19_0()
		{
			return null;
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x981850", Offset = "0x980A50", VA = "0x180981850", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x981810", Offset = "0x980A10", VA = "0x180981810", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x981FA0", Offset = "0x9811A0", VA = "0x180981FA0")]
		private void RpcWriter___Observers_PlayEnterAnimation_2166136261()
		{
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x981E50", Offset = "0x981050", VA = "0x180981E50")]
		private void RpcLogic___PlayEnterAnimation_2166136261()
		{
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x981F60", Offset = "0x981160", VA = "0x180981F60")]
		private void RpcReader___Observers_PlayEnterAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x9789D0", Offset = "0x977BD0", VA = "0x1809789D0", Slot = "46")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040039A8 RID: 14760
		[Token(Token = "0x40039A8")]
		[FieldOffset(Offset = "0x158")]
		public NPCEnterableBuilding Building;

		// Token: 0x040039A9 RID: 14761
		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x160")]
		[Header("Optionally specify door to use. Otherwise closest door will be used.")]
		public StaticDoor Door;

		// Token: 0x040039AA RID: 14762
		[Token(Token = "0x40039AA")]
		[FieldOffset(Offset = "0x168")]
		private bool IsEntering;

		// Token: 0x040039AB RID: 14763
		[Token(Token = "0x40039AB")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine enterRoutine;

		// Token: 0x040039AC RID: 14764
		[Token(Token = "0x40039AC")]
		[FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted;

		// Token: 0x040039AD RID: 14765
		[Token(Token = "0x40039AD")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted;
	}
}
