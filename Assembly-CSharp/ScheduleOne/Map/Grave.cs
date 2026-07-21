using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class Grave : MonoBehaviour
	{
		// Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x622B60", Offset = "0x621D60", VA = "0x180622B60")]
		[Button]
		public void RandomizeGrave()
		{
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Grave()
		{
		}

		// Token: 0x040018C4 RID: 6340
		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Grave.GraveSuface[] Surfaces;

		// Token: 0x040018C5 RID: 6341
		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] HeadstoneObjects;

		// Token: 0x040018C6 RID: 6342
		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer[] HeadstoneMeshes;

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x38")]
		public Material[] HeadstoneMaterials;

		// Token: 0x02000530 RID: 1328
		[Token(Token = "0x2000530")]
		[Serializable]
		public class GraveSuface
		{
			// Token: 0x06001D5D RID: 7517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public GraveSuface()
			{
			}

			// Token: 0x040018C8 RID: 6344
			[Token(Token = "0x40018C8")]
			[FieldOffset(Offset = "0x10")]
			public GameObject Object;

			// Token: 0x040018C9 RID: 6345
			[Token(Token = "0x40018C9")]
			[FieldOffset(Offset = "0x18")]
			public MeshRenderer Mesh;

			// Token: 0x040018CA RID: 6346
			[Token(Token = "0x40018CA")]
			[FieldOffset(Offset = "0x20")]
			public Material[] Materials;
		}
	}
}
