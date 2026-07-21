using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x5C5220", Offset = "0x5C4420", VA = "0x1805C5220", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x5C52D0", Offset = "0x5C44D0", VA = "0x1805C52D0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x5C5120", Offset = "0x5C4320", VA = "0x1805C5120")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x5C51B0", Offset = "0x5C43B0", VA = "0x1805C51B0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x5C5190", Offset = "0x5C4390", VA = "0x1805C5190", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x58EE90", Offset = "0x58E090", VA = "0x18058EE90")]
		public void PlayTaskCompleteSound()
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x5C51D0", Offset = "0x5C43D0", VA = "0x1805C51D0")]
		public void StartTask(Task task)
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x5C52F0", Offset = "0x5C44F0", VA = "0x1805C52F0")]
		public TaskManager()
		{
		}

		// Token: 0x04001420 RID: 5152
		[Token(Token = "0x4001420")]
		[FieldOffset(Offset = "0x28")]
		public Task currentTask;

		// Token: 0x04001421 RID: 5153
		[Token(Token = "0x4001421")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController TaskCompleteSound;

		// Token: 0x04001422 RID: 5154
		[Token(Token = "0x4001422")]
		[FieldOffset(Offset = "0x38")]
		public Action<Task> OnTaskStarted;
	}
}
