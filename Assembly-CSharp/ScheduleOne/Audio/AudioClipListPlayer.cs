using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD0 RID: 3024
	[Token(Token = "0x2000BD0")]
	[RequireComponent(typeof(AudioSourceController))]
	public class AudioClipListPlayer : MonoBehaviour
	{
		// Token: 0x06005992 RID: 22930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005992")]
		[Address(RVA = "0x9A8040", Offset = "0x9A7240", VA = "0x1809A8040")]
		private void Awake()
		{
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005993")]
		[Address(RVA = "0x9A82C0", Offset = "0x9A74C0", VA = "0x1809A82C0")]
		private void Start()
		{
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005994")]
		[Address(RVA = "0x9A80E0", Offset = "0x9A72E0", VA = "0x1809A80E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005995")]
		[Address(RVA = "0x9A8200", Offset = "0x9A7400", VA = "0x1809A8200")]
		private void OnTick()
		{
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005996")]
		[Address(RVA = "0x9A83E0", Offset = "0x9A75E0", VA = "0x1809A83E0")]
		public AudioClipListPlayer()
		{
		}

		// Token: 0x04003BDC RID: 15324
		[Token(Token = "0x4003BDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("Clips")]
		private List<AudioClip> _clips;

		// Token: 0x04003BDD RID: 15325
		[Token(Token = "0x4003BDD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _shuffleOnAwake;

		// Token: 0x04003BDE RID: 15326
		[Token(Token = "0x4003BDE")]
		[FieldOffset(Offset = "0x30")]
		private AudioSourceController _audioSource;

		// Token: 0x04003BDF RID: 15327
		[Token(Token = "0x4003BDF")]
		[FieldOffset(Offset = "0x38")]
		private int _currentClipIndex;
	}
}
