using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B27 RID: 2855
	[Token(Token = "0x2000B27")]
	public class ScheduleBehaviour : Behaviour
	{
		// Token: 0x06005497 RID: 21655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005498")]
		[Address(RVA = "0x986EE0", Offset = "0x9860E0", VA = "0x180986EE0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005499")]
		[Address(RVA = "0x986F80", Offset = "0x986180", VA = "0x180986F80", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x986F50", Offset = "0x986150", VA = "0x180986F50", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549B")]
		[Address(RVA = "0x986F20", Offset = "0x986120", VA = "0x180986F20", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public ScheduleBehaviour()
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549D")]
		[Address(RVA = "0x983820", Offset = "0x982A20", VA = "0x180983820", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x983800", Offset = "0x982A00", VA = "0x180983800", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549F")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x986F10", Offset = "0x986110", VA = "0x180986F10", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.ScheduleBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x168")]
		[Header("References")]
		public NPCScheduleManager schedule;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted;
	}
}
