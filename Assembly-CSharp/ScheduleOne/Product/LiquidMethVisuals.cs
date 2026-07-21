using System;
using Il2CppDummyDll;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008FD RID: 2301
	[Token(Token = "0x20008FD")]
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x82D3D0", Offset = "0x82C5D0", VA = "0x18082D3D0")]
		public void Setup(LiquidMethDefinition def)
		{
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LiquidMethVisuals()
		{
		}

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer StaticLiquidMesh;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x28")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x30")]
		public ParticleSystem PourParticles;
	}
}
