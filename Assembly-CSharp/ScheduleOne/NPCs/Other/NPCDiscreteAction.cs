using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B4C RID: 2892
	[Token(Token = "0x2000B4C")]
	public abstract class NPCDiscreteAction : MonoBehaviour
	{
		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x00016350 File Offset: 0x00014550
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB2")]
		public bool IsActive
		{
			[Token(Token = "0x60056C6")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056C7")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void BeginOnServer()
		{
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		protected virtual void BeginOnClient()
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void EndOnServer()
		{
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		protected virtual void EndOnClient()
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x99E6B0", Offset = "0x99D8B0", VA = "0x18099E6B0")]
		public void Begin()
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CD")]
		[Address(RVA = "0x99E710", Offset = "0x99D910", VA = "0x18099E710")]
		public void End()
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056CE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected NPCDiscreteAction()
		{
		}
	}
}
