using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x17000B80")]
		public static bool InstanceExists
		{
			[Token(Token = "0x60049A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B81")]
		public static T Instance
		{
			[Token(Token = "0x60049A9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049AA")]
			protected set
			{
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AB")]
		protected virtual void Start()
		{
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AC")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AD")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AE")]
		protected Singleton()
		{
		}

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x0")]
		protected bool Destroyed;
	}
}
