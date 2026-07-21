using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Weather;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	[ExecuteInEditMode]
	public class TimeOfDayController : MonoBehaviour
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023E")]
		public static TimeOfDayController instance
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xA05320", Offset = "0xA04520", VA = "0x180A05320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xA05430", Offset = "0xA04630", VA = "0x180A05430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023F")]
		public SkyProfile skyProfile
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xA05490", Offset = "0xA04690", VA = "0x180A05490")]
			set
			{
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00006630 File Offset: 0x00004830
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		public float skyTime
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xA05570", Offset = "0xA04770", VA = "0x180A05570")]
			set
			{
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000241")]
		public SkyMaterialController SkyMaterial
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event TimeOfDayController.TimeOfDayDidChange timeChangedCallback
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xA05260", Offset = "0xA04460", VA = "0x180A05260")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0xA05380", Offset = "0xA04580", VA = "0x180A05380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00006648 File Offset: 0x00004848
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000242")]
		public bool UseEnvironmentProfileStack
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xA05300", Offset = "0xA04500", VA = "0x180A05300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0xA05420", Offset = "0xA04620", VA = "0x180A05420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000243")]
		public SkyProfileFrame SkyProfileFrame
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x73A010", Offset = "0x739210", VA = "0x18073A010")]
			set
			{
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x17000244")]
		public float timeOfDay
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xA05360", Offset = "0xA04560", VA = "0x180A05360")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x17000245")]
		public int daysElapsed
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xA05310", Offset = "0xA04510", VA = "0x180A05310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xA00980", Offset = "0x9FFB80", VA = "0x180A00980")]
		private void Awake()
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xA00C60", Offset = "0x9FFE60", VA = "0x180A00C60")]
		private void OnEnabled()
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xA00C80", Offset = "0x9FFE80", VA = "0x180A00C80")]
		private void OnValidate()
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xA051F0", Offset = "0xA043F0", VA = "0x180A051F0")]
		private void WarnInvalidSkySetup()
		{
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xA04AE0", Offset = "0xA03CE0", VA = "0x180A04AE0")]
		private void Update()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xA01430", Offset = "0xA00630", VA = "0x180A01430")]
		public void UpdateGlobalIllumination()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xA01070", Offset = "0xA00270", VA = "0x180A01070")]
		private void SynchronizeAllShaderKeywords()
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA012E0", Offset = "0xA004E0", VA = "0x180A012E0")]
		private void SynchronizedShaderKeyword(string featureKey, string shaderKeyword)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xA00A70", Offset = "0x9FFC70", VA = "0x180A00A70")]
		private Vector3 GetPrimaryLightDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xA00CE0", Offset = "0x9FFEE0", VA = "0x180A00CE0")]
		public bool StartSkyProfileTransition(SkyProfile toProfile, float duration = 1f)
		{
			return default(bool);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA009E0", Offset = "0x9FFBE0", VA = "0x180A009E0")]
		public void CancelSkyProfileTransition()
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA00C20", Offset = "0x9FFE20", VA = "0x180A00C20")]
		public void OnBlendComplete(BlendSkyProfiles blender)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA00BB0", Offset = "0x9FFDB0", VA = "0x180A00BB0")]
		public bool IsBlendingInProgress()
		{
			return default(bool);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA01440", Offset = "0xA00640", VA = "0x180A01440")]
		public void UpdateSkyForCurrentTime()
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xA05250", Offset = "0xA04450", VA = "0x180A05250")]
		public TimeOfDayController()
		{
		}

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Sky profile defines the skyColors configuration for times of day. This script will animate between those skyColors values based on the time of day.")]
		[SerializeField]
		private SkyProfile m_SkyProfile;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Time is expressed in a fractional number of days that have completed.")]
		private float m_SkyTime;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Automatically advance time at fixed speed.")]
		public bool automaticTimeIncrement;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x2D")]
		[Tooltip("Create a copy of the sky profile at runtime, so modifications don't affect the original Sky Profile in your project.")]
		public bool copySkyProfile;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x30")]
		private SkyMaterialController m_SkyMaterialController;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Speed at which to advance time by if in automatic increment is enabled.")]
		[Range(0f, 1f)]
		public float automaticIncrementSpeed;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Sun orbit.")]
		public OrbitingBody sunOrbit;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Moon orbit.")]
		public OrbitingBody moonOrbit;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Controller for managing weather effects")]
		public WeatherController weatherController;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("If true we'll invoke DynamicGI.UpdateEnvironment() when skybox changes. This is an expensive operation.")]
		public bool updateGlobalIllumination;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Configurable prefab that determines how to animate between 2 sky profiles. You can override individual feature animations, ex: 'skyBlender', to create a custom sky blending effect.")]
		public BlendSkyProfiles skyProfileTransitionPrefab;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x68")]
		[Header("Overrides")]
		public SkyProfileOverride[] SkyProfileOverrideStack;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x78")]
		private bool m_DidInitialUpdate;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x80")]
		private SkyProfileFrame _skyProfileFrame;

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x06000A3A RID: 2618
		[Token(Token = "0x20001DD")]
		public delegate void TimeOfDayDidChange(TimeOfDayController tc, float timeOfDay);
	}
}
