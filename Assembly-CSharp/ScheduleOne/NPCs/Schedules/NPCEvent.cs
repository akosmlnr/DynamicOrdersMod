using System;
using Il2CppDummyDll;
using ScheduleOne.Core;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	public class NPCEvent : NPCAction
	{
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CA1")]
		public new string ActionName
		{
			[Token(Token = "0x6005617")]
			[Address(RVA = "0x97C4C0", Offset = "0x97B6C0", VA = "0x18097C4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005618")]
		[Address(RVA = "0x979E90", Offset = "0x979090", VA = "0x180979E90")]
		[Button]
		public void ApplyDuration()
		{
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005619")]
		[Address(RVA = "0x979F70", Offset = "0x979170", VA = "0x180979F70")]
		[Button]
		public void ApplyEndTime()
		{
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561A")]
		[Address(RVA = "0x97F410", Offset = "0x97E610", VA = "0x18097F410", Slot = "41")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561B")]
		[Address(RVA = "0x97F290", Offset = "0x97E490", VA = "0x18097F290", Slot = "32")]
		public override void OnActiveMinPass()
		{
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561C")]
		[Address(RVA = "0x97F350", Offset = "0x97E550", VA = "0x18097F350", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x9791C0", Offset = "0x9783C0", VA = "0x1809791C0", Slot = "33")]
		public override void PendingMinPassed()
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x97C4C0", Offset = "0x97B6C0", VA = "0x18097C4C0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x97C4F0", Offset = "0x97B6F0", VA = "0x18097C4F0", Slot = "37")]
		public override string GetTimeDescription()
		{
			return null;
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x97C460", Offset = "0x97B660", VA = "0x18097C460", Slot = "38")]
		public override int GetEndTime()
		{
			return 0;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005621")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCEvent()
		{
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005622")]
		[Address(RVA = "0x97F260", Offset = "0x97E460", VA = "0x18097F260", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005623")]
		[Address(RVA = "0x97F230", Offset = "0x97E430", VA = "0x18097F230", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005624")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005625")]
		[Address(RVA = "0x97A0D0", Offset = "0x9792D0", VA = "0x18097A0D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039C0 RID: 14784
		[Token(Token = "0x40039C0")]
		[FieldOffset(Offset = "0x148")]
		public int Duration;

		// Token: 0x040039C1 RID: 14785
		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0x14C")]
		public int EndTime;

		// Token: 0x040039C2 RID: 14786
		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0x150")]
		private bool _forgotUmbrella;

		// Token: 0x040039C3 RID: 14787
		[Token(Token = "0x40039C3")]
		[FieldOffset(Offset = "0x151")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted;

		// Token: 0x040039C4 RID: 14788
		[Token(Token = "0x40039C4")]
		[FieldOffset(Offset = "0x152")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEventAssembly-CSharp.dll_Excuted;
	}
}
