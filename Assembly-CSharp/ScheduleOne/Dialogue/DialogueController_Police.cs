using System;
using Il2CppDummyDll;
using ScheduleOne.Police;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x06002F54 RID: 12116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x73E100", Offset = "0x73D300", VA = "0x18073E100", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x0000EB20 File Offset: 0x0000CD20
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x73E060", Offset = "0x73D260", VA = "0x18073E060", Slot = "8")]
		public override bool CanStartDialogue()
		{
			return default(bool);
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x738E10", Offset = "0x738010", VA = "0x180738E10")]
		public DialogueController_Police()
		{
		}

		// Token: 0x040022F9 RID: 8953
		[Token(Token = "0x40022F9")]
		[FieldOffset(Offset = "0x80")]
		private PoliceOfficer officer;
	}
}
