using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CAB RID: 3243
	[Token(Token = "0x2000CAB")]
	public class SaveIndicator : MonoBehaviour
	{
		// Token: 0x06005EDC RID: 24284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x7E7EC0", Offset = "0x7E70C0", VA = "0x1807E7EC0")]
		public void Awake()
		{
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0xA11280", Offset = "0xA10480", VA = "0x180A11280")]
		public void Start()
		{
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0xA11180", Offset = "0xA10380", VA = "0x180A11180")]
		public void OnDestroy()
		{
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EDF")]
		[Address(RVA = "0xA11100", Offset = "0xA10300", VA = "0x180A11100")]
		public void Display()
		{
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EE0")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SaveIndicator()
		{
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0xA11360", Offset = "0xA10560", VA = "0x180A11360")]
		[CompilerGenerated]
		private IEnumerator <Display>g__Routine|6_0()
		{
			return null;
		}

		// Token: 0x04004139 RID: 16697
		[Token(Token = "0x4004139")]
		[FieldOffset(Offset = "0x20")]
		public Canvas Canvas;

		// Token: 0x0400413A RID: 16698
		[Token(Token = "0x400413A")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Icon;

		// Token: 0x0400413B RID: 16699
		[Token(Token = "0x400413B")]
		[FieldOffset(Offset = "0x30")]
		public Animation Anim;
	}
}
