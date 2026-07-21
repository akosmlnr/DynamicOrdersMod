using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	[CreateAssetMenu(fileName = "Graffiti Drawing", menuName = "Serialized Graffiti Drawing", order = 1)]
	public class SerializedGraffitiDrawing : ScriptableObject
	{
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		public string DrawingName
		{
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CE")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x0000CE88 File Offset: 0x0000B088
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F3")]
		public int Width
		{
			[Token(Token = "0x60027CF")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027D0")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		public int Height
		{
			[Token(Token = "0x60027D1")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027D2")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F5")]
		public List<SprayStroke> Strokes
		{
			[Token(Token = "0x60027D3")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
		public void SetDrawingName(string name)
		{
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x6CC810", Offset = "0x6CBA10", VA = "0x1806CC810")]
		public void SetStrokes(List<SprayStroke> strokes)
		{
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x6CC510", Offset = "0x6CB710", VA = "0x1806CC510")]
		private void RecalculateSize()
		{
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x6CCA00", Offset = "0x6CBC00", VA = "0x1806CCA00")]
		public SerializedGraffitiDrawing()
		{
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x6CC840", Offset = "0x6CBA40", VA = "0x1806CC840")]
		[CompilerGenerated]
		internal static void <RecalculateSize>g__GetStrokeBounds|18_0(SprayStroke stroke, out UShort2 min, out UShort2 max)
		{
		}
	}
}
