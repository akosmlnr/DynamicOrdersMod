using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	public abstract class NetworkSingleton<T> : NetworkBehaviour where T : NetworkSingleton<T>
	{
		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x17000B77")]
		public static bool InstanceExists
		{
			[Token(Token = "0x600494F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004951 RID: 18769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B78")]
		public static T Instance
		{
			[Token(Token = "0x6004950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004951")]
			protected set
			{
			}
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004952")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004953")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004954")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004955")]
		protected NetworkSingleton()
		{
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004956")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004957")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004958")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004959")]
		protected virtual void Awake_UserLogic_ScheduleOne.DevUtilities.NetworkSingleton`1_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[FieldOffset(Offset = "0x0")]
		protected bool Destroyed;

		// Token: 0x040033D3 RID: 13267
		[Token(Token = "0x40033D3")]
		[FieldOffset(Offset = "0x0")]
		private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted;

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x0")]
		private bool NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted;
	}
}
