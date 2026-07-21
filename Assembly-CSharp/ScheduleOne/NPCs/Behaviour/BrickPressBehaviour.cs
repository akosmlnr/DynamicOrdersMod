using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class BrickPressBehaviour : Behaviour
	{
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C28")]
		public BrickPress Press
		{
			[Token(Token = "0x60050CE")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050CF")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x00015270 File Offset: 0x00013470
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C29")]
		public bool PackagingInProgress
		{
			[Token(Token = "0x60050D0")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050D1")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x948350", Offset = "0x947550", VA = "0x180948350", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x948C00", Offset = "0x947E00", VA = "0x180948C00", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x948BB0", Offset = "0x947DB0", VA = "0x180948BB0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x948490", Offset = "0x947690", VA = "0x180948490", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x9488F0", Offset = "0x947AF0", VA = "0x1809488F0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x948EE0", Offset = "0x9480E0", VA = "0x180948EE0")]
		private void StartPackaging()
		{
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void AssignStation(BrickPress press)
		{
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x948630", Offset = "0x947830", VA = "0x180948630")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x9485B0", Offset = "0x9477B0", VA = "0x1809485B0")]
		public void GoToStation()
		{
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x948370", Offset = "0x947570", VA = "0x180948370")]
		[ObserversRpc(RunLocally = true)]
		public void BeginPackaging()
		{
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x948FE0", Offset = "0x9481E0", VA = "0x180948FE0")]
		private void StopPackaging()
		{
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x9486C0", Offset = "0x9478C0", VA = "0x1809486C0")]
		public bool IsStationReady(BrickPress press)
		{
			return default(bool);
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public BrickPressBehaviour()
		{
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x949020", Offset = "0x948220", VA = "0x180949020")]
		[CompilerGenerated]
		private IEnumerator <BeginPackaging>g__Package|20_0()
		{
			return null;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x948860", Offset = "0x947A60", VA = "0x180948860", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x948DD0", Offset = "0x947FD0", VA = "0x180948DD0")]
		private void RpcWriter___Observers_BeginPackaging_2166136261()
		{
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x948C20", Offset = "0x947E20", VA = "0x180948C20")]
		public void RpcLogic___BeginPackaging_2166136261()
		{
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E6")]
		[Address(RVA = "0x948D90", Offset = "0x947F90", VA = "0x180948D90")]
		private void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400379F RID: 14239
		[Token(Token = "0x400379F")]
		public const float BASE_PACKAGING_TIME = 15f;

		// Token: 0x040037A2 RID: 14242
		[Token(Token = "0x40037A2")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine packagingRoutine;

		// Token: 0x040037A3 RID: 14243
		[Token(Token = "0x40037A3")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted;
	}
}
