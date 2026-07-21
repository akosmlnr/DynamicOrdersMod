using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.GameTime
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0xB30F10", Offset = "0xB30110", VA = "0x180B30F10")]
		private void Awake()
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0xB31270", Offset = "0xB30470", VA = "0x180B31270")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124E")]
		[Address(RVA = "0xB313E0", Offset = "0xB305E0", VA = "0x180B313E0")]
		private void Update()
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x600124F")]
		[Address(RVA = "0xB31100", Offset = "0xB30300", VA = "0x180B31100")]
		private int GetCurrentKeyFrameStart()
		{
			return 0;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0xB311B0", Offset = "0xB303B0", VA = "0x180B311B0")]
		[Button]
		public void IncrementKeyframe()
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0xB31060", Offset = "0xB30260", VA = "0x180B31060")]
		public void Disable()
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TutorialTimeController()
		{
		}

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve TimeProgressionCurve;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x28")]
		public TutorialTimeController.KeyFrame[] KeyFrames;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int currentKeyFrameIndex;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x34")]
		private bool disabled;

		// Token: 0x02000304 RID: 772
		[Token(Token = "0x2000304")]
		[Serializable]
		public struct KeyFrame
		{
			// Token: 0x040010B9 RID: 4281
			[Token(Token = "0x40010B9")]
			[FieldOffset(Offset = "0x0")]
			public int Time;

			// Token: 0x040010BA RID: 4282
			[Token(Token = "0x40010BA")]
			[FieldOffset(Offset = "0x4")]
			public float SpeedMultiplier;

			// Token: 0x040010BB RID: 4283
			[Token(Token = "0x40010BB")]
			[FieldOffset(Offset = "0x8")]
			public string Note;
		}
	}
}
