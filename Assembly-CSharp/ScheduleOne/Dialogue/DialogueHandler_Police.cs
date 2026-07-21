using System;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x2000713")]
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x7427F0", Offset = "0x7419F0", VA = "0x1807427F0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "16")]
		public override void Hovered()
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x742DE0", Offset = "0x741FE0", VA = "0x180742DE0", Slot = "17")]
		public override void Interacted()
		{
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0000ED18 File Offset: 0x0000CF18
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x742920", Offset = "0x741B20", VA = "0x180742920")]
		private bool CanTalk_Checkpoint()
		{
			return default(bool);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x742A70", Offset = "0x741C70", VA = "0x180742A70", Slot = "10")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x7372D0", Offset = "0x7364D0", VA = "0x1807372D0")]
		public DialogueHandler_Police()
		{
		}

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0xB8")]
		[Header("References")]
		public DialogueContainer CheckpointRequestDialogue;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0xC0")]
		private PoliceOfficer officer;
	}
}
