using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x060020BA RID: 8378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x687530", Offset = "0x686730", VA = "0x180687530", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x687630", Offset = "0x686830", VA = "0x180687630")]
		private void UpdateScale()
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x687930", Offset = "0x686B30", VA = "0x180687930")]
		public TreeScaler()
		{
		}

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		protected List<Transform> branchMeshes;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x28")]
		public float minScale;

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x2C")]
		public float maxScale;

		// Token: 0x04001A94 RID: 6804
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x30")]
		public float minScaleDistance;

		// Token: 0x04001A95 RID: 6805
		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x34")]
		public float maxScaleDistance;
	}
}
