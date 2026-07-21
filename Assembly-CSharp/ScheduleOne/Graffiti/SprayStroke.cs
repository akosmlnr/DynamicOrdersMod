using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	[Serializable]
	public class SprayStroke
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x6CE700", Offset = "0x6CD900", VA = "0x1806CE700")]
		public SprayStroke(UShort2 start, UShort2 end, ESprayColor color, byte strokeSize)
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x6CD9A0", Offset = "0x6CCBA0", VA = "0x1806CD9A0")]
		public SprayStroke GetCopy()
		{
			return null;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public SprayStroke()
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x6CDA30", Offset = "0x6CCC30", VA = "0x1806CDA30")]
		public List<PixelData> GetPixelsFromStroke()
		{
			return null;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x6CDF20", Offset = "0x6CD120", VA = "0x1806CDF20")]
		public static List<SprayStroke> GetStrokesFromPixels(List<UShort2> coords, ESprayColor color, byte strokeSize, SpraySurface surface)
		{
			return null;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x6CE5C0", Offset = "0x6CD7C0", VA = "0x1806CE5C0")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x6CD650", Offset = "0x6CC850", VA = "0x1806CD650")]
		public static SprayStroke Deserialize(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x6CD380", Offset = "0x6CC580", VA = "0x1806CD380")]
		public static List<SprayStroke> CopyAndShiftStrokes(List<SprayStroke> strokes, UShort2 shift)
		{
			return null;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x6CD790", Offset = "0x6CC990", VA = "0x1806CD790")]
		public static void GetBounds(List<SprayStroke> strokes, out UShort2 min, out UShort2 max)
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x6CC840", Offset = "0x6CBA40", VA = "0x1806CC840")]
		[CompilerGenerated]
		internal static void <GetBounds>g__GetStrokeBounds|24_0(SprayStroke stroke, out UShort2 min, out UShort2 max)
		{
		}

		// Token: 0x04001EE9 RID: 7913
		[Token(Token = "0x4001EE9")]
		public const int MinStrokeLength = 6;

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		public const int AngleThreshold_Degrees = 10;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		public const float MaxStrokeDeviation = 5f;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		public const int ForwardSampleCount = 5;

		// Token: 0x04001EED RID: 7917
		[Token(Token = "0x4001EED")]
		public const byte StrokeSize_LegacyDefault = 16;

		// Token: 0x04001EEE RID: 7918
		[Token(Token = "0x4001EEE")]
		public const byte StrokeSize_Small = 10;

		// Token: 0x04001EEF RID: 7919
		[Token(Token = "0x4001EEF")]
		public const byte StrokeSize_Medium = 16;

		// Token: 0x04001EF0 RID: 7920
		[Token(Token = "0x4001EF0")]
		public const byte StrokeSize_Large = 24;

		// Token: 0x04001EF1 RID: 7921
		[Token(Token = "0x4001EF1")]
		public const byte StrokeSize_ExtraLarge = 32;

		// Token: 0x04001EF2 RID: 7922
		[Token(Token = "0x4001EF2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte[] StrokeSizePresets;

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		public const byte StrokeSize_Min = 10;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		public const byte StrokeSize_Max = 32;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0x10")]
		public UShort2 Start;

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0x14")]
		public UShort2 End;

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		[FieldOffset(Offset = "0x18")]
		public ESprayColor Color;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		[FieldOffset(Offset = "0x19")]
		public byte StrokeSize;
	}
}
