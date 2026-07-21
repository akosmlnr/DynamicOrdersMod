using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C28 RID: 3112
	[Token(Token = "0x2000C28")]
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x000171C0 File Offset: 0x000153C0
		// (set) Token: 0x06005B24 RID: 23332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D31")]
		public bool IsOpen
		{
			[Token(Token = "0x6005B23")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B24")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B25")]
		[Address(RVA = "0x9C3910", Offset = "0x9C2B10", VA = "0x1809C3910")]
		private void Awake()
		{
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B26")]
		[Address(RVA = "0x9C3950", Offset = "0x9C2B50", VA = "0x1809C3950")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B27")]
		[Address(RVA = "0x9C3B80", Offset = "0x9C2D80", VA = "0x1809C3B80")]
		public void Open()
		{
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B28")]
		[Address(RVA = "0x9C3910", Offset = "0x9C2B10", VA = "0x1809C3910")]
		public void Close()
		{
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B29")]
		[Address(RVA = "0x9C3EF0", Offset = "0x9C30F0", VA = "0x1809C3EF0")]
		public CharacterInterface()
		{
		}

		// Token: 0x04003D99 RID: 15769
		[Token(Token = "0x4003D99")]
		[FieldOffset(Offset = "0x28")]
		public ClothingSlotUI[] ClothingSlots;

		// Token: 0x04003D9A RID: 15770
		[Token(Token = "0x4003D9A")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform Container;

		// Token: 0x04003D9B RID: 15771
		[Token(Token = "0x4003D9B")]
		[FieldOffset(Offset = "0x38")]
		public Slider RotationSlider;

		// Token: 0x04003D9C RID: 15772
		[Token(Token = "0x4003D9C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints;
	}
}
