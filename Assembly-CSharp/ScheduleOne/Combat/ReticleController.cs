using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	public class ReticleController : MonoBehaviour
	{
		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060067D0 RID: 26576 RVA: 0x00019488 File Offset: 0x00017688
		[Token(Token = "0x17000EB6")]
		public bool IsActive
		{
			[Token(Token = "0x60067D0")]
			[Address(RVA = "0xAB41A0", Offset = "0xAB33A0", VA = "0x180AB41A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D1")]
		[Address(RVA = "0xAB3E30", Offset = "0xAB3030", VA = "0x180AB3E30")]
		private void Awake()
		{
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D2")]
		[Address(RVA = "0xAB4050", Offset = "0xAB3250", VA = "0x180AB4050")]
		public void ShowReticle(float duration = -1f)
		{
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D3")]
		[Address(RVA = "0xAB3EF0", Offset = "0xAB30F0", VA = "0x180AB3EF0")]
		public void HideReticle(float duration = -1f)
		{
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D4")]
		[Address(RVA = "0xAB4020", Offset = "0xAB3220", VA = "0x180AB4020")]
		public void SetReticle(float spreadAngle)
		{
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60067D5")]
		[Address(RVA = "0xAB3E60", Offset = "0xAB3060", VA = "0x180AB3E60")]
		private IEnumerator DoRecticleFade(float endAlpha, float duration)
		{
			return null;
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D6")]
		[Address(RVA = "0xAB4190", Offset = "0xAB3390", VA = "0x180AB4190")]
		public ReticleController()
		{
		}

		// Token: 0x04004957 RID: 18775
		[Token(Token = "0x4004957")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private ReticleUI _reticleUI;

		// Token: 0x04004958 RID: 18776
		[Token(Token = "0x4004958")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04004959 RID: 18777
		[Token(Token = "0x4004959")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isActive;

		// Token: 0x0400495A RID: 18778
		[Token(Token = "0x400495A")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _fadeCo;
	}
}
