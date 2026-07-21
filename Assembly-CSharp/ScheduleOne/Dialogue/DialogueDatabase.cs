using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	[CreateAssetMenu(fileName = "New Dialogue Database", menuName = "Dialogue/Dialogue Database")]
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007D0")]
		private List<DialogueModule> runtimeModules
		{
			[Token(Token = "0x6002F5F")]
			[Address(RVA = "0x529E50", Offset = "0x529050", VA = "0x180529E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F60")]
		[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
		public void Initialize(DialogueHandler _handler)
		{
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F61")]
		[Address(RVA = "0x73FAC0", Offset = "0x73ECC0", VA = "0x18073FAC0")]
		public DialogueModule GetModule(EDialogueModule moduleType)
		{
			return null;
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F62")]
		[Address(RVA = "0x73F840", Offset = "0x73EA40", VA = "0x18073F840")]
		public DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			return null;
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x6002F63")]
		[Address(RVA = "0x73FC70", Offset = "0x73EE70", VA = "0x18073FC70")]
		public bool HasChain(EDialogueModule moduleType, string key)
		{
			return default(bool);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x73F970", Offset = "0x73EB70", VA = "0x18073F970")]
		public string GetLine(EDialogueModule moduleType, string key)
		{
			return null;
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x73FDA0", Offset = "0x73EFA0", VA = "0x18073FDA0")]
		public bool HasLine(EDialogueModule moduleType, string key)
		{
			return default(bool);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F66")]
		[Address(RVA = "0x73FED0", Offset = "0x73F0D0", VA = "0x18073FED0")]
		public DialogueDatabase()
		{
		}

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x18")]
		public List<DialogueModule> Modules;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x20")]
		public List<Entry> GenericEntries;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x28")]
		private DialogueHandler handler;
	}
}
