using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200093B RID: 2363
	[Token(Token = "0x200093B")]
	public abstract class ProductVisualsSetter : MonoBehaviour
	{
		// Token: 0x06003F81 RID: 16257
		[Token(Token = "0x6003F81")]
		public abstract void ApplyVisuals(ProductDefinition productDefinition);

		// Token: 0x06003F82 RID: 16258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F82")]
		[Address(RVA = "0x863060", Offset = "0x862260", VA = "0x180863060")]
		public void ApplyVisuals(ProductItemInstance productInstance)
		{
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0x863150", Offset = "0x862350", VA = "0x180863150")]
		public void ResetVisuals()
		{
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x6003F84")]
		protected bool TryCastProductDefinition<T>(ProductDefinition definition, out T castedDefinition) where T : ProductDefinition
		{
			return default(bool);
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F85")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected ProductVisualsSetter()
		{
		}

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		[FieldOffset(Offset = "0x20")]
		public Transform VisualsContainer;

		// Token: 0x0200093C RID: 2364
		[Token(Token = "0x200093C")]
		[Serializable]
		protected class MeshRendererInt
		{
			// Token: 0x06003F86 RID: 16262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F86")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public MeshRendererInt()
			{
			}

			// Token: 0x04002E29 RID: 11817
			[Token(Token = "0x4002E29")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Renderer;

			// Token: 0x04002E2A RID: 11818
			[Token(Token = "0x4002E2A")]
			[FieldOffset(Offset = "0x18")]
			public int MaterialIndex;
		}
	}
}
