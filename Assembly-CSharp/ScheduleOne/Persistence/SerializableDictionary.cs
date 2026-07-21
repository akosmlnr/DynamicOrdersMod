using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001938")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001939")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193A")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x600193B")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x600193C")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x600193D")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170004D2 RID: 1234
		[Token(Token = "0x170004D2")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x600193E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600193F")]
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004D3")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6001940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004D4")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6001941")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x170004D5")]
		public int Count
		{
			[Token(Token = "0x6001942")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x170004D6")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6001943")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001944")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001945")]
		public void Clear()
		{
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6001946")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001947")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6001948")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001949")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600194A")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600194B")]
		public SerializableDictionary()
		{
		}

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> dictionary;
	}
}
