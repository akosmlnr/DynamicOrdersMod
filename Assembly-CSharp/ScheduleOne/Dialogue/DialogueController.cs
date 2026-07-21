using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006F6 RID: 1782
	[Token(Token = "0x20006F6")]
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x06002F1D RID: 12061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x73F2A0", Offset = "0x73E4A0", VA = "0x18073F2A0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x73C4F0", Offset = "0x73B6F0", VA = "0x18073C4F0")]
		private void Hovered()
		{
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x73F260", Offset = "0x73E460", VA = "0x18073F260")]
		public void StartGenericDialogue(bool allowExit = true)
		{
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x73C640", Offset = "0x73B840", VA = "0x18073C640")]
		private void Interacted()
		{
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F21")]
		[Address(RVA = "0x73F710", Offset = "0x73E910", VA = "0x18073F710")]
		private void Unqueue()
		{
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x73BF70", Offset = "0x73B170", VA = "0x18073BF70")]
		private string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			return null;
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x73BCD0", Offset = "0x73AED0", VA = "0x18073BCD0")]
		private List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			return null;
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x73C380", Offset = "0x73B580", VA = "0x18073C380", Slot = "5")]
		protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			return default(bool);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x737A90", Offset = "0x736C90", VA = "0x180737A90", Slot = "6")]
		public virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			return 0;
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x737B70", Offset = "0x736D70", VA = "0x180737B70", Slot = "7")]
		public virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			return 0;
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x739160", Offset = "0x738360", VA = "0x180739160", Slot = "8")]
		public virtual bool CanStartDialogue()
		{
			return default(bool);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x73DCF0", Offset = "0x73CEF0", VA = "0x18073DCF0", Slot = "9")]
		public virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x73DCE0", Offset = "0x73CEE0", VA = "0x18073DCE0", Slot = "10")]
		public virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x73DA80", Offset = "0x73CC80", VA = "0x18073DA80", Slot = "11")]
		public virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x7395A0", Offset = "0x7387A0", VA = "0x1807395A0", Slot = "12")]
		public virtual void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x7393F0", Offset = "0x7385F0", VA = "0x1807393F0", Slot = "13")]
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
		public void SetOverrideContainer(DialogueContainer container)
		{
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x739770", Offset = "0x738970", VA = "0x180739770")]
		public void ClearOverrideContainer()
		{
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x73A020", Offset = "0x739220", VA = "0x18073A020", Slot = "14")]
		public virtual bool DecideBranch(string branchLabel, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
		public void SetDialogueEnabled(bool enabled)
		{
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x73F720", Offset = "0x73E920", VA = "0x18073F720")]
		public DialogueController()
		{
		}

		// Token: 0x040022D9 RID: 8921
		[Token(Token = "0x40022D9")]
		private const float GreetingCooldown = 5f;

		// Token: 0x040022DA RID: 8922
		[Token(Token = "0x40022DA")]
		private const float RainyGreetingThreshold = 0.4f;

		// Token: 0x040022DB RID: 8923
		[Token(Token = "0x40022DB")]
		private const float RainyGreetingChance = 0.4f;

		// Token: 0x040022DC RID: 8924
		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040022DD RID: 8925
		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x28")]
		public DialogueContainer GenericDialogue;

		// Token: 0x040022DE RID: 8926
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public bool DialogueEnabled;

		// Token: 0x040022DF RID: 8927
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x31")]
		public bool UseDialogueBehaviour;

		// Token: 0x040022E0 RID: 8928
		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x38")]
		public List<DialogueController.DialogueChoice> Choices;

		// Token: 0x040022E1 RID: 8929
		[Token(Token = "0x40022E1")]
		[FieldOffset(Offset = "0x40")]
		public List<DialogueController.GreetingOverride> GreetingOverrides;

		// Token: 0x040022E2 RID: 8930
		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0x48")]
		public DialogueContainer OverrideContainer;

		// Token: 0x040022E3 RID: 8931
		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0x50")]
		protected NPC npc;

		// Token: 0x040022E4 RID: 8932
		[Token(Token = "0x40022E4")]
		[FieldOffset(Offset = "0x58")]
		protected DialogueHandler handler;

		// Token: 0x040022E5 RID: 8933
		[Token(Token = "0x40022E5")]
		[FieldOffset(Offset = "0x60")]
		private float lastGreetingTime;

		// Token: 0x040022E6 RID: 8934
		[Token(Token = "0x40022E6")]
		[FieldOffset(Offset = "0x68")]
		private List<DialogueController.DialogueChoice> shownChoices;

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[FieldOffset(Offset = "0x70")]
		private bool dialogueQueued;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[FieldOffset(Offset = "0x78")]
		private string cachedGreeting;

		// Token: 0x020006F7 RID: 1783
		[Token(Token = "0x20006F7")]
		[Serializable]
		public class DialogueChoice
		{
			// Token: 0x06002F32 RID: 12082 RVA: 0x0000EA90 File Offset: 0x0000CC90
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0x7379F0", Offset = "0x736BF0", VA = "0x1807379F0")]
			public bool ShouldShow()
			{
				return default(bool);
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
			[Token(Token = "0x6002F33")]
			[Address(RVA = "0x737960", Offset = "0x736B60", VA = "0x180737960")]
			public bool IsValid(out string invalidReason)
			{
				return default(bool);
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F34")]
			[Address(RVA = "0x737A20", Offset = "0x736C20", VA = "0x180737A20")]
			public DialogueChoice()
			{
			}

			// Token: 0x040022E9 RID: 8937
			[Token(Token = "0x40022E9")]
			[FieldOffset(Offset = "0x10")]
			public bool Enabled;

			// Token: 0x040022EA RID: 8938
			[Token(Token = "0x40022EA")]
			[FieldOffset(Offset = "0x18")]
			public string ChoiceText;

			// Token: 0x040022EB RID: 8939
			[Token(Token = "0x40022EB")]
			[FieldOffset(Offset = "0x20")]
			public bool ShowWorldspaceDialogue;

			// Token: 0x040022EC RID: 8940
			[Token(Token = "0x40022EC")]
			[FieldOffset(Offset = "0x28")]
			public DialogueContainer Conversation;

			// Token: 0x040022ED RID: 8941
			[Token(Token = "0x40022ED")]
			[FieldOffset(Offset = "0x30")]
			public UnityEvent onChoosen;

			// Token: 0x040022EE RID: 8942
			[Token(Token = "0x40022EE")]
			[FieldOffset(Offset = "0x38")]
			public DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck;

			// Token: 0x040022EF RID: 8943
			[Token(Token = "0x40022EF")]
			[FieldOffset(Offset = "0x40")]
			public DialogueController.DialogueChoice.IsChoiceValid isValidCheck;

			// Token: 0x040022F0 RID: 8944
			[Token(Token = "0x40022F0")]
			[FieldOffset(Offset = "0x48")]
			public int Priority;

			// Token: 0x020006F8 RID: 1784
			// (Invoke) Token: 0x06002F36 RID: 12086
			[Token(Token = "0x20006F8")]
			public delegate bool ShouldShowCheck(bool enabled);

			// Token: 0x020006F9 RID: 1785
			// (Invoke) Token: 0x06002F3A RID: 12090
			[Token(Token = "0x20006F9")]
			public delegate bool IsChoiceValid(out string invalidReason);
		}

		// Token: 0x020006FA RID: 1786
		[Token(Token = "0x20006FA")]
		[Serializable]
		public class GreetingOverride
		{
			// Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F3D")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public GreetingOverride()
			{
			}

			// Token: 0x040022F1 RID: 8945
			[Token(Token = "0x40022F1")]
			[FieldOffset(Offset = "0x10")]
			public string Greeting;

			// Token: 0x040022F2 RID: 8946
			[Token(Token = "0x40022F2")]
			[FieldOffset(Offset = "0x18")]
			public bool ShouldShow;

			// Token: 0x040022F3 RID: 8947
			[Token(Token = "0x40022F3")]
			[FieldOffset(Offset = "0x19")]
			public bool PlayVO;

			// Token: 0x040022F4 RID: 8948
			[Token(Token = "0x40022F4")]
			[FieldOffset(Offset = "0x1C")]
			public EVOLineType VOType;
		}
	}
}
