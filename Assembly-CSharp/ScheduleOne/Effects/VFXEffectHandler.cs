using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class VFXEffectHandler : EffectHandler
	{
		// Token: 0x0600570F RID: 22287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570F")]
		[Address(RVA = "0x9A60A0", Offset = "0x9A52A0", VA = "0x1809A60A0", Slot = "4")]
		public override void Activate()
		{
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005710")]
		[Address(RVA = "0x9A61E0", Offset = "0x9A53E0", VA = "0x1809A61E0", Slot = "5")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005711")]
		[Address(RVA = "0x9A6320", Offset = "0x9A5520", VA = "0x1809A6320", Slot = "12")]
		public override void SetColorParameterForAll(string variable, Color value)
		{
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005712")]
		[Address(RVA = "0x9A6620", Offset = "0x9A5820", VA = "0x1809A6620", Slot = "6")]
		public override void SetNumericParameter(string effectName, string variable, float value)
		{
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005713")]
		[Address(RVA = "0x9A64D0", Offset = "0x9A56D0", VA = "0x1809A64D0", Slot = "7")]
		public override void SetNumericParameterForAll(string variable, float value)
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005714")]
		[Address(RVA = "0x9A6B10", Offset = "0x9A5D10", VA = "0x1809A6B10", Slot = "8")]
		public override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005715")]
		[Address(RVA = "0x9A6A00", Offset = "0x9A5C00", VA = "0x1809A6A00", Slot = "9")]
		public override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005716")]
		[Address(RVA = "0x9A6890", Offset = "0x9A5A90", VA = "0x1809A6890", Slot = "10")]
		public override void SetVectorParameterForAll(string variable, Vector3 value)
		{
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005717")]
		[Address(RVA = "0x9A6730", Offset = "0x9A5930", VA = "0x1809A6730", Slot = "11")]
		public override void SetVectorParameterForAll(string variable, Vector2 value)
		{
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005718")]
		[Address(RVA = "0x994A80", Offset = "0x993C80", VA = "0x180994A80")]
		public VFXEffectHandler()
		{
		}

		// Token: 0x04003A27 RID: 14887
		[Token(Token = "0x4003A27")]
		[FieldOffset(Offset = "0x38")]
		[Header("Components")]
		[SerializeField]
		private List<VisualEffect> _visualEffects;
	}
}
