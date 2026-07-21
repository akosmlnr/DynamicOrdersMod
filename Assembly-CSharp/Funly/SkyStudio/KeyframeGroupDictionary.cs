using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Serializable]
	public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable
	{
		// Token: 0x17000246 RID: 582
		[Token(Token = "0x17000246")]
		public IKeyframeGroup this[string aKey]
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x9F82C0", Offset = "0x9F74C0", VA = "0x1809F82C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
			set
			{
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x9F7360", Offset = "0x9F6560", VA = "0x1809F7360")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x9F7310", Offset = "0x9F6510", VA = "0x1809F7310")]
		public void Clear()
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4C")]
		public T GetGroup<T>(string propertyName) where T : class
		{
			return null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x9F7C10", Offset = "0x9F6E10", VA = "0x1809F7C10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x9F7460", Offset = "0x9F6660", VA = "0x1809F7460", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x9F73C0", Offset = "0x9F65C0", VA = "0x1809F73C0", Slot = "6")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x9F73C0", Offset = "0x9F65C0", VA = "0x1809F73C0", Slot = "7")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x9F8140", Offset = "0x9F7340", VA = "0x1809F8140")]
		public KeyframeGroupDictionary()
		{
		}

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private Dictionary<string, IKeyframeGroup> m_Groups;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColorGroupDictionary m_ColorGroup;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NumberGroupDictionary m_NumberGroup;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextureGroupDictionary m_TextureGroup;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpherePointGroupDictionary m_SpherePointGroup;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BoolGroupDictionary m_BoolGroup;
	}
}
