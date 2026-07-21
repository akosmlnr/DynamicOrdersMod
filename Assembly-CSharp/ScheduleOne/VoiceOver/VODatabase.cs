using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	[CreateAssetMenu(fileName = "VODatabase", menuName = "ScriptableObjects/VODatabase")]
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0xAFC2E0", Offset = "0xAFB4E0", VA = "0x180AFC2E0")]
		public VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			return null;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0xAFC430", Offset = "0xAFB630", VA = "0x180AFC430")]
		public AudioClip GetRandomClip(EVOLineType lineType)
		{
			return null;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0xAFC550", Offset = "0xAFB750", VA = "0x180AFC550")]
		public VODatabase()
		{
		}

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 2f)]
		public float VolumeMultiplier;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x20")]
		public List<VODatabaseEntry> Entries;
	}
}
