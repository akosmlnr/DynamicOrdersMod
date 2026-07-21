using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
[BurstCompile]
public static class BurstFunctions
{
	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x550430", Offset = "0x54F630", VA = "0x180550430")]
	[BurstCompile]
	public static void Average(ref NativeArray<float> arr, out float result)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x5503D0", Offset = "0x54F5D0", VA = "0x1805503D0")]
	[BurstCompile]
	public static void Average(ref NativeArray<Vector3> arr, out Vector3 result)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x550330", Offset = "0x54F530", VA = "0x180550330")]
	[BurstCompile]
	[MethodImpl(256)]
	public static void Average$BurstManaged(ref NativeArray<float> arr, out float result)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x550250", Offset = "0x54F450", VA = "0x180550250")]
	[BurstCompile]
	[MethodImpl(256)]
	public static void Average$BurstManaged(ref NativeArray<Vector3> arr, out Vector3 result)
	{
	}

	// Token: 0x02000027 RID: 39
	// (Invoke) Token: 0x0600008C RID: 140
	[Token(Token = "0x2000027")]
	public delegate void Average_00000087$PostfixBurstDelegate(ref NativeArray<float> arr, out float result);

	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	internal static class Average_00000087$BurstDirectCall
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x54E2C0", Offset = "0x54D4C0", VA = "0x18054E2C0")]
		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr A_0)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x54E3F0", Offset = "0x54D5F0", VA = "0x18054E3F0")]
		private static IntPtr GetFunctionPointer()
		{
			return 0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x54E210", Offset = "0x54D410", VA = "0x18054E210")]
		public static void Constructor()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public static void Initialize()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x54E560", Offset = "0x54D760", VA = "0x18054E560")]
		public static void Invoke(ref NativeArray<float> arr, out float result)
		{
		}

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private static IntPtr Pointer;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x8")]
		private static IntPtr DeferredCompilation;
	}

	// Token: 0x02000029 RID: 41
	// (Invoke) Token: 0x06000096 RID: 150
	[Token(Token = "0x2000029")]
	public delegate void Average_00000088$PostfixBurstDelegate(ref NativeArray<Vector3> arr, out Vector3 result);

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal static class Average_00000088$BurstDirectCall
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x54E9F0", Offset = "0x54DBF0", VA = "0x18054E9F0")]
		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr A_0)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x54EB20", Offset = "0x54DD20", VA = "0x18054EB20")]
		private static IntPtr GetFunctionPointer()
		{
			return 0;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x54E940", Offset = "0x54DB40", VA = "0x18054E940")]
		public static void Constructor()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public static void Initialize()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x54EC90", Offset = "0x54DE90", VA = "0x18054EC90")]
		public static void Invoke(ref NativeArray<Vector3> arr, out Vector3 result)
		{
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		private static IntPtr Pointer;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x8")]
		private static IntPtr DeferredCompilation;
	}
}
