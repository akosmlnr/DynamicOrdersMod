using System;
using Il2CppDummyDll;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000BDB")]
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060059ED RID: 23021 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D0D")]
		public FloatSmoother VolumeController
		{
			[Token(Token = "0x60059ED")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000D0E")]
		public FloatSmoother PitchController
		{
			[Token(Token = "0x60059EE")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059EF")]
		[Address(RVA = "0x9AC8A0", Offset = "0x9ABAA0", VA = "0x1809AC8A0")]
		private void Awake()
		{
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F0")]
		[Address(RVA = "0x9AC910", Offset = "0x9ABB10", VA = "0x1809AC910")]
		private void Update()
		{
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public HeartbeatSoundController()
		{
		}

		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("VolumeController")]
		[SerializeField]
		private FloatSmoother _volumeController;

		// Token: 0x04003C2F RID: 15407
		[Token(Token = "0x4003C2F")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("PitchController")]
		[SerializeField]
		private FloatSmoother _pitchController;

		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("sound")]
		private AudioSourceController _sound;
	}
}
