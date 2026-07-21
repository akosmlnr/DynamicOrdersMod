using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x060039DE RID: 14814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x80D610", Offset = "0x80C810", VA = "0x18080D610")]
		[Button]
		public void SetMaterial()
		{
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SetRendererMaterial()
		{
		}

		// Token: 0x04002A96 RID: 10902
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x20")]
		public Material Material;
	}
}
