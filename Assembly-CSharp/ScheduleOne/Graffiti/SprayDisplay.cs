using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000650 RID: 1616
	[Token(Token = "0x2000650")]
	[RequireComponent(typeof(SpraySurface))]
	public class SprayDisplay : MonoBehaviour
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x6CD0A0", Offset = "0x6CC2A0", VA = "0x1806CD0A0")]
		private void Awake()
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x6CD1C0", Offset = "0x6CC3C0", VA = "0x1806CD1C0")]
		private void Redraw()
		{
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SprayDisplay()
		{
		}

		// Token: 0x04001EE6 RID: 7910
		[Token(Token = "0x4001EE6")]
		[FieldOffset(Offset = "0x20")]
		public SpraySurface SpraySurface;

		// Token: 0x04001EE7 RID: 7911
		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x28")]
		public DecalProjector Projector;

		// Token: 0x04001EE8 RID: 7912
		[Token(Token = "0x4001EE8")]
		[FieldOffset(Offset = "0x30")]
		private Material cachedMaterial;
	}
}
