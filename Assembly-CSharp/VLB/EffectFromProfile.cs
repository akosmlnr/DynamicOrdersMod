using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-from-profile/")]
	public class EffectFromProfile : MonoBehaviour
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public EffectAbstractBase effectProfile
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x694B10", Offset = "0x693D10", VA = "0x180694B10")]
			set
			{
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x694830", Offset = "0x693A30", VA = "0x180694830")]
		public void InitInstanceFromProfile()
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x694980", Offset = "0x693B80", VA = "0x180694980")]
		private void OnEnable()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x694900", Offset = "0x693B00", VA = "0x180694900")]
		private void OnDisable()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public EffectFromProfile()
		{
		}

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		public const string ClassName = "EffectFromProfile";

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EffectAbstractBase m_EffectProfile;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x28")]
		private EffectAbstractBase m_EffectInstance;
	}
}
