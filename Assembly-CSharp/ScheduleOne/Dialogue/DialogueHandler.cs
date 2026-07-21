using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000708 RID: 1800
	[Token(Token = "0x2000708")]
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x0000EB80 File Offset: 0x0000CD80
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D1")]
		public bool IsDialogueInProgress
		{
			[Token(Token = "0x6002F6D")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F6E")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D2")]
		public List<DialogueModule> runtimeModules
		{
			[Token(Token = "0x6002F6F")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F70")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D3")]
		public NPC NPC
		{
			[Token(Token = "0x6002F71")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F72")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007D4")]
		protected DialogueCanvas canvas
		{
			[Token(Token = "0x6002F73")]
			[Address(RVA = "0x743BB0", Offset = "0x742DB0", VA = "0x180743BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x73FF50", Offset = "0x73F150", VA = "0x18073FF50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x743730", Offset = "0x742930", VA = "0x180743730", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x742090", Offset = "0x741290", VA = "0x180742090")]
		public void InitializeDialogue(DialogueContainer container)
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0x7420F0", Offset = "0x7412F0", VA = "0x1807420F0")]
		public void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0x742440", Offset = "0x741640", VA = "0x180742440")]
		public void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x7425F0", Offset = "0x7417F0", VA = "0x1807425F0")]
		public void OverrideShownDialogue(string _overrideText)
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x743940", Offset = "0x742B40", VA = "0x180743940")]
		public void StopOverride()
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x7409B0", Offset = "0x73FBB0", VA = "0x1807409B0", Slot = "6")]
		public virtual void EndDialogue()
		{
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x743720", Offset = "0x742920", VA = "0x180743720")]
		public void SkipNextDialogueBehaviourEnd()
		{
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x4975B0", Offset = "0x4967B0", VA = "0x1804975B0", Slot = "7")]
		protected virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			return null;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x743120", Offset = "0x742320", VA = "0x180743120")]
		public void ShowNode(DialogueNodeData node)
		{
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x741D40", Offset = "0x740F40", VA = "0x180741D40")]
		private void EvaluateBranch(BranchNodeData node)
		{
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x740340", Offset = "0x73F540", VA = "0x180740340")]
		public void ChoiceSelected(int choiceIndex)
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x740580", Offset = "0x73F780", VA = "0x180740580")]
		public void ContinueSubmitted()
		{
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x740230", Offset = "0x73F430", VA = "0x180740230", Slot = "8")]
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "9")]
		public virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			return default(bool);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x740100", Offset = "0x73F300", VA = "0x180740100", Slot = "10")]
		protected virtual int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x73DCE0", Offset = "0x73CEE0", VA = "0x18073DCE0", Slot = "11")]
		protected virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x73DCE0", Offset = "0x73CEE0", VA = "0x18073DCE0", Slot = "12")]
		protected virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x7402E0", Offset = "0x73F4E0", VA = "0x1807402E0", Slot = "13")]
		protected virtual void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x740830", Offset = "0x73FA30", VA = "0x180740830", Slot = "14")]
		protected virtual void DialogueCallback(string dialogueLabel)
		{
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "15")]
		protected virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x740700", Offset = "0x73F900", VA = "0x180740700")]
		protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x741F50", Offset = "0x741150", VA = "0x180741F50")]
		private NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "16")]
		public virtual void Hovered()
		{
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "17")]
		public virtual void Interacted()
		{
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x742640", Offset = "0x741840", VA = "0x180742640", Slot = "18")]
		public virtual void PlayReaction_Local(string key)
		{
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x742670", Offset = "0x741870", VA = "0x180742670", Slot = "19")]
		public virtual void PlayReaction_Networked(string key)
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x7426A0", Offset = "0x7418A0", VA = "0x1807426A0", Slot = "20")]
		public virtual void PlayReaction(string key, float duration, bool network)
		{
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x742070", Offset = "0x741270", VA = "0x180742070", Slot = "21")]
		public virtual void HideWorldspaceDialogue()
		{
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x7436C0", Offset = "0x7428C0", VA = "0x1807436C0", Slot = "22")]
		public virtual void ShowWorldspaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x7436A0", Offset = "0x7428A0", VA = "0x1807436A0", Slot = "23")]
		public virtual void ShowWorldspaceDialogue_5s(string text)
		{
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x7439F0", Offset = "0x742BF0", VA = "0x1807439F0")]
		public DialogueHandler()
		{
		}

		// Token: 0x04002308 RID: 8968
		[Token(Token = "0x4002308")]
		public const float TimePerChar = 0.2f;

		// Token: 0x04002309 RID: 8969
		[Token(Token = "0x4002309")]
		public const float WorldspaceDialogueMinDuration = 1.5f;

		// Token: 0x0400230A RID: 8970
		[Token(Token = "0x400230A")]
		public const float WorldspaceDialogueMaxDuration = 5f;

		// Token: 0x0400230B RID: 8971
		[Token(Token = "0x400230B")]
		[FieldOffset(Offset = "0x0")]
		public static DialogueContainer activeDialogue;

		// Token: 0x0400230C RID: 8972
		[Token(Token = "0x400230C")]
		[FieldOffset(Offset = "0x8")]
		public static DialogueNodeData activeDialogueNode;

		// Token: 0x0400230E RID: 8974
		[Token(Token = "0x400230E")]
		[FieldOffset(Offset = "0x28")]
		public DialogueDatabase Database;

		// Token: 0x04002310 RID: 8976
		[Token(Token = "0x4002310")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform LookPosition;

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0x40")]
		public WorldspaceDialogueRenderer WorldspaceRend;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x50")]
		public VOEmitter VOEmitter;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public List<DialogueChoiceData> CurrentChoices;

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x60")]
		[Header("Events")]
		public DialogueEvent[] DialogueEvents;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onConversationStart;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent<string> onDialogueNodeDisplayed;

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent<string> onDialogueChoiceChosen;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected List<DialogueContainer> dialogueContainers;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x88")]
		protected string overrideText;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x90")]
		protected List<NodeLinkData> tempLinks;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x98")]
		protected bool skipNextDialogueBehaviourEnd;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0xA0")]
		protected List<DialogueChoiceData> finalChoices;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0xA8")]
		private bool passChecked;
	}
}
