using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
public abstract class BaseStarDataRenderer
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	public event BaseStarDataRenderer.StarDataProgress progressCallback
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x54F150", Offset = "0x54E350", VA = "0x18054F150")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x54F290", Offset = "0x54E490", VA = "0x18054F290")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000002")]
	public event BaseStarDataRenderer.StarDataComplete completionCallback
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x54F0B0", Offset = "0x54E2B0", VA = "0x18054F0B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x54F1F0", Offset = "0x54E3F0", VA = "0x18054F1F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x060000CB RID: 203
	[Token(Token = "0x60000CB")]
	public abstract IEnumerator ComputeStarData();

	// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x54EFF0", Offset = "0x54E1F0", VA = "0x18054EFF0", Slot = "5")]
	public virtual void Cancel()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x54F070", Offset = "0x54E270", VA = "0x18054F070")]
	protected void SendProgress(float progress)
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x54F030", Offset = "0x54E230", VA = "0x18054F030")]
	protected void SendCompletion(Texture2D texture, bool success)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x54F0A0", Offset = "0x54E2A0", VA = "0x18054F0A0")]
	protected BaseStarDataRenderer()
	{
	}

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x20")]
	public float density;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x24")]
	public float imageSize;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x28")]
	public string layerId;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x30")]
	public float maxRadius;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x34")]
	protected float sphereRadius;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x38")]
	protected bool isCancelled;

	// Token: 0x02000036 RID: 54
	// (Invoke) Token: 0x060000D1 RID: 209
	[Token(Token = "0x2000036")]
	public delegate void StarDataProgress(BaseStarDataRenderer renderer, float progress);

	// Token: 0x02000037 RID: 55
	// (Invoke) Token: 0x060000D5 RID: 213
	[Token(Token = "0x2000037")]
	public delegate void StarDataComplete(BaseStarDataRenderer renderer, Texture2D texture, bool success);
}
