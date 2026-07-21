using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	public class LightningController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10")]
		private void Start()
		{
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x9F8B90", Offset = "0x9F7D90", VA = "0x1809F8B90", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x9F8BC0", Offset = "0x9F7DC0", VA = "0x1809F8BC0")]
		public void Update()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x9F8850", Offset = "0x9F7A50", VA = "0x1809F8850")]
		public void ClearLightningRenderers()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x9F8960", Offset = "0x9F7B60", VA = "0x1809F8960")]
		public void CreateLightningRenderers()
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x9F8F30", Offset = "0x9F8130", VA = "0x1809F8F30")]
		public LightningController()
		{
		}

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x20")]
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x28")]
		private float m_TimeOfDay;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x30")]
		private List<LightningRenderer> m_LightningRenderers;
	}
}
