using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B93 RID: 2963
	[Token(Token = "0x2000B93")]
	public class DayNightController : MonoBehaviour
	{
		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06005819 RID: 22553 RVA: 0x000165D8 File Offset: 0x000147D8
		[Token(Token = "0x17000CC3")]
		public bool EnableDebugTimeControl
		{
			[Token(Token = "0x6005819")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x993EB0", Offset = "0x9930B0", VA = "0x180993EB0")]
		private void Update()
		{
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600581B")]
		[Address(RVA = "0x991F30", Offset = "0x991130", VA = "0x180991F30")]
		public SkyState EvaluateSky(SkySettings activeSettings, SkySettings neighbourSettings, float blend, [Optional] SkySettings overrideSkySettings, float overrideBlend = 0f)
		{
			return null;
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600581C")]
		[Address(RVA = "0x992210", Offset = "0x991410", VA = "0x180992210")]
		private SkyState EvaluateSky(SkyState state, SkySettings activeSettings, SkySettings neighbourSettings, float blend, float timeInTwentyFourHour, float timePercentage)
		{
			return null;
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600581D")]
		[Address(RVA = "0x9914F0", Offset = "0x9906F0", VA = "0x1809914F0")]
		private SkyState BlendSky(SkyState from, SkyState to, float blend)
		{
			return null;
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x600581E")]
		[Address(RVA = "0x991F00", Offset = "0x991100", VA = "0x180991F00")]
		public float EvaluateFloatByTimeOfDay(DynamicGradient gradient)
		{
			return 0f;
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x600581F")]
		[Address(RVA = "0x991EC0", Offset = "0x9910C0", VA = "0x180991EC0")]
		public Color EvaluateColorByTimeOfDay(DynamicGradient gradient)
		{
			return default(Color);
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005820")]
		[Address(RVA = "0x993D50", Offset = "0x992F50", VA = "0x180993D50")]
		private void UpdateSky(SkyState skyState)
		{
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005821")]
		[Address(RVA = "0x9937B0", Offset = "0x9929B0", VA = "0x1809937B0")]
		private void SetLights(bool isDay)
		{
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005822")]
		[Address(RVA = "0x993AA0", Offset = "0x992CA0", VA = "0x180993AA0")]
		private void UpdateRotation()
		{
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005823")]
		[Address(RVA = "0x9938F0", Offset = "0x992AF0", VA = "0x1809938F0")]
		private void SnapRotation()
		{
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005824")]
		[Address(RVA = "0x993830", Offset = "0x992A30", VA = "0x180993830")]
		public void SetRotation()
		{
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005825")]
		[Address(RVA = "0x993E40", Offset = "0x993040", VA = "0x180993E40")]
		public void UpdateTime(float normalisedTime)
		{
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005826")]
		[Address(RVA = "0x993590", Offset = "0x992790", VA = "0x180993590")]
		public void OnTick()
		{
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005827")]
		[Address(RVA = "0x9935A0", Offset = "0x9927A0", VA = "0x1809935A0")]
		public void OnTimeSet(float normalisedTime)
		{
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x6005828")]
		[Address(RVA = "0x993560", Offset = "0x992760", VA = "0x180993560")]
		private bool IsDay(float timeInTwentyFourHour)
		{
			return default(bool);
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005829")]
		[Address(RVA = "0x993F60", Offset = "0x993160", VA = "0x180993F60")]
		public DayNightController()
		{
		}

		// Token: 0x04003A7F RID: 14975
		[Token(Token = "0x4003A7F")]
		private const float SunShadowStrength = 0.95f;

		// Token: 0x04003A80 RID: 14976
		[Token(Token = "0x4003A80")]
		private const float MoonShadowStrength = 0.8f;

		// Token: 0x04003A81 RID: 14977
		[Token(Token = "0x4003A81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private GameObject _lightPivot;

		// Token: 0x04003A82 RID: 14978
		[Token(Token = "0x4003A82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _skyRenderer;

		// Token: 0x04003A83 RID: 14979
		[Token(Token = "0x4003A83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Lights")]
		[SerializeField]
		private Light _sunLight;

		// Token: 0x04003A84 RID: 14980
		[Token(Token = "0x4003A84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Light _moonLight;

		// Token: 0x04003A85 RID: 14981
		[Token(Token = "0x4003A85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Light _ambientLight;

		// Token: 0x04003A86 RID: 14982
		[Token(Token = "0x4003A86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _fadeInCurve;

		// Token: 0x04003A87 RID: 14983
		[Token(Token = "0x4003A87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationCurve _fadeOutCurve;

		// Token: 0x04003A88 RID: 14984
		[Token(Token = "0x4003A88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Debugging & Development")]
		private float _debugRotationSpeed;

		// Token: 0x04003A89 RID: 14985
		[Token(Token = "0x4003A89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _debugTimeSpeed;

		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _enableDebugTimeControl;

		// Token: 0x04003A8B RID: 14987
		[Token(Token = "0x4003A8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _debugAutoUpdateTime;

		// Token: 0x04003A8C RID: 14988
		[Token(Token = "0x4003A8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Range(0f, 24f)]
		private float _timeInHours;

		// Token: 0x04003A8D RID: 14989
		[Token(Token = "0x4003A8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _timePercentage;

		// Token: 0x04003A8E RID: 14990
		[Token(Token = "0x4003A8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _isDay;

		// Token: 0x04003A8F RID: 14991
		[Token(Token = "0x4003A8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion _currentSunRotation;

		// Token: 0x04003A90 RID: 14992
		[Token(Token = "0x4003A90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion _currentMoonRotation;

		// Token: 0x04003A91 RID: 14993
		[Token(Token = "0x4003A91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DayNightPhaseTimes _dayNightPhaseTimes;

		// Token: 0x04003A92 RID: 14994
		[Token(Token = "0x4003A92")]
		public const float MAX_LIGHT_INTENSITY = 4f;
	}
}
