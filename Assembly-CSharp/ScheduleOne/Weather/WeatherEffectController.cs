using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Effects;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BB7 RID: 2999
	[Token(Token = "0x2000BB7")]
	public class WeatherEffectController : EffectController
	{
		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CE7")]
		public string ControllerId
		{
			[Token(Token = "0x6005923")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005924")]
		[Address(RVA = "0x9BB7B0", Offset = "0x9BA9B0", VA = "0x1809BB7B0", Slot = "24")]
		public override void Awake()
		{
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005925")]
		[Address(RVA = "0x9BD300", Offset = "0x9BC500", VA = "0x1809BD300", Slot = "25")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005926")]
		[Address(RVA = "0x9BBDA0", Offset = "0x9BAFA0", VA = "0x1809BBDA0")]
		public void Initialise(WeatherVolume mainVolume)
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005927")]
		[Address(RVA = "0x9BC980", Offset = "0x9BBB80", VA = "0x1809BC980")]
		public void SetNeighbourVolume(WeatherVolume neighbourVolume)
		{
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005928")]
		[Address(RVA = "0x9BB680", Offset = "0x9BA880", VA = "0x1809BB680", Slot = "19")]
		public override void Activate()
		{
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005929")]
		[Address(RVA = "0x9BB9F0", Offset = "0x9BABF0", VA = "0x1809BB9F0", Slot = "20")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592A")]
		[Address(RVA = "0x9BB8E0", Offset = "0x9BAAE0", VA = "0x1809BB8E0")]
		public void BlendEffects(float blend, AnimationCurve curve)
		{
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592B")]
		[Address(RVA = "0x9BC270", Offset = "0x9BB470", VA = "0x1809BC270")]
		private void SetEffectParamters(EffectHandler effectHandler, float blend, AnimationCurve curve)
		{
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592C")]
		[Address(RVA = "0x9BCA90", Offset = "0x9BBC90", VA = "0x1809BCA90")]
		public void SetShaderNumericParameter(string paramater, float value)
		{
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592D")]
		[Address(RVA = "0x9BCB80", Offset = "0x9BBD80", VA = "0x1809BCB80")]
		public void SetVisualEffectNumericParameter(string paramater, float value)
		{
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600592E")]
		[Address(RVA = "0x9BC9A0", Offset = "0x9BBBA0", VA = "0x1809BC9A0")]
		public void SetShaderColorParameter(string paramater, Color value)
		{
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600592F")]
		[Address(RVA = "0x9BBA10", Offset = "0x9BAC10", VA = "0x1809BBA10")]
		public EffectSettings FindEffectSettings(string handlerId)
		{
			return null;
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005930")]
		[Address(RVA = "0x9BBAF0", Offset = "0x9BACF0", VA = "0x1809BBAF0", Slot = "26")]
		protected virtual EffectSettings GetFromEffectSettings(string handlerId)
		{
			return null;
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005931")]
		[Address(RVA = "0x9BCC70", Offset = "0x9BBE70", VA = "0x1809BCC70", Slot = "27")]
		public virtual void UpdateAudio()
		{
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005932")]
		[Address(RVA = "0x9BD1C0", Offset = "0x9BC3C0", VA = "0x1809BD1C0", Slot = "21")]
		public override void UpdateProperties(Vector3 anchoredPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
		{
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005933")]
		[Address(RVA = "0x9BC1C0", Offset = "0x9BB3C0", VA = "0x1809BC1C0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005934")]
		[Address(RVA = "0x9B2A40", Offset = "0x9B1C40", VA = "0x1809B2A40")]
		public WeatherEffectController()
		{
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005935")]
		[Address(RVA = "0x9BC1A0", Offset = "0x9BB3A0", VA = "0x1809BC1A0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005936")]
		[Address(RVA = "0x9BC180", Offset = "0x9BB380", VA = "0x1809BC180", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005937")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x9BB6A0", Offset = "0x9BA8A0", VA = "0x1809BB6A0", Slot = "28")]
		protected virtual void Awake_UserLogic_ScheduleOne.Weather.WeatherEffectController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003B78 RID: 15224
		[Token(Token = "0x4003B78")]
		[FieldOffset(Offset = "0x140")]
		[Header("Components")]
		[SerializeField]
		protected List<ParticleEffectHandler> particleEffects;

		// Token: 0x04003B79 RID: 15225
		[Token(Token = "0x4003B79")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected List<VFXEffectHandler> visualEffects;

		// Token: 0x04003B7A RID: 15226
		[Token(Token = "0x4003B7A")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected List<ShaderEffectHandler> shaderEffects;

		// Token: 0x04003B7B RID: 15227
		[Token(Token = "0x4003B7B")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected List<AudioSourceController> _audioSources;

		// Token: 0x04003B7C RID: 15228
		[Token(Token = "0x4003B7C")]
		[FieldOffset(Offset = "0x160")]
		[Header("Parameters: general")]
		[SerializeField]
		protected string _controllerId;

		// Token: 0x04003B7D RID: 15229
		[Token(Token = "0x4003B7D")]
		[FieldOffset(Offset = "0x168")]
		[Header("Parameters: Audio")]
		[Tooltip("Min and max distance for audio effects. Max being the distance at which audio is inaudible, and min being the distance at which audio is at full volume")]
		[SerializeField]
		protected Vector2 _minMaxDistanceToPlayer;

		// Token: 0x04003B7E RID: 15230
		[Token(Token = "0x4003B7E")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Tooltip("Uses the blend value of weather volume to determine audio volume rather than distance to player")]
		protected bool _useWeatherBlendForAudio;

		// Token: 0x04003B7F RID: 15231
		[Token(Token = "0x4003B7F")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Tooltip("Used to evaluate audio blending of audio volume (when using distance to player)")]
		protected AnimationCurve _distanceCurve;

		// Token: 0x04003B80 RID: 15232
		[Token(Token = "0x4003B80")]
		[FieldOffset(Offset = "0x180")]
		[Tooltip("Used to evaluate audio blending from inside to outside")]
		[SerializeField]
		protected AnimationCurve _enclosureCurve;

		// Token: 0x04003B81 RID: 15233
		[Token(Token = "0x4003B81")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Header("Parameters: Effects")]
		[Header("Settings: Player Following")]
		protected List<EffectHandler> _effectsToFollowPlayer;

		// Token: 0x04003B82 RID: 15234
		[Token(Token = "0x4003B82")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Header("Settings: Effects")]
		protected List<EffectSettings> _effectSettings;

		// Token: 0x04003B83 RID: 15235
		[Token(Token = "0x4003B83")]
		[FieldOffset(Offset = "0x198")]
		[Header("Settings: Audio")]
		[SerializeField]
		protected List<ScheduleOne.Audio.AudioSettings> _audioSettings;

		// Token: 0x04003B84 RID: 15236
		[Token(Token = "0x4003B84")]
		[FieldOffset(Offset = "0x1A0")]
		[Header("Debugging & Development")]
		[SerializeField]
		protected bool _showGizmos;

		// Token: 0x04003B85 RID: 15237
		[Token(Token = "0x4003B85")]
		[FieldOffset(Offset = "0x1A4")]
		protected float _weatherBlend;

		// Token: 0x04003B86 RID: 15238
		[Token(Token = "0x4003B86")]
		[FieldOffset(Offset = "0x1A8")]
		protected WeatherVolume _mainVolume;

		// Token: 0x04003B87 RID: 15239
		[Token(Token = "0x4003B87")]
		[FieldOffset(Offset = "0x1B0")]
		protected WeatherVolume _neighbourVolume;

		// Token: 0x04003B88 RID: 15240
		[Token(Token = "0x4003B88")]
		[FieldOffset(Offset = "0x1B8")]
		private bool NetworkInitialize___EarlyScheduleOne.Weather.WeatherEffectControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003B89 RID: 15241
		[Token(Token = "0x4003B89")]
		[FieldOffset(Offset = "0x1B9")]
		private bool NetworkInitialize__LateScheduleOne.Weather.WeatherEffectControllerAssembly-CSharp.dll_Excuted;
	}
}
