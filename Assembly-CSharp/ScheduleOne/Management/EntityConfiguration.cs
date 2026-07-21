using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	public class EntityConfiguration
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000591")]
		public ConfigurationReplicator Replicator
		{
			[Token(Token = "0x6001F64")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F65")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000592")]
		public IConfigurable Configurable
		{
			[Token(Token = "0x6001F66")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F67")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0000AFC8 File Offset: 0x000091C8
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000593")]
		public bool IsSelected
		{
			[Token(Token = "0x6001F68")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000594")]
		public StringField Name
		{
			[Token(Token = "0x6001F6A")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "4")]
		public virtual bool AllowRename()
		{
			return default(bool);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x643160", Offset = "0x642360", VA = "0x180643160")]
		public EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, string defaultName)
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		protected void InvokeChanged()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x643110", Offset = "0x642310", VA = "0x180643110")]
		public void ReplicateField(ConfigField field, [Optional] NetworkConnection conn)
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x642F60", Offset = "0x642160", VA = "0x180642F60")]
		public void ReplicateAllFields([Optional] NetworkConnection conn, bool replicateDefaults = true)
		{
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x62A7B0", Offset = "0x6299B0", VA = "0x18062A7B0", Slot = "5")]
		public virtual void Destroy()
		{
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x570E40", Offset = "0x570040", VA = "0x180570E40", Slot = "7")]
		public virtual void Selected()
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x642EC0", Offset = "0x6420C0", VA = "0x180642EC0", Slot = "8")]
		public virtual void Deselected()
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x643130", Offset = "0x642330", VA = "0x180643130", Slot = "9")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x642ED0", Offset = "0x6420D0", VA = "0x180642ED0", Slot = "10")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F77")]
		public T GetField<T>() where T : ConfigField
		{
			return null;
		}

		// Token: 0x040019EE RID: 6638
		[Token(Token = "0x40019EE")]
		private const int NameCharacterLimit = 28;

		// Token: 0x040019F1 RID: 6641
		[Token(Token = "0x40019F1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ConfigField> Fields;

		// Token: 0x040019F2 RID: 6642
		[Token(Token = "0x40019F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent onChanged;
	}
}
