using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BA9 RID: 2985
	[Token(Token = "0x2000BA9")]
	public class ShaderEffectHandler : EffectHandler
	{
		// Token: 0x060058C5 RID: 22725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x9B44C0", Offset = "0x9B36C0", VA = "0x1809B44C0", Slot = "16")]
		public override void Initialise()
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public override void Activate()
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public override void Deactivate()
		{
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "10")]
		public override void SetVectorParameterForAll(string variable, Vector3 value)
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "11")]
		public override void SetVectorParameterForAll(string variable, Vector2 value)
		{
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public override void SetNumericParameter(string effectName, string variable, float value)
		{
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x9B4770", Offset = "0x9B3970", VA = "0x1809B4770", Slot = "7")]
		public override void SetNumericParameterForAll(string variable, float value)
		{
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		public override void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		public override void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x9B4640", Offset = "0x9B3840", VA = "0x1809B4640", Slot = "12")]
		public override void SetColorParameterForAll(string variable, Color value)
		{
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x9AFAB0", Offset = "0x9AECB0", VA = "0x1809AFAB0")]
		public ShaderEffectHandler()
		{
		}

		// Token: 0x04003B09 RID: 15113
		[Token(Token = "0x4003B09")]
		[FieldOffset(Offset = "0x38")]
		[Header("Mesh Renderers")]
		[SerializeField]
		private List<MeshRenderer> _meshRenderers;

		// Token: 0x04003B0A RID: 15114
		[Token(Token = "0x4003B0A")]
		[FieldOffset(Offset = "0x40")]
		private MaterialPropertyBlock[] _propertyBlocks;
	}
}
