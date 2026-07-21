using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x686B00", Offset = "0x685D00", VA = "0x180686B00")]
		public void SetSourcePosition(Vector3 position)
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209D")]
		[Address(RVA = "0x686AC0", Offset = "0x685CC0", VA = "0x180686AC0")]
		public void SetDestinationPosition(Vector3 position)
		{
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TransitLineVisuals()
		{
		}

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x20")]
		public LineRenderer Renderer;
	}
}
