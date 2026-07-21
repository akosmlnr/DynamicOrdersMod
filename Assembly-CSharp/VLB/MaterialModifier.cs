using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public static class MaterialModifier
	{
		// Token: 0x0200012F RID: 303
		[Token(Token = "0x200012F")]
		public interface Interface
		{
			// Token: 0x060004C4 RID: 1220
			[Token(Token = "0x60004C4")]
			void SetMaterialProp(int nameID, float value);

			// Token: 0x060004C5 RID: 1221
			[Token(Token = "0x60004C5")]
			void SetMaterialProp(int nameID, Vector4 value);

			// Token: 0x060004C6 RID: 1222
			[Token(Token = "0x60004C6")]
			void SetMaterialProp(int nameID, Color value);

			// Token: 0x060004C7 RID: 1223
			[Token(Token = "0x60004C7")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			// Token: 0x060004C8 RID: 1224
			[Token(Token = "0x60004C8")]
			void SetMaterialProp(int nameID, Texture value);
		}

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x060004CA RID: 1226
		[Token(Token = "0x2000130")]
		public delegate void Callback(MaterialModifier.Interface owner);
	}
}
