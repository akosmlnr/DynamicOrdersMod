using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x0000EE20 File Offset: 0x0000D020
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D7")]
		public bool allowExit
		{
			[Token(Token = "0x6002FD7")]
			[Address(RVA = "0x4956E0", Offset = "0x4948E0", VA = "0x1804956E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002FD8")]
			[Address(RVA = "0x693AE0", Offset = "0x692CE0", VA = "0x180693AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x170007D8")]
		public bool AllowExit
		{
			[Token(Token = "0x6002FD9")]
			[Address(RVA = "0x764EA0", Offset = "0x7640A0", VA = "0x180764EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x764BD0", Offset = "0x763DD0", VA = "0x180764BD0")]
		public DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			return null;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x764A10", Offset = "0x763C10", VA = "0x180764A10")]
		public BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			return null;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x764AF0", Offset = "0x763CF0", VA = "0x180764AF0")]
		public DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			return null;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x764930", Offset = "0x763B30", VA = "0x180764930")]
		public BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			return null;
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x764CB0", Offset = "0x763EB0", VA = "0x180764CB0")]
		public NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x693AE0", Offset = "0x692CE0", VA = "0x180693AE0")]
		public void SetAllowExit(bool allowed)
		{
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x764D90", Offset = "0x763F90", VA = "0x180764D90")]
		public DialogueContainer()
		{
		}

		// Token: 0x0400234D RID: 9037
		[Token(Token = "0x400234D")]
		[FieldOffset(Offset = "0x20")]
		public List<NodeLinkData> NodeLinks;

		// Token: 0x0400234E RID: 9038
		[Token(Token = "0x400234E")]
		[FieldOffset(Offset = "0x28")]
		public List<DialogueNodeData> DialogueNodeData;

		// Token: 0x0400234F RID: 9039
		[Token(Token = "0x400234F")]
		[FieldOffset(Offset = "0x30")]
		public List<BranchNodeData> BranchNodeData;
	}
}
