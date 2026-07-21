using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x0200006C RID: 108
[Token(Token = "0x200006C")]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x060001FE RID: 510 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x577380", Offset = "0x576580", VA = "0x180577380")]
	[MethodImpl(256)]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	private struct MonoScriptData
	{
		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}
}
