using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	public class FootPatrolBehaviour : Behaviour
	{
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005365 RID: 21349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C74")]
		public PatrolGroup Group
		{
			[Token(Token = "0x6005364")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005365")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005366")]
		[Address(RVA = "0x962550", Offset = "0x961750", VA = "0x180962550", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005367")]
		[Address(RVA = "0x963630", Offset = "0x962830", VA = "0x180963630", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005368")]
		[Address(RVA = "0x9634C0", Offset = "0x9626C0", VA = "0x1809634C0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005369")]
		[Address(RVA = "0x9626F0", Offset = "0x9618F0", VA = "0x1809626F0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536A")]
		[Address(RVA = "0x962CD0", Offset = "0x961ED0", VA = "0x180962CD0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536B")]
		[Address(RVA = "0x9637D0", Offset = "0x9629D0", VA = "0x1809637D0")]
		private void SetFlashlightEquipped(bool equipped)
		{
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536C")]
		[Address(RVA = "0x963870", Offset = "0x962A70", VA = "0x180963870")]
		public void SetGroup(PatrolGroup group)
		{
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x600536D")]
		[Address(RVA = "0x962A30", Offset = "0x961C30", VA = "0x180962A30")]
		public bool IsReadyToAdvance()
		{
			return default(bool);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x600536E")]
		[Address(RVA = "0x9628A0", Offset = "0x961AA0", VA = "0x1809628A0")]
		private bool IsAtDestination(float threshold = 2f)
		{
			return default(bool);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536F")]
		[Address(RVA = "0x963950", Offset = "0x962B50", VA = "0x180963950")]
		public FootPatrolBehaviour()
		{
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005370")]
		[Address(RVA = "0x962CB0", Offset = "0x961EB0", VA = "0x180962CB0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005371")]
		[Address(RVA = "0x962C90", Offset = "0x961E90", VA = "0x180962C90", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400388D RID: 14477
		[Token(Token = "0x400388D")]
		public const float MOVE_SPEED = 0.08f;

		// Token: 0x0400388E RID: 14478
		[Token(Token = "0x400388E")]
		public const int FLASHLIGHT_MIN_TIME = 1930;

		// Token: 0x0400388F RID: 14479
		[Token(Token = "0x400388F")]
		[FieldOffset(Offset = "0x168")]
		public int FLASHLIGHT_MAX_TIME;

		// Token: 0x04003890 RID: 14480
		[Token(Token = "0x4003890")]
		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		// Token: 0x04003891 RID: 14481
		[Token(Token = "0x4003891")]
		[FieldOffset(Offset = "0x16C")]
		public bool UseFlashlight;

		// Token: 0x04003892 RID: 14482
		[Token(Token = "0x4003892")]
		[FieldOffset(Offset = "0x16D")]
		private bool flashlightEquipped;

		// Token: 0x04003894 RID: 14484
		[Token(Token = "0x4003894")]
		[FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003895 RID: 14485
		[Token(Token = "0x4003895")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted;
	}
}
