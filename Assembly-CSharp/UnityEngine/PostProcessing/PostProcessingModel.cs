using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00003120 File Offset: 0x00001320
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public bool enabled
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x496F90", Offset = "0x496190", VA = "0x180496F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x69B370", Offset = "0x69A570", VA = "0x18069B370")]
			set
			{
			}
		}

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		public abstract void Reset();

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		protected PostProcessingModel()
		{
		}

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x10")]
		[GetSet("enabled")]
		[SerializeField]
		private bool m_Enabled;
	}
}
