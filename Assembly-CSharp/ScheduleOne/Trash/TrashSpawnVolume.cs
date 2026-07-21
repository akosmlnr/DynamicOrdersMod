using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x20007DB")]
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x06003616 RID: 13846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x7DF130", Offset = "0x7DE330", VA = "0x1807DF130")]
		public void Awake()
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x7DF280", Offset = "0x7DE480", VA = "0x1807DF280")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x7DF3F0", Offset = "0x7DE5F0", VA = "0x1807DF3F0")]
		public void SleepStart()
		{
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x7DFA40", Offset = "0x7DEC40", VA = "0x1807DFA40")]
		public TrashSpawnVolume()
		{
		}

		// Token: 0x04002713 RID: 10003
		[Token(Token = "0x4002713")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider CreatonVolume;

		// Token: 0x04002714 RID: 10004
		[Token(Token = "0x4002714")]
		[FieldOffset(Offset = "0x28")]
		public BoxCollider DetectionVolume;

		// Token: 0x04002715 RID: 10005
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0x30")]
		public int TrashLimit;

		// Token: 0x04002716 RID: 10006
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x34")]
		public float TrashSpawnChance;
	}
}
