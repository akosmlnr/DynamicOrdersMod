using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	public class SpillController : MonoBehaviour
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x7B7580", Offset = "0x7B6780", VA = "0x1807B7580")]
		private void Start()
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x7B78B0", Offset = "0x7B6AB0", VA = "0x1807B78B0")]
		private void Update()
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x7B7180", Offset = "0x7B6380", VA = "0x1807B7180")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x7B7110", Offset = "0x7B6310", VA = "0x1807B7110")]
		private IEnumerator DestroySpill(GameObject spill)
		{
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SpillController()
		{
		}

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x20")]
		public GameObject spill;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x28")]
		private LiquidVolume lv;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x30")]
		private GameObject[] dropTemplates;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		private const int DROP_TEMPLATES_COUNT = 10;
	}
}
