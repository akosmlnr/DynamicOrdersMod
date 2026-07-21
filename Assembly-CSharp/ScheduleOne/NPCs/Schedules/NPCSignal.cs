using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	public class NPCSignal : NPCAction
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CA2")]
		public new string ActionName
		{
			[Token(Token = "0x6005626")]
			[Address(RVA = "0x9834A0", Offset = "0x9826A0", VA = "0x1809834A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06005627 RID: 22055 RVA: 0x000161E8 File Offset: 0x000143E8
		// (set) Token: 0x06005628 RID: 22056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA3")]
		public bool StartedThisCycle
		{
			[Token(Token = "0x6005627")]
			[Address(RVA = "0x5115C0", Offset = "0x5107C0", VA = "0x1805115C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005628")]
			[Address(RVA = "0x9836F0", Offset = "0x9828F0", VA = "0x1809836F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005629")]
		[Address(RVA = "0x9834A0", Offset = "0x9826A0", VA = "0x1809834A0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "30")]
		public override void ActiveUpdate()
		{
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600562B")]
		[Address(RVA = "0x9834D0", Offset = "0x9826D0", VA = "0x1809834D0", Slot = "37")]
		public override string GetTimeDescription()
		{
			return null;
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x600562C")]
		[Address(RVA = "0x983440", Offset = "0x982640", VA = "0x180983440", Slot = "38")]
		public override int GetEndTime()
		{
			return 0;
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562D")]
		[Address(RVA = "0x9836D0", Offset = "0x9828D0", VA = "0x1809836D0", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562E")]
		[Address(RVA = "0x983540", Offset = "0x982740", VA = "0x180983540", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00016218 File Offset: 0x00014418
		[Token(Token = "0x600562F")]
		[Address(RVA = "0x983690", Offset = "0x982890", VA = "0x180983690", Slot = "35")]
		public override bool ShouldStart()
		{
			return default(bool);
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005630")]
		[Address(RVA = "0x983530", Offset = "0x982730", VA = "0x180983530", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x983560", Offset = "0x982760", VA = "0x180983560", Slot = "34")]
		public override void MinPassed()
		{
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005632")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCSignal()
		{
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005633")]
		[Address(RVA = "0x983660", Offset = "0x982860", VA = "0x180983660", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005634")]
		[Address(RVA = "0x983630", Offset = "0x982830", VA = "0x180983630", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x97A0D0", Offset = "0x9792D0", VA = "0x18097A0D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039C5 RID: 14789
		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0x148")]
		public int MaxDuration;

		// Token: 0x040039C7 RID: 14791
		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0x14D")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted;

		// Token: 0x040039C8 RID: 14792
		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0x14E")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignalAssembly-CSharp.dll_Excuted;
	}
}
