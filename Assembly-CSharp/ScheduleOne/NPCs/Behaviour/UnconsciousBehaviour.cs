using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B2D RID: 2861
	[Token(Token = "0x2000B2D")]
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x060054EB RID: 21739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EB")]
		[Address(RVA = "0x98B3C0", Offset = "0x98A5C0", VA = "0x18098B3C0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EC")]
		[Address(RVA = "0x98B700", Offset = "0x98A900", VA = "0x18098B700", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x98B880", Offset = "0x98AA80", VA = "0x18098B880", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EE")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x964D50", Offset = "0x963F50", VA = "0x180964D50")]
		public UnconsciousBehaviour()
		{
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x98B860", Offset = "0x98AA60", VA = "0x18098B860", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x98B840", Offset = "0x98AA40", VA = "0x18098B840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		public const float SnoreInterval = 6f;

		// Token: 0x04003946 RID: 14662
		[Token(Token = "0x4003946")]
		private const float SnoreChance = 0.5f;

		// Token: 0x04003947 RID: 14663
		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x168")]
		public ParticleSystem Particles;

		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		[FieldOffset(Offset = "0x170")]
		public bool PlaySnoreSounds;

		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x174")]
		private float timeOnLastSnore;

		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x178")]
		private bool _shouldPlaySnoreSounds;

		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		[FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400394C RID: 14668
		[Token(Token = "0x400394C")]
		[FieldOffset(Offset = "0x17A")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted;
	}
}
