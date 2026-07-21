using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	[CreateAssetMenu(fileName = "LensFlareSettings", menuName = "ScriptableObjects/Weather/Lens Flare Settings")]
	public class LensFlareSettings : ScriptableObject
	{
		// Token: 0x06005895 RID: 22677 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x6005895")]
		[Address(RVA = "0x9AD420", Offset = "0x9AC620", VA = "0x1809AD420")]
		public bool TryGetLensFlareSettings(LensFlareDataSRP lensFlare, out LensFlareSettings.LensFlareSettingsGroup group)
		{
			return default(bool);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
		public LensFlareSettings.LensFlareSettingsGroup[] GetLensFlareGroups()
		{
			return null;
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005897")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public LensFlareSettings()
		{
		}

		// Token: 0x04003ADE RID: 15070
		[Token(Token = "0x4003ADE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LensFlareSettings.LensFlareSettingsGroup[] lensFlareGroups;

		// Token: 0x02000BA0 RID: 2976
		[Token(Token = "0x2000BA0")]
		[Serializable]
		public class LensFlareSettingsGroup
		{
			// Token: 0x06005898 RID: 22680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005898")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public LensFlareSettingsGroup()
			{
			}

			// Token: 0x04003ADF RID: 15071
			[Token(Token = "0x4003ADF")]
			[FieldOffset(Offset = "0x10")]
			public LensFlareDataSRP LensFlare;

			// Token: 0x04003AE0 RID: 15072
			[Token(Token = "0x4003AE0")]
			[FieldOffset(Offset = "0x18")]
			public float Intensity;
		}
	}
}
