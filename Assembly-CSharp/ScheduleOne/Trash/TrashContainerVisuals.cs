using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007CC RID: 1996
	[Token(Token = "0x20007CC")]
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerVisuals : MonoBehaviour
	{
		// Token: 0x06003569 RID: 13673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x7D2D70", Offset = "0x7D1F70", VA = "0x1807D2D70")]
		protected void Start()
		{
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x7D2E20", Offset = "0x7D2020", VA = "0x1807D2E20")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TrashContainerVisuals()
		{
		}

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x20")]
		public TrashContainer TrashContainer;

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform ContentsTransform;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x30")]
		public Transform VisualsContainer;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x38")]
		public Transform VisualsMinTransform;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x40")]
		public Transform VisualsMaxTransform;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x48")]
		public Collider Collider;
	}
}
