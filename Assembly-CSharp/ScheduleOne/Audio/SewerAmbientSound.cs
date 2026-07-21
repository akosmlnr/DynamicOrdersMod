using System;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BEB RID: 3051
	[Token(Token = "0x2000BEB")]
	public class SewerAmbientSound : MonoBehaviour
	{
		// Token: 0x06005A3B RID: 23099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x9B4400", Offset = "0x9B3600", VA = "0x1809B4400")]
		private void Update()
		{
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SewerAmbientSound()
		{
		}

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0x20")]
		public SewerCameraPresense SewerCameraPresense;

		// Token: 0x04003C57 RID: 15447
		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController SewerAmbienceSource;
	}
}
