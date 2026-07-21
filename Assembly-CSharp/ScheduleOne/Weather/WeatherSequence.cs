using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	[CreateAssetMenu(fileName = "WeatherSequence", menuName = "ScriptableObjects/Weather/Weather Sequence")]
	public class WeatherSequence : ScriptableObject
	{
		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CEC")]
		public string Id
		{
			[Token(Token = "0x6005954")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CED")]
		public List<WeatherSequence.SequenceItem> WeatherVolumes
		{
			[Token(Token = "0x6005955")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x000169C8 File Offset: 0x00014BC8
		[Token(Token = "0x17000CEE")]
		public WeatherSequence.TimeReference TimeRef
		{
			[Token(Token = "0x6005956")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			get
			{
				return WeatherSequence.TimeReference.StartOfDay;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x000169E0 File Offset: 0x00014BE0
		[Token(Token = "0x17000CEF")]
		public int StartTime
		{
			[Token(Token = "0x6005957")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005958")]
		[Address(RVA = "0x9BD6C0", Offset = "0x9BC8C0", VA = "0x1809BD6C0")]
		public WeatherSequence()
		{
		}

		// Token: 0x04003B9D RID: 15261
		[Token(Token = "0x4003B9D")]
		[FieldOffset(Offset = "0x18")]
		[Header("Settings")]
		[SerializeField]
		private string _id;

		// Token: 0x04003B9E RID: 15262
		[Token(Token = "0x4003B9E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _chanceToOccur;

		// Token: 0x04003B9F RID: 15263
		[Token(Token = "0x4003B9F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _startTime;

		// Token: 0x04003BA0 RID: 15264
		[Token(Token = "0x4003BA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WeatherSequence.TimeReference _timeReference;

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<WeatherSequence.SequenceItem> _weatherVolumes;

		// Token: 0x02000BC5 RID: 3013
		[Token(Token = "0x2000BC5")]
		[Serializable]
		public class SequenceItem
		{
			// Token: 0x06005959 RID: 22873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005959")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SequenceItem()
			{
			}

			// Token: 0x04003BA2 RID: 15266
			[Token(Token = "0x4003BA2")]
			[FieldOffset(Offset = "0x10")]
			public WeatherVolume Volume;

			// Token: 0x04003BA3 RID: 15267
			[Token(Token = "0x4003BA3")]
			[FieldOffset(Offset = "0x18")]
			public int ActiveTime;

			// Token: 0x04003BA4 RID: 15268
			[Token(Token = "0x4003BA4")]
			[FieldOffset(Offset = "0x1C")]
			public int TransitionInTime;
		}

		// Token: 0x02000BC6 RID: 3014
		[Token(Token = "0x2000BC6")]
		public enum TimeReference
		{
			// Token: 0x04003BA6 RID: 15270
			[Token(Token = "0x4003BA6")]
			StartOfDay,
			// Token: 0x04003BA7 RID: 15271
			[Token(Token = "0x4003BA7")]
			OnInitialisation,
			// Token: 0x04003BA8 RID: 15272
			[Token(Token = "0x4003BA8")]
			Custom
		}
	}
}
