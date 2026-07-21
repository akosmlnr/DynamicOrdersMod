using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	public class MultiTypeVisualsSetter : MonoBehaviour
	{
		// Token: 0x06003F7C RID: 16252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x85E370", Offset = "0x85D570", VA = "0x18085E370")]
		public void ApplyVisuals(ProductItemInstance itemInstance)
		{
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x85E110", Offset = "0x85D310", VA = "0x18085E110")]
		public void ApplyVisuals(ProductDefinition product)
		{
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x85E450", Offset = "0x85D650", VA = "0x18085E450")]
		private void ResetVisuals()
		{
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MultiTypeVisualsSetter()
		{
		}

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x20")]
		public WeedVisualsSetter WeedVisuals;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x28")]
		public MethVisualsSetter MethVisuals;

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x30")]
		public CocaineVisualsSetter CocaineVisuals;

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x38")]
		public ShroomVisualsSetter ShroomVisuals;
	}
}
