using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A0 RID: 1440
	[Token(Token = "0x20005A0")]
	[RequireComponent(typeof(Light))]
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x6708A0", Offset = "0x66FAA0", VA = "0x1806708A0")]
		private void Start()
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x6709F0", Offset = "0x66FBF0", VA = "0x1806709F0")]
		private void Update()
		{
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x670900", Offset = "0x66FB00", VA = "0x180670900")]
		private void UpdateTargetValues()
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x670BE0", Offset = "0x66FDE0", VA = "0x180670BE0")]
		public FlickeringLight()
		{
		}

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x20")]
		[Header("Intensity Settings")]
		[Tooltip("The minimum light intensity.")]
		public float minIntensity;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("The maximum light intensity.")]
		public float maxIntensity;

		// Token: 0x04001AC4 RID: 6852
		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Enable slight color shifts to simulate a warm flame.")]
		[Header("Color Settings")]
		public bool enableColorShift;

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0x2C")]
		public Color minColor;

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0x3C")]
		public Color maxColor;

		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("How quickly the light flickers (lower is faster).")]
		[Header("Flicker Speed")]
		public float flickerSpeed;

		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[FieldOffset(Offset = "0x50")]
		private Light lightSource;

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		[FieldOffset(Offset = "0x58")]
		private float targetIntensity;

		// Token: 0x04001ACA RID: 6858
		[Token(Token = "0x4001ACA")]
		[FieldOffset(Offset = "0x5C")]
		private Color targetColor;
	}
}
