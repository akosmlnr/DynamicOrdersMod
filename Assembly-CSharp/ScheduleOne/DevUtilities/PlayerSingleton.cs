using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	public abstract class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06004980 RID: 18816 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x17000B7D")]
		public static bool InstanceExists
		{
			[Token(Token = "0x6004980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004982 RID: 18818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7E")]
		public static T Instance
		{
			[Token(Token = "0x6004981")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004982")]
			protected set
			{
			}
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004983")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004984")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004985")]
		public virtual void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004986")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004987")]
		protected PlayerSingleton()
		{
		}

		// Token: 0x040033F2 RID: 13298
		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;
	}
}
