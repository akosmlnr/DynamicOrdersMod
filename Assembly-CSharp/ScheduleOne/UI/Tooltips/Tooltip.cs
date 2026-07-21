using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI.Tooltips
{
	// Token: 0x02000CD5 RID: 3285
	[Token(Token = "0x2000CD5")]
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06005FBA RID: 24506 RVA: 0x00017E68 File Offset: 0x00016068
		[Token(Token = "0x17000DDC")]
		public Vector3 labelPosition
		{
			[Token(Token = "0x6005FBA")]
			[Address(RVA = "0xA37F00", Offset = "0xA37100", VA = "0x180A37F00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06005FBB RID: 24507 RVA: 0x00017E80 File Offset: 0x00016080
		// (set) Token: 0x06005FBC RID: 24508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DDD")]
		public bool isWorldspace
		{
			[Token(Token = "0x6005FBB")]
			[Address(RVA = "0x7B13B0", Offset = "0x7B05B0", VA = "0x1807B13B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FBC")]
			[Address(RVA = "0xA38080", Offset = "0xA37280", VA = "0x180A38080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0xA37D80", Offset = "0xA36F80", VA = "0x180A37D80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Tooltip()
		{
		}

		// Token: 0x0400420D RID: 16909
		[Token(Token = "0x400420D")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[TextArea(3, 10)]
		public string text;

		// Token: 0x0400420E RID: 16910
		[Token(Token = "0x400420E")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 labelOffset;

		// Token: 0x0400420F RID: 16911
		[Token(Token = "0x400420F")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform LabelOriginRect;

		// Token: 0x04004211 RID: 16913
		[Token(Token = "0x4004211")]
		[FieldOffset(Offset = "0x40")]
		private Canvas canvas;
	}
}
