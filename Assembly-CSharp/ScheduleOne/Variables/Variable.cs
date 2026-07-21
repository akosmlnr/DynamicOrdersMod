using System;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Variables
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public class Variable<T> : BaseVariable
	{
		// Token: 0x06001102 RID: 4354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001102")]
		public Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001103")]
		public override object GetValue()
		{
			return null;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001104")]
		public override void SetValue(object value, bool replicate)
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6001105")]
		public virtual bool TryDeserialize(string valueString, out T value)
		{
			return default(bool);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001106")]
		public override void ReplicateValue(NetworkConnection conn)
		{
		}

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x0")]
		public T Value;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T> OnValueChanged;
	}
}
