using System;
using Funly.SkyStudio;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2000B9C")]
	[CreateAssetMenu(fileName = "EnvironmentProfile", menuName = "ScriptableObjects/Weather/Environment Profile")]
	public class EnvironmentProfile : ScriptableObject
	{
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06005884 RID: 22660 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CC7")]
		public SkySettings SkySettings
		{
			[Token(Token = "0x6005884")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005885")]
		[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
		public SkyProfile GetSkyProfile()
		{
			return null;
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005886")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public EnvironmentProfile()
		{
		}

		// Token: 0x04003ACF RID: 15055
		[Token(Token = "0x4003ACF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Sky profile (TEMP - REPLACING)")]
		private SkyProfile _skyProfile;

		// Token: 0x04003AD0 RID: 15056
		[Token(Token = "0x4003AD0")]
		[FieldOffset(Offset = "0x20")]
		[Header("Sky Settings")]
		[SerializeField]
		private SkySettings _skySettings;
	}
}
