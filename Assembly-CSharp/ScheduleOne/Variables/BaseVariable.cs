using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public abstract class BaseVariable
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public Player Owner
		{
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0xAFFC40", Offset = "0xAFEE40", VA = "0x180AFFC40")]
		public BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner)
		{
		}

		// Token: 0x060010F2 RID: 4338
		[Token(Token = "0x60010F2")]
		public abstract object GetValue();

		// Token: 0x060010F3 RID: 4339
		[Token(Token = "0x60010F3")]
		public abstract void SetValue(object value, bool replicate = true);

		// Token: 0x060010F4 RID: 4340
		[Token(Token = "0x60010F4")]
		public abstract void ReplicateValue(NetworkConnection conn);

		// Token: 0x060010F5 RID: 4341 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "7")]
		public virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x10")]
		public EVariableReplicationMode ReplicationMode;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x20")]
		public bool Persistent;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x24")]
		public EVariableMode VariableMode;
	}
}
