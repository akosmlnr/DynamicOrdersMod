using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	public abstract class EffectController : NetworkBehaviour
	{
		// Token: 0x060056D8 RID: 22232
		[Token(Token = "0x60056D8")]
		public abstract void Activate();

		// Token: 0x060056D9 RID: 22233
		[Token(Token = "0x60056D9")]
		public abstract void Deactivate();

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x00016368 File Offset: 0x00014568
		// (set) Token: 0x060056DB RID: 22235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB3")]
		public bool IsActive
		{
			[Token(Token = "0x60056DA")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056DB")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0x9946F0", Offset = "0x9938F0", VA = "0x1809946F0", Slot = "21")]
		public virtual void UpdateProperties(Vector3 anchorPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
		{
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0x994720", Offset = "0x993920", VA = "0x180994720")]
		protected EffectController()
		{
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x9946D0", Offset = "0x9938D0", VA = "0x1809946D0", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0x9946B0", Offset = "0x9938B0", VA = "0x1809946B0", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "24")]
		public virtual void Awake()
		{
		}

		// Token: 0x04003A05 RID: 14853
		[Token(Token = "0x4003A05")]
		[FieldOffset(Offset = "0x11C")]
		protected float _distanceToPlayerNormalised;

		// Token: 0x04003A06 RID: 14854
		[Token(Token = "0x4003A06")]
		[FieldOffset(Offset = "0x120")]
		protected float _enclosureBlend;

		// Token: 0x04003A07 RID: 14855
		[Token(Token = "0x4003A07")]
		[FieldOffset(Offset = "0x124")]
		protected Vector3 _playerPosition;

		// Token: 0x04003A08 RID: 14856
		[Token(Token = "0x4003A08")]
		[FieldOffset(Offset = "0x130")]
		protected Vector3 _anchoredPosition;

		// Token: 0x04003A09 RID: 14857
		[Token(Token = "0x4003A09")]
		[FieldOffset(Offset = "0x13C")]
		private bool NetworkInitialize___EarlyScheduleOne.Effects.EffectControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003A0A RID: 14858
		[Token(Token = "0x4003A0A")]
		[FieldOffset(Offset = "0x13D")]
		private bool NetworkInitialize__LateScheduleOne.Effects.EffectControllerAssembly-CSharp.dll_Excuted;
	}
}
