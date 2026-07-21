using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A0F RID: 2575
	[Token(Token = "0x2000A0F")]
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x17000B7F")]
		public float RecordedTime
		{
			[Token(Token = "0x600498A")]
			[Address(RVA = "0x90BA00", Offset = "0x90AC00", VA = "0x18090BA00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498B")]
		[Address(RVA = "0x90B800", Offset = "0x90AA00", VA = "0x18090B800")]
		private void Start()
		{
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498C")]
		[Address(RVA = "0x90B820", Offset = "0x90AA20", VA = "0x18090B820")]
		private void Update()
		{
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498D")]
		[Address(RVA = "0x90B6E0", Offset = "0x90A8E0", VA = "0x18090B6E0")]
		private void RecordPosition()
		{
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x600498E")]
		[Address(RVA = "0x90B630", Offset = "0x90A830", VA = "0x18090B630")]
		public Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			return default(Vector3);
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x90B5E0", Offset = "0x90A7E0", VA = "0x18090B5E0")]
		public void ClearHistory()
		{
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004990")]
		[Address(RVA = "0x90B970", Offset = "0x90AB70", VA = "0x18090B970")]
		public PositionHistoryTracker()
		{
		}

		// Token: 0x040033F3 RID: 13299
		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Frequency (in seconds) to record the position.")]
		public float recordingFrequency;

		// Token: 0x040033F4 RID: 13300
		[Token(Token = "0x40033F4")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Duration (in seconds) to store the position history.")]
		public float historyDuration;

		// Token: 0x040033F5 RID: 13301
		[Token(Token = "0x40033F5")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> positionHistory;

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0x30")]
		private float lastRecordTime;
	}
}
