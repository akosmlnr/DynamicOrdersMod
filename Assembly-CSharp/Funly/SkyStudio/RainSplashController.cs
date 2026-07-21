using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	public class RainSplashController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x9FC2B0", Offset = "0x9FB4B0", VA = "0x1809FC2B0")]
		private void Start()
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x9F8B90", Offset = "0x9F7D90", VA = "0x1809F8B90", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x9FC330", Offset = "0x9FB530", VA = "0x1809FC330")]
		private void Update()
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x9FBFF0", Offset = "0x9FB1F0", VA = "0x1809FBFF0")]
		public void ClearSplashRenderers()
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x9FC100", Offset = "0x9FB300", VA = "0x1809FC100")]
		public void CreateSplashRenderers()
		{
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x9FC610", Offset = "0x9FB810", VA = "0x1809FC610")]
		public RainSplashController()
		{
		}

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x20")]
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		[FieldOffset(Offset = "0x28")]
		private float m_TimeOfDay;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		[FieldOffset(Offset = "0x30")]
		private List<RainSplashRenderer> m_SplashRenderers;
	}
}
