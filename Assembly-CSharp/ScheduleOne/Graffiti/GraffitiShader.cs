using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200064C")]
	public class GraffitiShader
	{
		// Token: 0x060027C0 RID: 10176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x6BD400", Offset = "0x6BC600", VA = "0x1806BD400")]
		public void Initialise(Texture2D texture, int minStrokeSize, int maxStrokeSize, AnimationCurve falloffCurve)
		{
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x6BD2A0", Offset = "0x6BC4A0", VA = "0x1806BD2A0")]
		public void Draw()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x6BD010", Offset = "0x6BC210", VA = "0x1806BD010")]
		public void ClearStrokes()
		{
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBF40", VA = "0x1806BCD40")]
		public void AddStrokes(List<SprayStroke> strokes)
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x6BD680", Offset = "0x6BC880", VA = "0x1806BD680")]
		public void RemoveStrokes(int count)
		{
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x6BD060", Offset = "0x6BC260", VA = "0x1806BD060")]
		private void CreateFalloffTables(int minFalloff, int maxFalloff, AnimationCurve falloffCurve)
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x6BD700", Offset = "0x6BC900", VA = "0x1806BD700")]
		public GraffitiShader()
		{
		}

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		[FieldOffset(Offset = "0x10")]
		private int _kernal;

		// Token: 0x04001ED5 RID: 7893
		[Token(Token = "0x4001ED5")]
		[FieldOffset(Offset = "0x18")]
		private ComputeShader _shader;

		// Token: 0x04001ED6 RID: 7894
		[Token(Token = "0x4001ED6")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D _texture;

		// Token: 0x04001ED7 RID: 7895
		[Token(Token = "0x4001ED7")]
		[FieldOffset(Offset = "0x28")]
		private int _width;

		// Token: 0x04001ED8 RID: 7896
		[Token(Token = "0x4001ED8")]
		[FieldOffset(Offset = "0x2C")]
		private int _height;

		// Token: 0x04001ED9 RID: 7897
		[Token(Token = "0x4001ED9")]
		[FieldOffset(Offset = "0x30")]
		private List<GraffitiShader.StrokeData> _strokes;

		// Token: 0x04001EDA RID: 7898
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x38")]
		private float[] _falloffTable;

		// Token: 0x0200064D RID: 1613
		[Token(Token = "0x200064D")]
		public struct StrokeData
		{
			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0000CE28 File Offset: 0x0000B028
			[Token(Token = "0x170006EF")]
			public static int Stride
			{
				[Token(Token = "0x60027C7")]
				[Address(RVA = "0x6CE910", Offset = "0x6CDB10", VA = "0x1806CE910")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04001EDB RID: 7899
			[Token(Token = "0x4001EDB")]
			[FieldOffset(Offset = "0x0")]
			public uint2 Start;

			// Token: 0x04001EDC RID: 7900
			[Token(Token = "0x4001EDC")]
			[FieldOffset(Offset = "0x8")]
			public uint2 End;

			// Token: 0x04001EDD RID: 7901
			[Token(Token = "0x4001EDD")]
			[FieldOffset(Offset = "0x10")]
			public uint Color;

			// Token: 0x04001EDE RID: 7902
			[Token(Token = "0x4001EDE")]
			[FieldOffset(Offset = "0x14")]
			public uint Size;
		}
	}
}
