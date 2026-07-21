using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BCB RID: 3019
	[Token(Token = "0x2000BCB")]
	[CreateAssetMenu(fileName = "AudioSettings", menuName = "ScriptableObjects/Audio/Audio Settings")]
	public class AudioSettings : ScriptableObject
	{
		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CFE")]
		public string Id
		{
			[Token(Token = "0x6005983")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06005984 RID: 22916 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CFF")]
		public AudioSettingsWrapper Wrapper
		{
			[Token(Token = "0x6005984")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005985")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public AudioSettings()
		{
		}

		// Token: 0x04003BBB RID: 15291
		[Token(Token = "0x4003BBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Settings")]
		private string _id;

		// Token: 0x04003BBC RID: 15292
		[Token(Token = "0x4003BBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSettingsWrapper _settings;
	}
}
