using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD5 RID: 3029
	[Token(Token = "0x2000BD5")]
	public class AudioZoneModifierVolume : MonoBehaviour, IAudioZoneModifier
	{
		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x00016C68 File Offset: 0x00014E68
		[Token(Token = "0x17000D0C")]
		public float VolumeMultiplier
		{
			[Token(Token = "0x60059DA")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DB")]
		[Address(RVA = "0x9AAF30", Offset = "0x9AA130", VA = "0x1809AAF30")]
		private void Start()
		{
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x9AAA90", Offset = "0x9A9C90", VA = "0x1809AAA90")]
		private void Refresh()
		{
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x00016C80 File Offset: 0x00014E80
		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x9AA940", Offset = "0x9A9B40", VA = "0x1809AA940")]
		private bool IsCameraWithinVolume()
		{
			return default(bool);
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x9AAFE0", Offset = "0x9AA1E0", VA = "0x1809AAFE0")]
		public AudioZoneModifierVolume()
		{
		}

		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("Zones")]
		[SerializeField]
		private List<AudioZone> _zones;

		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("VolumeMultiplier")]
		[SerializeField]
		private float _volumeMultiplier;

		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		[FieldOffset(Offset = "0x30")]
		private BoxCollider[] _colliders;
	}
}
