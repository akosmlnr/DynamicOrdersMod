using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	public class Fillable : MonoBehaviour
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C91 RID: 15505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097C")]
		public List<Fillable.Content> contents
		{
			[Token(Token = "0x6003C90")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C91")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x814120", Offset = "0x813320", VA = "0x180814120")]
		private void Awake()
		{
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x813F30", Offset = "0x813130", VA = "0x180813F30")]
		public void AddLiquid(string label, float volume, Color color)
		{
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x814370", Offset = "0x813570", VA = "0x180814370")]
		public void ResetContents()
		{
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x8143E0", Offset = "0x8135E0", VA = "0x1808143E0")]
		private void UpdateLiquid()
		{
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x814150", Offset = "0x813350", VA = "0x180814150")]
		public float GetLiquidVolume(string label)
		{
			return 0f;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6003C97")]
		[Address(RVA = "0x814250", Offset = "0x813450", VA = "0x180814250")]
		public float GetTotalLiquidVolume()
		{
			return 0f;
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x814650", Offset = "0x813850", VA = "0x180814650")]
		public Fillable()
		{
		}

		// Token: 0x04002C7D RID: 11389
		[Token(Token = "0x4002C7D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public bool FillableEnabled;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x34")]
		public float LiquidCapacity_L;

		// Token: 0x020008DF RID: 2271
		[Token(Token = "0x20008DF")]
		public class Content
		{
			// Token: 0x06003C99 RID: 15513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C99")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Content()
			{
			}

			// Token: 0x04002C80 RID: 11392
			[Token(Token = "0x4002C80")]
			[FieldOffset(Offset = "0x10")]
			public string Label;

			// Token: 0x04002C81 RID: 11393
			[Token(Token = "0x4002C81")]
			[FieldOffset(Offset = "0x18")]
			public float Volume_L;

			// Token: 0x04002C82 RID: 11394
			[Token(Token = "0x4002C82")]
			[FieldOffset(Offset = "0x1C")]
			public Color Color;
		}
	}
}
