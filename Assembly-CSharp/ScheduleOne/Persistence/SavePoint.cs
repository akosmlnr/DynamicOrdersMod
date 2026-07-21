using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003E3 RID: 995
	[Token(Token = "0x20003E3")]
	public class SavePoint : MonoBehaviour
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x5FA7E0", Offset = "0x5F99E0", VA = "0x1805FA7E0")]
		public void Awake()
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x5FAD10", Offset = "0x5F9F10", VA = "0x1805FAD10")]
		public void Hovered()
		{
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x5FAB20", Offset = "0x5F9D20", VA = "0x1805FAB20")]
		private bool CanSave(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x5FAED0", Offset = "0x5FA0D0", VA = "0x1805FAED0")]
		public void Interacted()
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x5FAFB0", Offset = "0x5FA1B0", VA = "0x1805FAFB0")]
		private void Save()
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		public void OnSaveStart()
		{
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x5FAF70", Offset = "0x5FA170", VA = "0x1805FAF70")]
		public void OnSaveComplete()
		{
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SavePoint()
		{
		}

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		public const float SAVE_COOLDOWN = 60f;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x20")]
		public InteractableObject IntObj;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onSaveStart;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onSaveComplete;
	}
}
