using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[Serializable]
	public class SerializableDictionary<K, V> : ISerializationCallbackReceiver
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		public void Clear()
		{
		}

		// Token: 0x17000247 RID: 583
		[Token(Token = "0x17000247")]
		public V this[K aKey]
		{
			[Token(Token = "0x6000A53")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A54")]
			set
			{
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A56")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		public SerializableDictionary()
		{
		}

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Dictionary<K, V> dict;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public List<K> m_Keys;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public List<V> m_Values;
	}
}
