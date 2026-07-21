using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
public class Interpolate
{
	// Token: 0x06000182 RID: 386 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x55A260", Offset = "0x559460", VA = "0x18055A260")]
	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x55AC60", Offset = "0x559E60", VA = "0x18055AC60")]
	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x55ABF0", Offset = "0x559DF0", VA = "0x18055ABF0")]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x55A840", Offset = "0x559A40", VA = "0x18055A840")]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x55AA00", Offset = "0x559C00", VA = "0x18055AA00")]
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x55A8D0", Offset = "0x559AD0", VA = "0x18055A8D0")]
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x55AB20", Offset = "0x559D20", VA = "0x18055AB20")]
	private static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x55A130", Offset = "0x559330", VA = "0x18055A130")]
	private static Vector3 Ease(Interpolate.Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x559D60", Offset = "0x558F60", VA = "0x180559D60")]
	public static Interpolate.Function Ease(Interpolate.EaseType type)
	{
		return null;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x55A4C0", Offset = "0x5596C0", VA = "0x18055A4C0")]
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x55A5C0", Offset = "0x5597C0", VA = "0x18055A5C0")]
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x55A2A0", Offset = "0x5594A0", VA = "0x18055A2A0")]
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x55A3A0", Offset = "0x5595A0", VA = "0x18055A3A0")]
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600018F")]
	private static IEnumerable<Vector3> NewBezier<T>(Interpolate.Function ease, IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x6000190")]
	[Address(RVA = "0x559150", Offset = "0x558350", VA = "0x180559150")]
	private static Vector3 Bezier(Interpolate.Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x55A790", Offset = "0x559990", VA = "0x18055A790")]
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000192")]
	[Address(RVA = "0x55A6E0", Offset = "0x5598E0", VA = "0x18055A6E0")]
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000193")]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x6000194")]
	[Address(RVA = "0x559320", Offset = "0x558520", VA = "0x180559320")]
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x6000195")]
	[Address(RVA = "0x55A280", Offset = "0x559480", VA = "0x18055A280")]
	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x559A30", Offset = "0x558C30", VA = "0x180559A30")]
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x6000197")]
	[Address(RVA = "0x559C50", Offset = "0x558E50", VA = "0x180559C50")]
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x6000198")]
	[Address(RVA = "0x5597F0", Offset = "0x5589F0", VA = "0x1805597F0")]
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x6000199")]
	[Address(RVA = "0x559560", Offset = "0x558760", VA = "0x180559560")]
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019A RID: 410 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x600019A")]
	[Address(RVA = "0x559BB0", Offset = "0x558DB0", VA = "0x180559BB0")]
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x600019B")]
	[Address(RVA = "0x5596D0", Offset = "0x5588D0", VA = "0x1805596D0")]
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x559A70", Offset = "0x558C70", VA = "0x180559A70")]
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x559C90", Offset = "0x558E90", VA = "0x180559C90")]
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x559890", Offset = "0x558A90", VA = "0x180559890")]
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x600019F")]
	[Address(RVA = "0x559AA0", Offset = "0x558CA0", VA = "0x180559AA0")]
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x559CD0", Offset = "0x558ED0", VA = "0x180559CD0")]
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x559930", Offset = "0x558B30", VA = "0x180559930")]
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x559AE0", Offset = "0x558CE0", VA = "0x180559AE0")]
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x559D10", Offset = "0x558F10", VA = "0x180559D10")]
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x5599D0", Offset = "0x558BD0", VA = "0x1805599D0")]
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x5595A0", Offset = "0x5587A0", VA = "0x1805595A0")]
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x559BF0", Offset = "0x558DF0", VA = "0x180559BF0")]
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x559750", Offset = "0x558950", VA = "0x180559750")]
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x5594E0", Offset = "0x5586E0", VA = "0x1805594E0")]
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x559B40", Offset = "0x558D40", VA = "0x180559B40")]
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x559600", Offset = "0x558800", VA = "0x180559600")]
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return 0f;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
	public Interpolate()
	{
	}

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public enum EaseType
	{
		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		Linear,
		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		EaseInQuad,
		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		EaseOutQuad,
		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		EaseInOutQuad,
		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		EaseInCubic,
		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		EaseOutCubic,
		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		EaseInOutCubic,
		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		EaseInQuart,
		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		EaseOutQuart,
		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		EaseInOutQuart,
		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		EaseInQuint,
		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		EaseOutQuint,
		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		EaseInOutQuint,
		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		EaseInSine,
		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		EaseOutSine,
		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		EaseInOutSine,
		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		EaseInExpo,
		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		EaseOutExpo,
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		EaseInOutExpo,
		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		EaseInCirc,
		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		EaseOutCirc,
		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		EaseInOutCirc
	}

	// Token: 0x0200005C RID: 92
	// (Invoke) Token: 0x060001AD RID: 429
	[Token(Token = "0x200005C")]
	public delegate Vector3 ToVector3<T>(T v);

	// Token: 0x0200005D RID: 93
	// (Invoke) Token: 0x060001B1 RID: 433
	[Token(Token = "0x200005D")]
	public delegate float Function(float a, float b, float c, float d);
}
