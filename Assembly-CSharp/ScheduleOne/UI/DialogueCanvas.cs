using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C37 RID: 3127
	[Token(Token = "0x2000C37")]
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06005BAA RID: 23466 RVA: 0x00017388 File Offset: 0x00015588
		[Token(Token = "0x17000D45")]
		public bool isActive
		{
			[Token(Token = "0x6005BAA")]
			[Address(RVA = "0x9CC550", Offset = "0x9CB750", VA = "0x1809CC550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x9CAEB0", Offset = "0x9CA0B0", VA = "0x1809CAEB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x9CB2E0", Offset = "0x9CA4E0", VA = "0x1809CB2E0")]
		public void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<DialogueChoiceData> choices)
		{
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x9CB960", Offset = "0x9CAB60", VA = "0x1809CB960")]
		public void OverrideText(string text)
		{
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x9CC2E0", Offset = "0x9CB4E0", VA = "0x1809CC2E0")]
		public void StopTextOverride()
		{
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x9CC3E0", Offset = "0x9CB5E0", VA = "0x1809CC3E0")]
		private void Update()
		{
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x9CB780", Offset = "0x9CA980", VA = "0x1809CB780")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x9CBA00", Offset = "0x9CAC00", VA = "0x1809CBA00")]
		protected IEnumerator RolloutDialogue(string text, List<DialogueChoiceData> choices)
		{
			return null;
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0x9CBAB0", Offset = "0x9CACB0", VA = "0x1809CBAB0")]
		private IEnumerator SelectPanel(UISelectable selectable)
		{
			return null;
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x9CB240", Offset = "0x9CA440", VA = "0x1809CB240")]
		private IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			return null;
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x9CBB40", Offset = "0x9CAD40", VA = "0x1809CBB40")]
		private void StartDialogue(DialogueHandler handler)
		{
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x9CB440", Offset = "0x9CA640", VA = "0x1809CB440")]
		public void EndDialogue()
		{
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x9CC390", Offset = "0x9CB590", VA = "0x1809CC390")]
		private IEnumerator UnlockPlayer()
		{
			return null;
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x9CAFA0", Offset = "0x9CA1A0", VA = "0x1809CAFA0")]
		public void ChoiceSelected(int choiceIndex)
		{
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x000173A0 File Offset: 0x000155A0
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x9CB870", Offset = "0x9CAA70", VA = "0x1809CB870")]
		private bool IsChoiceValid(int choiceIndex, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x9CC490", Offset = "0x9CB690", VA = "0x1809CC490")]
		public DialogueCanvas()
		{
		}

		// Token: 0x04003E0C RID: 15884
		[Token(Token = "0x4003E0C")]
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x04003E0D RID: 15885
		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x28")]
		public bool SkipNextRollout;

		// Token: 0x04003E0E RID: 15886
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("References")]
		protected Canvas canvas;

		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected TextMeshProUGUI dialogueText;

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject continuePopup;

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected List<DialogueChoiceEntry> dialogueChoices;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x58")]
		[Header("Custom UI")]
		[SerializeField]
		protected UIScreen uiScreen;

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected UIPanel uiPanel;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x68")]
		private DialogueHandler currentHandler;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x70")]
		private DialogueNodeData currentNode;

		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x78")]
		private bool spaceDownThisFrame;

		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x79")]
		private bool leftClickThisFrame;

		// Token: 0x04003E19 RID: 15897
		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x80")]
		private string overrideText;

		// Token: 0x04003E1A RID: 15898
		[Token(Token = "0x4003E1A")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine dialogueRollout;

		// Token: 0x04003E1B RID: 15899
		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine choiceSelectionResidualCoroutine;

		// Token: 0x04003E1C RID: 15900
		[Token(Token = "0x4003E1C")]
		[FieldOffset(Offset = "0x98")]
		private bool hasChoiceBeenSelected;
	}
}
