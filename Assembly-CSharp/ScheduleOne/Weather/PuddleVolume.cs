using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BA7 RID: 2983
	[Token(Token = "0x2000BA7")]
	public class PuddleVolume : MonoBehaviour
	{
		// Token: 0x060058BB RID: 22715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x9B1720", Offset = "0x9B0920", VA = "0x1809B1720")]
		private void Start()
		{
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x9B1640", Offset = "0x9B0840", VA = "0x1809B1640")]
		private void RandomiseActivePuddles()
		{
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Update()
		{
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x9B1870", Offset = "0x9B0A70", VA = "0x1809B1870")]
		public void UpdateRates(WeatherConditions weatherConditions)
		{
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x9B1900", Offset = "0x9B0B00", VA = "0x1809B1900")]
		public PuddleVolume()
		{
		}

		// Token: 0x04003B01 RID: 15105
		[Token(Token = "0x4003B01")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private List<GameObject> _puddleObjs;

		// Token: 0x04003B02 RID: 15106
		[Token(Token = "0x4003B02")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[SerializeField]
		private Vector2Int _minMaxPuddlesInVolume;

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _minMaxPuddleDecay;

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _minMaxGrowthRate;

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		[FieldOffset(Offset = "0x40")]
		private float _decayRate;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		[FieldOffset(Offset = "0x44")]
		private float _growthRate;
	}
}
