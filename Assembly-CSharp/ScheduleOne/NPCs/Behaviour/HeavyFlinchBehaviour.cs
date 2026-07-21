using System;
using Il2CppDummyDll;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public class HeavyFlinchBehaviour : Behaviour
	{
		// Token: 0x060053B2 RID: 21426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0x9669F0", Offset = "0x965BF0", VA = "0x1809669F0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B3")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B4")]
		[Address(RVA = "0x966910", Offset = "0x965B10", VA = "0x180966910", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B5")]
		[Address(RVA = "0x966A80", Offset = "0x965C80", VA = "0x180966A80", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x966AF0", Offset = "0x965CF0", VA = "0x180966AF0")]
		public void Flinch()
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public HeavyFlinchBehaviour()
		{
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x966B40", Offset = "0x965D40", VA = "0x180966B40", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x966B20", Offset = "0x965D20", VA = "0x180966B20", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		public const float FLINCH_DURATION = 1.25f;

		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x168")]
		private float remainingFlinchTime;

		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		[FieldOffset(Offset = "0x16C")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x16D")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted;
	}
}
