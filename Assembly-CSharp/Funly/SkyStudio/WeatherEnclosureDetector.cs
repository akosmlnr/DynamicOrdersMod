using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	public class WeatherEnclosureDetector : MonoBehaviour
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xA077B0", Offset = "0xA069B0", VA = "0x180A077B0")]
		private void Start()
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0xA077B0", Offset = "0xA069B0", VA = "0x180A077B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0xA077C0", Offset = "0xA069C0", VA = "0x180A077C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0xA07930", Offset = "0xA06B30", VA = "0x180A07930")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xA076B0", Offset = "0xA068B0", VA = "0x180A076B0")]
		public void ApplyEnclosure()
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xA07A20", Offset = "0xA06C20", VA = "0x180A07A20")]
		public WeatherEnclosureDetector()
		{
		}

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Default enclosure used when not inside the trigger of another enclosure area.")]
		public WeatherEnclosure mainEnclosure;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x28")]
		private List<WeatherEnclosure> triggeredEnclosures;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x30")]
		public RainDownfallController rainController;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x38")]
		public Action<WeatherEnclosure> enclosureChangedCallback;
	}
}
