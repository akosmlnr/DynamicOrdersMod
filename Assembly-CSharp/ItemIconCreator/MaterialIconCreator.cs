using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemIconCreator
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	[ExecuteInEditMode]
	public class MaterialIconCreator : IconCreator
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x8D7F50", Offset = "0x8D7150", VA = "0x1808D7F50", Slot = "4")]
		public override void BuildIcons()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x8D7FD0", Offset = "0x8D71D0", VA = "0x1808D7FD0", Slot = "6")]
		public override bool CheckConditions()
		{
			return default(bool);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x8D7EE0", Offset = "0x8D70E0", VA = "0x1808D7EE0")]
		private IEnumerator BuildIconsRotine()
		{
			return null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x8D80D0", Offset = "0x8D72D0", VA = "0x1808D80D0")]
		private void Reset()
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x8D8150", Offset = "0x8D7350", VA = "0x1808D8150", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x8D7140", Offset = "0x8D6340", VA = "0x1808D7140")]
		public MaterialIconCreator()
		{
		}

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0xA8")]
		public Renderer targetRenderer;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0xB0")]
		public Material[] materials;
	}
}
