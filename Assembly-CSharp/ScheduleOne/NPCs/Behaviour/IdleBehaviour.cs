using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B19 RID: 2841
	[Token(Token = "0x2000B19")]
	public class IdleBehaviour : Behaviour
	{
		// Token: 0x060053BC RID: 21436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x94CB50", Offset = "0x94BD50", VA = "0x18094CB50", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0x94D750", Offset = "0x94C950", VA = "0x18094D750", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x966D90", Offset = "0x965F90", VA = "0x180966D90", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x9670D0", Offset = "0x9662D0", VA = "0x1809670D0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x966B60", Offset = "0x965D60", VA = "0x180966B60", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x966BC0", Offset = "0x965DC0", VA = "0x180966BC0")]
		public bool IsAtIdleLocation()
		{
			return default(bool);
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public IdleBehaviour()
		{
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x966D70", Offset = "0x965F70", VA = "0x180966D70", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x964070", Offset = "0x963270", VA = "0x180964070", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		[FieldOffset(Offset = "0x168")]
		public Transform IdlePoint;

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x170")]
		private bool facingDir;

		// Token: 0x040038BB RID: 14523
		[Token(Token = "0x40038BB")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038BC RID: 14524
		[Token(Token = "0x40038BC")]
		[FieldOffset(Offset = "0x172")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.IdleBehaviourAssembly-CSharp.dll_Excuted;
	}
}
