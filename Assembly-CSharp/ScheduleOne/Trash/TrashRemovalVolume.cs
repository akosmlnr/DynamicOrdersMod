using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	[RequireComponent(typeof(BoxCollider))]
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x06003611 RID: 13841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public void Awake()
		{
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x7DEF20", Offset = "0x7DE120", VA = "0x1807DEF20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x7DF090", Offset = "0x7DE290", VA = "0x1807DF090")]
		private void SleepStart()
		{
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x7DEBA0", Offset = "0x7DDDA0", VA = "0x1807DEBA0")]
		private TrashItem[] GetTrash()
		{
			return null;
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x7DF120", Offset = "0x7DE320", VA = "0x1807DF120")]
		public TrashRemovalVolume()
		{
		}

		// Token: 0x04002711 RID: 10001
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider Collider;

		// Token: 0x04002712 RID: 10002
		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x28")]
		public float RemovalChance;
	}
}
