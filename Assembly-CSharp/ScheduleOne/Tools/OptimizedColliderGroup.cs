using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087D RID: 2173
	[Token(Token = "0x200087D")]
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x06003984 RID: 14724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x8071F0", Offset = "0x8063F0", VA = "0x1808071F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x8070F0", Offset = "0x8062F0", VA = "0x1808070F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x8075E0", Offset = "0x8067E0", VA = "0x1808075E0")]
		private void RegisterEvent()
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x8070A0", Offset = "0x8062A0", VA = "0x1808070A0")]
		[Button]
		public void GetColliders()
		{
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void Start()
		{
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x807360", Offset = "0x806560", VA = "0x180807360")]
		private void Refresh()
		{
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x8077C0", Offset = "0x8069C0", VA = "0x1808077C0")]
		private void SetCollidersEnabled(bool enabled)
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x8078A0", Offset = "0x806AA0", VA = "0x1808078A0")]
		public OptimizedColliderGroup()
		{
		}

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		public const int UPDATE_DISTANCE = 5;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[FieldOffset(Offset = "0x20")]
		public Collider[] Colliders;

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[FieldOffset(Offset = "0x28")]
		public float ColliderEnableMaxDistance;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0x2C")]
		private float sqrColliderEnableMaxDistance;

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0x30")]
		private bool collidersEnabled;
	}
}
