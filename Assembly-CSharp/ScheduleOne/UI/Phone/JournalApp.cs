using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x06006121 RID: 24865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006121")]
		[Address(RVA = "0xA4B7D0", Offset = "0xA4A9D0", VA = "0x180A4B7D0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006122")]
		[Address(RVA = "0xA4BCC0", Offset = "0xA4AEC0", VA = "0x180A4BCC0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006123")]
		[Address(RVA = "0xA4BBF0", Offset = "0xA4ADF0", VA = "0x180A4BBF0", Slot = "11")]
		public override void SetOpen(bool open)
		{
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006124")]
		[Address(RVA = "0xA4BDE0", Offset = "0xA4AFE0", VA = "0x180A4BDE0", Slot = "8")]
		protected override void Update()
		{
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006125")]
		[Address(RVA = "0xA4B980", Offset = "0xA4AB80", VA = "0x180A4B980")]
		private void RefreshDetailsPanel()
		{
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006126")]
		[Address(RVA = "0xA4B840", Offset = "0xA4AA40", VA = "0x180A4B840", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006127")]
		[Address(RVA = "0xA4B810", Offset = "0xA4AA10", VA = "0x180A4B810", Slot = "12")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006128")]
		[Address(RVA = "0xA4BF00", Offset = "0xA4B100", VA = "0x180A4BF00")]
		public JournalApp()
		{
		}

		// Token: 0x04004310 RID: 17168
		[Token(Token = "0x4004310")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x04004311 RID: 17169
		[Token(Token = "0x4004311")]
		[FieldOffset(Offset = "0x70")]
		public Text NoTasksLabel;

		// Token: 0x04004312 RID: 17170
		[Token(Token = "0x4004312")]
		[FieldOffset(Offset = "0x78")]
		public Text NoDetailsLabel;

		// Token: 0x04004313 RID: 17171
		[Token(Token = "0x4004313")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform DetailsPanelContainer;

		// Token: 0x04004314 RID: 17172
		[Token(Token = "0x4004314")]
		[FieldOffset(Offset = "0x88")]
		[Header("Entry prefabs")]
		public GameObject GenericEntry;

		// Token: 0x04004315 RID: 17173
		[Token(Token = "0x4004315")]
		[FieldOffset(Offset = "0x90")]
		[Header("Details panel prefabs")]
		public GameObject GenericDetailsPanel;

		// Token: 0x04004316 RID: 17174
		[Token(Token = "0x4004316")]
		[FieldOffset(Offset = "0x98")]
		[Header("Quest Entry prefab")]
		public GameObject GenericQuestEntry;

		// Token: 0x04004317 RID: 17175
		[Token(Token = "0x4004317")]
		[FieldOffset(Offset = "0xA0")]
		[Header("HUD entry prefabs")]
		public QuestHUDUI QuestHUDUIPrefab;

		// Token: 0x04004318 RID: 17176
		[Token(Token = "0x4004318")]
		[FieldOffset(Offset = "0xA8")]
		public QuestEntryHUDUI QuestEntryHUDUIPrefab;

		// Token: 0x04004319 RID: 17177
		[Token(Token = "0x4004319")]
		[FieldOffset(Offset = "0xB0")]
		protected Quest currentDetailsPanelQuest;

		// Token: 0x0400431A RID: 17178
		[Token(Token = "0x400431A")]
		[FieldOffset(Offset = "0xB8")]
		protected RectTransform currentDetailsPanel;
	}
}
