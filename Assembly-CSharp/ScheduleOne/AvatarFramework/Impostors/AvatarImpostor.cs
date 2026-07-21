using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x000105A8 File Offset: 0x0000E7A8
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CB")]
		public bool HasTexture
		{
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600372C")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008CC")]
		private Transform Camera
		{
			[Token(Token = "0x600372D")]
			[Address(RVA = "0x7E8300", Offset = "0x7E7500", VA = "0x1807E8300")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x7E7EF0", Offset = "0x7E70F0", VA = "0x1807E7EF0")]
		private void Awake()
		{
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x7E81F0", Offset = "0x7E73F0", VA = "0x1807E81F0")]
		public void SetAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x7E7FB0", Offset = "0x7E71B0", VA = "0x1807E7FB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x7E7FC0", Offset = "0x7E71C0", VA = "0x1807E7FC0")]
		private void Realign()
		{
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x7E7F70", Offset = "0x7E7170", VA = "0x1807E7F70")]
		public void EnableImpostor()
		{
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x74D910", Offset = "0x74CB10", VA = "0x18074D910")]
		public void DisableImpostor()
		{
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x7E82A0", Offset = "0x7E74A0", VA = "0x1807E82A0")]
		public AvatarImpostor()
		{
		}

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x28")]
		public MeshRenderer meshRenderer;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x30")]
		public Transform AnchorBone;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x38")]
		private Transform cachedCamera;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 anchorBoneOffset;
	}
}
