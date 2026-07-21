using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Effects.MixMaps
{
	// Token: 0x02000B8E RID: 2958
	[Token(Token = "0x2000B8E")]
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x060057FE RID: 22526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x99E250", Offset = "0x99D450", VA = "0x18099E250")]
		private void OnValidate()
		{
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0x99DDF0", Offset = "0x99CFF0", VA = "0x18099DDF0")]
		[Button]
		public void CreateEffectPrefabs()
		{
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x99E110", Offset = "0x99D310", VA = "0x18099E110")]
		[Button]
		public MixMapEffect GetEffect(Effect effect)
		{
			return null;
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005801")]
		[Address(RVA = "0x99E330", Offset = "0x99D530", VA = "0x18099E330")]
		public MixerMapGenerator()
		{
		}

		// Token: 0x04003A68 RID: 14952
		[Token(Token = "0x4003A68")]
		[FieldOffset(Offset = "0x20")]
		public float MapRadius;

		// Token: 0x04003A69 RID: 14953
		[Token(Token = "0x4003A69")]
		[FieldOffset(Offset = "0x28")]
		public string MapName;

		// Token: 0x04003A6A RID: 14954
		[Token(Token = "0x4003A6A")]
		[FieldOffset(Offset = "0x30")]
		public Transform BasePlateMesh;

		// Token: 0x04003A6B RID: 14955
		[Token(Token = "0x4003A6B")]
		[FieldOffset(Offset = "0x38")]
		public MixMapEffect EffectPrefab;
	}
}
