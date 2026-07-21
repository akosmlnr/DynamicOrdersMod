using System;
using Il2CppDummyDll;
using ScheduleOne.Configuration;
using ScheduleOne.Core;
using ScheduleOne.Core.Audio;
using ScheduleOne.Core.Settings;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BEC RID: 3052
	[Token(Token = "0x2000BEC")]
	[CreateAssetMenu(fileName = "SFXConfiguration", menuName = "ScheduleOne/Configurations/SFX Configuration")]
	public class SFXConfiguration : Configuration<SFXSettings>
	{
		// Token: 0x06005A3E RID: 23102 RVA: 0x00016DA0 File Offset: 0x00014FA0
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x9B2E70", Offset = "0x9B2070", VA = "0x1809B2E70")]
		public bool TryGetImpactTypeData(EImpactSound material, out SFXSettings.ImpactSound data)
		{
			return default(bool);
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00016DB8 File Offset: 0x00014FB8
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x9B2D60", Offset = "0x9B1F60", VA = "0x1809B2D60")]
		public bool TryGetFootstepSoundGroup(EMaterialType materialType, out SFXSettings.FootstepSound group)
		{
			return default(bool);
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0x9B2F80", Offset = "0x9B2180", VA = "0x1809B2F80")]
		public SFXConfiguration()
		{
		}

		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController ImpactSoundPrefab;
	}
}
