using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	[RequireComponent(typeof(AudioSource))]
	public class RainDownfallController : MonoBehaviour, ISkyModule
	{
		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x9FB4F0", Offset = "0x9FA6F0", VA = "0x1809FB4F0")]
		public void SetWeatherEnclosure(WeatherEnclosure enclosure)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x9FBF70", Offset = "0x9FB170", VA = "0x1809FBF70")]
		private void Update()
		{
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x9FB700", Offset = "0x9FA900", VA = "0x1809FB700", Slot = "4")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RainDownfallController()
		{
		}

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer rainMeshRenderer;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x28")]
		public Material rainMaterial;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x30")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x38")]
		private AudioSource m_RainAudioSource;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x40")]
		private float m_TimeOfDay;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x48")]
		private SkyProfile m_SkyProfile;
	}
}
