using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemIconCreator
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	[ExecuteInEditMode]
	public class PrefabIconCreator : IconCreator
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x8D9AA0", Offset = "0x8D8CA0", VA = "0x1808D9AA0", Slot = "4")]
		public override void BuildIcons()
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x8D9B20", Offset = "0x8D8D20", VA = "0x1808D9B20", Slot = "6")]
		public override bool CheckConditions()
		{
			return default(bool);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x8D9E00", Offset = "0x8D9000", VA = "0x1808D9E00", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x8D9C20", Offset = "0x8D8E20", VA = "0x1808D9C20")]
		private void ClearShit()
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x8D9A30", Offset = "0x8D8C30", VA = "0x1808D9A30")]
		public IEnumerator BuildAllIcons()
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8D7140", Offset = "0x8D6340", VA = "0x1808D7140")]
		public PrefabIconCreator()
		{
		}

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Items")]
		public GameObject[] itemsToShot;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0xB0")]
		public Transform itemPosition;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject instantiatedItem;
	}
}
