using System;
using System.Collections.Generic;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BC8 RID: 3016
	[Token(Token = "0x2000BC8")]
	public class WeatherVolume : NetworkBehaviour
	{
		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x000169F8 File Offset: 0x00014BF8
		[Token(Token = "0x17000CF0")]
		public float BlendAmount
		{
			[Token(Token = "0x600595B")]
			[Address(RVA = "0x9BEF70", Offset = "0x9BE170", VA = "0x1809BEF70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x00016A10 File Offset: 0x00014C10
		[Token(Token = "0x17000CF1")]
		public Vector3 WeatherBounds
		{
			[Token(Token = "0x600595C")]
			[Address(RVA = "0x9BF6A0", Offset = "0x9BE8A0", VA = "0x1809BF6A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x00016A28 File Offset: 0x00014C28
		[Token(Token = "0x17000CF2")]
		public Vector3 BlendSize
		{
			[Token(Token = "0x600595D")]
			[Address(RVA = "0x9BEF80", Offset = "0x9BE180", VA = "0x1809BEF80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x17000CF3")]
		public Vector3 VolumeSize
		{
			[Token(Token = "0x600595E")]
			[Address(RVA = "0x9BF680", Offset = "0x9BE880", VA = "0x1809BF680")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x00016A58 File Offset: 0x00014C58
		[Token(Token = "0x17000CF4")]
		public Vector3 Center
		{
			[Token(Token = "0x600595F")]
			[Address(RVA = "0x92AA30", Offset = "0x929C30", VA = "0x18092AA30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x17000CF5")]
		public Vector3 MinBounds
		{
			[Token(Token = "0x6005960")]
			[Address(RVA = "0x9BF310", Offset = "0x9BE510", VA = "0x1809BF310")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x00016A88 File Offset: 0x00014C88
		[Token(Token = "0x17000CF6")]
		public Vector3 MaxBounds
		{
			[Token(Token = "0x6005961")]
			[Address(RVA = "0x9BF270", Offset = "0x9BE470", VA = "0x1809BF270")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CF7")]
		public List<WeatherEffectController> EffectControllers
		{
			[Token(Token = "0x6005962")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CF8")]
		public WeatherProfile WeatherProfile
		{
			[Token(Token = "0x6005963")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x00016AA0 File Offset: 0x00014CA0
		[Token(Token = "0x17000CF9")]
		protected Vector3 TopRightBlendCorner
		{
			[Token(Token = "0x6005964")]
			[Address(RVA = "0x9BF520", Offset = "0x9BE720", VA = "0x1809BF520")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[Token(Token = "0x17000CFA")]
		protected Vector3 BottomRightBlendCorner
		{
			[Token(Token = "0x6005965")]
			[Address(RVA = "0x9BF110", Offset = "0x9BE310", VA = "0x1809BF110")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x00016AD0 File Offset: 0x00014CD0
		[Token(Token = "0x17000CFB")]
		protected Vector3 TopLeftBlendCorner
		{
			[Token(Token = "0x6005966")]
			[Address(RVA = "0x9BF3C0", Offset = "0x9BE5C0", VA = "0x1809BF3C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x00016AE8 File Offset: 0x00014CE8
		[Token(Token = "0x17000CFC")]
		protected Vector3 BottomLeftBlendCorner
		{
			[Token(Token = "0x6005967")]
			[Address(RVA = "0x9BEFA0", Offset = "0x9BE1A0", VA = "0x1809BEFA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005968")]
		[Address(RVA = "0x9BDA20", Offset = "0x9BCC20", VA = "0x1809BDA20")]
		[ObserversRpc(BufferLast = true, RunLocally = true)]
		public void Initialise(Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005969")]
		[Address(RVA = "0x9BEE20", Offset = "0x9BE020", VA = "0x1809BEE20")]
		private void Update()
		{
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596A")]
		[Address(RVA = "0x9BE490", Offset = "0x9BD690", VA = "0x1809BE490")]
		public void SetAnchor(Vector3 anchorPosition)
		{
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596B")]
		[Address(RVA = "0x9BE4B0", Offset = "0x9BD6B0", VA = "0x1809BE4B0")]
		public void SetNeighbourVolume(WeatherVolume neighbourVolume)
		{
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596C")]
		[Address(RVA = "0x9BD6D0", Offset = "0x9BC8D0", VA = "0x1809BD6D0")]
		public void BlendEffects(float blend, AnimationCurve blendCurve)
		{
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596D")]
		[Address(RVA = "0x9BE7A0", Offset = "0x9BD9A0", VA = "0x1809BE7A0")]
		public void SetShaderNumericParameter(string paramater, float value)
		{
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596E")]
		[Address(RVA = "0x9BE590", Offset = "0x9BD790", VA = "0x1809BE590")]
		public void SetShaderColorParameter(string paramater, Color value)
		{
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596F")]
		[Address(RVA = "0x9BE9B0", Offset = "0x9BDBB0", VA = "0x1809BE9B0")]
		public void SetVisualEffectNumericParameter(string paramater, float value)
		{
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005970")]
		[Address(RVA = "0x9BEBC0", Offset = "0x9BDDC0", VA = "0x1809BEBC0")]
		public void UpdateVolume(Vector3 playerPosition, float enclosureBlend)
		{
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00016B00 File Offset: 0x00014D00
		[Token(Token = "0x6005971")]
		[Address(RVA = "0x9BDB70", Offset = "0x9BCD70", VA = "0x1809BDB70")]
		public bool IsInRightHalf(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00016B18 File Offset: 0x00014D18
		[Token(Token = "0x6005972")]
		[Address(RVA = "0x9BD8A0", Offset = "0x9BCAA0", VA = "0x1809BD8A0")]
		public Vector2 GetClosestPointOnLeft(Vector3 point)
		{
			return default(Vector2);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00016B30 File Offset: 0x00014D30
		[Token(Token = "0x6005973")]
		[Address(RVA = "0x9BD960", Offset = "0x9BCB60", VA = "0x1809BD960")]
		public Vector2 GetClosestPointOnRight(Vector3 point)
		{
			return default(Vector2);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005974")]
		[Address(RVA = "0x9BDC60", Offset = "0x9BCE60", VA = "0x1809BDC60")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005975")]
		[Address(RVA = "0x9BEF60", Offset = "0x9BE160", VA = "0x1809BEF60")]
		public WeatherVolume()
		{
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005976")]
		[Address(RVA = "0x9BDBD0", Offset = "0x9BCDD0", VA = "0x1809BDBD0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005977")]
		[Address(RVA = "0x6E3410", Offset = "0x6E2610", VA = "0x1806E3410", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005978")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005979")]
		[Address(RVA = "0x9BE200", Offset = "0x9BD400", VA = "0x1809BE200")]
		private void RpcWriter___Observers_Initialise_1999361799(Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597A")]
		[Address(RVA = "0x9BDD70", Offset = "0x9BCF70", VA = "0x1809BDD70")]
		public void RpcLogic___Initialise_1999361799(Vector3 weatherBounds, Vector3 volumeSize, Vector3 blendSize, float blendAmount, Vector3 anchorPosition, float heightMapWorldSize)
		{
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597B")]
		[Address(RVA = "0x9BDF80", Offset = "0x9BD180", VA = "0x1809BDF80")]
		private void RpcReader___Observers_Initialise_1999361799(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597C")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04003BAB RID: 15275
		[Token(Token = "0x4003BAB")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Header("Controllers")]
		private List<WeatherEffectController> _effectControllers;

		// Token: 0x04003BAC RID: 15276
		[Token(Token = "0x4003BAC")]
		[FieldOffset(Offset = "0x120")]
		[Header("Profile")]
		[SerializeField]
		private WeatherProfile _weatherProfile;

		// Token: 0x04003BAD RID: 15277
		[Token(Token = "0x4003BAD")]
		[FieldOffset(Offset = "0x128")]
		[Header("Debugging & Development")]
		[SerializeField]
		private bool _showGizmos;

		// Token: 0x04003BAE RID: 15278
		[Token(Token = "0x4003BAE")]
		[FieldOffset(Offset = "0x12C")]
		private Vector3 _weatherBounds;

		// Token: 0x04003BAF RID: 15279
		[Token(Token = "0x4003BAF")]
		[FieldOffset(Offset = "0x138")]
		private Vector3 _volumeSize;

		// Token: 0x04003BB0 RID: 15280
		[Token(Token = "0x4003BB0")]
		[FieldOffset(Offset = "0x144")]
		private Vector3 _blendSize;

		// Token: 0x04003BB1 RID: 15281
		[Token(Token = "0x4003BB1")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 _anchorPosition;

		// Token: 0x04003BB2 RID: 15282
		[Token(Token = "0x4003BB2")]
		[FieldOffset(Offset = "0x15C")]
		private float _blendAmount;

		// Token: 0x04003BB3 RID: 15283
		[Token(Token = "0x4003BB3")]
		[FieldOffset(Offset = "0x160")]
		private bool _isInitialized;

		// Token: 0x04003BB4 RID: 15284
		[Token(Token = "0x4003BB4")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 _velocity;

		// Token: 0x04003BB5 RID: 15285
		[Token(Token = "0x4003BB5")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Weather.WeatherVolumeAssembly-CSharp.dll_Excuted;

		// Token: 0x04003BB6 RID: 15286
		[Token(Token = "0x4003BB6")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Weather.WeatherVolumeAssembly-CSharp.dll_Excuted;
	}
}
