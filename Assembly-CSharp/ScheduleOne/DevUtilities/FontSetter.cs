using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	public class FontSetter : MonoBehaviour
	{
		// Token: 0x060049DC RID: 18908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x8F4FB0", Offset = "0x8F41B0", VA = "0x1808F4FB0")]
		public void SetColour(string componentName, string ColourName)
		{
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FontSetter()
		{
		}

		// Token: 0x0400342B RID: 13355
		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private List<FontSetter.ImageItem> _imageItems;

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x28")]
		[Header("Fonts")]
		[SerializeField]
		private ColorFont _colourFont;

		// Token: 0x02000A22 RID: 2594
		[Token(Token = "0x2000A22")]
		[Serializable]
		public class ImageItem
		{
			// Token: 0x060049DE RID: 18910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049DE")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ImageItem()
			{
			}

			// Token: 0x0400342D RID: 13357
			[Token(Token = "0x400342D")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x0400342E RID: 13358
			[Token(Token = "0x400342E")]
			[FieldOffset(Offset = "0x18")]
			public Image Image;
		}
	}
}
