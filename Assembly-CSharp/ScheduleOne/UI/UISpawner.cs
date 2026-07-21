using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC4 RID: 3268
	[Token(Token = "0x2000CC4")]
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x06005F5B RID: 24411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0xA1CF00", Offset = "0xA1C100", VA = "0x180A1CF00")]
		private void Start()
		{
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0xA1CF40", Offset = "0xA1C140", VA = "0x180A1CF40")]
		private void Update()
		{
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0xA1D270", Offset = "0xA1C470", VA = "0x180A1D270")]
		public UISpawner()
		{
		}

		// Token: 0x040041A9 RID: 16809
		[Token(Token = "0x40041A9")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform SpawnArea;

		// Token: 0x040041AA RID: 16810
		[Token(Token = "0x40041AA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] Prefabs;

		// Token: 0x040041AB RID: 16811
		[Token(Token = "0x40041AB")]
		[FieldOffset(Offset = "0x30")]
		public float MinInterval;

		// Token: 0x040041AC RID: 16812
		[Token(Token = "0x40041AC")]
		[FieldOffset(Offset = "0x34")]
		public float MaxInterval;

		// Token: 0x040041AD RID: 16813
		[Token(Token = "0x40041AD")]
		[FieldOffset(Offset = "0x38")]
		public float SpawnRateMultiplier;

		// Token: 0x040041AE RID: 16814
		[Token(Token = "0x40041AE")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 MinScale;

		// Token: 0x040041AF RID: 16815
		[Token(Token = "0x40041AF")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 MaxScale;

		// Token: 0x040041B0 RID: 16816
		[Token(Token = "0x40041B0")]
		[FieldOffset(Offset = "0x4C")]
		public bool UniformScale;

		// Token: 0x040041B1 RID: 16817
		[Token(Token = "0x40041B1")]
		[FieldOffset(Offset = "0x50")]
		private float nextSpawnTime;

		// Token: 0x040041B2 RID: 16818
		[Token(Token = "0x40041B2")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<GameObject> OnSpawn;
	}
}
