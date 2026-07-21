using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000C3C RID: 3132
	[Token(Token = "0x2000C3C")]
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06005BD3 RID: 23507 RVA: 0x00017430 File Offset: 0x00015630
		// (set) Token: 0x06005BD4 RID: 23508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4E")]
		public bool IsOpen
		{
			[Token(Token = "0x6005BD3")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005BD4")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x9CCD70", Offset = "0x9CBF70", VA = "0x1809CCD70", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x9CC8E0", Offset = "0x9CBAE0", VA = "0x1809CC8E0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x9CC930", Offset = "0x9CBB30", VA = "0x1809CC930")]
		public void Open(string documentName)
		{
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x9CC5A0", Offset = "0x9CB7A0", VA = "0x1809CC5A0")]
		public void Close()
		{
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x9CCE40", Offset = "0x9CC040", VA = "0x1809CCE40")]
		public DocumentViewer()
		{
		}

		// Token: 0x04003E33 RID: 15923
		[Token(Token = "0x4003E33")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform[] Documents;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onOpen;
	}
}
