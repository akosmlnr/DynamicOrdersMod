using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	public class LightningSpawnArea : MonoBehaviour
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x9FA2A0", Offset = "0x9F94A0", VA = "0x1809FA2A0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x9FA460", Offset = "0x9F9660", VA = "0x1809FA460")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x9FA1A0", Offset = "0x9F93A0", VA = "0x1809FA1A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x9FA5B0", Offset = "0x9F97B0", VA = "0x1809FA5B0")]
		public LightningSpawnArea()
		{
		}

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Dimensions of the lightning area where lightning bolts will be spawned inside randomly.")]
		public Vector3 lightningArea;
	}
}
