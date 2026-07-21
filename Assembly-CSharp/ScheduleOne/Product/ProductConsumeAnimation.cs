using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace ScheduleOne.Product
{
	// Token: 0x02000911 RID: 2321
	[Token(Token = "0x2000911")]
	public class ProductConsumeAnimation : MonoBehaviour
	{
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B6")]
		public string ConsumeDescription
		{
			[Token(Token = "0x6003DF1")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DF2")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B7")]
		public float PrepareDuration
		{
			[Token(Token = "0x6003DF3")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003DF4")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003DF5 RID: 15861 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x06003DF6 RID: 15862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B8")]
		public float EffectsApplyDelay
		{
			[Token(Token = "0x6003DF5")]
			[Address(RVA = "0x4956F0", Offset = "0x4948F0", VA = "0x1804956F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003DF6")]
			[Address(RVA = "0x5D63C0", Offset = "0x5D55C0", VA = "0x1805D63C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF7")]
		[Address(RVA = "0x8371C0", Offset = "0x8363C0", VA = "0x1808371C0")]
		public void StartPrepare()
		{
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x766050", Offset = "0x765250", VA = "0x180766050")]
		public void CancelPrepare()
		{
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x836F30", Offset = "0x836130", VA = "0x180836F30")]
		public void StartConsume()
		{
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x8371E0", Offset = "0x8363E0", VA = "0x1808371E0")]
		public void StopConsume()
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x837300", Offset = "0x836500", VA = "0x180837300")]
		public ProductConsumeAnimation()
		{
		}

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("ConsumeAnimationBool")]
		private string _thirdPersonAnimationBool;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("ConsumeAnimationTrigger")]
		[SerializeField]
		private string _thirdPersonAnimationTrigger;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AvatarEquippable _thirdPersonEquippable;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public AudioSourceController ConsumeSound;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0x50")]
		[Header("Events")]
		public UnityEvent onPrepareStart;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onPrepareCancel;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onConsume;
	}
}
