using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
	public class SkewingHandleSD : MonoBehaviour
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7B6E50", Offset = "0x7B6050", VA = "0x1807B6E50")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7B6D20", Offset = "0x7B5F20", VA = "0x1807B6D20")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7B6DA0", Offset = "0x7B5FA0", VA = "0x1807B6DA0")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x7B6FE0", Offset = "0x7B61E0", VA = "0x1807B6FE0")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x7B6F10", Offset = "0x7B6110", VA = "0x1807B6F10")]
		private void OnEnable()
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x7B7020", Offset = "0x7B6220", VA = "0x1807B7020")]
		private void Start()
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7B6DE0", Offset = "0x7B5FE0", VA = "0x1807B6DE0")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7B6F40", Offset = "0x7B6140", VA = "0x1807B6F40")]
		private void SetSkewingVector()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SkewingHandleSD()
		{
		}

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		public const string ClassName = "SkewingHandleSD";

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x20")]
		public VolumetricLightBeamSD volumetricLightBeam;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldUpdateEachFrame;
	}
}
