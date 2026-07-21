using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	[RequireComponent(typeof(Light))]
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x060017F6 RID: 6134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x5D1050", Offset = "0x5D0250", VA = "0x1805D1050", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x5D13D0", Offset = "0x5D05D0", VA = "0x1805D13D0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x5D1270", Offset = "0x5D0470", VA = "0x1805D1270")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x5D17B0", Offset = "0x5D09B0", VA = "0x1805D17B0", Slot = "5")]
		protected virtual void UpdateVisibility()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x5D15B0", Offset = "0x5D07B0", VA = "0x1805D15B0")]
		private void UpdateAttribute(float visibity)
		{
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FB")]
		[Address(RVA = "0x5D11B0", Offset = "0x5D03B0", VA = "0x1805D11B0")]
		private void ClearAttribute()
		{
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FC")]
		[Address(RVA = "0x5D1DD0", Offset = "0x5D0FD0", VA = "0x1805D1DD0")]
		public LightVisibilityAffector()
		{
		}

		// Token: 0x040014FD RID: 5373
		[Token(Token = "0x40014FD")]
		public const float PointLightEffect = 15f;

		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		public const float SpotLightEffect = 10f;

		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float EffectMultiplier;

		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0x28")]
		public string uniquenessCode;

		// Token: 0x04001501 RID: 5377
		[Token(Token = "0x4001501")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("How far does the player have to move for visibility to be recalculated?")]
		public int updateDistanceThreshold;

		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0x38")]
		protected Light light;

		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x40")]
		protected VisibilityAttribute attribute;
	}
}
