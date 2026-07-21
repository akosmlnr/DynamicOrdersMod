using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	[RequireComponent(typeof(AudioSourceController))]
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x06005987 RID: 22919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005987")]
		[Address(RVA = "0x9A6F50", Offset = "0x9A6150", VA = "0x1809A6F50")]
		private void Awake()
		{
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005988")]
		[Address(RVA = "0x9A7330", Offset = "0x9A6530", VA = "0x1809A7330")]
		private void Start()
		{
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005989")]
		[Address(RVA = "0x9A6FA0", Offset = "0x9A61A0", VA = "0x1809A6FA0")]
		private void OnUncappedMinPass()
		{
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598A")]
		[Address(RVA = "0x9A72E0", Offset = "0x9A64E0", VA = "0x1809A72E0")]
		private void Play()
		{
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598B")]
		[Address(RVA = "0x9A7430", Offset = "0x9A6630", VA = "0x1809A7430")]
		public AmbientOneShot()
		{
		}

		// Token: 0x04003BC4 RID: 15300
		[Token(Token = "0x4003BC4")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("Volume")]
		[Header("Settings")]
		private float _volume;

		// Token: 0x04003BC5 RID: 15301
		[Token(Token = "0x4003BC5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("ChancePerHour")]
		[Range(0f, 1f)]
		private float _playChancePerHour;

		// Token: 0x04003BC6 RID: 15302
		[Token(Token = "0x4003BC6")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("CooldownTime")]
		[SerializeField]
		private int _cooldownTime;

		// Token: 0x04003BC7 RID: 15303
		[Token(Token = "0x4003BC7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("PlayTime")]
		private AmbientOneShot.EPlayTime _playTime;

		// Token: 0x04003BC8 RID: 15304
		[Token(Token = "0x4003BC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("MinDistance")]
		private float _minDistanceFromCameraToPlay;

		// Token: 0x04003BC9 RID: 15305
		[Token(Token = "0x4003BC9")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("MaxDistance")]
		[SerializeField]
		private float _maxDistanceFromCameraToPlay;

		// Token: 0x04003BCA RID: 15306
		[Token(Token = "0x4003BCA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("PlayWhileInSewer")]
		private bool _canPlayWhilePlayerInSewer;

		// Token: 0x04003BCB RID: 15307
		[Token(Token = "0x4003BCB")]
		[FieldOffset(Offset = "0x3C")]
		private int _timeSinceLastPlay;

		// Token: 0x04003BCC RID: 15308
		[Token(Token = "0x4003BCC")]
		[FieldOffset(Offset = "0x40")]
		private AudioSourceController _audioSource;

		// Token: 0x02000BCE RID: 3022
		[Token(Token = "0x2000BCE")]
		private enum EPlayTime
		{
			// Token: 0x04003BCE RID: 15310
			[Token(Token = "0x4003BCE")]
			All,
			// Token: 0x04003BCF RID: 15311
			[Token(Token = "0x4003BCF")]
			Day,
			// Token: 0x04003BD0 RID: 15312
			[Token(Token = "0x4003BD0")]
			Night
		}
	}
}
