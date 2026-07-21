using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs.CharacterClasses;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0000A950 File Offset: 0x00008B50
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054F")]
		public bool KnockingEnabled
		{
			[Token(Token = "0x6001D2A")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D2B")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x620680", Offset = "0x61F880", VA = "0x180620680")]
		private void Start()
		{
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x620630", Offset = "0x61F830", VA = "0x180620630")]
		public void SetKnockingEnabled(bool enabled)
		{
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x6204C0", Offset = "0x61F6C0", VA = "0x1806204C0")]
		public void Hovered()
		{
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x6205A0", Offset = "0x61F7A0", VA = "0x1806205A0")]
		public void Interacted()
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x6205A0", Offset = "0x61F7A0", VA = "0x1806205A0")]
		private void Knocked()
		{
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x620750", Offset = "0x61F950", VA = "0x180620750")]
		public DarkMarketMainDoor()
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x6206E0", Offset = "0x61F8E0", VA = "0x1806206E0")]
		[CompilerGenerated]
		private IEnumerator <Knocked>g__Knock|16_0()
		{
			return null;
		}

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource KnockSound;

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject InteractableObject;

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[FieldOffset(Offset = "0x38")]
		public Peephole Peephole;

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[FieldOffset(Offset = "0x40")]
		public Igor Igor;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[FieldOffset(Offset = "0x48")]
		public DialogueContainer FailDialogue;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[FieldOffset(Offset = "0x50")]
		public DialogueContainer SuccessDialogue;

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x58")]
		public DialogueContainer SuccessDialogueNotOpen;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine knockRoutine;
	}
}
