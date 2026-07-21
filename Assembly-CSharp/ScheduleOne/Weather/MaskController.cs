using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2000BA1")]
	public class MaskController : MonoBehaviour
	{
		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x00016710 File Offset: 0x00014910
		[Token(Token = "0x17000CCB")]
		public float WorldSize
		{
			[Token(Token = "0x6005899")]
			[Address(RVA = "0x9ADFF0", Offset = "0x9AD1F0", VA = "0x1809ADFF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x17000CCC")]
		public int HeightMapResolution
		{
			[Token(Token = "0x600589A")]
			[Address(RVA = "0x4E09E0", Offset = "0x4DFBE0", VA = "0x1804E09E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CCD")]
		public float[] HeightMap
		{
			[Token(Token = "0x600589B")]
			[Address(RVA = "0x4B4770", Offset = "0x4B3970", VA = "0x1804B4770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x17000CCE")]
		public Vector2 MinMaxHeight
		{
			[Token(Token = "0x600589C")]
			[Address(RVA = "0x9ADFD0", Offset = "0x9AD1D0", VA = "0x1809ADFD0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589D")]
		[Address(RVA = "0x9AD630", Offset = "0x9AC830", VA = "0x1809AD630")]
		public void Initialise(int weatherVolumeCount, float blendAmount, Vector3 weatherVolumeSize)
		{
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589E")]
		[Address(RVA = "0x9ADB90", Offset = "0x9ACD90", VA = "0x1809ADB90")]
		public void RunWetMaskShader(List<WeatherVolume> weatherVolumes)
		{
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589F")]
		[Address(RVA = "0x9AD520", Offset = "0x9AC720", VA = "0x1809AD520")]
		public void ConvertHeightToArray()
		{
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60058A0")]
		[Address(RVA = "0x9AD5C0", Offset = "0x9AC7C0", VA = "0x1809AD5C0")]
		private IEnumerator DoHeightConversionRoutine()
		{
			return null;
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A1")]
		[Address(RVA = "0x9ADB10", Offset = "0x9ACD10", VA = "0x1809ADB10")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A2")]
		[Address(RVA = "0x9ADF50", Offset = "0x9AD150", VA = "0x1809ADF50")]
		public MaskController()
		{
		}

		// Token: 0x04003AE1 RID: 15073
		[Token(Token = "0x4003AE1")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private ComputeShader _wetMaskShader;

		// Token: 0x04003AE2 RID: 15074
		[Token(Token = "0x4003AE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ComputeShader _maskDownsampleShader;

		// Token: 0x04003AE3 RID: 15075
		[Token(Token = "0x4003AE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RenderTexture _wetMaskTexture;

		// Token: 0x04003AE4 RID: 15076
		[Token(Token = "0x4003AE4")]
		[FieldOffset(Offset = "0x38")]
		[Header("General Settings")]
		[SerializeField]
		private int _worldSize;

		// Token: 0x04003AE5 RID: 15077
		[Token(Token = "0x4003AE5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Header("Wet Mask Settings")]
		private int _wetMaskResolution;

		// Token: 0x04003AE6 RID: 15078
		[Token(Token = "0x4003AE6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _wetGrowthRate;

		// Token: 0x04003AE7 RID: 15079
		[Token(Token = "0x4003AE7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _wetDecayRate;

		// Token: 0x04003AE8 RID: 15080
		[Token(Token = "0x4003AE8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _sunEvapMultiplier;

		// Token: 0x04003AE9 RID: 15081
		[Token(Token = "0x4003AE9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationCurve _wetnessGrowthCurve;

		// Token: 0x04003AEA RID: 15082
		[Token(Token = "0x4003AEA")]
		[FieldOffset(Offset = "0x58")]
		[Header("Height Settings")]
		[SerializeField]
		private Texture2D _heightMask;

		// Token: 0x04003AEB RID: 15083
		[Token(Token = "0x4003AEB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _downsampledResolution;

		// Token: 0x04003AEC RID: 15084
		[Token(Token = "0x4003AEC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector2 _minMaxHeight;

		// Token: 0x04003AED RID: 15085
		[Token(Token = "0x4003AED")]
		[FieldOffset(Offset = "0x70")]
		[Header("Debugging & Development")]
		[SerializeField]
		private RenderTexture _debugTexture;

		// Token: 0x04003AEE RID: 15086
		[Token(Token = "0x4003AEE")]
		[FieldOffset(Offset = "0x78")]
		private Vector2[] _weatherVolumeOrigins;

		// Token: 0x04003AEF RID: 15087
		[Token(Token = "0x4003AEF")]
		[FieldOffset(Offset = "0x80")]
		private float[] _weatherRainValues;

		// Token: 0x04003AF0 RID: 15088
		[Token(Token = "0x4003AF0")]
		[FieldOffset(Offset = "0x88")]
		private float[] _weatherSunValues;

		// Token: 0x04003AF1 RID: 15089
		[Token(Token = "0x4003AF1")]
		[FieldOffset(Offset = "0x90")]
		private ComputeBuffer _volumeOriginsBuffer;

		// Token: 0x04003AF2 RID: 15090
		[Token(Token = "0x4003AF2")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer _volumeRainBuffer;

		// Token: 0x04003AF3 RID: 15091
		[Token(Token = "0x4003AF3")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer _volumeSunBuffer;

		// Token: 0x04003AF4 RID: 15092
		[Token(Token = "0x4003AF4")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine _heightConversionCo;

		// Token: 0x04003AF5 RID: 15093
		[Token(Token = "0x4003AF5")]
		[FieldOffset(Offset = "0xB0")]
		private float[] _heightMap;
	}
}
