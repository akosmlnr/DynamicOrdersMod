using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	public class EyebrowController : MonoBehaviour
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x7F2D50", Offset = "0x7F1F50", VA = "0x1807F2D50")]
		public void ApplySettings(AvatarSettings settings)
		{
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x7F2FF0", Offset = "0x7F21F0", VA = "0x1807F2FF0")]
		public void SetLeftBrowRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x7F3010", Offset = "0x7F2210", VA = "0x1807F3010")]
		public void SetRightBrowRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public EyebrowController()
		{
		}

		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Eyebrow leftBrow;

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0x28")]
		public Eyebrow rightBrow;
	}
}
