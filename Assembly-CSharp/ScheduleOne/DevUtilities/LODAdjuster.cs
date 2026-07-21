using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	public class LODAdjuster : MonoBehaviour
	{
		// Token: 0x0600491A RID: 18714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491A")]
		[Address(RVA = "0x8F7090", Offset = "0x8F6290", VA = "0x1808F7090")]
		[Button]
		public void AddToLodGroup()
		{
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LODAdjuster()
		{
		}

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private LODGroup _lodGroup;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0x28")]
		[Header("LOD Settings")]
		[SerializeField]
		private string _rendererName;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _lodLevel;
	}
}
