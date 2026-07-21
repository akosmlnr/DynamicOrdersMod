using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x060020C0 RID: 8384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x670440", Offset = "0x66F640", VA = "0x180670440")]
		private void Start()
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x6701F0", Offset = "0x66F3F0", VA = "0x1806701F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x670370", Offset = "0x66F570", VA = "0x180670370")]
		public void SetScreenLit(bool lit)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x66FFD0", Offset = "0x66F1D0", VA = "0x18066FFD0")]
		public void DisplayText(string text)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x66FEF0", Offset = "0x66F0F0", VA = "0x18066FEF0")]
		public void DisplayMinutes(int mins)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x670100", Offset = "0x66F300", VA = "0x180670100")]
		private void MinPass()
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x670000", Offset = "0x66F200", VA = "0x180670000")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DigitalAlarm()
		{
		}

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		public const float FLASH_FREQUENCY = 4f;

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer ScreenMesh;

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x28")]
		public int ScreenMeshMaterialIndex;

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshPro ScreenText;

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x38")]
		public bool FlashScreen;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x39")]
		[Header("Settings")]
		public bool DisplayCurrentTime;

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x40")]
		public Material ScreenOffMat;

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x48")]
		public Material ScreenOnMat;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x50")]
		private bool isLit;
	}
}
