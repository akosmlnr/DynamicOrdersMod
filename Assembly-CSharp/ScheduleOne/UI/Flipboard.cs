using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C43 RID: 3139
	[Token(Token = "0x2000C43")]
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x06005C02 RID: 23554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x9CE6A0", Offset = "0x9CD8A0", VA = "0x1809CE6A0")]
		public void Update()
		{
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0x9CE650", Offset = "0x9CD850", VA = "0x1809CE650")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C04")]
		[Address(RVA = "0x9CE730", Offset = "0x9CD930", VA = "0x1809CE730")]
		public Flipboard()
		{
		}

		// Token: 0x04003E48 RID: 15944
		[Token(Token = "0x4003E48")]
		[FieldOffset(Offset = "0x20")]
		public Sprite[] Sprites;

		// Token: 0x04003E49 RID: 15945
		[Token(Token = "0x4003E49")]
		[FieldOffset(Offset = "0x28")]
		public Image Image;

		// Token: 0x04003E4A RID: 15946
		[Token(Token = "0x4003E4A")]
		[FieldOffset(Offset = "0x30")]
		public float FlipTime;

		// Token: 0x04003E4B RID: 15947
		[Token(Token = "0x4003E4B")]
		[FieldOffset(Offset = "0x34")]
		public float SpeedMultiplier;

		// Token: 0x04003E4C RID: 15948
		[Token(Token = "0x4003E4C")]
		[FieldOffset(Offset = "0x38")]
		private float time;

		// Token: 0x04003E4D RID: 15949
		[Token(Token = "0x4003E4D")]
		[FieldOffset(Offset = "0x3C")]
		private int index;
	}
}
