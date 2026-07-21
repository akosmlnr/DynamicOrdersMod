using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x06003718 RID: 14104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x7F38E0", Offset = "0x7F2AE0", VA = "0x1807F38E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x7F3CD0", Offset = "0x7F2ED0", VA = "0x1807F3CD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x7F3950", Offset = "0x7F2B50", VA = "0x1807F3950")]
		private void FinalizeMugshot()
		{
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x7F39F0", Offset = "0x7F2BF0", VA = "0x1807F39F0")]
		[Button]
		public void GenerateMugshot()
		{
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x7F3A20", Offset = "0x7F2C20", VA = "0x1807F3A20")]
		public void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x7F3D80", Offset = "0x7F2F80", VA = "0x1807F3D80")]
		public MugshotGenerator()
		{
		}

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x28")]
		public string OutputPath;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x30")]
		public AvatarSettings Settings;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Avatar MugshotRig;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x40")]
		public IconGenerator Generator;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x48")]
		public AvatarSettings DefaultSettings;

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x50")]
		public Transform LookAtPosition;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D finalTexture;

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x60")]
		private bool generate;
	}
}
