using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	public class WeatherController : MonoBehaviour
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public RainDownfallController rainDownfallController
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		public RainSplashController rainSplashController
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		public LightningController lightningController
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000252")]
		public WeatherDepthCamera weatherDepthCamera
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xA069E0", Offset = "0xA05BE0", VA = "0x180A069E0")]
		private void Awake()
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xA069E0", Offset = "0xA05BE0", VA = "0x180A069E0")]
		private void Start()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xA06D50", Offset = "0xA05F50", VA = "0x180A06D50")]
		private void OnEnable()
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xA069F0", Offset = "0xA05BF0", VA = "0x180A069F0")]
		private void DiscoverWeatherControllers()
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0xA06C10", Offset = "0xA05E10", VA = "0x180A06C10")]
		private void OnDisable()
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0xA06FB0", Offset = "0xA061B0", VA = "0x180A06FB0")]
		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0xA06AF0", Offset = "0xA05CF0", VA = "0x180A06AF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xA06EE0", Offset = "0xA060E0", VA = "0x180A06EE0")]
		private void OnEnclosureDidChange(WeatherEnclosure enclosure)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WeatherController()
		{
		}

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x40")]
		private WeatherEnclosure m_Enclosure;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x48")]
		private MeshRenderer m_EnclosureMeshRenderer;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x50")]
		private WeatherEnclosureDetector detector;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x58")]
		private SkyProfile m_Profile;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x60")]
		private float m_TimeOfDay;
	}
}
