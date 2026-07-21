using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public class TransitionBetweenProfiles : MonoBehaviour
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xA056D0", Offset = "0xA048D0", VA = "0x180A056D0")]
		private void Start()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0xA057A0", Offset = "0xA049A0", VA = "0x180A057A0")]
		public void ToggleSkyProfiles()
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x71EB70", Offset = "0x71DD70", VA = "0x18071EB70")]
		public TransitionBetweenProfiles()
		{
		}

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x20")]
		public SkyProfile daySkyProfile;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x28")]
		public SkyProfile nightSkyProfile;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.1f, 30f)]
		[Tooltip("How long the transition animation will last.")]
		public float transitionDuration;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x38")]
		public TimeOfDayController timeOfDayController;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		[FieldOffset(Offset = "0x40")]
		private SkyProfile m_CurrentSkyProfile;
	}
}
