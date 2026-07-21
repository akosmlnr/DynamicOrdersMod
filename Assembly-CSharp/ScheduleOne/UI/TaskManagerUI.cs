using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x06005F19 RID: 24345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F19")]
		[Address(RVA = "0xA15870", Offset = "0xA14A70", VA = "0x180A15870", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0xA15380", Offset = "0xA14580", VA = "0x180A15380", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0xA156B0", Offset = "0xA148B0", VA = "0x180A156B0", Slot = "8")]
		protected virtual void UpdateInstructionLabel()
		{
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0xA15510", Offset = "0xA14710", VA = "0x180A15510")]
		private void TaskStarted(Task task)
		{
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0xA15920", Offset = "0xA14B20", VA = "0x180A15920")]
		public TaskManagerUI()
		{
		}

		// Token: 0x04004164 RID: 16740
		[Token(Token = "0x4004164")]
		[FieldOffset(Offset = "0x28")]
		private bool textShown;

		// Token: 0x04004165 RID: 16741
		[Token(Token = "0x4004165")]
		[FieldOffset(Offset = "0x30")]
		public GenericUIScreen inputPromptUI;

		// Token: 0x04004166 RID: 16742
		[Token(Token = "0x4004166")]
		[FieldOffset(Offset = "0x38")]
		public Canvas canvas;

		// Token: 0x04004167 RID: 16743
		[Token(Token = "0x4004167")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform multiGrabIndicator;

		// Token: 0x04004168 RID: 16744
		[Token(Token = "0x4004168")]
		[FieldOffset(Offset = "0x48")]
		public GenericUIScreen PackagingStationMK2TutorialDone;
	}
}
