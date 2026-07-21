using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BA4 RID: 2980
	[Token(Token = "0x2000BA4")]
	public class ParticleEffectHandler : EffectHandler
	{
		// Token: 0x060058AB RID: 22699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x9AF240", Offset = "0x9AE440", VA = "0x1809AF240", Slot = "4")]
		public override void Activate()
		{
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x9AF380", Offset = "0x9AE580", VA = "0x1809AF380", Slot = "5")]
		public override void Deactivate()
		{
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AD")]
		[Address(RVA = "0x9AF4C0", Offset = "0x9AE6C0", VA = "0x1809AF4C0", Slot = "12")]
		public override void SetColorParameterForAll(string variable, Color value)
		{
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x9AF6C0", Offset = "0x9AE8C0", VA = "0x1809AF6C0", Slot = "6")]
		public override void SetNumericParameter(string effectName, string variable, float value)
		{
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x9AF500", Offset = "0x9AE700", VA = "0x1809AF500", Slot = "7")]
		public override void SetNumericParameterForAll(string variable, float value)
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0x9AFA70", Offset = "0x9AEC70", VA = "0x1809AFA70", Slot = "8")]
		public override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B1")]
		[Address(RVA = "0x9AFA30", Offset = "0x9AEC30", VA = "0x1809AFA30", Slot = "9")]
		public override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B2")]
		[Address(RVA = "0x9AF9F0", Offset = "0x9AEBF0", VA = "0x1809AF9F0", Slot = "10")]
		public override void SetVectorParameterForAll(string variable, Vector3 value)
		{
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x9AF9B0", Offset = "0x9AEBB0", VA = "0x1809AF9B0", Slot = "11")]
		public override void SetVectorParameterForAll(string variable, Vector2 value)
		{
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x9AFAB0", Offset = "0x9AECB0", VA = "0x1809AFAB0")]
		public ParticleEffectHandler()
		{
		}

		// Token: 0x04003AFC RID: 15100
		[Token(Token = "0x4003AFC")]
		[FieldOffset(Offset = "0x38")]
		[Header("Components")]
		[SerializeField]
		private List<ParticleSystem> _particleSystems;
	}
}
