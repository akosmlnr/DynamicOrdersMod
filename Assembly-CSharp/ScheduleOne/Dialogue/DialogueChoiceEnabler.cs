using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006F5 RID: 1781
	[Token(Token = "0x20006F5")]
	public class DialogueChoiceEnabler : MonoBehaviour
	{
		// Token: 0x06002F18 RID: 12056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x737680", Offset = "0x736880", VA = "0x180737680")]
		private void Awake()
		{
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F19")]
		[Address(RVA = "0x7377B0", Offset = "0x7369B0", VA = "0x1807377B0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x737790", Offset = "0x736990", VA = "0x180737790")]
		public void EnableChoice()
		{
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x737770", Offset = "0x736970", VA = "0x180737770")]
		public void DisableChoice()
		{
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DialogueChoiceEnabler()
		{
		}

		// Token: 0x040022D6 RID: 8918
		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x20")]
		public DialogueController DialogueController;

		// Token: 0x040022D7 RID: 8919
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x28")]
		public int ChoiceIndex;

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x30")]
		private DialogueController.DialogueChoice choice;
	}
}
