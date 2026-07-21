using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	public class Intersection : MonoBehaviour
	{
		// Token: 0x06001E77 RID: 7799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x643AF0", Offset = "0x642CF0", VA = "0x180643AF0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x643340", Offset = "0x642540", VA = "0x180643340")]
		protected IEnumerator Run()
		{
			return null;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x6433B0", Offset = "0x6425B0", VA = "0x1806433B0")]
		protected void SetPath1Lights(TrafficLight.State state)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x643750", Offset = "0x642950", VA = "0x180643750")]
		protected void SetPath2Lights(TrafficLight.State state)
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x643BE0", Offset = "0x642DE0", VA = "0x180643BE0")]
		public Intersection()
		{
		}

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		private const float AmberTime = 3f;

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected List<TrafficLight> path1Lights;

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected List<TrafficLight> path2Lights;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected List<GameObject> path1Obstacles;

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<GameObject> path2Obstacles;

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		[SerializeField]
		protected float path1Time;

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected float path2Time;

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected float timeOffset;
	}
}
