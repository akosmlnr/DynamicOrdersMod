using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AA6 RID: 2726
	[Token(Token = "0x2000AA6")]
	public class Lily : NPC
	{
		// Token: 0x06004E68 RID: 20072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0x93BE80", Offset = "0x93B080", VA = "0x18093BE80", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0x93BFC0", Offset = "0x93B1C0", VA = "0x18093BFC0")]
		private void Unlocked(NPCRelationData.EUnlockType type, bool b)
		{
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6A")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Lily()
		{
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6B")]
		[Address(RVA = "0x8F17B0", Offset = "0x8F09B0", VA = "0x1808F17B0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6C")]
		[Address(RVA = "0x93A340", Offset = "0x939540", VA = "0x18093A340", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x93BD70", Offset = "0x93AF70", VA = "0x18093BD70", Slot = "130")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Lily_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040036A8 RID: 13992
		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x328")]
		[Header("References")]
		public Transform TutorialScheduleGroup;

		// Token: 0x040036A9 RID: 13993
		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0x330")]
		public Transform RegularScheduleGroup;

		// Token: 0x040036AA RID: 13994
		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0x338")]
		public Conditions TutorialConditions;

		// Token: 0x040036AB RID: 13995
		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0x340")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted;

		// Token: 0x040036AC RID: 13996
		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x341")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LilyAssembly-CSharp.dll_Excuted;
	}
}
