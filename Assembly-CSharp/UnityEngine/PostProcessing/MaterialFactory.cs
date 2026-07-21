using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	public sealed class MaterialFactory : IDisposable
	{
		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x695FC0", Offset = "0x6951C0", VA = "0x180695FC0")]
		public MaterialFactory()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x695DD0", Offset = "0x694FD0", VA = "0x180695DD0")]
		public Material Get(string shaderName)
		{
			return null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x695C50", Offset = "0x694E50", VA = "0x180695C50", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Material> m_Materials;
	}
}
