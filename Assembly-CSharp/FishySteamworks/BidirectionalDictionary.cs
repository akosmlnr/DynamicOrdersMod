using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FishySteamworks
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public class BidirectionalDictionary<T1, T2> : IEnumerable
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000253")]
		public IEnumerable<T1> FirstTypes
		{
			[Token(Token = "0x6000B04")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000254")]
		public IEnumerable<T2> SecondTypes
		{
			[Token(Token = "0x6000B05")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B06")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x17000255")]
		public int Count
		{
			[Token(Token = "0x6000B07")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000256")]
		public Dictionary<T1, T2> First
		{
			[Token(Token = "0x6000B08")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000257")]
		public Dictionary<T2, T1> Second
		{
			[Token(Token = "0x6000B09")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0A")]
		public void Add(T1 key, T2 value)
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0B")]
		public void Add(T2 key, T1 value)
		{
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B0C")]
		public T2 Get(T1 key)
		{
			return null;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B0D")]
		public T1 Get(T2 key)
		{
			return null;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000B0E")]
		public bool TryGetValue(T1 key, out T2 value)
		{
			return default(bool);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x6000B0F")]
		public bool TryGetValue(T2 key, out T1 value)
		{
			return default(bool);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000B10")]
		public bool Contains(T1 key)
		{
			return default(bool);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6000B11")]
		public bool Contains(T2 key)
		{
			return default(bool);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B12")]
		public void Remove(T1 key)
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B13")]
		public void Remove(T2 key)
		{
		}

		// Token: 0x17000258 RID: 600
		[Token(Token = "0x17000258")]
		public T1 this[T2 key]
		{
			[Token(Token = "0x6000B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B15")]
			set
			{
			}
		}

		// Token: 0x17000259 RID: 601
		[Token(Token = "0x17000259")]
		public T2 this[T1 key]
		{
			[Token(Token = "0x6000B16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B17")]
			set
			{
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B18")]
		public BidirectionalDictionary()
		{
		}

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T1, T2> t1ToT2Dict;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T2, T1> t2ToT1Dict;
	}
}
