using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	public class EndCutscene : Cutscene
	{
		// Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x765FA0", Offset = "0x7651A0", VA = "0x180765FA0", Slot = "5")]
		public override void Play()
		{
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x766050", Offset = "0x765250", VA = "0x180766050")]
		public void StandUp()
		{
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x766030", Offset = "0x765230", VA = "0x180766030")]
		public void RunStart()
		{
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x765EE0", Offset = "0x7650E0", VA = "0x180765EE0")]
		public void EngineStart()
		{
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x765F00", Offset = "0x765100", VA = "0x180765F00")]
		public void LightsOn()
		{
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x765F20", Offset = "0x765120", VA = "0x180765F20")]
		public void On3rdPerson()
		{
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307D")]
		[Address(RVA = "0x760CB0", Offset = "0x75FEB0", VA = "0x180760CB0")]
		public EndCutscene()
		{
		}

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onStandUp;

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onRunStart;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onEngineStart;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onLightsOn;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[FieldOffset(Offset = "0x78")]
		public Avatar Avatar;
	}
}
