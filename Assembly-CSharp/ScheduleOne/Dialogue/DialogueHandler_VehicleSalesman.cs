using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x06002FBC RID: 12220 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x765560", Offset = "0x764760", VA = "0x180765560", Slot = "12")]
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x765020", Offset = "0x764220", VA = "0x180765020", Slot = "8")]
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x7651D0", Offset = "0x7643D0", VA = "0x1807651D0", Slot = "13")]
		protected override void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x764F50", Offset = "0x764150", VA = "0x180764F50", Slot = "10")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x765550", Offset = "0x764750", VA = "0x180765550", Slot = "14")]
		protected override void DialogueCallback(string choiceLabel)
		{
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x765750", Offset = "0x764950", VA = "0x180765750", Slot = "11")]
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x765810", Offset = "0x764A10", VA = "0x180765810")]
		public DialogueHandler_VehicleSalesman()
		{
		}

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0xB8")]
		public Jeremy Salesman;

		// Token: 0x04002331 RID: 9009
		[Token(Token = "0x4002331")]
		[FieldOffset(Offset = "0xC0")]
		public Jeremy.DealershipListing selectedVehicle;
	}
}
