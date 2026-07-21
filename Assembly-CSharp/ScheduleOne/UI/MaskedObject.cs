using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScheduleOne.UI
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x2000CB9")]
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x06005F2A RID: 24362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0xA09D20", Offset = "0xA08F20", VA = "0x180A09D20", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0xA09C80", Offset = "0xA08E80", VA = "0x180A09C80", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0xA09FB0", Offset = "0xA091B0", VA = "0x180A09FB0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0xA09CD0", Offset = "0xA08ED0", VA = "0x180A09CD0")]
		public void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0xA09D50", Offset = "0xA08F50", VA = "0x180A09D50")]
		private void SetTargetClippingRect()
		{
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0xA0A140", Offset = "0xA09340", VA = "0x180A0A140")]
		public MaskedObject()
		{
		}

		// Token: 0x0400417A RID: 16762
		[Token(Token = "0x400417A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasRenderer canvasRendererToClip;

		// Token: 0x0400417B RID: 16763
		[Token(Token = "0x400417B")]
		[FieldOffset(Offset = "0x28")]
		public bool includeChildren;

		// Token: 0x0400417C RID: 16764
		[Token(Token = "0x400417C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas rootCanvas;

		// Token: 0x0400417D RID: 16765
		[Token(Token = "0x400417D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform maskRectTransform;

		// Token: 0x0400417E RID: 16766
		[Token(Token = "0x400417E")]
		[FieldOffset(Offset = "0x40")]
		private bool initialized;

		// Token: 0x0400417F RID: 16767
		[Token(Token = "0x400417F")]
		[FieldOffset(Offset = "0x48")]
		private List<CanvasRenderer> canvasRenderersToClip;
	}
}
