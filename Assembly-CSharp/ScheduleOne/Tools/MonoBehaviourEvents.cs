using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x0600397C RID: 14716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x806D90", Offset = "0x805F90", VA = "0x180806D90")]
		private void Awake()
		{
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x806DB0", Offset = "0x805FB0", VA = "0x180806DB0")]
		private void Start()
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x806DD0", Offset = "0x805FD0", VA = "0x180806DD0")]
		private void Update()
		{
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MonoBehaviourEvents()
		{
		}

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onAwake;

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onStart;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onUpdate;
	}
}
