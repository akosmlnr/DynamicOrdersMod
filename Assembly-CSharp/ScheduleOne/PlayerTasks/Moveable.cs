using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class Moveable : Clickable
	{
		// Token: 0x06001690 RID: 5776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x5BE210", Offset = "0x5BD410", VA = "0x1805BE210", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x5BE520", Offset = "0x5BD720", VA = "0x1805BE520", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x5BE200", Offset = "0x5BD400", VA = "0x1805BE200", Slot = "7")]
		public override void EndClick()
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x5BE820", Offset = "0x5BDA20", VA = "0x1805BE820")]
		public Moveable()
		{
		}

		// Token: 0x040013DA RID: 5082
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 clickOffset;

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x5C")]
		protected float clickDist;

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("Bounds")]
		protected float yMax;

		// Token: 0x040013DD RID: 5085
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected float yMin;
	}
}
